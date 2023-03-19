using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectXAML
{
    public partial class MainWindow : Window
    {
        MenuButtons menu = new MenuButtons();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            menu.Start();
        }
        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            menu.Load();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            menu.Close();
        }
    }
}
