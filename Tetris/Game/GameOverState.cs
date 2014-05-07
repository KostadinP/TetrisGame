using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class GameOverState : GameState
    {
        private Game game;

        public GameOverState(Game g)
        {
            game = g;
            Sounds.GameOverSound();
        }

        public void moveDown()
        {
            return;
        }

        public void moveLeft()
        {
            return;
        }

        public void moveRight()
        {
            return;
        }

        public void rotate()
        {
            return;
        }

        public void draw(System.Drawing.Graphics g)
        {
            try
            {
                Image img = Properties.Resources.GameOver;
                foreach (TetrisForm t in game.tetrisForms)
                {
                    t.draw(g);
                }
                g.DrawImage(img, new Point(50, 100));
            }
            catch (Exception e)
            {
                Debug.WriteLine("Poraka: " + e.Message);
            }
        }
    }
}
