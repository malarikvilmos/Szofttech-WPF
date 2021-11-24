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
using Szofttech_WPF.Network;
using Szofttech_WPF.Utils;
using Szofttech_WPF.View;

namespace Szofttech_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Settings settings = Settings.getInstance();
            Console.WriteLine(Settings.port);
            Server server = new Server(25564);

            MenuGUI menu = new MenuGUI();
            windowGrid.Children.Add(menu);
            Grid.SetRow(menu, 1);
        }
        private void drawWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
