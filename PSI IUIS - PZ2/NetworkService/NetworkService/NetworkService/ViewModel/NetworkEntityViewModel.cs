using MVVMLight.Messaging;
using NetworkService.Model;
using Notification.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using MessageBox = System.Windows.Forms.MessageBox;

namespace NetworkService.ViewModel
{
    public class NetworkEntityViewModel : BindableBase
    {
        //ShowToastNotification(new ToastNotification("Error", "You must enter an id!", NotificationType.Error));
        public ObservableCollection<string> Types { get; set; }
        public static ObservableCollection<Entity> EntitiesToShow { get; set; }
        public ObservableCollection<Entity> EntitiesToShowHelp { get; set; }
        public ObservableCollection<Entity> Entities { get; set; }
        public ObservableCollection<Entity> SearchedEntities { get; set; }
        public ObservableCollection<int> EntityIndexes { get; set; }
        public ObservableCollection<ActionHistory> ActionHistories { get;private set; }

        //public MyICommand AddEntity { get; set; }
        public MyICommand DeleteCommand { get; set; }
        public MyICommand UndoCommand { get; set; }
        public MyICommand DeleteCommand2 { get; set; }
        public MyICommand SearchEntity { get; set; }
        public MyICommand ResetCommand { get; set; }

        public MyICommand UndoAllCommand { get; set; }
        public MyICommand HistoryCommand { get; set; }

        private string historyBox;
        public string HistoryBox
        {
            get { return historyBox; }
            set
            {
                if (historyBox != value)
                {
                    historyBox = value;
                    OnPropertyChanged(nameof(historyBox));
                }
            }
        }

        private bool isNameRbSelected;
        public bool IsNameRbSelected
        {
            get { return isNameRbSelected; }
            set
            {
                if (isNameRbSelected != value)
                {
                    isNameRbSelected = value;
                    OnPropertyChanged(nameof(IsNameRbSelected));
                }
            }
        }

        private bool isTypeRbSelected;
        public bool IsTypeRbSelected
        {
            get { return isTypeRbSelected; }
            set
            {
                if (isTypeRbSelected != value)
                {
                    isTypeRbSelected = value;
                    OnPropertyChanged(nameof(IsTypeRbSelected));
                }
            }
        }

        private Entity selectedEntity;
        public Entity SelectedEntity
        {
            get
            {
                return selectedEntity;
            }

            set
            {
                if (selectedEntity != value)
                {
                    selectedEntity = value;
                    OnPropertyChanged(nameof(SelectedEntity));
                    DeleteCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private Entity selectedEntity2;
        public Entity SelectedEntity2
        {
            get
            {
                return selectedEntity2;
            }

            set
            {
                if (selectedEntity2 != value)
                {
                    selectedEntity2 = value;
                    OnPropertyChanged(nameof(SelectedEntity2));
                    DeleteCommand2.RaiseCanExecuteChanged();
                }
            }
        }
        public string SearchBox
        {
            get { return searchBox; }
            set
            {
                searchBox = value;
                OnPropertyChanged("SearchBox");
            }
        }



        private string searchBox;
        public MyICommand AddCommand { get; set; }

        private string selectedType;
        public string SelectedType
        {
            get
            {
                return selectedType;
            }

            set
            {
                if (selectedType != value)
                {
                    selectedType = value;
                    OnPropertyChanged(nameof(SelectedType));
                }
            }
        }

        private string idText;
        public string IdText
        {
            get { return idText; }
            set
            {
                if (idText != value)
                {
                    idText = value;
                    OnPropertyChanged(nameof(IdText));
                }
            }
        }

        private string name;
        public string NameText
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(NameText));
                }
            }
        }

        private string searchValueTextame;
        public string SearchValueText
        {
            get { return searchValueTextame; }
            set
            {
                if (searchValueTextame != value)
                {
                    searchValueTextame = value;
                    OnPropertyChanged(nameof(SearchValueText));
                }
            }
        }

        private int _zIndex1;
        public int ZIndex1
        {
            get { return _zIndex1; }
            set
            {
                if (_zIndex1 != value)
                {
                    _zIndex1 = value;
                    OnPropertyChanged(nameof(ZIndex1));
                }
            }
        }

