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
        public int Points { get; set; }
        public DateTime Date { get; set; }

        public Player(String name, int points)
        {
            Name = name;
            Points = points;
            Date = DateTime.Now;
        }
    }
}
