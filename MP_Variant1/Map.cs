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
using System.IO;
using System.Net;
using DevExpress.Xpf.Map;
using System.Collections.ObjectModel;

namespace MP_Variant1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class NewBingMap : Window
    {
        #region #CalculateRoute
        int waypointIndex;
        List<RouteWaypoint> waypoints;
        ObservableCollection<MapItem> helpers;

        public ObservableCollection<MapItem> Helpers
        {
            get { return this.helpers; }
        }

        public NewBingMap()
        {
            InitializeComponent();
            DataContext = this;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            e.Handled = true;
            Helpers.Clear();
            waypoints.Clear();
            waypointIndex = 0;
            routeInformationLayer.ClearResults();
            geocodeInformationLayer.ClearResults();
        }
        

    }
}
