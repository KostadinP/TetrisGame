using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class SquareForm:TetrisForm
    {
        public SquareForm(int MAXX, int MAXY) : base(MAXX, MAXY) { typeOne(); }

        private void typeOne()
        {

            SquareList.Add(new Square(4, 0));
            SquareList.Add(new Square(5, 0));
            SquareList.Add(new Square(4, 1));
            SquareList.Add(new Square(5, 1));

            this.WestField = 4;
            this.EastField = 5;
            this.SouthField = 1;
            this.Type = 1;
        }
    }
}
