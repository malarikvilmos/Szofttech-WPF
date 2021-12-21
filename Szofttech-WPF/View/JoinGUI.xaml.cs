﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Szofttech_WPF.Interfaces;
using Szofttech_WPF.Utils;
using Szofttech_WPF.ViewModel;

namespace Szofttech_WPF.View
{
    /// <summary>
    /// Interaction logic for JoinGUI.xaml
    /// </summary>
    public partial class JoinGUI : UserControl, IExitableGUI
    {
        public JoinGUI()
        {
            InitializeComponent();
            DataContext = new JoinGameGUIViewModel();
        }

        public void CloseGUI()
        {
            this.Visibility = Visibility.Hidden;
            JoinGameGUIViewModel.SelectedServerAddress = null;
        }

        public bool ExitApplication()
        {
            return true;
        }
    }
}
