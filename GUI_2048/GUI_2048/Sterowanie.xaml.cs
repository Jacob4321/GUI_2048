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

namespace GUI_2048
{
    /// <summary>
    /// Interaction logic for Sterowanie.xaml
    /// </summary>
    public partial class Sterowanie : Window
    {
        public Sterowanie()
        {
            InitializeComponent();
        }

        private void wyjscie(object sender, RoutedEventArgs e)
        {
            MainWindow wyjscie = new MainWindow();
            wyjscie.Show();
            this.Close();
        }
    }
}
