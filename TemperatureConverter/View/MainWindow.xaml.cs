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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            double i = double.Parse(textBox.Text);
            i = i - 32;
            i = i * 0.5556;
            MessageBox.Show(this, i.ToString(), "celcus");
        }

        private void ConvertToFahr(object sender, RoutedEventArgs e)
        {
            double i = double.Parse(textBox.Text);
            i = i / 0.5556;
            i = i + 32;
            MessageBox.Show(this, i.ToString(), "fahur");
        }

    }
}
