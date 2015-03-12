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

namespace MP_Variant1
{
    /// <summary>
    /// Interaction logic for Compute.xaml
    /// </summary>
    public partial class Compute : Window
    {
        public Compute()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LocationComboBox.Text == "Mapua Institute of Technology")
            {
                if (DestinationComboBox.Text == "SM City North Edsa")
                {
                    System.Windows.MessageBox.Show("Distance: 8.6km \n Estimated Time of Travel: 1.2 hours  ");
                }

                else if (DestinationComboBox.Text == "SM City Sta. Mesa")
                {
                    System.Windows.MessageBox.Show("Distance: 4.2km \n Estimated Time of Travel: 40 minutes");
                }

                else if (DestinationComboBox.Text == "SM Megamall")
                {
                    System.Windows.MessageBox.Show("Distance: 8.06km \nEstimated Time of Travel: 1 hour");
                }
                else if (DestinationComboBox.Text == "SM City Fairview")
                {
                    System.Windows.MessageBox.Show("Distance: 16.12km \nEstimated Time of Travel: 2 hours");
                }
                else if (DestinationComboBox.Text == "SM Mall of Asia")
                {
                    System.Windows.MessageBox.Show("Distance: 5km \n Estimated Time of Travel: 40 minutes");
                }
                else if (DestinationComboBox.Text == "SM City Manila")
                {
                    System.Windows.MessageBox.Show("Distance: 0.47km \nEstimate Time of Travel: 15 minutes");
                }
                else if (DestinationComboBox.Text == "SM City Sucat")
                {
                    System.Windows.MessageBox.Show("Distance: 11.05km \n Estimated Time of Travel: 1.5 hours");
                }
                else if (DestinationComboBox.Text == "SM City Bicutan")
                {
                    System.Windows.MessageBox.Show("Distance: 11.66km \n Estimated Time of Travel: 1.6 hours");
                }
                else if (DestinationComboBox.Text == "SM City San Lazaro")
                {
                    System.Windows.MessageBox.Show("Distance: 3.16km \nEstimated Time of Travel: 35 minutes");
                }
              
            }

            else if (LocationComboBox.Text == "Santolan LRT Station")
            {
                if (DestinationComboBox.Text == "SM City North Edsa")
                {
                    System.Windows.MessageBox.Show("Distance: 7.21km\n Estimated Time of Travel: 1.2 hours  ");
                }

                else if (DestinationComboBox.Text == "SM City Sta. Mesa")
                {
                    System.Windows.MessageBox.Show("Distance: 7.23km \n Estimated Time of Travel: 1 hour");
                }

                else if (DestinationComboBox.Text == "SM Megamall")
                {
                    System.Windows.MessageBox.Show("Distance: 5 km \nEstimated Time of Travel: 40 minutes");
                }
                else if (DestinationComboBox.Text == "SM City Fairview")
                {
                    System.Windows.MessageBox.Show("Distance: 11.4km \n Estimated Time of Travel: 1.8 hours");
                }
                else if (DestinationComboBox.Text == "SM Mall of Asia")
                {
                    System.Windows.MessageBox.Show("Distance: 13.6km \n Estimated Time of Travel: 1.9 hours ");
                }
                else if (DestinationComboBox.Text == "SM City Manila")
                {
                    System.Windows.MessageBox.Show("Distance: 11.4km \nEstimated Time of Travel: 1.5 hours");
                }
                else if (DestinationComboBox.Text == "SM City Sucat")
                {
                    System.Windows.MessageBox.Show("Distance: 17.2km \n Estimated Time of Travel: 2.3 hours");
                }
                else if (DestinationComboBox.Text == "SM City Bicutan")
                {
                    System.Windows.MessageBox.Show("Distance: 13.93 km \nEstimated Time of Travel:1.7 hours");
                }
                else if (DestinationComboBox.Text == "SM City San Lazaro")
                {
                    System.Windows.MessageBox.Show("Distance: 10km \n Estimated Time of Travel: 1.4 hours");
                }

            }

