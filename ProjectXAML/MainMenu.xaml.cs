using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectXAML
{
    /// <summary>
    /// Interaktionslogik für MainMenu.xaml
    /// </summary>
    ///
    public partial class MainMenu : Page
    {
        MenuButtons menu = new MenuButtons();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NameBox nameBox= new NameBox();
                MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

                mainWindow.MainFrame.NavigationService.Navigate(nameBox);
/*
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                int score = player.getScore();
                player.setPosition(screenHeight, screenWidth); */
            }
            catch
            {

            }
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
