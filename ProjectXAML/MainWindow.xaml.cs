using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectXAML
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu= new MainMenu();
            MainFrame.Navigate(mainMenu);
        }

    }
}
