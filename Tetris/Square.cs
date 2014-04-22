using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Square
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Rectangle rectangle;
        public Square(int x, int y) {
            this.X = x;
            this.Y = y;
            rectangle = new Rectangle(5 + x * 25, 5 + y * 25, 20, 20);
        }

        public void moveLeft() {
            this.X -= 1;
            rectangle = new Rectangle(rectangle.X-25,rectangle.Y,20,20);
        }

        public void moveRight() {
            this.X += 1;
            rectangle = new Rectangle(rectangle.X + 25, rectangle.Y, 20, 20);
        }

        public void moveDown() {
            this.Y += 1;
            rectangle = new Rectangle(rectangle.X, rectangle.Y+25, 20, 20);
        }

        public static Rectangle moveSouth (Rectangle rect){
            return new Rectangle(rect.X + 15, rect.Y, rect.Width, rect.Height);
        }
    }
}
