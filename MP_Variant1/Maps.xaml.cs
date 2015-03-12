using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Map;
using System.Collections.ObjectModel;
using Microsoft.Maps.MapControl;
using System.Windows.Forms;
using DevExpress.Data;




namespace MP_Variant1
{
    /// <summary>
    /// Interaction logic for Maps.xaml
    /// </summary>
    public partial class Maps : Window
    {
        #region #CalculateRoute
        int waypointIndex;
        List<RouteWaypoint> waypoints;
        ObservableCollection<MapItem> helpers;
       // ObservableCollection<MapPushpin> MapItems { get; set; }
        //public DataTemplate Pushpin { get; set; }

        
        public ObservableCollection<MapItem> Helpers
        {
            get { return this.helpers; }
        }
      //  Random rand = new Random((int)DateTime.Now.Ticks);
        //private void PushpinLocationAnimation_Completed(object sender, EventArgs e)
        //{
          //  SelectRandomLocation();
       // }

       // void SelectRandomLocation()
        //{
        //    MapPushpin pushpin = new MapPushpin();
         //   pushpin.Location = (new GeoPoint(rand.NextDouble() * 40, rand.NextDouble() * 40));
        //}
        public Maps()
        {
            InitializeComponent();
           // SelectRandomLocation();
            myMap.Focus();
            DataContext = this;
            //MapItems = new ObservableCollection<MapPushpin>();
            this.helpers = new ObservableCollection<MapItem>();
            this.waypoints = new List<RouteWaypoint>();
          
            
        }
     
    
        private string NextWaypointLetter()
        {
            string letter = "" + (char)((byte)'A' + waypointIndex % 26);
            waypointIndex++;
            return letter;
        }

        private void GeocodeLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs args)
        {
            foreach (MapItem item in args.Items)
            {
                MapPushpin pushpin = item as MapPushpin;
                if (pushpin != null)
                {
                    pushpin.MouseLeftButtonDown += new MouseButtonEventHandler(PushpinMouseLeftButtonDown);
                }
            }
        }

