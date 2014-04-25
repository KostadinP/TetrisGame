using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class ZForm:TetrisForm
    {

        public ZForm(int MAXX, int MAXY) : base(MAXX, MAXY) { choseType(); }


        //тип на форма може да се најде во 2 различни изгледи
        // како буквата z или обратно

        private void typeOne() {

            SquareList.Add(new Square(4, 1));
            SquareList.Add(new Square(5, 0));
            SquareList.Add(new Square(5, 1));
            SquareList.Add(new Square(6, 0));

            this.WestField = 4;
            this.EastField = 6;
            this.SouthField = 1;
            this.Type = 1;
        }

        private void typeTwo() {

            SquareList.Add(new Square(4, 0));
            SquareList.Add(new Square(5, 0));
            SquareList.Add(new Square(5, 1));
            SquareList.Add(new Square(6, 1));

            this.WestField = 4;
            this.EastField = 6;
            this.SouthField = 1;
            this.Type = 2;
        }

        public override void rotate(int [,] matrix)
        {
            if (this.Type == 1) {
                changeToTypeTwo(matrix);
                this.Type = 2;
            }
            else if (this.Type == 2) {
                changeToTypeOne(matrix);
                this.Type = 1;
            }
        }


        private void changeToTypeOne(int [,]matrix) {
            List<Square> list = new List<Square>();

                list.Add(new Square(this.WestField, this.SouthField));
                list.Add(new Square(this.WestField+1, this.SouthField));
                list.Add(new Square(this.WestField+1, this.SouthField-1));
                list.Add(new Square(this.EastField, this.SouthField-1));
                
                foreach(Square s in list){
                    if (matrix[s.Y, s.X] == 1) return;
                }
                this.SquareList = list;
                this.WestField = WestField + 1; 
        }

        private void changeToTypeTwo(int [,] matrix) {
            List<Square> list = new List<Square>();

                list.Add(new Square(this.WestField, this.SouthField-1));
                list.Add(new Square(this.WestField + 1, this.SouthField-1));
                list.Add(new Square(this.WestField + 1, this.SouthField ));
                list.Add(new Square(this.EastField, this.SouthField ));

                foreach (Square s in list)
                {
                    if (matrix[s.Y, s.X] == 1) return;
                }
                this.SquareList = list;
        }

        private void choseType() {
            Random r = new Random();
            int k = r.Next(2);
            if (k == 0)
                typeOne();
            else
                typeTwo();
        }


    }
}
