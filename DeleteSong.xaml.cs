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
    /// Interaction logic for DeleteSong.xaml
    /// </summary>
    public partial class DeleteSong : Window
    {
        public DeleteSong()
        {
            InitializeComponent();
        }

        private void ButtonDeleteSong_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Author.Text) && !string.IsNullOrWhiteSpace(Title.Text))
            {
                App.Current.Resources["Author_res"] = Author.Text;
                App.Current.Resources["Title_res"] = Title.Text;
                Author.Clear();
                Title.Clear();
                Close();
            }
            else
            {
                MessageBox.Show("Error!");
                App.Current.Resources["Author_res"] = "";
                App.Current.Resources["Title_res"] = "";
            }
        }
    }
}
