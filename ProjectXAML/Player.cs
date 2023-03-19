using System;
using System.Configuration;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace ProjectXAML
{
    internal class Player
    {
        string name = "player";
        string color;
        int score = 0;



        public string setName()
        {
            return name;
        }

        public int setScore( int score )
        {
            return score++;
        }
        public string setColor()
        {
            return color;
        }
        public void setPosition()
        {
            int playerSize = 10;
            int screenHigth = Screen.PrimaryScreen.Bounds.Height;
        }
        public string getName()
        {
            return name;
        }
        public int getScore()
        {
            return score;
        }

        public string getColor()
        {
            return color;
        }
        public void movePlayer()
        {

        }


    }
}