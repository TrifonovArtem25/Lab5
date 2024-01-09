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

namespace Lab5
{
    /// <summary>
    /// Interaction logic for OpenXML.xaml
    /// </summary>
    public partial class OpenXML : Window
    {
        public OpenXML()
        {
            InitializeComponent();
        }

        private void ButtonOpenXML_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FileName.Text) && FileName.Text.EndsWith(".xml") && FileName.Text != ".xml")
            {
                App.Current.Resources["XML_Name"] = FileName.Text;
                FileName.Clear();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid name!");
                App.Current.Resources["XML_Name"] = "";
            }
            FileName.Clear();
        }
    }
}