            else if (LocationComboBox.Text == "Quezon Memorial Center")
            {
                if (DestinationComboBox.Text == "SM City North Edsa")
                {
                    System.Windows.MessageBox.Show("Distance: 2.24km \n Estimated Time of Travel: 30 minutes ");
                }

                else if (DestinationComboBox.Text == "SM City Sta. Mesa")
                {
                    System.Windows.MessageBox.Show("Distance: 5.83km \nTime of Travel: 50 minutes ");
                }

                else if (DestinationComboBox.Text == "SM Megamall")
                {
                    System.Windows.MessageBox.Show("Distance: 7.07km \nEstimated Time of Travel: 1 hour");
                }
                else if (DestinationComboBox.Text == "SM City Fairview")
                {
                    System.Windows.MessageBox.Show("Distance: 8.06km \n Estimated Time of Travel: 1.2 hours");
                }
                else if (DestinationComboBox.Text == "SM Mall of Asia")
                {
                    System.Windows.MessageBox.Show("Distance: 13.04km \nEstimated Time of Travel:1.7 hours");
                }
                else if (DestinationComboBox.Text == "SM City Manila")
                {
                    System.Windows.MessageBox.Show("Distance: 9.226km \nEstimated Time of Travel:1 hour");
                }
                else if (DestinationComboBox.Text == "SM City Sucat")
                {
                    System.Windows.MessageBox.Show("Distance: 9.07km \n Estimated Time of Travel: 1 hour");
                }
                else if (DestinationComboBox.Text == "SM City Bicutan")
                {
                    System.Windows.MessageBox.Show("Distance: 16.4km \nEstimated Time of Travel: 2 hours");
                }
                else if (DestinationComboBox.Text == "SM City San Lazaro")
                {
                    System.Windows.MessageBox.Show("Distance: 6.71km \n Estimated Time of Travel: 40 minutes");
                }

            }

            else if (LocationComboBox.Text == "Pinaglabanan Shrine")
            {
                if (DestinationComboBox.Text == "SM City North Edsa")
                {
                    System.Windows.MessageBox.Show("Distance: 6.71km \n Estimated Time of Travel: 40 minutes");
                }

                else if (DestinationComboBox.Text == "SM City Sta. Mesa")
                {
                    System.Windows.MessageBox.Show("Distance: 1km\nTime of Travel: 10 minutes");
                }

                else if (DestinationComboBox.Text == "SM Megamall")
                {
                    System.Windows.MessageBox.Show("Distance: 3.61km \n Estimated Time of Travel: 30 minutes");
                }
                else if (DestinationComboBox.Text == "SM City Fairview")
                {
                    System.Windows.MessageBox.Show("Distance: 13.346km \n Estimated Time of Travel:1.7 hours");
                }
                else if (DestinationComboBox.Text == "SM Mall of Asia")
                {
                    System.Windows.MessageBox.Show("Distance: 7.81km \nEstimated Time of Travel: 1 hour");
                }
                else if (DestinationComboBox.Text == "SM City Manila")
                {
                    System.Windows.MessageBox.Show("Distance: 5.1km \nEstimated Time of Travel: 30 minutes");
                }
                else if (DestinationComboBox.Text == "SM City Sucat")
                {
                    System.Windows.MessageBox.Show("Distance: 12.65km \nEstimated Time of Travel: 1.5 hours");
                }
                else if (DestinationComboBox.Text == "SM City Bicutan")
                {
                    System.Windows.MessageBox.Show("Distance: 11.05km \nEstimated Time of Travel:1.2 hours");
                }
                else if (DestinationComboBox.Text == "SM City San Lazaro")
                {
                    System.Windows.MessageBox.Show("Distance: 4.47km \nEstimated Time of Travel:40 minutes ");
                }

            }

            else if (LocationComboBox.Text == "Rizal Park")
            {
                if (DestinationComboBox.Text == "SM City North Edsa")
                {
                    System.Windows.MessageBox.Show("Distance: 9.43km \n Estimated Time of Travel: 1 hour");
                }

                else if (DestinationComboBox.Text == "SM City Sta. Mesa")
                {
                    System.Windows.MessageBox.Show("Distance: 4.47km \nEstimated Time of Travel: 40 minutes");
                }

                else if (DestinationComboBox.Text == "SM Megamall")
                {
                    System.Windows.MessageBox.Show("Distance: 8.46km \nEstimated Time of Travel: 1 hour");
                }
                else if (DestinationComboBox.Text == "SM City Fairview")
                {
                    System.Windows.MessageBox.Show("Distance: 17km \nEstimated Time of Travel: 2.3 hours");
                }
                else if (DestinationComboBox.Text == "SM Mall of Asia")
                {
                    System.Windows.MessageBox.Show("Distance: 5.25km \nTime of Travel:");
                }
                else if (DestinationComboBox.Text == "SM City Manila")
                {
                    System.Windows.MessageBox.Show("Distance: 3.61km \n Estimated Time of Travel: 30 minutes ");
                }
                else if (DestinationComboBox.Text == "SM City Sucat")
                {
                    System.Windows.MessageBox.Show("Distance: 10.05km \n Estimated Time of Travel: 1.2 hours");
                }
                else if (DestinationComboBox.Text == "SM City Bicutan")
                {
                    System.Windows.MessageBox.Show("Distance: 10.05km \nEstimated Time of Travel:1.3 hours");
                }
                else if (DestinationComboBox.Text == "SM City San Lazaro")
                {
                    System.Windows.MessageBox.Show("Distance: 4.03km \nEstimated Time of Travel: 40 minutes");
                }

            }

