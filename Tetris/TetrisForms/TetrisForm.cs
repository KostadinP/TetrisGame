﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class TetrisForm
    {
        public bool isActive { get; set; }
        public List<Square> SquareList;
        public int SouthField { get; set; }
        public int EastField { get; set; }
        public int WestField { get; set; }
        public Brush Color { get; set; }
        public int Type { get; set; }
        public int MAXX { get; set; }
        public int MAXY { get; set; }
        public bool Rotation { get; set; }
        public int SquareListCount { get { return SquareList.Count; } }

        public TetrisForm(int maxx, int maxy)
        {
            this.isActive = true;
            this.Rotation = true;
            this.MAXX = maxx;
            this.MAXY = maxy;
            pickColor();
            SquareList = new List<Square>();
        }

        private void pickColor()
        {
            Random r = new Random();
            int k = r.Next(5);
            if (k == 0) { this.Color = Brushes.Red; }
            else if (k == 1) { this.Color = Brushes.Blue; }
            else if (k == 2) { this.Color = Brushes.DeepPink; }
            else if (k == 3) { this.Color = Brushes.Green; }
            else if (k == 4) { this.Color = Brushes.Purple; }
        }

        public void draw(Graphics g)
        {
            foreach (Square s in SquareList)
            {
                s.draw(g, Color);
            }
        }

        public bool moveLeft()
        {
            if (WestField > 0)
            {
                foreach (Square s in SquareList)
                {
                    s.moveLeft();
                }
                WestField -= 1;
                EastField -= 1;
                return true;
            }
            return false;
        }

        public bool moveRight()
        {
            if (EastField < MAXY - 1)
            {
                foreach (Square s in SquareList)
                {
                    s.moveRight();
                }
                EastField += 1;
                WestField += 1;
                return true;
            }
            return false;
        }


        public bool tryMoveDown(List<Coordinate> tempList)
        {

            if (SouthField < MAXX - 1)
            {
                for (int i = 0; i < SquareList.Count; i++)
                {
                    Square s = SquareList.ElementAt(i);
                    tempList.Add(new Coordinate(s.X, s.Y + 1));
                }
                return true;
            }
            else
            {
                for (int i = 0; i < SquareList.Count; i++)
                {
                    Square s = SquareList.ElementAt(i);
                    tempList.Add(new Coordinate(s.X, s.Y));
                }
            }
            return false;
        }

        public bool tryMoveLeft(List<Coordinate> tempList)
        {

            if (WestField > 0)
            {
                for (int i = 0; i < SquareList.Count; i++)
                {
                    Square s = SquareList.ElementAt(i);
                    tempList.Add(new Coordinate(s.X - 1, s.Y));
                }
                return true;
            }
            else
            {
                for (int i = 0; i < SquareList.Count; i++)
                {
                    Square s = SquareList.ElementAt(i);
                    tempList.Add(new Coordinate(s.X, s.Y));
                }
            }
            return false;
        }

        public bool tryMoveRight(List<Coordinate> tempList)
        {

            if (EastField < MAXY - 1)
            {
                for (int i = 0; i < SquareList.Count; i++)
                {
                    Square s = SquareList.ElementAt(i);
                    tempList.Add(new Coordinate(s.X + 1, s.Y));
                }
                return true;
            }
            else
            {
                for (int i = 0; i < SquareList.Count; i++)
                {
                    Square s = SquareList.ElementAt(i);
                    tempList.Add(new Coordinate(s.X, s.Y));
                }
            }
            return false;
        }

        public void moveDown()
        {

            foreach (Square s in SquareList)
            {
                s.moveDown(1);
            }
            SouthField += 1;
        }

        public void moveDownSquares(int position, int spaces) {

            foreach (Square s in SquareList) {
                if (s.Y <= position) s.moveDown(spaces);
            }
        
        }

        public virtual void rotate(int[,] matrix) { }

        public void deleteSquares(List<int> rowList)
        {
            List<Square> temp = new List<Square>();
            for (int i = 0;i<rowList.Count;i++)
            {
                foreach (Square s in SquareList)
                {
                    if (s.Y == rowList[i])
                    {
                        temp.Add(s);
                    }
                }
            }

            foreach (Square s in temp) {
                SquareList.Remove(s);
            }
        }
    }

}
