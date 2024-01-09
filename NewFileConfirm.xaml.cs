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
    /// Interaction logic for NewFileConfirm.xaml
    /// </summary>
    public partial class NewFileConfirm : Window
    {
        public NewFileConfirm()
        {
            InitializeComponent();
        }

        private void ButtonNewFile_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["NPL"] = "1";
            Close();
        }
    }
}
