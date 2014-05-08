using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        public bool NewLevel { get; set; }
        private int rows;
        public int Rows 
        { get 
          { 
            return rows;
          } 
          set
            {
              rows = value;
              if (rows / 10 != 0) { 
                  int temp = rows / 10 + 1; 
                  if (temp > Level) {
                      NewLevel = true; Level = temp; 
                  } 
              }
          } 
        }

        public Player()
        {
            NewLevel = false;
            Points = 0;
            Level = 1;
            Rows = 0;

        }
    }
}
