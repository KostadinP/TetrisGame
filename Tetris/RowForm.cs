using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class RowForm:TetrisForm
    {
        public RowForm(int MAXX, int MAXY) : base(MAXX, MAXY) {
            chooseType();
        }

        private void typeOne() {

            SquareList.Add(new Square(4, 0));
            SquareList.Add(new Square(5, 0));
            SquareList.Add(new Square(6, 0));
            SquareList.Add(new Square(7, 0));

            this.WestField = 4;
            this.EastField = 7;
            this.SouthField = 0;
            this.Type = 1;
        }

        private void typeTwo() {

            SquareList.Add(new Square(5, 1));
            SquareList.Add(new Square(5, 1));
            SquareList.Add(new Square(5, 2));
            SquareList.Add(new Square(5, 3));

            this.WestField = 5;
            this.EastField = 5;
            this.SouthField = 3;
            this.Type = 2;
        }

        private void chooseType()
        {

            Random r = new Random();
            int k = r.Next(2);
            if (k == 0)
            {
                typeOne();
            }
            else if (k == 1) {
                typeTwo();
            }
        }
    }
}