        private int _zIndex2;
        public int ZIndex2
        {
            get { return _zIndex2; }
            set
            {
                if (_zIndex2 != value)
                {
                    _zIndex2 = value;
                    OnPropertyChanged(nameof(ZIndex2));
                }
            }
        }

        private int _zIndexButton1;
        public int ZIndexButton1
        {
            get { return _zIndexButton1; }
            set
            {
                if (_zIndexButton1 != value)
                {
                    _zIndexButton1 = value;
                    OnPropertyChanged(nameof(ZIndexButton1));
                }
            }
        }

        private int _zIndexButton2;
        public int ZIndexButton2
        {
            get { return _zIndexButton2; }
            set
            {
                if (_zIndexButton2 != value)
                {
                    _zIndexButton2 = value;
                    OnPropertyChanged(nameof(ZIndexButton2));
                }
            }
        }
        public int idForDelete;

        #region ToolTipsInitialization
        private string nameRadioToolTip;
        public string NameRadioToolTip
        {
            get { return nameRadioToolTip; }
            set
            {
                if (nameRadioToolTip != value)
                {
                    nameRadioToolTip = value;
                    OnPropertyChanged(nameof(NameRadioToolTip));
                }
            }
        }

        private string typeRadioToolTip;
        public string TypeRadioToolTip
        {
            get { return typeRadioToolTip; }
            set
            {
                if (typeRadioToolTip != value)
                {
                    typeRadioToolTip = value;
                    OnPropertyChanged(nameof(TypeRadioToolTip));
                }
            }
        }

        private string searchTextBoxToolTip;
        public string SearchTextBoxToolTip
        {
            get { return searchTextBoxToolTip; }
            set
            {
                if (searchTextBoxToolTip != value)
                {
                    searchTextBoxToolTip = value;
                    OnPropertyChanged(nameof(SearchTextBoxToolTip));
                }
            }
        }

        private string searchButtonToolTip;
        public string SearchButtonToolTip
        {
            get { return searchButtonToolTip; }
            set
            {
                if (searchButtonToolTip != value)
                {
                    searchButtonToolTip = value;
                    OnPropertyChanged(nameof(SearchButtonToolTip));
                }
            }
        }

        private string deleteButtonToolTip;
        public string DeleteButtonToolTip
        {
            get { return deleteButtonToolTip; }
            set
            {
                if (deleteButtonToolTip != value)
                {
                    deleteButtonToolTip = value;
                    OnPropertyChanged(nameof(DeleteButtonToolTip));
                }
            }
        }

        private string deleteButtonToolTip2;
        public string DeleteButtonToolTip2
        {
            get { return deleteButtonToolTip2; }
            set
            {
                if (deleteButtonToolTip2 != value)
                {
                    deleteButtonToolTip2 = value;
                    OnPropertyChanged(nameof(DeleteButtonToolTip2));
                }
            }
        }




        private string idTextBoxToolTip;
        public string IdTextBoxToolTip
        {
            get { return idTextBoxToolTip; }
            set
            {
                if (idTextBoxToolTip != value)
                {
                    idTextBoxToolTip = value;
                    OnPropertyChanged(nameof(IdTextBoxToolTip));
                }
            }
        }

        private string nameTextBoxToolTip;
        public string NameTextBoxToolTip
        {
            get { return nameTextBoxToolTip; }
            set
            {
                if (nameTextBoxToolTip != value)
                {
                    nameTextBoxToolTip = value;
                    OnPropertyChanged(nameof(NameTextBoxToolTip));
                }
            }
        }

        private string typeComboBoxToolTip;
        public string TypeComboBoxToolTip
        {
            get { return typeComboBoxToolTip; }
            set
            {
                if (typeComboBoxToolTip != value)
                {
                    typeComboBoxToolTip = value;
                    OnPropertyChanged(nameof(TypeComboBoxToolTip));
                }
            }
        }

        private string addButtonToolTip;
        public string AddButtonToolTip
        {
            get { return addButtonToolTip; }
            set
            {
                if (addButtonToolTip != value)
                {
                    addButtonToolTip = value;
                    OnPropertyChanged(nameof(AddButtonToolTip));
                }
            }
        }

       



        #endregion

