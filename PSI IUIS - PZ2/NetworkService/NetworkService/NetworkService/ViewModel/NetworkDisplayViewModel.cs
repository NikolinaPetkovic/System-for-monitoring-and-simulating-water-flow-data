using MVVMLight.Messaging;
using NetworkService.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static NetworkService.ViewModel.MainWindowViewModel;
using static NetworkService.ViewModel.NetworkEntityViewModel;

namespace NetworkService.ViewModel
{
    public class NetworkDisplayViewModel : BindableBase, INotifyPropertyChanged
    {
        private SolidColorBrush _preTextBlockColorOLD = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColorOLD
        {
            get { return _preTextBlockColorOLD; }
            set
            {
                _preTextBlockColorOLD = value;
                OnPropertyChanged(nameof(PreTextBlockColorOLD));
            }
        }

        private SolidColorBrush _preTextBlockColor1 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor1
        {
            get { return _preTextBlockColor1; }
            set
            {
                _preTextBlockColor1 = value;
                OnPropertyChanged(nameof(PreTextBlockColor1));
            }
        }
        private SolidColorBrush _preTextBlockColor2 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor2
        {
            get { return _preTextBlockColor2; }
            set
            {
                _preTextBlockColor2 = value;
                OnPropertyChanged(nameof(PreTextBlockColor2));
            }
        }
        private SolidColorBrush _preTextBlockColor3 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor3
        {
            get { return _preTextBlockColor3; }
            set
            {
                _preTextBlockColor3 = value;
                OnPropertyChanged(nameof(PreTextBlockColor3));
            }
        }
        private SolidColorBrush _preTextBlockColor4 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor4
        {
            get { return _preTextBlockColor4; }
            set
            {
                _preTextBlockColor4 = value;
                OnPropertyChanged(nameof(PreTextBlockColor4));
            }
        }
        private SolidColorBrush _preTextBlockColor5 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor5
        {
            get { return _preTextBlockColor5; }
            set
            {
                _preTextBlockColor5 = value;
                OnPropertyChanged(nameof(PreTextBlockColor5));
            }
        }
        private SolidColorBrush _preTextBlockColor6 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor6
        {
            get { return _preTextBlockColor6; }
            set
            {
                _preTextBlockColor6 = value;
                OnPropertyChanged(nameof(PreTextBlockColor6));
            }
        }
        private SolidColorBrush _preTextBlockColor7 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor7
        {
            get { return _preTextBlockColor7; }
            set
            {
                _preTextBlockColor7 = value;
                OnPropertyChanged(nameof(PreTextBlockColor7));
            }
        }
        private SolidColorBrush _preTextBlockColor8 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor8
        {
            get { return _preTextBlockColor8; }
            set
            {
                _preTextBlockColor8 = value;
                OnPropertyChanged(nameof(PreTextBlockColor8));
            }
        }
        private SolidColorBrush _preTextBlockColor9 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor9
        {
            get { return _preTextBlockColor9; }
            set
            {
                _preTextBlockColor9 = value;
                OnPropertyChanged(nameof(PreTextBlockColor9));
            }
        }
        private SolidColorBrush _preTextBlockColor10 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor10
        {
            get { return _preTextBlockColor10; }
            set
            {
                _preTextBlockColor10 = value;
                OnPropertyChanged(nameof(PreTextBlockColor10));
            }
        }
        private SolidColorBrush _preTextBlockColor11 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor11
        {
            get { return _preTextBlockColor11; }
            set
            {
                _preTextBlockColor11 = value;
                OnPropertyChanged(nameof(PreTextBlockColor11));
            }
        }
        private SolidColorBrush _preTextBlockColor12 = Brushes.LightGray;
        public SolidColorBrush PreTextBlockColor12
        {
            get { return _preTextBlockColor12; }
            set
            {
                _preTextBlockColor12 = value;
                OnPropertyChanged(nameof(PreTextBlockColor12));
            }
        }
        private string _textBlockText;
        public string TextBlockText
        {
            get { return _textBlockText; }
            set
            {
                if (_textBlockText != value)
                {
                    _textBlockText = value;
                    OnPropertyChanged(nameof(TextBlockText));
                }
            }
        }
        private string _textBlockCanvasUndoText1;
        public string TextBlockCanvasUndoText1
        {
            get { return _textBlockCanvasUndoText1; }
            set
            {
                if (_textBlockCanvasUndoText1 != value)
                {
                    _textBlockCanvasUndoText1 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText1));
                }
            }
        }
        private string _textBlockCanvasUndoText2;
        public string TextBlockCanvasUndoText2
        {
            get { return _textBlockCanvasUndoText2; }
            set
            {
                if (_textBlockCanvasUndoText2 != value)
                {
                    _textBlockCanvasUndoText2 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText2));
                }
            }
        }
        private string _textBlockCanvasUndoText3;
        public string TextBlockCanvasUndoText3
        {
            get { return _textBlockCanvasUndoText3; }
            set
            {
                if (_textBlockCanvasUndoText3 != value)
                {
                    _textBlockCanvasUndoText3 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText3));
                }
            }
        }
        private string _textBlockCanvasUndoText4;
        public string TextBlockCanvasUndoText4
        {
            get { return _textBlockCanvasUndoText4; }
            set
            {
                if (_textBlockCanvasUndoText4 != value)
                {
                    _textBlockCanvasUndoText4 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText4));
                }
            }
        }
        private string _textBlockCanvasUndoText5;
        public string TextBlockCanvasUndoText5
        {
            get { return _textBlockCanvasUndoText5; }
            set
            {
                if (_textBlockCanvasUndoText5 != value)
                {
                    _textBlockCanvasUndoText5 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText5));
                }
            }
        }
        private string _textBlockCanvasUndoText6;
        public string TextBlockCanvasUndoText6
        {
            get { return _textBlockCanvasUndoText6; }
            set
            {
                if (_textBlockCanvasUndoText6 != value)
                {
                    _textBlockCanvasUndoText6 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText6));
                }
            }
        }
        private string _textBlockCanvasUndoText7;
        public string TextBlockCanvasUndoText7
        {
            get { return _textBlockCanvasUndoText7; }
            set
            {
                if (_textBlockCanvasUndoText7 != value)
                {
                    _textBlockCanvasUndoText7 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText7));
                }
            }
        }
        private string _textBlockCanvasUndoText8;
        public string TextBlockCanvasUndoText8
        {
            get { return _textBlockCanvasUndoText8; }
            set
            {
                if (_textBlockCanvasUndoText8 != value)
                {
                    _textBlockCanvasUndoText8 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText8));
                }
            }
        }
        private string _textBlockCanvasUndoText9;
        public string TextBlockCanvasUndoText9
        {
            get { return _textBlockCanvasUndoText9; }
            set
            {
                if (_textBlockCanvasUndoText9 != value)
                {
                    _textBlockCanvasUndoText9 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText9));
                }
            }
        }
        private string _textBlockCanvasUndoText10;
        public string TextBlockCanvasUndoText10
        {
            get { return _textBlockCanvasUndoText10; }
            set
            {
                if (_textBlockCanvasUndoText10 != value)
                {
                    _textBlockCanvasUndoText10 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText10));
                }
            }
        }
        private string _textBlockCanvasUndoText11;
        public string TextBlockCanvasUndoText11
        {
            get { return _textBlockCanvasUndoText11; }
            set
            {
                if (_textBlockCanvasUndoText11 != value)
                {
                    _textBlockCanvasUndoText11 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText11));
                }
            }
        }
        private string _textBlockCanvasUndoText12;
        public string TextBlockCanvasUndoText12
        {
            get { return _textBlockCanvasUndoText12; }
            set
            {
                if (_textBlockCanvasUndoText12 != value)
                {
                    _textBlockCanvasUndoText12 = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText12));
                }
            }
        }
        private string _textBlockCanvasUndoText;
        public string TextBlockCanvasUndoText
        {
            get { return _textBlockCanvasUndoText; }
            set
            {
                if (_textBlockCanvasUndoText != value)
                {
                    _textBlockCanvasUndoText = value;
                    OnPropertyChanged(nameof(TextBlockCanvasUndoText));
                }
            }
        }
        private string _textBlockCanvas1Text;
        public string TextBlockCanvas1Text
        {
            get { return _textBlockCanvas1Text; }
            set
            {
                if (_textBlockCanvas1Text != value)
                {
                    _textBlockCanvas1Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas1Text));
                }
            }
        }
        private string _textBlockCanvas2Text;
        public string TextBlockCanvas2Text
        {
            get { return _textBlockCanvas2Text; }
            set
            {
                if (_textBlockCanvas2Text != value)
                {
                    _textBlockCanvas2Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas2Text));
                }
            }
        }
        private string _textBlockCanvas3Text;
        public string TextBlockCanvas3Text
        {
            get { return _textBlockCanvas3Text; }
            set
            {
                if (_textBlockCanvas3Text != value)
                {
                    _textBlockCanvas3Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas3Text));
                }
            }
        }
        private string _textBlockCanvas4Text;
        public string TextBlockCanvas4Text
        {
            get { return _textBlockCanvas4Text; }
            set
            {
                if (_textBlockCanvas4Text != value)
                {
                    _textBlockCanvas4Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas4Text));
                }
            }
        }
        private string _textBlockCanvas5Text;
        public string TextBlockCanvas5Text
        {
            get { return _textBlockCanvas5Text; }
            set
            {
                if (_textBlockCanvas5Text != value)
                {
                    _textBlockCanvas5Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas5Text));
                }
            }
        }
        private string _textBlockCanvas6Text;
        public string TextBlockCanvas6Text
        {
            get { return _textBlockCanvas6Text; }
            set
            {
                if (_textBlockCanvas6Text != value)
                {
                    _textBlockCanvas6Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas6Text));
                }
            }
        }
        private string _textBlockCanvas7Text;
        public string TextBlockCanvas7Text
        {
            get { return _textBlockCanvas7Text; }
            set
            {
                if (_textBlockCanvas7Text != value)
                {
                    _textBlockCanvas7Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas7Text));
                }
            }
        }
        private string _textBlockCanvas8Text;
        public string TextBlockCanvas8Text
        {
            get { return _textBlockCanvas8Text; }
            set
            {
                if (_textBlockCanvas8Text != value)
                {
                    _textBlockCanvas8Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas8Text));
                }
            }
        }
        private string _textBlockCanvas9Text;
        public string TextBlockCanvas9Text
        {
            get { return _textBlockCanvas9Text; }
            set
            {
                if (_textBlockCanvas9Text != value)
                {
                    _textBlockCanvas9Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas9Text));
                }
            }
        }
        private string _textBlockCanvas10Text;
        public string TextBlockCanvas10Text
        {
            get { return _textBlockCanvas10Text; }
            set
            {
                if (_textBlockCanvas10Text != value)
                {
                    _textBlockCanvas10Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas10Text));
                }
            }
        }
        private string _textBlockCanvas11Text;
        public string TextBlockCanvas11Text
        {
            get { return _textBlockCanvas11Text; }
            set
            {
                if (_textBlockCanvas11Text != value)
                {
                    _textBlockCanvas11Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas11Text));
                }
            }
        }
        private string _textBlockCanvas12Text;
        public string TextBlockCanvas12Text
        {
            get { return _textBlockCanvas12Text; }
            set
            {
                if (_textBlockCanvas12Text != value)
                {
                    _textBlockCanvas12Text = value;
                    OnPropertyChanged(nameof(TextBlockCanvas12Text));
                }
            }
        }
        public ObservableCollection<Entity> Entities { get; set; }
        public ObservableCollection<Entity> EntitiesHelper { get; set; }

        public ObservableCollection<ImagesByType> AllImages { get; set; }
        public ImagesByType zapreminskiImages { get; set; }
        public ImagesByType turbinskiImages { get; set; }
        public ImagesByType elektronskiImages { get; set; }




        private ImageBrush imageUndo { get; set; }
        private ImageBrush imageUndo1 { get; set; }
        private ImageBrush imageUndo2 { get; set; }
        private ImageBrush imageUndo3 { get; set; }
        private ImageBrush imageUndo4 { get; set; }
        private ImageBrush imageUndo5 { get; set; }
        private ImageBrush imageUndo6 { get; set; }
        private ImageBrush imageUndo7 { get; set; }
        private ImageBrush imageUndo8 { get; set; }
        private ImageBrush imageUndo9 { get; set; }
        private ImageBrush imageUndo10 { get; set; }
        private ImageBrush imageUndo11 { get; set; }
        private ImageBrush imageUndo12 { get; set; }

        private bool isDragging = false;
        private Image draggedItem = null;
        private Image draggedItem2 = null;
        private int draggedItemIndex = -1;
        public MyICommand HelpCommand { get; set; }
        public ICommand TreeViewSelectionChangedCommand { get; private set; }
        public ICommand CanvasMouseLeftButtonUpCommand { get; private set; }
        public ICommand CanvasSelectionChangedCommand { get; private set; }
        public ICommand TreeViewMouseLeftButtonUpCommand { get; private set; }
        public ICommand CanvasDragOverCommand { get; private set; }
        public ICommand CanvasDropCommand { get; private set; }
        public ICommand ClearCommand { get; set; }
        int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, c10 = 0, c11 = 0, c12 = 0;
        string s1 = "", s2 = "", s3 = "", s4 = "", s5 = "", s6 = "", s7 = "", s8 = "", s9 = "", s10 = "", s11 = "", s12 = "";
        string s1b = "", s2b = "", s3b = "", s4b = "", s5b = "", s6b = "", s7b = "", s8b = "", s9b = "", s10b = "", s11b = "", s12b = "";
        int u1 = 0, u2 = 0, u3 = 0, u4 = 0, u5 = 0, u6 = 0, u7 = 0, u8 = 0, u9 = 0, u10 = 0, u11 = 0, u12 = 0, u = 0;
        public Canvas canvas1 { get; set; }
        public Canvas canvas2 { get; set; }
        public Canvas canvas3 { get; set; }
        public Canvas canvas4 { get; set; }
        public Canvas canvas5 { get; set; }
        public Canvas canvas6 { get; set; }
        public Canvas canvas7 { get; set; }
        public Canvas canvas8 { get; set; }
        public Canvas canvas9 { get; set; }
        public Canvas canvas10 { get; set; }
        public Canvas canvas11 { get; set; }
        public Canvas canvas12 { get; set; }
        public Canvas canvasUndo { get; set; }
        string dragFullName = "";

        
       
        public NetworkDisplayViewModel()
        {

            TextBlockCanvas1Text = "";
            TextBlockCanvas2Text = "";
            TextBlockCanvas3Text = "";
            TextBlockCanvas4Text = "";
            TextBlockCanvas5Text = "";
            TextBlockCanvas6Text = "";
            TextBlockCanvas7Text = "";
            TextBlockCanvas8Text = "";
            TextBlockCanvas9Text = "";
            TextBlockCanvas10Text = "";
            TextBlockCanvas11Text = "";
            TextBlockCanvas12Text = "";
            TextBlockCanvasUndoText = "";

            TreeViewSelectionChangedCommand = new MyICommand<TreeView>(OnTreeViewSelectionChanged);
            TreeViewMouseLeftButtonUpCommand = new MyICommand<TreeView>(OnTreeViewMouseLeftButtonUp);
            //CanvasSelectionChangedCommand = new RelayCommand(OnCanvasSelectionChanged);
            //CanvasMouseLeftButtonUpCommand = new RelayCommand(OnCanvasMouseLeftButtonUp);
            CanvasDragOverCommand = new MyICommandWithParameter<Canvas>(OnCanvasDragOver);
            CanvasDropCommand = new MyICommandWithParameter<string>(OnCanvasDrop);

            Entities = new ObservableCollection<Entity>();
            AllImages = new ObservableCollection<ImagesByType>();
            zapreminskiImages = new ImagesByType() { EntyType = "Zapreminski" };
            turbinskiImages = new ImagesByType() { EntyType = "Turbinski" };
            elektronskiImages = new ImagesByType() { EntyType = "Elektronski" };
            Messenger.Default.Register<ObservableCollection<Entity>>(this, "FirstCollection", HandleCollection);

            ClearCommand = new MyICommandWithParameter<string>(OnClear);
            Messenger.Default.Register<Entity>(this, "AddCollection", HandleCollectionAdd);
            Messenger.Default.Register<Entity>(this, "DeleteCollection", HandleCollectionDelete);
            Messenger.Default.Register<Entity>(this, "ChangeCollection", HandleCollectionChange);
            

           

        }

        private void HandleCollection(ObservableCollection<Entity> collection)
        {
            Entities.Clear();
            foreach (var entity in collection)
            {
                Entities.Add(entity);
            }

            for (int i = 0; i < Entities.Count; i++)
            {
                if (Entities[i].Type.Name.Equals("Zapreminski"))
                {
                    zapreminskiImages.Images.Add(new Image() { TypeOfImage = Entities[i].Type.Name, IdOfImage = Entities[i].Id.ToString(), ValueOfImage = Entities[i].InvalidValue.ToString(), FileName = "ID:" + Entities[i].Id.ToString() + "_" + Entities[i].Name, Path = @"C:\Users\Korisnik\Desktop\zapreminski.jpg" });
                }
                else if (Entities[i].Type.Name.Equals("Turbinski"))
                {
                    turbinskiImages.Images.Add(new Image() { TypeOfImage = Entities[i].Type.Name, IdOfImage = Entities[i].Id.ToString(), ValueOfImage = Entities[i].InvalidValue.ToString(), FileName = "ID:" + Entities[i].Id.ToString() + "_" + Entities[i].Name, Path = @"C:\Users\Korisnik\Desktop\turbinski.jpg" });
                }
                else if (Entities[i].Type.Name.Equals("Elektronski"))
                {
                    elektronskiImages.Images.Add(new Image() { TypeOfImage = Entities[i].Type.Name, IdOfImage = Entities[i].Id.ToString(), ValueOfImage = Entities[i].InvalidValue.ToString(), FileName = "ID:" + Entities[i].Id.ToString() + "_" + Entities[i].Name, Path = @"C:\Users\Korisnik\Desktop\elektronski.jpg" });
                }
            }

            AllImages.Add(zapreminskiImages);
            AllImages.Add(turbinskiImages);
            AllImages.Add(elektronskiImages);

        }
        private void OnTreeViewSelectionChanged(object parameter)
        {
            if (parameter is TreeView treeView)
            {

                if (!isDragging && treeView.SelectedItem != null && treeView.SelectedItem.GetType() != typeof(ImagesByType))
                {
                    isDragging = true;
                    draggedItem = (Image)treeView.SelectedItem;
                    DragDrop.DoDragDrop(treeView, draggedItem, DragDropEffects.Move | DragDropEffects.Copy);
                }
            }

        }
        private void OnTreeViewMouseLeftButtonUp(object parameter)
        {
            TextBlockText = "A2A";
            ResetDragState();

            // Logika koja se izvršava kada se događaj MouseLeftButtonUp dogodi na TreeView-u
        }
        private void ResetDragState()
        {
            isDragging = false;
            draggedItem = null;
            draggedItemIndex = -1;
        }
        private void OnCanvasDragOver(object parameter)
        {
            TextBlockText = "OVER";
            if (parameter is DragEventArgs e && e.Source is Canvas canvas)
            {
                if (canvas.Resources["taken"] != null)
                {
                    // Odbaciti element ako je 'taken'
                    e.Effects = DragDropEffects.None;
                }
                else
                {
                    // Inače dozvoliti povlačenje
                    e.Effects = DragDropEffects.Move;
                }
                e.Handled = true;
            }

            // Logika koja se izvršava kada se događaj DragOver dogodi na Canvas-u
        }



        private void OnCanvasDrop(object parameter)
        {
            if (parameter is string canvasName)
            {
                Canvas canvas = FindCanvasByName(canvasName); // Pronalazi Canvas na osnovu imena
                if (canvas != null)
                {
                    if (draggedItem != null)
                    {

                        if (canvas.Resources["taken"] == null)
                        {
                            BitmapImage image = new BitmapImage();
                            image.BeginInit();
                            image.UriSource = new Uri(draggedItem.Path, UriKind.Absolute);
                            image.EndInit();
                            canvas.Background = new ImageBrush(image);

                            if (draggedItem.TypeOfImage == "Zapreminski")
                            {
                                if (canvasName == "Canvas1")
                                {
                                    TextBlockCanvas1Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor1 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas2")
                                {
                                    TextBlockCanvas2Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor2 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas3")
                                {
                                    TextBlockCanvas3Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor3 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas4")
                                {
                                    TextBlockCanvas4Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor4 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas5")
                                {
                                    TextBlockCanvas5Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor5 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas6")
                                {
                                    TextBlockCanvas6Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor6 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas7")
                                {
                                    TextBlockCanvas7Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor7 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas8")
                                {
                                    TextBlockCanvas8Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor8 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas9")
                                {
                                    TextBlockCanvas9Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor9 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas10")
                                {
                                    TextBlockCanvas10Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor10 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas11")
                                {
                                    TextBlockCanvas11Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor11 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas12")
                                {
                                    TextBlockCanvas12Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor12 = PreTextBlockColorOLD;
                                }

                            }
                            if (draggedItem.TypeOfImage == "Turbinski")
                            {
                                if (canvasName == "Canvas1")
                                {
                                    TextBlockCanvas1Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor1 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas2")
                                {
                                    TextBlockCanvas2Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor2 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas3")
                                {
                                    TextBlockCanvas3Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor3 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas4")
                                {
                                    TextBlockCanvas4Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor4 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas5")
                                {
                                    TextBlockCanvas5Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor5 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas6")
                                {
                                    TextBlockCanvas6Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor6 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas7")
                                {
                                    TextBlockCanvas7Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor7 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas8")
                                {
                                    TextBlockCanvas8Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor8 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas9")
                                {
                                    TextBlockCanvas9Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor9 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas10")
                                {
                                    TextBlockCanvas10Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor10 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas11")
                                {
                                    TextBlockCanvas11Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor11 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas12")
                                {
                                    TextBlockCanvas12Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor12 = PreTextBlockColorOLD;
                                }

                            }
                            if (draggedItem.TypeOfImage == "Elektronski")
                            {
                                if (canvasName == "Canvas1")
                                {
                                    TextBlockCanvas1Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor1 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas2")
                                {
                                    TextBlockCanvas2Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor2 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas3")
                                {
                                    TextBlockCanvas3Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor3 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas4")
                                {
                                    TextBlockCanvas4Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor4 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas5")
                                {
                                    TextBlockCanvas5Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor5 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas6")
                                {
                                    TextBlockCanvas6Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor6 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas7")
                                {
                                    TextBlockCanvas7Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor7 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas8")
                                {
                                    TextBlockCanvas8Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor8 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas9")
                                {
                                    TextBlockCanvas9Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor9 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas10")
                                {
                                    TextBlockCanvas10Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor10 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas11")
                                {
                                    TextBlockCanvas11Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor11 = PreTextBlockColorOLD;
                                }
                                if (canvasName == "Canvas12")
                                {
                                    TextBlockCanvas12Text = $"Id:{draggedItem.IdOfImage} Value:{draggedItem.ValueOfImage}";
                                    PreTextBlockColor12 = PreTextBlockColorOLD;
                                }

                            }

                            switch (canvasName)
                            {
                                case "Canvas1": c1 = 1; s1 = draggedItem.IdOfImage; s1b = draggedItem.IdOfImage; canvas1 = FindCanvasByName("Canvas1"); TextBlockCanvasUndoText1 = TextBlockCanvas1Text; imageUndo1 = (ImageBrush)canvas1.Background; break;
                                case "Canvas2": c2 = 1; s2 = draggedItem.IdOfImage; s2b = draggedItem.IdOfImage; canvas2 = FindCanvasByName("Canvas2"); TextBlockCanvasUndoText2 = TextBlockCanvas2Text; imageUndo2 = (ImageBrush)canvas2.Background; break;
                                case "Canvas3": c3 = 1; s3 = draggedItem.IdOfImage; s3b = draggedItem.IdOfImage; canvas3 = FindCanvasByName("Canvas3"); TextBlockCanvasUndoText3 = TextBlockCanvas3Text; imageUndo3 = (ImageBrush)canvas3.Background; break;
                                case "Canvas4": c4 = 1; s4 = draggedItem.IdOfImage; s4b = draggedItem.IdOfImage; canvas4 = FindCanvasByName("Canvas4"); TextBlockCanvasUndoText4 = TextBlockCanvas4Text; imageUndo4 = (ImageBrush)canvas4.Background; break;
                                case "Canvas5": c5 = 1; s5 = draggedItem.IdOfImage; s5b = draggedItem.IdOfImage; canvas5 = FindCanvasByName("Canvas5"); TextBlockCanvasUndoText5 = TextBlockCanvas5Text; imageUndo5 = (ImageBrush)canvas5.Background; break;
                                case "Canvas6": c6 = 1; s6 = draggedItem.IdOfImage; s6b = draggedItem.IdOfImage; canvas6 = FindCanvasByName("Canvas6"); TextBlockCanvasUndoText6 = TextBlockCanvas6Text; imageUndo6 = (ImageBrush)canvas6.Background; break;
                                case "Canvas7": c7 = 1; s7 = draggedItem.IdOfImage; s7b = draggedItem.IdOfImage; canvas7 = FindCanvasByName("Canvas7"); TextBlockCanvasUndoText7 = TextBlockCanvas7Text; imageUndo7 = (ImageBrush)canvas7.Background; break;
                                case "Canvas8": c8 = 1; s8 = draggedItem.IdOfImage; s8b = draggedItem.IdOfImage; canvas8 = FindCanvasByName("Canvas8"); TextBlockCanvasUndoText8 = TextBlockCanvas8Text; imageUndo8 = (ImageBrush)canvas8.Background; break;
                                case "Canvas9": c9 = 1; s9 = draggedItem.IdOfImage; s9b = draggedItem.IdOfImage; canvas9 = FindCanvasByName("Canvas9"); TextBlockCanvasUndoText9 = TextBlockCanvas9Text; imageUndo9 = (ImageBrush)canvas9.Background; break;
                                case "Canvas10": c10 = 1; s10 = draggedItem.IdOfImage; s10b = draggedItem.IdOfImage; canvas10 = FindCanvasByName("Canvas10"); TextBlockCanvasUndoText10 = TextBlockCanvas10Text; imageUndo10 = (ImageBrush)canvas10.Background; break;
                                case "Canvas11": c11 = 1; s11 = draggedItem.IdOfImage; s11b = draggedItem.IdOfImage; canvas11 = FindCanvasByName("Canvas11"); TextBlockCanvasUndoText11 = TextBlockCanvas11Text; imageUndo11 = (ImageBrush)canvas11.Background; break;
                                case "Canvas12": c12 = 1; s12 = draggedItem.IdOfImage; s12b = draggedItem.IdOfImage; canvas12 = FindCanvasByName("Canvas12"); TextBlockCanvasUndoText12 = TextBlockCanvas12Text; imageUndo12 = (ImageBrush)canvas12.Background; break;
                            }

                            canvas.Resources.Add("taken", true);
                            RemoveImageFromCollection(draggedItem);
                        }
                        ResetDragState();
                    }
                }
            }
        }
        private void RemoveImageFromCollection(Image draggedItem)
        {
            if (draggedItem.TypeOfImage == "Zapreminski")
            {
                for (int i = 0; i < zapreminskiImages.Images.Count; i++)
                {
                    if (zapreminskiImages.Images[i].IdOfImage == draggedItem.IdOfImage)
                    {
                        zapreminskiImages.Images.Remove(zapreminskiImages.Images[i]);
                        break;
                    }
                }
            }
            if (draggedItem.TypeOfImage == "Turbinski")
            {
                for (int i = 0; i < turbinskiImages.Images.Count; i++)
                {
                    if (turbinskiImages.Images[i].IdOfImage == draggedItem.IdOfImage)
                    {
                        turbinskiImages.Images.Remove(turbinskiImages.Images[i]);
                        break;
                    }
                }
            }
            if (draggedItem.TypeOfImage == "Elektronski")
            {
                for (int i = 0; i < elektronskiImages.Images.Count; i++)
                {
                    if (elektronskiImages.Images[i].IdOfImage == draggedItem.IdOfImage)
                    {
                        elektronskiImages.Images.Remove(elektronskiImages.Images[i]);
                        break;
                    }
                }
            }
        }
        private Canvas FindCanvasByName(string canvasName)
        {
            // Pronalaženje roditelja UserControlla
            FrameworkElement parent = Application.Current.MainWindow as FrameworkElement;

            // Rekurzivno pretraživanje svih Canvas elemenata
            return FindVisualChild<Canvas>(parent, canvasName);
        }

        // Rekurzivna pomoćna metoda za pronalaženje elementa po imenu
        private T FindVisualChild<T>(DependencyObject parent, string childName) where T : DependencyObject
        {
            // Broj dece roditelja
            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);

            for (int i = 0; i < childrenCount; i++)
            {
                // Pronalaženje deteta po indeksu
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                // Provera da li je dete tipa T i ima li ime koje tražimo
                if (child is T typedChild && (child as FrameworkElement).Name == childName)
                {
                    return typedChild;
                }
                else
                {
                    // Rekurzivna pretraga unutar deteta
                    T foundChild = FindVisualChild<T>(child, childName);
                    if (foundChild != null)
                    {
                        return foundChild;
                    }
                }
            }

            return null;
        }

        private void HandleCollectionChange(Entity entityChanger)
        {
            //ne moram menjati Entities, samo vrednost od 
            if (entityChanger.Type.Name == "Zapreminski")
            {
                for (int i = 0; i < zapreminskiImages.Images.Count; i++)
                {
                    if (zapreminskiImages.Images[i].IdOfImage == entityChanger.Id.ToString())
                    {
                        if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                        {
                            zapreminskiImages.Images[i].ValueOfImage = entityChanger.InvalidValue.ToString();
                        }
                    }
                }
            }
            else if (entityChanger.Type.Name == "Turbinski")
            {
                for (int i = 0; i < turbinskiImages.Images.Count; i++)
                {
                    if (turbinskiImages.Images[i].IdOfImage == entityChanger.Id.ToString())
                    {
                        if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                        {
                            turbinskiImages.Images[i].ValueOfImage = entityChanger.InvalidValue.ToString();
                        }
                    }
                }
            }
            else if (entityChanger.Type.Name == "Elektronski")
            {
                for (int i = 0; i < elektronskiImages.Images.Count; i++)
                {
                    if (elektronskiImages.Images[i].IdOfImage == entityChanger.Id.ToString())
                    {
                        if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                        {
                            elektronskiImages.Images[i].ValueOfImage = entityChanger.InvalidValue.ToString();
                        }
                    }
                }
            }

            //ovde proveriti da li je novodobijena vrednost izmedju 0.34 i 2.73 ako je izmedju prikazati ako nije ne prikazati i pocrveneti TextBlock
            if (!TextBlockCanvas1Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas1Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor1 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas1Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText1 = TextBlockCanvas1Text;
                        PreTextBlockColor1 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor1 = Brushes.LightGray;
            }
            if (!TextBlockCanvas2Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas2Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor2 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas2Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText2 = TextBlockCanvas2Text;
                        PreTextBlockColor2 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor2 = Brushes.LightGray;
            }
            if (!TextBlockCanvas3Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas3Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor3 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas3Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText3 = TextBlockCanvas3Text;
                        PreTextBlockColor3 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor3 = Brushes.LightGray;
            }
            if (!TextBlockCanvas4Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas4Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor4 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas4Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText4 = TextBlockCanvas4Text;
                        PreTextBlockColor4 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor4 = Brushes.LightGray;
            }
            if (!TextBlockCanvas5Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas5Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor5 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas5Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText5 = TextBlockCanvas5Text;
                        PreTextBlockColor5 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor5 = Brushes.LightGray;
            }
            if (!TextBlockCanvas6Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas6Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor6 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas6Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText6 = TextBlockCanvas6Text;
                        PreTextBlockColor6 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor6 = Brushes.LightGray;
            }
            if (!TextBlockCanvas7Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas7Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor7 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas7Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText7 = TextBlockCanvas7Text;
                        PreTextBlockColor7 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor7 = Brushes.LightGray;
            }
            if (!TextBlockCanvas8Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas8Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor8 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas8Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText8 = TextBlockCanvas8Text;
                        PreTextBlockColor8 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor8 = Brushes.LightGray;
            }
            if (!TextBlockCanvas9Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas9Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor9 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas9Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText9 = TextBlockCanvas9Text;
                        PreTextBlockColor9 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor9 = Brushes.LightGray;
            }
            if (!TextBlockCanvas10Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas10Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor10 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas10Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText10 = TextBlockCanvas10Text;
                        PreTextBlockColor10 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor10 = Brushes.LightGray;
            }
            if (!TextBlockCanvas11Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas11Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor11 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas11Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText11 = TextBlockCanvas11Text;
                        PreTextBlockColor11 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor11 = Brushes.LightGray;
            }
            if (!TextBlockCanvas12Text.Equals(string.Empty))
            {
                string[] words1 = TextBlockCanvas12Text.Split(' ');
                string[] words = words1[0].Split(':');
                string idBlock = words[1];
                if (idBlock == entityChanger.Id.ToString())
                {
                    if (entityChanger.InvalidValue < 670 || entityChanger.InvalidValue > 735)
                    { //ako je nevalidna
                        PreTextBlockColor12 = Brushes.Red;
                    }
                    if (entityChanger.InvalidValue >= 670 && entityChanger.InvalidValue <= 735)
                    {
                        TextBlockCanvas12Text = $"Id:{idBlock} Value:{entityChanger.InvalidValue}";
                        TextBlockCanvasUndoText12 = TextBlockCanvas12Text;
                        PreTextBlockColor12 = Brushes.LightGray;
                    }
                }
            }
            else
            {
                PreTextBlockColor12 = Brushes.LightGray;
            }
        }
        private void HandleCollectionAdd(Entity entityAdder)
        {
            Entities.Add(entityAdder);
            if (entityAdder.Type.Name == "Zapreminski")
            {
                zapreminskiImages.Images.Add(new Image() { TypeOfImage = entityAdder.Type.Name, IdOfImage = entityAdder.Id.ToString(), ValueOfImage = entityAdder.InvalidValue.ToString(), FileName = "ID:" + entityAdder.Id.ToString() + "_" + entityAdder.Name, Path = @"C:\Users\Korisnik\Desktop\zapreminski.jpg" });
            }

            else if (entityAdder.Type.Name == "Turbinski")
            {
                turbinskiImages.Images.Add(new Image() { TypeOfImage = entityAdder.Type.Name, IdOfImage = entityAdder.Id.ToString(), ValueOfImage = entityAdder.InvalidValue.ToString(), FileName = "ID:" + entityAdder.Id.ToString() + "_" + entityAdder.Name, Path = @"C:\Users\Korisnik\Desktop\turbinski.jpg" });
            }
            else if (entityAdder.Type.Name == "Elektronski")
            {
                elektronskiImages.Images.Add(new Image() { TypeOfImage = entityAdder.Type.Name, IdOfImage = entityAdder.Id.ToString(), ValueOfImage = entityAdder.InvalidValue.ToString(), FileName = "ID:" + entityAdder.Id.ToString() + "_" + entityAdder.Name, Path = @"C:\Users\Korisnik\Desktop\elektonski.jpg" });
            }

        }
        private void HandleCollectionDelete(Entity entityDeleter)
        {

            if (entityDeleter != null)
            {
                if (entityDeleter.Type.Name == "Zapreminski")
                {
                    Image imageDeleter = null;
                    for (int i = 0; i < zapreminskiImages.Images.Count; i++)
                    {
                        if (zapreminskiImages.Images[i].IdOfImage == entityDeleter.Id.ToString())
                        {
                            imageDeleter = zapreminskiImages.Images[i];
                            break;
                        }
                    }

                    zapreminskiImages.Images.Remove(imageDeleter);
                }
                else if (entityDeleter.Type.Name == "Turbinski")
                {

                    Image imageDeleter = null;
                    for (int i = 0; i < turbinskiImages.Images.Count; i++)
                    {
                        if (turbinskiImages.Images[i].IdOfImage == entityDeleter.Id.ToString())
                        {
                            imageDeleter = turbinskiImages.Images[i];
                            break;
                        }
                    }

                    turbinskiImages.Images.Remove(imageDeleter);

                }
                else if (entityDeleter.Type.Name == "Elektronski")
                {

                    Image imageDeleter = null;
                    for (int i = 0; i < elektronskiImages.Images.Count; i++)
                    {
                        if (elektronskiImages.Images[i].IdOfImage == entityDeleter.Id.ToString())
                        {
                            imageDeleter = elektronskiImages.Images[i];
                            break;
                        }
                    }

                    elektronskiImages.Images.Remove(imageDeleter);
                }

                Entities.Remove(entityDeleter);
            }

            //MessageBox.Show(("AA=" + c1 + " BB=" + s1).ToString());
            u1 = 0; u2 = 0; u3 = 0; u4 = 0; u5 = 0; u6 = 0; u7 = 0; u8 = 0; u9 = 0; u10 = 0; u11 = 0; u12 = 0;

            if (c1 == 1 && (s1 == entityDeleter.Id.ToString()))
            {
                canvas1.Background = Brushes.White;
                canvas1.Resources.Remove("taken");
                TextBlockCanvas1Text = string.Empty;
                c1 = 0;
                s1 = "";
                u1 = 1;
                PreTextBlockColor1 = Brushes.LightGray;
            }
            if (c2 == 1 && (s2 == entityDeleter.Id.ToString()))
            {

                canvas2.Background = Brushes.White;
                canvas2.Resources.Remove("taken");
                TextBlockCanvas2Text = string.Empty;
                c2 = 0;
                s2 = "";
                u2 = 2;
                PreTextBlockColor2 = Brushes.LightGray;
            }
            if (c3 == 1 && (s3 == entityDeleter.Id.ToString()))
            {

                canvas3.Background = Brushes.White;
                canvas3.Resources.Remove("taken");
                TextBlockCanvas3Text = string.Empty;
                c3 = 0;
                s3 = "";
                u3 = 3;
                PreTextBlockColor3 = Brushes.LightGray;
            }
            if (c4 == 1 && (s4 == entityDeleter.Id.ToString()))
            {
                canvas4.Background = Brushes.White;
                canvas4.Resources.Remove("taken");
                TextBlockCanvas4Text = string.Empty;
                c4 = 0;
                s4 = "";
                u4 = 4;
                PreTextBlockColor4 = Brushes.LightGray;
            }
            if (c5 == 1 && (s5 == entityDeleter.Id.ToString()))
            {
                canvas5.Background = Brushes.White;
                canvas5.Resources.Remove("taken");
                TextBlockCanvas5Text = string.Empty;
                c5 = 0;
                s5 = "";
                u5 = 5;
                PreTextBlockColor5 = Brushes.LightGray;
            }
            if (c6 == 1 && (s6 == entityDeleter.Id.ToString()))
            {
                canvas6.Background = Brushes.White;
                canvas6.Resources.Remove("taken");
                TextBlockCanvas6Text = string.Empty;
                c6 = 0;
                s6 = "";
                u6 = 6;
                PreTextBlockColor6 = Brushes.LightGray;
            }
            if (c7 == 1 && (s7 == entityDeleter.Id.ToString()))
            {
                canvas7.Background = Brushes.White;
                canvas7.Resources.Remove("taken");
                TextBlockCanvas7Text = string.Empty;
                c7 = 0;
                s7 = "";
                u7 = 7;
                PreTextBlockColor7 = Brushes.LightGray;
            }
            if (c8 == 1 && (s8 == entityDeleter.Id.ToString()))
            {
                canvas8.Background = Brushes.White;
                canvas8.Resources.Remove("taken");
                TextBlockCanvas8Text = string.Empty;
                c8 = 0;
                s8 = "";
                u8 = 8;
                PreTextBlockColor8 = Brushes.LightGray;
            }
            if (c9 == 1 && (s9 == entityDeleter.Id.ToString()))
            {
                canvas9.Background = Brushes.White;
                canvas9.Resources.Remove("taken");
                TextBlockCanvas9Text = string.Empty;
                c9 = 0;
                s9 = "";
                u9 = 9;
                PreTextBlockColor9 = Brushes.LightGray;
            }
            if (c10 == 1 && (s10 == entityDeleter.Id.ToString()))
            {
                canvas10.Background = Brushes.White;
                canvas10.Resources.Remove("taken");
                TextBlockCanvas10Text = string.Empty;
                c10 = 0;
                s10 = "";
                u10 = 10;
                PreTextBlockColor10 = Brushes.LightGray;
            }
            if (c11 == 1 && (s11 == entityDeleter.Id.ToString()))
            {

                canvas11.Background = Brushes.White;
                canvas11.Resources.Remove("taken");
                TextBlockCanvas11Text = string.Empty;
                c11 = 0;
                s11 = "";
                u11 = 11;
                PreTextBlockColor11 = Brushes.LightGray;
            }
            if (c12 == 1 && (s12 == entityDeleter.Id.ToString()))
            {

                canvas12.Background = Brushes.White;
                canvas12.Resources.Remove("taken");
                TextBlockCanvas12Text = string.Empty;
                c12 = 0;
                s12 = "";
                u12 = 12;
                PreTextBlockColor12 = Brushes.LightGray;
            }
        }

        private void OnClear(string parameter)
        {
            if (parameter is string canvasName)
            {
                Canvas canvas = FindCanvasByName(canvasName); // Pronalazi Canvas na osnovu imena
                if (canvas != null)
                {
                    if (canvas.Resources["taken"] != null)
                    {
                        canvas.Background = Brushes.White;
                        canvas.Resources.Remove("taken");

                        if (canvasName == "Canvas1")
                        {

                            ReturnImageToCollectionFromCanvas(TextBlockCanvas1Text);
                            TextBlockCanvas1Text = string.Empty;
                            s1 = "";
                            s1b = "";
                            TextBlockCanvasUndoText1 = "";
                            TextBlockCanvas1Text = "";
                            imageUndo1 = null;
                            PreTextBlockColor1 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas2")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas2Text);
                            TextBlockCanvas2Text = string.Empty;
                            s2 = "";
                            s2b = "";
                            TextBlockCanvasUndoText2 = "";
                            TextBlockCanvas2Text = "";
                            imageUndo2 = null;
                            PreTextBlockColor2 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas3")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas3Text);
                            TextBlockCanvas3Text = string.Empty;
                            s3 = "";
                            s3b = "";
                            TextBlockCanvasUndoText3 = "";
                            TextBlockCanvas3Text = "";
                            imageUndo3 = null;
                            PreTextBlockColor3 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas4")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas4Text);
                            TextBlockCanvas4Text = string.Empty;
                            s4 = "";
                            s4b = "";
                            TextBlockCanvasUndoText4 = "";
                            TextBlockCanvas4Text = "";
                            imageUndo4 = null;
                            PreTextBlockColor4 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas5")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas5Text);
                            TextBlockCanvas5Text = string.Empty;
                            s5 = "";
                            s5b = "";
                            TextBlockCanvasUndoText5 = "";
                            TextBlockCanvas5Text = "";
                            imageUndo5 = null;
                            PreTextBlockColor5 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas6")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas6Text);
                            TextBlockCanvas6Text = string.Empty;
                            s6 = "";
                            s6b = "";
                            TextBlockCanvasUndoText6 = "";
                            TextBlockCanvas6Text = "";
                            imageUndo6 = null;
                            PreTextBlockColor6 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas7")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas7Text);
                            TextBlockCanvas7Text = string.Empty;
                            s7 = "";
                            s7b = "";
                            TextBlockCanvasUndoText7 = "";
                            TextBlockCanvas7Text = "";
                            imageUndo7 = null;
                            PreTextBlockColor7 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas8")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas8Text);
                            TextBlockCanvas8Text = string.Empty;
                            s8 = "";
                            s8b = "";
                            TextBlockCanvasUndoText8 = "";
                            TextBlockCanvas8Text = "";
                            imageUndo8 = null;
                            PreTextBlockColor8 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas9")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas9Text);
                            TextBlockCanvas9Text = string.Empty;
                            s9 = "";
                            s9b = "";
                            TextBlockCanvasUndoText9 = "";
                            TextBlockCanvas9Text = "";
                            imageUndo9 = null;
                            PreTextBlockColor9 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas10")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas10Text);
                            TextBlockCanvas10Text = string.Empty;
                            s10 = "";
                            s10b = "";
                            TextBlockCanvasUndoText10 = "";
                            TextBlockCanvas10Text = "";
                            imageUndo10 = null;
                            PreTextBlockColor10 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas11")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas11Text);
                            TextBlockCanvas11Text = string.Empty;
                            s11 = "";
                            s11b = "";
                            TextBlockCanvasUndoText11 = "";
                            TextBlockCanvas11Text = "";
                            imageUndo11 = null;
                            PreTextBlockColor11 = Brushes.LightGray;
                        }
                        if (canvasName == "Canvas12")
                        {
                            ReturnImageToCollectionFromCanvas(TextBlockCanvas12Text);
                            TextBlockCanvas12Text = string.Empty;
                            s12 = "";
                            s12b = "";
                            TextBlockCanvasUndoText12 = "";
                            TextBlockCanvas12Text = "";
                            imageUndo12 = null;
                            PreTextBlockColor12 = Brushes.LightGray;
                        }



                    }
                }
            }
        }
        private void ReturnImageToCollectionFromCanvas(string idValue)
        {
            string[] words1 = idValue.Split(' ');
            string[] words = words1[0].Split(':');
            string[] words2 = words1[1].Split(':');
            string idBlock = words[1];
            string valueBlock = words2[1];

            for (int i = 0; i < Entities.Count; i++)
            {
                if (Entities[i].Id.ToString() == idBlock)
                {
                    if (Entities[i].Type.Name == "Zapreminski")
                    {
                        zapreminskiImages.Images.Add(new Image() { TypeOfImage = "Zapreminski", IdOfImage = idBlock, ValueOfImage = valueBlock, FileName = "ID:" + idBlock + "_" + Entities[i].Name, Path = @"C:\Users\Korisnik\Desktop\zapreminski.jpg" });
                        dragFullName = words1[0];
                        break;
                    }
                    if (Entities[i].Type.Name == "Turbinski")
                    {
                        turbinskiImages.Images.Add(new Image() { TypeOfImage = "Turbinski", IdOfImage = idBlock, ValueOfImage = valueBlock, FileName = "ID:" + idBlock + "_" + Entities[i].Name, Path = @"C:\Users\Korisnik\Desktop\turbinski.jpg" });
                        dragFullName = words1[0];
                        break;
                    }
                    if (Entities[i].Type.Name == "Elektronski")
                    {
                        elektronskiImages.Images.Add(new Image() { TypeOfImage = "Elektronski", IdOfImage = idBlock, ValueOfImage = valueBlock, FileName = "ID:" + idBlock + "_" + Entities[i].Name, Path = @"C:\Users\Korisnik\Desktop\elektronski.jpg" });
                        dragFullName = words1[0];
                        break;
                    }
                }
            }

        }


    }
}
