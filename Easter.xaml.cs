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
    /// Interaction logic for Easter.xaml
    /// </summary>
    public partial class Easter : Window
    {
        public Easter()
        {
            InitializeComponent();
        }
        private void ButtonContinue_Click(object sender, RoutedEventArgs e)
        {
            if (PW.Text == "368923")
            {
                new Surprise().ShowDialog();
            }
            else
            {
                new Error().ShowDialog();
            }
            Close();
        }
    }
}
