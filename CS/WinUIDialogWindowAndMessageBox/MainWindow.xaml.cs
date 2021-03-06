﻿using DevExpress.Xpf.Core;
using DevExpress.Xpf.WindowsUI;
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

namespace WinUIDialogWindowAndMessageBox {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            WinUIDialogWindow dialog = new WinUIDialogWindow("Test", MessageBoxButton.OKCancel);
            dialog.Content = new TestUserControl();
            dialog.ShowDialogWindow();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            WinUIMessageBox.Show("WinUIMessageBox", "Test", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }
    }
}
