using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class LForm:TetrisForm
    {
        public LForm(int MAXX, int MAXY) : base(MAXX, MAXY) {
            chooseType();
        }

        private void typeOne()
        {

            SquareList.Add(new Square(4, 1));
            SquareList.Add(new Square(4, 0));
            SquareList.Add(new Square(5, 0));
            SquareList.Add(new Square(6, 0));

            this.WestField = 4;
            this.EastField = 6;
            this.SouthField = 1;
            this.Type = 1;
        }

        private void typeTwo()
        {

            SquareList.Add(new Square(4, 0));
            SquareList.Add(new Square(5, 0));
            SquareList.Add(new Square(5, 1));
            SquareList.Add(new Square(5, 2));

            this.WestField = 4;
            this.EastField = 5;
            this.SouthField = 2;
            this.Type = 3;
        }


        private void typeThree()
        {

            SquareList.Add(new Square(4, 1));
            SquareList.Add(new Square(5, 1));
            SquareList.Add(new Square(6, 1));
            SquareList.Add(new Square(6, 0));

            this.WestField = 4;
            this.EastField = 6;
            this.SouthField = 1;
            this.Type = 3;
        }

        private void typeFour()
        {

            SquareList.Add(new Square(4, 0));
            SquareList.Add(new Square(4, 1));
            SquareList.Add(new Square(4, 2));
            SquareList.Add(new Square(5, 2));

            this.WestField = 4;
            this.EastField = 5;
            this.SouthField = 2;
            this.Type = 4;

        }

        private void chooseType()
        {
            Random r = new Random();
            int k = r.Next(1, 5);
            if (k == 1)
            {
                typeOne();
            }
            else if (k == 2)
            {
                typeTwo();
            }
            else if (k == 3)
            {
                typeThree();
            }
            else { typeFour(); }

        }

        public override void rotate(int[,] matrix)
        {
            if (Type == 1)
            {
                this.Rotation = changeToTypeTwo(matrix);
                if (this.Rotation)
                    this.Type = 2;
            }
            else if (Type == 2)
            {
                this.Rotation = changeToTypeThree(matrix);
                if (this.Rotation)
                    this.Type = 3;
            }
            else if (Type == 3)
            {
                this.Rotation = changeToTypeFour(matrix);
                if (this.Rotation)
                    this.Type = 4;
            }
            else if (Type == 4)
            {
                this.Rotation = changeToTypeOne(matrix);
                if (this.Rotation)
                    this.Type = 1;
            }
        }


        public bool changeToTypeOne(int[,] matrix)
        {
            List<Square> list = new List<Square>();

            list.Add(new Square(this.EastField, this.SouthField - 1));
            list.Add(new Square(this.WestField, this.SouthField-1));
            list.Add(new Square(this.WestField - 1, this.SouthField - 1));
            list.Add(new Square(this.WestField - 1, this.SouthField ));

            foreach (Square s in list)
            {
                try
                {
                    if (matrix[s.Y, s.X] == 1) return false;
                }
                catch (IndexOutOfRangeException e)
                {
                    return false;
                }
            }
            this.SquareList = list;
            this.WestField -= 1;
            return true;
        }

        public bool changeToTypeTwo(int[,] matrix)
        {
            List<Square> list = new List<Square>();

            list.Add(new Square(this.EastField-1, this.SouthField - 2));
            list.Add(new Square(this.EastField, this.SouthField -2));
            list.Add(new Square(this.EastField, this.SouthField-1));
            list.Add(new Square(this.EastField , this.SouthField));

            foreach (Square s in list)
            {
                try
                {
                    if (matrix[s.Y, s.X] == 1) return false;
                }
                catch (IndexOutOfRangeException e)
                {
                    return false;
                }
            }
            this.SquareList = list;
            this.WestField = this.EastField - 1;
            return true;
        }

        public bool changeToTypeThree(int[,] matrix)
        {
            List<Square> list = new List<Square>();

            list.Add(new Square(this.EastField, this.SouthField-1));
            list.Add(new Square(this.EastField, this.SouthField));
            list.Add(new Square(this.EastField - 1, this.SouthField));
            list.Add(new Square(this.EastField - 2, this.SouthField ));

            foreach (Square s in list)
            {
                try
                {
                    if (matrix[s.Y, s.X] == 1) return false;
                }
                catch (IndexOutOfRangeException e)
                {
                    return false;
                }
            }
            this.SquareList = list;
            this.WestField = this.EastField - 2;
            return true;
        }

        public bool changeToTypeFour(int[,] matrix)
        {
            List<Square> list = new List<Square>();

            list.Add(new Square(this.EastField-1, this.SouthField - 2));
            list.Add(new Square(this.EastField - 1, this.SouthField - 1));
            list.Add(new Square(this.EastField - 1, this.SouthField ));
            list.Add(new Square(this.EastField , this.SouthField));

            foreach (Square s in list)
            {
                try
                {
                    if (matrix[s.Y, s.X] == 1) return false;
                }
                catch (IndexOutOfRangeException e)
                {
                    return false;
                }
            }
            this.SquareList = list;
            this.WestField = this.EastField - 1;
            return true;
        }

    }
}
