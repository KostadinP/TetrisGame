using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class ActiveState : GameState
    {
        Game game;

        public ActiveState(Game g)
        {
            game = g;
        }
        public void moveDown()
        {
            List<Coordinate> coordinateList = new List<Coordinate>();
            bool move = game.activeForm.tryMoveDown(coordinateList);
            if (move)
            {
                if (game.checkMoving(coordinateList))
                    game.activeForm.moveDown();
                else
                {
                    game.addCoordinateToMatrix(game.returnBackCoordinates(coordinateList));
                    game.RowComplete();
                    game.DeleteTetrisForm();
                    game.addNewForm();
                }
            }
            else
            {
                game.addCoordinateToMatrix(coordinateList);
                game.RowComplete();
                game.DeleteTetrisForm();
                game.addNewForm();
            }
        }

        public void moveLeft()
        {
            List<Coordinate> coordinateList = new List<Coordinate>();
            bool move = game.activeForm.tryMoveLeft(coordinateList);

            if (move)
            {
                if (game.checkMoving(coordinateList))
                    game.activeForm.moveLeft();
            }
        }

        public void moveRight()
        {
            List<Coordinate> coordinateList = new List<Coordinate>();
            bool move = game.activeForm.tryMoveRight(coordinateList);

            if (move)
            {
                if (game.checkMoving(coordinateList))
                    game.activeForm.moveRight();
            }
        }

        public void draw(System.Drawing.Graphics g)
        {
            foreach (TetrisForm t in game.tetrisForms)
            {
                t.draw(g);
            }
        }


        public void rotate()
        {
            game.activeForm.rotate(game.matrix);
        }
    }
}
