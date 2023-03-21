using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectXAML
{
    public partial class MainWindow : Window
    {
        bool menuVisibility= true;
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

        private void changeVisibility( bool menuVisibility )
        {
            if( menuVisibility )
            {
            StartButton.Visibility = Visibility.Collapsed;
            LoadButton.Visibility = Visibility.Collapsed;
            ExitButton.Visibility = Visibility.Collapsed;
            menuVisibility= false;
            }
            else
            {
                StartButton.Visibility = Visibility.Visible;
                LoadButton.Visibility = Visibility.Visible;
                ExitButton.Visibility = Visibility.Visible;
            }
        }
    }
}
