using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Player
    {
        public String Name { get; set; }
        private int points;
        public int Points { get { return points; } set { points = value; if (points / 500 != 0) { int t = points / 500 + 1; if (t > Level) { NewLevel = true; Level = t; } } } }
        public DateTime Date { get; set; }
        public int Level { get; set; }
        public bool NewLevel { get; set; }

        public Player()
        {
            NewLevel = false;
            Points = 0;
            Level = 1;

        }
    }
}
