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
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Windows.Form;
using MP_Variant1;
using BL;

namespace MP_Variant1
{
    /// <summary>
    /// Interaction logic for SimpleLogin_WpfApp.xaml
    /// </summary>
    public partial class SimpleLogin_WpfApp : Window
    {
        public SimpleLogin_WpfApp()
        {
            InitializeComponent();
        }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                string userName;
                userName =
                     .GetName(txtBoxUserName.Text, txtBoxPassword.Text);


                if (userName == "")
                {
                    lblMessage.Content = "Invalid Login";
                }
                else
                {
                    lblMessage.Content = "Welcome " + userName;

                    var BingMap = new Maps();
                    BingMap.ShowDialog();

                }


            }

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                this.Close();
            }

            private void Button_Click_2(object sender, RoutedEventArgs e)
            {
                var Register = new Register();
                Register.ShowDialog();
            }

            private void txtBoxUserName_TextChanged(object sender, TextChangedEventArgs e)
            {

            }
        }

     
    }