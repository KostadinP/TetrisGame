using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public interface GameState
    {
        void moveDown();
        void moveLeft();
        void moveRight();
        void rotate();
        void draw(Graphics g);
    }
}
