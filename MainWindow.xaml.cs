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
using System.Xml.Linq;
//using WpfLibrary1;

namespace Lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PlayList PL = new PlayList();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void ButtonAddSong_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["Author_res"] = "";
            App.Current.Resources["Title_res"] = "";
            new AddSong_Window().ShowDialog();
            if (App.Current.Resources["Author_res"].ToString() != ""  ||
                App.Current.Resources["Title_res"].ToString()!= "")
            {
                string author = App.Current.Resources["Author_res"].ToString();
                string title = App.Current.Resources["Title_res"].ToString();
                Song songToAdd = new Song(author, title);
                if(PL.AddSong(songToAdd))
                {
                    PlayListSongs.Items.Add(songToAdd);
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Song is already in playlist!");
                }

            }
        }
        private void ButtonDeleteSong_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["Author_res"] = "";
            App.Current.Resources["Title_res"] = "";
            new DeleteSong().ShowDialog();
            if (App.Current.Resources["Author_res"].ToString() != "" ||
                App.Current.Resources["Title_res"].ToString() != "")
            {
                string author = App.Current.Resources["Author_res"].ToString();
                string title = App.Current.Resources["Title_res"].ToString();
                Song songToDelete = new Song(author, title);
                if (PL.DeleteSong(songToDelete))
                {
                    PlayListSongs.Items.Clear();
                    foreach (Song song in PL.Songs)
                    {
                        PlayListSongs.Items.Add(song);
                    }
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Song was not found in playlist!");
                }

            }
        }
        private void ButtonSaveToXML_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["XML_Name"] = "";
            new SaveToXML().ShowDialog();
            string filename = App.Current.Resources["XML_Name"].ToString();
            if (filename != "") 
            {
                PL.ToXML(filename);
                MessageBox.Show("Success!");
            }
            
        }
        private void ButtonSaveToJSON_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["JSON_Name"] = "";
            new SaveToJSON().ShowDialog();
            string filename = App.Current.Resources["JSON_Name"].ToString();
            if (filename != "")
            {
                PL.ToJSON(filename);
                MessageBox.Show("Success!");
            }
        }
        private void ButtoOpenXML_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["XML_Name"] = "";
            new OpenXML().ShowDialog();
            string filename = App.Current.Resources["XML_Name"].ToString();
            if (filename == "") { return; }
            if (PL.FromXML(filename))
            {
                PlayListSongs.Items.Clear();
                foreach (Song song in PL.Songs)
                {
                    PlayListSongs.Items.Add(song);
                }
                MessageBox.Show("Playlist has been downloaded");
            }
            else
            {
                MessageBox.Show("XML-file was not found");
            }
        }

        private void ButtonOpenJSON_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["JSON_Name"] = "";
            new OpenJSON().ShowDialog();
            string filename = App.Current.Resources["JSON_Name"].ToString();
            if (filename == "") { return; }
            if (PL.FromJSON(filename))
            {
                PlayListSongs.Items.Clear();
                foreach (Song song in PL.Songs)
                {
                    PlayListSongs.Items.Add(song);
                }
                MessageBox.Show("Playlist has been downloaded");
            }
            else
            {
                MessageBox.Show("JSON-file was not found");
            }
        }
        private void ButtonSaveNewPlayList_Click(object sender, RoutedEventArgs e)
        {
            new NewFileConfirm().ShowDialog();
            if (App.Current.Resources["NPL"].ToString() == "1")
            {
                PlayListSongs.Items.Clear();
                PL.Clear();
                MessageBox.Show("New playlist created");
                App.Current.Resources["NPL"] = "0";
            }
        }
    }
}