        private NotificationManager notificationManager;
        public NetworkEntityViewModel()
        {
            notificationManager = new NotificationManager();
            Entities = new ObservableCollection<Entity>();
            SearchedEntities = new ObservableCollection<Entity>();
            EntitiesToShow = new ObservableCollection<Entity>();
            EntitiesToShowHelp = new ObservableCollection<Entity>();
            EntityIndexes = new ObservableCollection<int>();
            Types = new ObservableCollection<string>() { "Zapreminski", "Turbinski", "Elektronski" };
            ActionHistories = new ObservableCollection<ActionHistory>();
            SelectedType = Types[0];
            IsNameRbSelected = true;
            SearchValueText = "";
            EntitiesToShow.Add(new Entity { Id = 1, Name = "Zapreminski1", Type = new EntityType("Zapreminski", @"C:\Users\Korisnik\Desktop\zapreminski.jpg"), Value = 0 });
            EntitiesToShow.Add(new Entity { Id = 2, Name = "Turbinski2", Type = new EntityType("Turbinski", @"C:\Users\Korisnik\Desktop\turbinski.jpg"), Value = 0 });
            EntitiesToShow.Add(new Entity { Id = 3, Name = "Elektronski3", Type = new EntityType("Elektronski", @"C:\Users\Korisnik\Desktop\elektronski.jpg"), Value = 0 });

            AddCommand = new MyICommand(OnAddEntity);
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            DeleteCommand2 = new MyICommand(OnDelete2, CanDelete2);
            UndoAllCommand = new MyICommand(UndoAllActions);
            ResetCommand = new MyICommand(Reset);
            

            SearchEntity = new MyICommand(OnSearch);

            ZIndex1 = 1;
            ZIndex2 = 0;

            ZIndexButton1 = 1;
            ZIndexButton2 = 0;

            Messenger.Default.Register<string>(this, "NewValueReceived", SetValueAndWriteInFile);

           
           
            

        }

        private void History()
        {

        }

       

        private string errorMSg = "";
        private string errorMSgName = "";
        private string errorIdMsg = "";

        public string ErrorMSg
        {
            get { return errorMSg; }
            set
            {
                errorMSg = value;
                OnPropertyChanged("ErrorMSg");
            }
        }
        public string ErrorMSgName
        {
            get { return errorMSgName; }
            set
            {
                errorMSgName = value;
                OnPropertyChanged("ErrorMSgName");
            }
        }
        public string ErrorIdMsg
        {
            get { return errorIdMsg; }
            set
            {
                errorIdMsg = value;
                OnPropertyChanged("ErrorIdMsg");
            }
        }

