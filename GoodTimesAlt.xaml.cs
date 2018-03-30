/*
Aidan McClung
March 29, 2018
GoodTimesAlt
Defines a valid input and converts it if invalid
*/
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

namespace u2AidanMGoodTimes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            int minutes = 0;
            int hour = 0;
            int.TryParse(txtInput.Text.Substring(txtInput.Text.Length - 2, 2), out minutes);
            int.TryParse(txtInput.Text.Substring(0, txtInput.Text.Length - 2), out hour);
            string minOut = "";
            string hourOut = "";
            bool done = false;
            //decide
            if (hour > 0 & hour < 23 & minutes < 60 & minutes >= 0)
            {
                hourOut = hour.ToString();
                minOut = minutes.ToString("00");
                done = true;
            }
            else if (hour == 0 & minutes < 60 & minutes >= 0)
            {

                hourOut = "";
                minOut = minutes.ToString("00");
                done = true;
            }
            else if (hour == 24 & minutes == 0)
            {
                hourOut = hour.ToString();
                minOut = minutes.ToString("00");
                done = true;
            }
            if (done == true)
            {
                lblOutput.Content = hourOut + minOut;
            }
            else if (done == false)
            {
                lblOutput.Content = "Invalid input.";
            }
        }
    }
}
