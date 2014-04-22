using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class GForm:TetrisForm
    {
        public GForm(int MAXX, int MAXY) : base(MAXX, MAXY) {
            chooseType();
        }
 
        private void typeOne() {

            SquareList.Add(new Square(4, 0));
            SquareList.Add(new Square(5, 0));
            SquareList.Add(new Square(6, 0));
            SquareList.Add(new Square(0, 1));

            this.WestField = 4;
            this.EastField = 6;
            this.SouthField = 1;
            this.Type = 1;
        }

        private void typeTwo() {

            SquareList.Add(new Square(5, 0));
            SquareList.Add(new Square(5, 1));
            SquareList.Add(new Square(5, 2));
            SquareList.Add(new Square(4, 2));

            this.WestField = 4;
            this.EastField = 5;
            this.SouthField = 2;
            this.Type = 3;
        }


        private void typeThree() {

            SquareList.Add(new Square(4, 0));
            SquareList.Add(new Square(4, 1));
            SquareList.Add(new Square(5, 1));
            SquareList.Add(new Square(6, 1));

            this.WestField = 4;
            this.EastField = 6;
            this.SouthField = 1;
            this.Type = 3;
        }

        private void typeFour() {

            SquareList.Add(new Square(5, 0));
            SquareList.Add(new Square(4, 0));
            SquareList.Add(new Square(4, 1));
            SquareList.Add(new Square(4, 2));

            this.WestField = 4;
            this.EastField = 5;
            this.SouthField = 2;
            this.Type = 4;
        
        }

        private void chooseType() {
            Random r = new Random();
            int k = r.Next(1,5);
            if (k == 1) {
                typeOne();
            }
            else if (k == 2) {
                typeTwo();
            }
            else if (k == 3) {
                typeThree();
            }
            else { typeFour(); }
        
        }
        
    }
}
