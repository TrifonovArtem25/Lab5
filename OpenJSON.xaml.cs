﻿using System;
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
    /// Interaction logic for OpenJSON.xaml
    /// </summary>
    public partial class OpenJSON : Window
    {
        public OpenJSON()
        {
            InitializeComponent();
        }

        private void ButtonOpenJSON_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FileName.Text) && FileName.Text.EndsWith(".json") && FileName.Text != ".json")
            {
                App.Current.Resources["JSON_Name"] = FileName.Text;
                FileName.Clear();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid name!");
                App.Current.Resources["JSON_Name"] = "";
            }
            FileName.Clear();
        }
    }
}
