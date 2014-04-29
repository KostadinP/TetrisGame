using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Game
    {
        public List<TetrisForm> tetrisForms;
        public TetrisForm activeForm;
        private int MAXX;
        private int MAXY;
        private int[,] matrix;

        public Game(int maxx, int maxy) {
            tetrisForms = new List<TetrisForm>();
            MAXX = maxx;
            MAXY = maxy;
            matrix = new int[maxx,maxy];
            for (int i = 0; i < maxx; i++) {
                for (int j = 0; j < maxy; j++) {
                    matrix[i, j] = 0;
                }
            }
        }

        public void addNewForm() {
            activeForm = getRandomForm();
            tetrisForms.Add(activeForm);
        }

        private TetrisForm getRandomForm() {
            Random r = new Random();
            int k = r.Next(3);

            if (k == 0) {
                return new RowForm(MAXX, MAXY);
            }
            else if (k == 1) {
                return new SquareForm(MAXX, MAXY);
  
            }
            else if (k == 2)
            {
                return new ZForm(MAXX, MAXY);
            }
            return null;

        }

        public void moveDown()
        {
            List<Coordinate> coordinateList = new List<Coordinate>();
            bool move = activeForm.tryMoveDown(coordinateList);
            if (move)
            {              
                if (checkMoving(coordinateList))
                    activeForm.moveDown();
                else
                {
                    addCoordinateToMatrix(returnBackCoordinates(coordinateList));
                    addNewForm();
                }
            }
            else
            {
                addCoordinateToMatrix(coordinateList);
                addNewForm();
            }
        }

        private List<Coordinate> returnBackCoordinates(List<Coordinate> list) {
            List<Coordinate> result = new List<Coordinate>();

            for (int i = 0; i < list.Count; i++) {
                result.Add(new Coordinate(list.ElementAt(i).X,list.ElementAt(i).Y-1));   
            }
            return result;
        }

        private void addCoordinateToMatrix(List<Coordinate> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int x = list.ElementAt(i).Y;
                int y = list.ElementAt(i).X;
                matrix[x, y] = 1;
            }
        }

        public void moveLeft()
        {
            List<Coordinate> coordinateList = new List<Coordinate>();
            bool move = activeForm.tryMoveLeft(coordinateList);

            if (move)
            {
                if (checkMoving(coordinateList))
                    activeForm.moveLeft();
            }
        }
        

        public void moveRight()
        {
            List<Coordinate> coordinateList = new List<Coordinate>();
            bool move = activeForm.tryMoveRight(coordinateList);

            if (move)
            {
                if (checkMoving(coordinateList))
                    activeForm.moveRight();
            }
        }

        private bool checkMoving(List<Coordinate> coordinateList) {
            int x;
            int y;
            for (int i = 0; i < coordinateList.Count; i++)
            {
                x = coordinateList.ElementAt(i).Y;
                y = coordinateList.ElementAt(i).X;
                int k = matrix[x, y];
                if (k == 1) return false;
            }
            return true;
        }

        public void draw(Graphics g)
        {
            foreach (TetrisForm t in tetrisForms)
            {
                t.draw(g);
            }
        }



        public void rotate() {
            activeForm.rotate(matrix);
        }

        



    
    }
}
