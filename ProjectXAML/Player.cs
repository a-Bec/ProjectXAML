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
        int playerPositionX;
        int playerPositionY;
        int speed = 10;
        int playerSize = 10;

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
        public void setPosition( int screenHight, int screenWidth )
        {
            int x = (screenWidth - playerSize) / 2;
            int y = (screenHight - playerSize) / 2;
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