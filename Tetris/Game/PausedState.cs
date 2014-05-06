using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class PausedState : GameState
    {
        private Game game;

        public PausedState(Game g)
        {
            game = g;
        }
        public void moveDown()
        {
        }

        public void moveLeft()
        {
        }

        public void moveRight()
        {
        }

        public void draw(System.Drawing.Graphics g)
        {
            try
            {
                Image img = Properties.Resources.PauseImage;    
                foreach (TetrisForm t in game.tetrisForms)
                {
                    t.draw(g);
                }
                g.DrawImage(img, new Point(25, 100));
            }
            catch (Exception e)
            {
                Debug.WriteLine("Poraka: " +e.Message);
            }
        }


        public void rotate()
        {

        }
    }
}
