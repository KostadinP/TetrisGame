using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class CForm:TetrisForm
    {
        public CForm(int MAXX, int MAXY) : base(MAXX, MAXY) { choseType(); }
        
     private void choseType() {
            Random r = new Random();
            int k = r.Next(2);
            if (k == 0)
                typeOne();
            else
                typeTwo();
        }

     private void typeOne()
     {

         SquareList.Add(new Square(4, 0));
         SquareList.Add(new Square(5, 0));
         SquareList.Add(new Square(5, 1));
         SquareList.Add(new Square(6, 1));

         this.WestField = 4;
         this.EastField = 6;
         this.SouthField = 1;
         this.Type = 1;
     }

     private void typeTwo()
     {

         SquareList.Add(new Square(5, 0));
         SquareList.Add(new Square(5, 1));
         SquareList.Add(new Square(4, 1));
         SquareList.Add(new Square(4, 2));

         this.WestField = 4;
         this.EastField = 5;
         this.SouthField = 2;
         this.Type = 2;
     }

     public override void rotate(int[,] matrix)
     {
         if (this.Type == 1)
         {
             changeToTypeTwo(matrix);
             this.Type = 2;
         }
         else if (this.Type == 2)
         {
             changeToTypeOne(matrix);
             this.Type = 1;
         }
     }


     private bool changeToTypeOne(int[,] matrix)
     {
         List<Square> list = new List<Square>();

         list.Add(new Square(this.EastField, this.SouthField - 1));
         list.Add(new Square(this.WestField, this.SouthField - 1));
         list.Add(new Square(this.WestField, this.SouthField - 2));
         list.Add(new Square(this.WestField - 1, this.SouthField - 2));

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
         this.WestField -= 1;
         this.SouthField -= 1;
         this.SquareList = list;
         return true;
     }

     private bool changeToTypeTwo(int[,] matrix)
     {
         List<Square> list = new List<Square>();

         list.Add(new Square(this.EastField , this.SouthField - 1));
         list.Add(new Square(this.EastField , this.SouthField));
         list.Add(new Square(this.EastField - 1 , this.SouthField));
         list.Add(new Square(this.EastField - 1 , this.SouthField + 1));

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
         this.WestField += 1;
         this.SouthField += 1;
         this.SquareList = list;
         return true;
     }
    }
}
