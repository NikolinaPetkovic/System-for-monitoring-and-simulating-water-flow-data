using MVVMLight.Messaging;
using NetworkService.Model;
using NetworkService.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NetworkService.ViewModel
{

    public class MainWindowViewModel : BindableBase
    {
        public MyICommand<string> NavCommand { get; private set; }

        private MeasurementGraphView graphViewModel = new MeasurementGraphView();
        private NetworkDisplayView displayViewModel = new NetworkDisplayView();
        private NetworkEntityView entityViewModel = new NetworkEntityView();
        private UserControl currentViewModel;


        public UserControl CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                SetProperty(ref currentViewModel, value);
            }
        }


        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "NetworkEntity":
                    CurrentViewModel = entityViewModel;
                    break;
                case "NetworkDisplay":
                    CurrentViewModel = displayViewModel;
                    break;
                case "GraphMeasurement":
                    CurrentViewModel = graphViewModel;
                    break;
                default:
                    Console.WriteLine("Invalid destination");
                    break;
            }
        }
        private void SetCount(int c)
        {
            count = c;
        }
        #region
        private int count = 3; // Inicijalna vrednost broja objekata u sistemu
                               // ######### ZAMENITI stvarnim brojem elemenata
                               //           zavisno od broja entiteta u listi
        public ObservableCollection<Entity> EntitiesToShow { get; set; }
        public MainWindowViewModel()
        {
            string filePath = "Log.txt";
            File.WriteAllText(filePath, string.Empty);

            NavCommand = new MyICommand<string>(OnNav);

            CurrentViewModel = entityViewModel;

            EntitiesToShow = new ObservableCollection<Entity>();
            EntitiesToShow.Add(new Entity { Id = 1, Name = "Zapreminski1", Type = new EntityType("Zapreminski", @"C:\Users\Korisnik\Desktop\zapreminski.jpg"), Value = 0 });
            EntitiesToShow.Add(new Entity { Id = 2, Name = "Turbinski2", Type = new EntityType("Turbinski", @"C:\Users\Korisnik\Desktop\turbinski.jpg"), Value = 0 });
            EntitiesToShow.Add(new Entity { Id = 3, Name = "Elektronski3", Type = new EntityType("Elektronski", @"C:\Users\Korisnik\Desktop\elektronski.jpg"), Value = 0 });
           
            Messenger.Default.Send<ObservableCollection<Entity>>(EntitiesToShow, "FirstCollection");
            Messenger.Default.Register<int>(this, SetCount);
            createListener(); //Povezivanje sa serverskom aplikacijom
        }

        private void createListener()
        {
            var tcp = new TcpListener(IPAddress.Any, 30000);
            tcp.Start();

            var listeningThread = new Thread(() =>
            {
                while (true)
                {
                    var tcpClient = tcp.AcceptTcpClient();
                    ThreadPool.QueueUserWorkItem(param =>
                    {
                        //Prijem poruke
                        NetworkStream stream = tcpClient.GetStream();
                        string incomming;
                        byte[] bytes = new byte[1024];
                        int i = stream.Read(bytes, 0, bytes.Length);
                        //Primljena poruka je sacuvana u incomming stringu
                        incomming = System.Text.Encoding.ASCII.GetString(bytes, 0, i);

                        //Ukoliko je primljena poruka pitanje koliko objekata ima u sistemu -> odgovor
                        if (incomming.Equals("Need object count"))
                        {
                            //Response
                            /* Umesto sto se ovde salje count.ToString(), potrebno je poslati 
                             * duzinu liste koja sadrzi sve objekte pod monitoringom, odnosno
                             * njihov ukupan broj (NE BROJATI OD NULE, VEC POSLATI UKUPAN BROJ)
                             * */
                            Byte[] data = System.Text.Encoding.ASCII.GetBytes(count.ToString());
                            stream.Write(data, 0, data.Length);
                        }
                        else
                        {
                            //U suprotnom, server je poslao promenu stanja nekog objekta u sistemu
                            Console.WriteLine(incomming); //Na primer: "Entitet_1:272"
                            Messenger.Default.Send<string>(incomming, "NewValueReceived");
                            Messenger.Default.Send<string>("ValueSent", "NewValueForGraph");
                            //################ IMPLEMENTACIJA ####################
                            // Obraditi poruku kako bi se dobile informacije o izmeni
                            // Azuriranje potrebnih stvari u aplikaciji

                        }
                    }, null);
                }
            });

            listeningThread.IsBackground = true;
            listeningThread.Start();
        }
        #endregion
    }
}
