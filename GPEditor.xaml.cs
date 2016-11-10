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
    /// Логика взаимодействия для GPEditor.xaml
    /// </summary>
    public partial class GPEditor : TabItem
    {
        public GPEditor()
        {
            List<GPNode> GP = new List<GPNode>();
            InitializeComponent();
            dataGrid.ItemsSource = GP;
        }
    }
}
