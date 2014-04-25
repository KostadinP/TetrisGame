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

            SquareList.Add(new Square(5, 0));
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

        public override void rotate(int[,] matrix)
        {
            if (this.Type == 1)
            {
                this.Rotation = changeToTypeTwo(matrix);
                if (this.Rotation)
                        this.Type = 2;
            }
            else if (this.Type == 2) {
                this.Rotation = changeToTypeOne(matrix);
                if (this.Rotation) 
                    this.Type = 1;
            }
        }
     

        private bool changeToTypeTwo(int [,]matrix) {
            List<Square> list = new List<Square>();

            list.Add(new Square(this.EastField-1, this.SouthField));
            list.Add(new Square(this.EastField - 1, this.SouthField + 1));
            list.Add(new Square(this.EastField - 1, this.SouthField + 2));
            list.Add(new Square(this.EastField - 1, this.SouthField + 3));

            foreach (Square s in list)
            {
                try
                {
                    if (matrix[s.Y, s.X] == 1) return false;
                }
                catch (IndexOutOfRangeException e) {
                    return false;
                }
            }
            this.SquareList = list;
            this.EastField -= 1;
            this.WestField = this.EastField;
            this.SouthField += 3;
            return true;
        }

        private bool changeToTypeOne(int[,] matrix) {
            List<Square> list = new List<Square>();

            list.Add(new Square(this.WestField +1, this.SouthField-3));
            list.Add(new Square(this.WestField , this.SouthField -3));
            list.Add(new Square(this.WestField -1, this.SouthField -3));
            list.Add(new Square(this.WestField - 2, this.SouthField -3));

            foreach (Square s in list)
            {
                try
                {
                    if (matrix[s.Y, s.X] == 1) return false;
                }
                catch(IndexOutOfRangeException e){
                    return false;
                }
            }
            this.SquareList = list;
            this.WestField -= 1;
            this.EastField += 1;
            this.SouthField -= 3;
            return true;
        }
    }
}
