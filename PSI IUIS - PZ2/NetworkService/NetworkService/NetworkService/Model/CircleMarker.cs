using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NetworkService.Model
{
    public class CircleMarker : BindableBase
    {
        private string cmType;
        private int cmValue;
        private string cmDate;
        private string cmTime;
        private Thickness cmMargin;
        private Brush cmColor;

        public CircleMarker()
        {

        }
        public CircleMarker(string cmType, int cmValue)
        {
            CmType = cmType;
            CmValue = cmValue;
            CmDate = DateTime.Now.ToString("yyyy-MM-dd");
            CmTime = DateTime.Now.ToString("HH:mm:ss");
        }


        public CircleMarker(string cmType, int cmValue, string cmDate, string cmTime)
        {
            CmType = cmType;
            CmValue = cmValue;
            CmDate = cmDate;
            CmTime = cmTime;
        }

        public string CmType
        {
            get { return cmType; }
            set
            {
                cmType = value;
                OnPropertyChanged("CmType");
            }
        }

        public int CmValue
        {
            get { return cmValue; }
            set
            {
                if (value >= 670 && value <= 735) 
                {
                    cmValue = value;
                    CmMargin = new Thickness(0, 0, 0, cmValue / 100); 
                    CmColor = Brushes.CadetBlue;
                }
                else
                {
                    cmValue = 0; // or some default/error value
                    CmMargin = new Thickness(0, 0, 0, 0);
                    CmColor = Brushes.White;
                }
                OnPropertyChanged("CmValue");
            }
        }
        public string CmDate
        {
            get { return cmDate; }
            set
            {
                cmDate = value;
                OnPropertyChanged("CmDate");
            }
        }

        public string CmTime
        {
            get { return cmTime; }
            set
            {
                cmTime = value;
                OnPropertyChanged("CmTime");
            }
        }

        public Thickness CmMargin
        {
            get { return cmMargin; }
            set
            {
                cmMargin = value;
                OnPropertyChanged("CmMargin");
            }
        }

        public Brush CmColor
        {
            get { return cmColor; }
            set
            {
                cmColor = value;
                OnPropertyChanged("CmColor");
            }
        }
    }
}
