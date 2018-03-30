/*
 * AidanMcClung
 * March 30, 2018
 * u2AidanMGoodTimes
 * Converts eastern time toi the other time zones in Canada
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
            //gets minute and hour seperatly
            int minute = 0;
            int.TryParse(txtInput.Text.Substring(txtInput.Text.Length - 2, 2), out minute);
            int hour = 0;
            int.TryParse(txtInput.Text.Substring(0, txtInput.Text.Length - 2), out hour);
            hour = hour * 100;

            //changes the times
            int pacifiTime = hour - 300;
            if  (pacifiTime < 0)
            {
                pacifiTime = pacifiTime + 2400;
            }
            int mountainTime = hour - 200;
            if (mountainTime < 0)
            {
                mountainTime = mountainTime + 2400;
            }
            int centralTime = hour - 100;
            if (centralTime < 0)
            {
                centralTime = centralTime + 2400;
            }
            int easternTime = hour;
            int atlantictime = hour + 100;
            int newfoundlandTime = hour + 130;
            
            createLabel("Ottawa", easternTime, minute);
            createLabel("Victoria", pacifiTime, minute);
            createLabel("Edmonton", mountainTime, minute);
            createLabel("Winnipeg", centralTime, minute);
            createLabel("Toronto", easternTime, minute);
            createLabel("Halifax", atlantictime, minute);
            createLabel("St. John's", newfoundlandTime, minute);
        }

        private void createLabel(string tz, int h, int m)
        {
            Label myLabel = new Label();
            myLabel.Content = (h + m).ToString("00") + " in " + tz;
            myStackPanel.Children.Add(myLabel);
        }
    }
}
