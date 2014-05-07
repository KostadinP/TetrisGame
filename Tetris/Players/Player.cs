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
        public int Level { get; set; }

        public Player()
        {
            Points = 0;
            Level = 1;
        }
    }
}
