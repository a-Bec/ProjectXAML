using System.Configuration;
using System.Dynamic;

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