        private void PushpinMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MapPushpin pushpin = sender as MapPushpin;
            if ((pushpin != null) && (pushpin.State == MapPushpinState.Normal))
            {
                LocationInformation locationInformation = pushpin.Information as LocationInformation;
                AddWaypoint(locationInformation == null ? string.Empty : locationInformation.DisplayName, pushpin.Location);
                geocodeInformationLayer.ClearResults();
            }
            e.Handled = true;
        }

        private void AddWaypoint(string description, GeoPoint location)
        {
            RouteWaypoint waypoint = new RouteWaypoint(description, location);
            if (!waypoints.Contains(waypoint))
            {
                MapPushpin pushpin = new MapPushpin();
                pushpin.Location = location;
                pushpin.Information = description;
                pushpin.Text = NextWaypointLetter();
                pushpin.TraceDepth = 0;
                pushpin.State = MapPushpinState.Busy;
                Helpers.Add(pushpin);
                waypoints.Add(waypoint);

                if (waypoints.Count > 1)
                    routeDataProvider.CalculateRoute(waypoints);
            }
        }
        #endregion #CalculateRoute
        #region #RoutingResult
        private void RouteLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs args)
        {
            if ((args.Error == null) && !args.Cancelled)
            {
                waypointIndex = 0;
                foreach (MapItem item in args.Items)
                {
                    MapPushpin pushpin = item as MapPushpin;
                    if (pushpin != null)
                        pushpin.Text = NextWaypointLetter();
                }

                Helpers.Clear();
            }
        }
        #endregion #RoutingResult

       

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Helpers.Clear();
            waypoints.Clear();
            waypointIndex = 0;
            routeInformationLayer.ClearResults();
            geocodeInformationLayer.ClearResults();
        }

     
        

        private void Locate_Click(object sender, RoutedEventArgs e)
        {   
            MapPushpin pushpin0 = new MapPushpin();
            pushpin0.Location = (new GeoPoint(14.6570, 121.0305));
            pushpin0.Information = "SM City North EDSA - EDSA cor. North Avenue, Quezon City, Philippines";
            pushpin0.Text = "SM City North EDSA";
            pushpin0.TraceDepth = 0;
            pushpin0.State = MapPushpinState.Normal;
            Helpers.Add(pushpin0);

           

            MapPushpin pushpin1 = new MapPushpin();
            pushpin1.Location = (new GeoPoint(14.6044, 121.0188));
            pushpin1.Information = "SM City Sta. Mesa - Ramon Magsaysay Boulevard cor. Araneta Avenue, Brgy. Doña Imelda, Quezon City, Philippines";
            pushpin1.Text = "SM City Sta. Mesa";
            pushpin1.TraceDepth = 0;
            pushpin1.State = MapPushpinState.Normal;
            Helpers.Add(pushpin1);

            MapPushpin pushpin2 = new MapPushpin();
            pushpin2.Location = (new GeoPoint(14.5844, 121.0568));
            pushpin2.Information = "SM Megamall - EDSA cor. Doña Julia Vargas Avenue, Ortigas Center, Mandaluyong City, Philippines";
            pushpin2.Text = "SM Megamall";
            pushpin2.TraceDepth = 0;
            pushpin2.State = MapPushpinState.Normal;
            Helpers.Add(pushpin2);

            MapPushpin pushpin3 = new MapPushpin();
            pushpin3.Location = (new GeoPoint(14.7337, 121.0585));
            pushpin3.Information = "SM City Fairview - Quirino Highway cor. Regalado Avenue & Beltfast Avenue, Greater Lagro, Novaliches, Quezon City, Philippines";
            pushpin3.Text = "SM City Fairview";
            pushpin3.TraceDepth = 0;
            pushpin3.State = MapPushpinState.Normal;
            Helpers.Add(pushpin3);

            MapPushpin pushpin4 = new MapPushpin();
            pushpin4.Location = (new GeoPoint(14.5895, 120.9827));
            pushpin4.Information = " SM City Manila- Natividad Almeda-Lopez (formerly called Concepcion) corner A. Villegas (formerly called Arroceros) and San Marcelino Streets, Ermita, Manila, Philippines";
            pushpin4.Text = "SM City Manila";
            //pushpin4.TraceDepth = 10;
            pushpin4.State = MapPushpinState.Normal;
            Helpers.Add(pushpin4);
          


            MapPushpin pushpin5 = new MapPushpin();
            pushpin5.Location = (new GeoPoint(14.4841, 120.9918));
            pushpin5.Information = "SM City Sucat - Dr. A. Santos Avenue cor. Carlos P. Garcia Avenue Extension (C-5), Brgy. San Dionisio, Parañaque City";
            pushpin5.Text = "SM City Sucat";
            pushpin5.TraceDepth = 0;
            pushpin5.State = MapPushpinState.Normal;
            Helpers.Add(pushpin5);


            MapPushpin pushpin6 = new MapPushpin();
            pushpin6.Location = (new GeoPoint(14.4870, 121.0434));
            pushpin6.Information = "SM City Bicutan - Doña Soledad Avenue cor. West Service Road (beside Exit 14, Bicutan Exit), Brgy. Don Bosco, Bicutan, Parañaque City, Philippines";
            pushpin6.Text = "SM City Bicutan";
            pushpin6.TraceDepth = 0;
            pushpin6.State = MapPushpinState.Normal;
            Helpers.Add(pushpin6);

            MapPushpin pushpin7 = new MapPushpin(); 
            pushpin7.Location = (new GeoPoint(14.6181, 120.9858));
            pushpin7.Information = "SM City San Lazaro - Felix Huertas Street cor. Arsenio H. Lacson Street (C-2 Road), Santa Cruz, Manila, Philippines";
            pushpin7.Text = "SM City San Lazaro";
            pushpin7.TraceDepth = 0;
            pushpin7.State = MapPushpinState.Normal;
            Helpers.Add(pushpin7);

            MapPushpin pushpin8 = new MapPushpin();
            pushpin8.Location = (new GeoPoint(14.5351, 120.9822));
            pushpin8.Information = "SM Mall of Asia - SM Central Business Park, Bay City, Pasay City";
            pushpin8.Text = "SM Mall of Asia";
            pushpin8.TraceDepth = 0;
            pushpin8.State = MapPushpinState.Normal;
            Helpers.Add(pushpin8);

            MapPushpin pushpin9 = new MapPushpin();
            pushpin9.Location = (new GeoPoint(14.5844, 121.0771));
            pushpin9.Information = "SM Center Pasig - Eulogio Rodriguez Jr. Avenue (C-5) cor. Doña Julia Vargas Ave., Ugong, Pasig City";
            pushpin9.Text = "SM Center Pasig";
            pushpin9.TraceDepth = 0;
            pushpin9.State = MapPushpinState.Normal;
            Helpers.Add(pushpin9);

            MapPushpin pushpin10 = new MapPushpin();
            pushpin10.Location = (new GeoPoint(14.6275, 121.0844));
            pushpin10.Information = "SM City Marikina - Riverbanks Center, Marcos Highway, Brgy. Calumpang, Marikina City";
            pushpin10.Text = "SM City Marikina";
            pushpin10.TraceDepth = 0;
            pushpin10.State = MapPushpinState.Normal;
            Helpers.Add(pushpin10);

            MapPushpin pushpin11 = new MapPushpin();
            pushpin11.Location = (new GeoPoint(14.5462, 121.0544));
            pushpin11.Information = "SM Aura Premier - McKinley Parkway and C5 Road cor. 26th St., Bonifacio Global City, Taguig City";
            pushpin11.Text = "SM Aura Premier";
            pushpin11.TraceDepth = 0;
            pushpin11.State = MapPushpinState.Normal;
            Helpers.Add(pushpin11);



        
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Logging out. Thank you for using the program. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();  
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Logging out. Thank you for using the program. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();  
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            var Help = new Help();
            Help.ShowDialog();
        }

        private void MapuaSelect(object sender, RoutedEventArgs e)
        {
            MapPushpin pushpin12 = new MapPushpin();
            pushpin12.Location = (new GeoPoint(14.59028, 120.97806));
            pushpin12.Information = "You are here at Mapua Institute of Technology";
            pushpin12.Text = "YOU ARE HERE";
          //  pushpin12.TraceDepth = 0;
            pushpin12.State = MapPushpinState.Normal;
            Helpers.Add(pushpin12);
        }

        private void SantolanSelect(object sender, RoutedEventArgs e)
        {
            MapPushpin pushpin13 = new MapPushpin();
            pushpin13.Location = (new GeoPoint(14.6221, 121.0859));
            pushpin13.Information = "You are here at Santolan LRT Station";
            pushpin13.Text = "YOU ARE HERE";
          //  pushpin13.TraceDepth = 0;
            pushpin13.State = MapPushpinState.Normal;
            Helpers.Add(pushpin13);

        }

        private void QuezonSelect(object sender, RoutedEventArgs e)
        {
            MapPushpin pushpin14 = new MapPushpin();
            pushpin14.Location = (new GeoPoint(14.651105, 121.049277));
            pushpin14.Information = "You are here at Quezon Memorial Circle";
            pushpin14.Text = "YOU ARE HERE";
           // pushpin14.TraceDepth = 0;
            pushpin14.State = MapPushpinState.Normal;
            Helpers.Add(pushpin14);
        }

      

        private void PinaglabananSelect(object sender, RoutedEventArgs e)
        {
            MapPushpin pushpin15 = new MapPushpin();
            pushpin15.Location = (new GeoPoint(14.604771, 121.031181));
            pushpin15.Information = "You are here at Pinaglabanan Shrine";
            pushpin15.Text = "YOU ARE HERE";
           // pushpin15.TraceDepth = 0;
            pushpin15.State = MapPushpinState.Normal;
            Helpers.Add(pushpin15);
        }

        private void MadisonSelect(object sender, RoutedEventArgs e)
        {
            MapPushpin pushpin16 = new MapPushpin();
            pushpin16.Location = (new GeoPoint(14.572733, 121.050224));
            pushpin16.Information = "You are here at Madison Square Garden Hotel";
            pushpin16.Text = "YOU ARE HERE";
           // pushpin16.TraceDepth = 0;
            pushpin16.State = MapPushpinState.Normal;
            Helpers.Add(pushpin16);
        }

        private void RizalSelect(object sender, RoutedEventArgs e)
        {
            MapPushpin pushpin18 = new MapPushpin();
            pushpin18.Location = (new GeoPoint(14.582390, 120.978320));
            pushpin18.Information = "You are here at Rizal Park";
            pushpin18.Text = "YOU ARE HERE";
           // pushpin18.TraceDepth = 0;
            pushpin18.State = MapPushpinState.Normal;
            Helpers.Add(pushpin18);
        }

        private void RobinsonsSelect(object sender, RoutedEventArgs e)
        {
            MapPushpin pushpin17 = new MapPushpin();
            pushpin17.Location = (new GeoPoint(14.735840, 121.056039));
            pushpin17.Information = "You are here at Robinsons Novaliches";
            pushpin17.Text = "YOU ARE HERE";
          //  pushpin17.TraceDepth = 0;
            pushpin17.State = MapPushpinState.Normal;
            Helpers.Add(pushpin17);
        }


        private void MonicaSelect(object sender, RoutedEventArgs e)
        {
            MapPushpin pushpin19 = new MapPushpin();
            pushpin19.Location = (new GeoPoint(14.476241, 120.994761));
            pushpin19.Information = "You are here at Sta. Monica Church";
            pushpin19.Text = "YOU ARE HERE";
           // pushpin19.TraceDepth = 0;
            pushpin19.State = MapPushpinState.Normal;
            Helpers.Add(pushpin19);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Compute = new Compute();
            Compute.ShowDialog();
        }

     

     
     

      

        

        




       

    

     

    }
}