            else if (LocationComboBox.Text == "Robinsons Novaliches")
            {
                if (DestinationComboBox.Text == "SM City North Edsa")
                {
                    System.Windows.MessageBox.Show("Distance: 9.15km \nEstimated Time of Travel: 1.3 hours");
                }

                else if (DestinationComboBox.Text == "SM City Sta. Mesa")
                {
                    System.Windows.MessageBox.Show("Distance: 15.09km \nEstimated Time of Travel: 2 hours");
                }

                else if (DestinationComboBox.Text == "SM Megamall")
                {
                    System.Windows.MessageBox.Show("Distance: 16.76km \n Estimated Time of Travel:2 hours");
                }
                else if (DestinationComboBox.Text == "SM City Fairview")
                {
                    System.Windows.MessageBox.Show("Distance: 0.36km \nEstimated Time of Travel: 10 minutes");
                }
                else if (DestinationComboBox.Text == "SM Mall of Asia")
                {
                    System.Windows.MessageBox.Show("Distance: 23.59km \nEstimated Time of Travel: 2.5 hours");
                }
                else if (DestinationComboBox.Text == "SM City Manila")
                {
                    System.Windows.MessageBox.Show("Distance: 18.0km \nEstimated Time of Travel: 2 hours");
                }
                else if (DestinationComboBox.Text == "SM City Sucat")
                {
                    System.Windows.MessageBox.Show("Distance: 28.70km \nEstimated Time of Travel:2.6 hours");
                }
                else if (DestinationComboBox.Text == "SM City Bicutan")
                {
                    System.Windows.MessageBox.Show("Distance: 27.5km \nEstimated Time of Travel:2.5 hours");
                }
                else if (DestinationComboBox.Text == "SM City San Lazaro")
                {
                    System.Windows.MessageBox.Show("Distance: 15.06km \nEstimated Time of Travel:2 hours");
                }

            }

            else if (LocationComboBox.Text == "Sta. Monica Church")
            {
                if (DestinationComboBox.Text == "SM City North Edsa")
                {
                    System.Windows.MessageBox.Show("Distance: 20.37km \nEstimated Time of Travel: 2 hours");
                }

                else if (DestinationComboBox.Text == "SM City Sta. Mesa")
                {
                    System.Windows.MessageBox.Show("Distance: 14.41km \nEstimated Time of Travel:1.7 hours");
                }   

                else if (DestinationComboBox.Text == "SM Megamall")
                {
                    System.Windows.MessageBox.Show("Distance: 13.71km \nEstimated Time of Travel:1.5 hours");
                }
                else if (DestinationComboBox.Text == "SM City Fairview")
                {
                    System.Windows.MessageBox.Show("Distance: 29.3km \nEstimated Time of Travel:2.7 hours");
                }
                else if (DestinationComboBox.Text == "SM Mall of Asia")
                {
                    System.Windows.MessageBox.Show("Distance: 6.65km \nEstiamted Time of Travel: 40 minutes");
                }
                  
                else if (DestinationComboBox.Text == "SM City Manila")
                {
                    System.Windows.MessageBox.Show("Distance: 12.60km \n Estimated Time of Travel:1.2 hours");
                }
                else if (DestinationComboBox.Text == "SM City Sucat")
                {
                    System.Windows.MessageBox.Show("Distance: .93km \nEstimated Time of Travel: 20 minutes");
                }
                else if (DestinationComboBox.Text == "SM City Bicutan")
                {
                    System.Windows.MessageBox.Show("Distance: 5.38km \nEstimated Time of Travel:1.2 hours");
                }
                else if (DestinationComboBox.Text == "SM City San Lazaro")
                {
                    System.Windows.MessageBox.Show("Distance: 15.73km \nEstimated Time of Travel:2 hours");
                }

            }








        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
