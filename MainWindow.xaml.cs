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

namespace Rybocompleks.GUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private class DataSensors
        {
            public string Name { get; set; }
            public int Value { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void FileExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SensorTable_Loaded(object sender, RoutedEventArgs e)
        {
            List<DataSensors> sensors = new List<DataSensors>();
         /*   {
                new DataSensors(){Name="temperature",Value=15},
                new DataSensors(){Name="pH", Value=7},
                new DataSensors(){Name="oxygen",Value=15}
            };*/
            SensorTable.ItemsSource = sensors;
        }
    }
}
