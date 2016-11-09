using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml;

namespace Rybocompleks.GUI
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [Serializable]
        private class DataSensors
        {
            public string Name { get; set; }
            public int Value { get; set; }
            public DataSensors(string Name, int Value)
            {
                this.Name = Name;
                this.Value = Value;
            }
            public DataSensors()
            {
                this.Name = null;
                this.Value = 0;
            }
        }
        List<DataSensors> sensors = new List<DataSensors>();
        public MainWindow()
        {
            InitializeComponent();
            XmlDocument doc = new XmlDocument();
            doc.Load("Sensors.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int value = Int32.Parse(node.Attributes[1].Value);
                sensors.Add(new DataSensors(name,value));
            }
        }

        private void FileExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SensorTable_Loaded(object sender, RoutedEventArgs e)
        {
            SensorTable.ItemsSource = sensors;
        }      

        private void MenuOpenGP_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuRun_Click(object sender, RoutedEventArgs e)
        {
        }

        private void MenuAbout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
