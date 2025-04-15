using NetworkService.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace NetworkService.ViewModel
{
    public class MeasurementGraphViewModel : BindableBase
    {


        private Brush _stage1Color = Brushes.DarkSlateBlue;
        private Brush _stage2Color = Brushes.CadetBlue;
        private Brush _stage3Color = Brushes.PowderBlue;
        private string _stage1Label = "Zapreminski";
        private string _stage2Label = "Turbinski";
        private string _stage3Label = "Elektronski";

        public Brush Stage1Color
        {
            get => _stage1Color;
            set { _stage1Color = value; }
        }

        public Brush Stage2Color
        {
            get => _stage2Color;
            set { _stage2Color = value;  }
        }

        public Brush Stage3Color
        {
            get => _stage3Color;
            set { _stage3Color = value;  }
        }

        public string Stage1Label
        {
            get => _stage1Label;
            set { _stage1Label = value;  }
        }

        public string Stage2Label
        {
            get => _stage2Label;
            set { _stage2Label = value;  }
        }

        public string Stage3Label
        {
            get => _stage3Label;
            set { _stage3Label = value;  }
        }

        

        public ObservableCollection<CircleMarker> CircleMarkers { get; set; }

        public List<string> ComboBoxItems { get; set; } = ComboBoxItemsData.entityTypes.Keys.ToList();

        public MyICommand ShowEntitiesCommand { get; set; }

        private string selectedType;
        private string errorMessage;

        public void UpdateCircleMarkers(List<int> newValues)
        {
            if (newValues.Count != 3)
                throw new ArgumentException("Exactly 3 values are required.");

            for (int i = 0; i < 3; i++)
            {
                CircleMarkers[i].CmValue = newValues[i];
            }
        }
        public MeasurementGraphViewModel()
        {
            ShowEntitiesCommand = new MyICommand(OnShow);

            CircleMarkers = new ObservableCollection<CircleMarker>();
            for (int i = 0; i <= 3; i++)
            {
                CircleMarker marker = new CircleMarker();
                CircleMarkers.Add(marker);
            }

            SelectedType = ComboBoxItemsData.entityTypes.Keys.ToList()[0];
            SetValuesToCircleMarkers(LoadLastFiveUpdates(SelectedType));
        }

        private List<CircleMarker> LoadLastFiveUpdates(string selectedType)
        {
            if (!File.Exists("Log.txt"))
            {
                ErrorMessage = "Log file doesn't exist.";
                return null;
            }

            string[] lines = File.ReadAllLines("Log.txt");

            List<CircleMarker> lastFiveUpdates = new List<CircleMarker>();

            for (int i = lines.Count() - 1; i >= 0; i--)
            {
                string line = lines[i];

                string date = line.Substring(0, line.IndexOf(" "));
                line = line.Substring(line.IndexOf(" ") + 1);
                string time = line.Substring(0, line.IndexOf(" ") - 1);
                line = line.Substring(line.IndexOf(" ") + 1);
                string type = line.Substring(0, line.IndexOf('_'));
                string val = line.Substring(line.IndexOf(',') + 2);

                if ((type == SelectedType) && (lastFiveUpdates.Count < 4))
                {
                    lastFiveUpdates.Add(new CircleMarker(type, int.Parse(val), date, time));
                }
            }

            return (lastFiveUpdates.Count == 4) ? lastFiveUpdates : null;
        }

        private void SetDefaultValuesToCircleMarkers()
        {
            for (int i = 0; i <= 3; i++)
            {
                CircleMarkers[i].CmType = "Type";
                CircleMarkers[i].CmValue = 0;
                CircleMarkers[i].CmDate = "Date";
                CircleMarkers[i].CmTime = "Time";
            }
        }

        private void SetValuesToCircleMarkers(List<CircleMarker> markers)
        {
            if (markers != null)
            {
                for (int i = 0; i <= 3; i++)
                {
                    CircleMarkers[i].CmType = markers[3 - i].CmType;
                    CircleMarkers[i].CmValue = markers[3 - i].CmValue;
                    CircleMarkers[i].CmDate = markers[3 - i].CmDate;
                    CircleMarkers[i].CmTime = markers[3 - i].CmTime;
                }
            }
            else
            {
                // Ako se u log fajlu nalazi manje od 5 promena vrednosti
                // Na kruzice se postavljaju default vrednosti
                SetDefaultValuesToCircleMarkers();
            }
        }

        public void OnShow()
        {
            if (SelectedType != null)
            {
                ErrorMessage = String.Empty;

                List<CircleMarker> markers = LoadLastFiveUpdates(SelectedType);

                SetValuesToCircleMarkers(markers);
            }
            else
            {
                ErrorMessage = "Type is required.";
            }
        }

        public string SelectedType
        {
            get { return selectedType; }
            set
            {
                selectedType = value;
                OnPropertyChanged("SelectedType");
            }
        }

        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                OnPropertyChanged("ErrorMessage");
            }
        }
    }
}