        private void OnAddEntity()
        {

            // Resetovanje poruka o greškama
            ErrorMSg = "";
            ErrorMSgName = "";
            ErrorIdMsg = "";

            bool isValid = true;

            // Provera da li je izabran tip
            if (SelectedType == null)
            {
                ErrorMSg = "You must select a type!";
                isValid = false;
            }

            // Provera da li je uneto ime
            if (string.IsNullOrWhiteSpace(NameText))
            {
                ErrorMSgName = "You must enter a name!";
                isValid = false;
            }

            // Provera da li je unet ID
            if (string.IsNullOrWhiteSpace(IdText))
            {
                ErrorIdMsg = "You must enter an ID!";
                isValid = false;
            }
            // Provera da li je ID pozitivan ceo broj
            else if (!int.TryParse(IdText, out int id) || id <= 0)
            {
                ErrorIdMsg = "ID must be a positive integer!";
                isValid = false;
            }

            // Ako bilo koja validacija nije prošla, izaći iz metode
            if (!isValid)
            {
                return;
            }
            if (EntitiesToShow.Any(entity => entity.Id == Int32.Parse(IdText)))
            {
                MessageBox.Show("Entity with this ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string picture = "";
            if (SelectedType == null)
            {
                ErrorMSg = "Need To Choose Type!";
                return;
            }
            else if (SelectedType == "Zapreminski")
            {
                picture = @"C:\Users\User\Desktop\zapreminski.jpg";
            }
            else if (SelectedType == "Turbinski")
            {
                picture = @"C:\Users\User\Desktop\turbinski.jpg";
            }
            else if (SelectedType == "Elektronski")
            {
                picture = @"C:\Users\User\Desktop\elektronski.jpg";
            }

            Entity entityAdder = new Entity { Id = int.Parse(IdText), Name = NameText, Type = new EntityType(SelectedType, picture), Value = 0, InvalidValue = 0 };

            // Dodajemo akciju dodavanja u listu istorije akcija
            ActionHistories.Add(new ActionHistory
            {
                Description = "Entity added",
                UndoAction = () =>
                {
                    SearchedEntities.Remove(entityAdder);
                    EntitiesToShow.Remove(entityAdder);

                    EntityIndexes.Clear();
                    foreach (var entity in EntitiesToShow)
                    {
                        EntityIndexes.Add(entity.Id);
                    }
                }
            });

            // Dodavanje entiteta u listu
            SearchedEntities.Add(entityAdder);
            EntitiesToShow.Add(entityAdder);

            EntityIndexes.Clear();
            foreach (var entity in EntitiesToShow)
            {
                EntityIndexes.Add(entity.Id);
            }

            var message = EntitiesToShow.Count;
            Messenger.Default.Send<int>(message);
            Messenger.Default.Send<Entity>(entityAdder, "AddCollection");

            MessageBox.Show("Entity added successfully!", "Add Entity", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetValueAndWriteInFile(string incomming)
        {
            //Na primer: "Entitet_1:272"

            EntityIndexes.Clear();
            foreach (var entity in EntitiesToShow)
            {
                EntityIndexes.Add(entity.Id);
            }

            DateTime currentTime = DateTime.Now;
            string filePath = "Log.txt";

            string[] parts1 = incomming.Split('_');
            string[] parts = parts1[1].Split(':');

            int numberOfEntity = int.Parse(parts[0]);
            double valueOfSimulator = double.Parse(parts[1]);
            int idForUsing = -1;

            for (int j = 0; j < EntityIndexes.Count; j++)
            {
                if (numberOfEntity == j)
                {
                    idForUsing = EntityIndexes[numberOfEntity];
                    break;
                }
            }
            //idForUsing- nalazi se id entiteta sa kojim radimo
            //0.01 - 5.50

            for (int i = 0; i < EntitiesToShow.Count; i++)
            {
                if (idForUsing == EntitiesToShow[i].Id)
                {
                    if (valueOfSimulator >= 670 && valueOfSimulator <= 735)
                    {
                        EntitiesToShow[i].Value = valueOfSimulator;
                    }
                    EntitiesToShow[i].InvalidValue = valueOfSimulator;

                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine("" + currentTime + "_ID=" + idForUsing + "_" + valueOfSimulator);
                    }

                    Messenger.Default.Send<Entity>(EntitiesToShow[i], "ChangeCollection");
                }

            }



        }

        private void Reset()
        {

            SelectedType = null;

            SearchedEntities.Clear();
            foreach (Entity e in EntitiesToShow)
            {
                SearchedEntities.Add(e);
            }


            ZIndex1 = 1;
            ZIndex2 = 0;
            ZIndexButton1 = 1;
            ZIndexButton2 = 0;

        }

        private void OnDelete()
        {
            var result = MessageBox.Show("Are you sure you want to delete the selected entity?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                Entity entityDelete = null;
                foreach (var entity in EntitiesToShow)
                {
                    if (entity.Id == SelectedEntity.Id)
                    {
                        entityDelete = entity;
                        break;
                    }
                }

                EntitiesToShow.Remove(SelectedEntity);

                EntityIndexes.Clear();
                foreach (var entity in EntitiesToShow)
                {
                    EntityIndexes.Add(entity.Id);
                }

                var message = EntitiesToShow.Count;
                Messenger.Default.Send<int>(message);

                Messenger.Default.Send<Entity>(entityDelete, "DeleteCollection");


                // Dodavanje akcije brisanja u istoriju
                ActionHistories.Add(new ActionHistory
                {
                    Description = $"Deleted Entity: {entityDelete.Name} (ID: {entityDelete.Id})",
                    UndoAction = () =>
                    {
                        EntitiesToShow.Add(entityDelete);
                        EntityIndexes.Add(entityDelete.Id);

                        message = EntitiesToShow.Count;
                        Messenger.Default.Send<int>(message);
                        Messenger.Default.Send<Entity>(entityDelete, "AddCollection");
                    }
                });

                // Obavesti da je lista istorije akcija promenjena
                OnPropertyChanged(nameof(ActionHistories));

                MessageBox.Show("Entity deleted successfully!", "Delete Entity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void OnDelete2()
        {

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected entity?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                Entity entityDelete = null;
                foreach (var entity in EntitiesToShow)
                {
                    if (entity.Id == SelectedEntity2.Id)
                    {
                        entityDelete = entity;
                        break;
                    }
                }

                idForDelete = SelectedEntity2.Id;
                SearchedEntities.Remove(SelectedEntity2);

                EntitiesToShowHelp.Clear();
                foreach (Entity e in EntitiesToShow)
                {
                    EntitiesToShowHelp.Add(e);
                }

               

                EntityIndexes.Clear();
                foreach (var entity in EntitiesToShow)
                {
                    EntityIndexes.Add(entity.Id);
                }

                var message = EntitiesToShow.Count;
                Messenger.Default.Send<int>(message);

                Messenger.Default.Send<Entity>(entityDelete, "DeleteCollection");
                ActionHistories.Add(new ActionHistory
                {
                    Description = $"Deleted Entity: {entityDelete.Name} (ID: {entityDelete.Id})",
                    UndoAction = () =>
                    {
                        EntitiesToShow.Add(entityDelete);
                        EntityIndexes.Add(entityDelete.Id);

                        message = EntitiesToShow.Count;
                        Messenger.Default.Send<int>(message);
                        Messenger.Default.Send<Entity>(entityDelete, "AddCollection");
                    }
                });

                // Obavesti da je lista istorije akcija promenjena
                OnPropertyChanged(nameof(ActionHistories));

                MessageBox.Show("Entity deleted successfully!", "Delete Entity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
            else
            {

            }
        }

        private bool CanDelete()
        {
            return SelectedEntity != null;
        }
        private bool CanDelete2()
        {
            return SelectedEntity2 != null;
        }

        private string searchError;
        private string search;
        public string SearchError
        {
            get { return searchError; }
            set
            {
                searchError = value;
                OnPropertyChanged("SearchError");
            }
        }
        public string Search
        {
            get { return search; }
            set
            {
                search = value;
            }
        }

        bool isValid = true;
        private void OnSearch()
        {

                foreach (Entity e in EntitiesToShow)
                {
                    SearchedEntities.Add(e); //prvo sve stavim  u kopiju liste(tabele)                
                }

                SearchedEntities.Clear();

                if (IsNameRbSelected == true)
                {
                    foreach (Entity e in EntitiesToShow)
                    {
                        if (e.Name.Equals(SearchValueText))
                        {
                            SearchedEntities.Add(e);
                        }
                    }
                    ZIndex1 = 0;
                    ZIndex2 = 1;
                    ZIndexButton1 = 0;
                    ZIndexButton2 = 1;
                }

                if (IsTypeRbSelected == true)
                {
                    foreach (Entity e in EntitiesToShow)
                    {
                        if (e.Type.Name.Equals(SearchValueText))
                        {
                            SearchedEntities.Add(e);
                        }
                    }
                    ZIndex1 = 0;
                    ZIndex2 = 1;
                    ZIndexButton1 = 0;
                    ZIndexButton2 = 1;
                }

                if (SearchValueText.Equals(string.Empty))
                {
                    ZIndex1 = 1;
                    ZIndex2 = 0;
                    ZIndexButton1 = 1;
                    ZIndexButton2 = 0;
                }

            
        }
        
        

        public class ActionHistory
        {
            public string Description { get; set; }
            public Action UndoAction { get; set; }
        }

        
       

        private void UndoAllActions()
        {
            foreach (var action in ActionHistories.Reverse())
            {
                action.UndoAction?.Invoke();
            }
            ActionHistories.Clear();
        }

        public void ShowToastNotification(ToastNotification toastNotification)
        {
            notificationManager.Show(toastNotification.Title, toastNotification.Message, toastNotification.Type, "WindowNotificationArea");
        }

    }
}



