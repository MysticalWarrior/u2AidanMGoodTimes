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
            int originalTime;
            int.TryParse(txtInput.Text, out originalTime);
            if (originalTime > 2359)
            {
                originalTime -= 2400;
            }
            int pacifiTime = originalTime - 300;
            int mountainTime = originalTime - 200;
            int centralTime = originalTime - 100;
            int easternTime = originalTime - 0;
            int atlantictime = originalTime + 100;
            int newfoundlandTime = originalTime + 130;

            createLabel("Ottawa", originalTime);
            createLabel("Victoria", pacifiTime);
            createLabel("Edmonton", mountainTime);
            createLabel("Winnipeg", centralTime);
            createLabel("Toronto", easternTime);
            createLabel("Halifax", atlantictime);
            createLabel("St. John's", newfoundlandTime);
        }

        private void createLabel(string tz, int t)
        {
            Label myLabel = new Label();
            myLabel.Content = t + " in " + tz;
            myStackPanel.Children.Add(myLabel);
        }
    }
}
