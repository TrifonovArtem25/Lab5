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

namespace Lab5
{
    /// <summary>
    /// Interaction logic for SaveToXML.xaml
    /// </summary>
    public partial class SaveToXML : Window
    {
        public SaveToXML()
        {
            InitializeComponent();
        }

        private void ButtonSaveToXML_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FileName.Text) && FileName.Text.EndsWith(".xml")  &&  FileName.Text!=".xml")
            {
                App.Current.Resources["XML_Name"] = FileName.Text;
                FileName.Clear();
                Close();
            }
            else
            {
                new Error().ShowDialog();
                //MessageBox.Show("Invalid name!");
                App.Current.Resources["XML_Name"] = "";
            }
            
            //NavigationService.GetNavigationService(this).Navigate(new Uri("/MainWindow.xaml",UriKind.RelativeOrAbsolute));
            FileName.Clear();
        }
    }
}
