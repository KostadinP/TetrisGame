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

        public override void rotate()
        {
            if (this.Type == 1) {
                changeToTypeTwo();
                this.Type = 2;
            }
            else if (this.Type == 2) {
                changeToTypeOne();
                this.Type = 1;
            }
        }


        private void changeToTypeOne() {
            List<Square> list = new List<Square>();

            foreach (Square s in SquareList) {
                list.Add(new Square(this.WestField, this.SouthField));
                list.Add(new Square(this.WestField+1, this.SouthField));
                list.Add(new Square(this.WestField+1, this.SouthField-1));
                list.Add(new Square(this.EastField, this.SouthField-1));
            }
            this.SquareList = list;
        }

        private void changeToTypeTwo() {
            List<Square> list = new List<Square>();
            foreach (Square s in SquareList)
            {
                list.Add(new Square(this.WestField, this.SouthField-1));
                list.Add(new Square(this.WestField + 1, this.SouthField-1));
                list.Add(new Square(this.WestField + 1, this.SouthField ));
                list.Add(new Square(this.EastField, this.SouthField ));
            }
            this.SquareList = list;
        }

        private void choseType() {
            Random r = new Random();
            int k = r.Next(2);
            if (k == 0)
            {
                typeOne();
            }
            else
            {
                typeTwo();
            }  
        }


    }
}
