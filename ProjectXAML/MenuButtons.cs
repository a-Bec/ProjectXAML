using System.Windows;
using System.Windows.Media;
using System.Windows.Forms;

namespace ProjectXAML
{
    internal class MenuButtons
    {
        public void Start()
        {
            try
            {
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                int screenWidth = Screen.PrimaryScreen.Bounds.Width;

                Player player = new Player();
                player.setName();
                player.setColor();
                string name = player.getName();
                int score = player.getScore();
                player.setPosition( screenHeight, screenWidth);
            }
            catch
            {

            }
        }

        public void Load()
        {
            try
            {

            }
            catch
            {

            }
        }

        public void Close()
        {
            Application.Current.Shutdown();
        }
    }
}