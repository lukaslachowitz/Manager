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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mitarbeiter_erstellen sw = new Mitarbeiter_erstellen();
            sw.Show();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mitarbeiter_bearbeiten sw = new Mitarbeiter_bearbeiten();
            sw.Show();
        }
    }
}
