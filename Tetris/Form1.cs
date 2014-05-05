using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game(15, 10);
            timer1.Enabled = true;
            timer1.Start();
        }


        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            game.draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.Equals(Keys.Down)) {
                game.moveDown();
                mainPanel.Invalidate();
            }
            else if (e.KeyCode.Equals(Keys.Left)) {
                game.moveLeft();
                mainPanel.Invalidate();
            }
            else if (e.KeyCode.Equals(Keys.Right)) {
                game.moveRight();
                mainPanel.Invalidate();
            }
            else if (e.KeyCode.Equals(Keys.Up)) {
                game.rotate();
                mainPanel.Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.moveDown();
            mainPanel.Invalidate();
        }

        private void pnlNextForm_Paint(object sender, PaintEventArgs e)
        {
            List<Rectangle> lstRt = new List<Rectangle>();
            foreach (Square sq in game.nextForm.SquareList)
            {
                Rectangle r = new Rectangle(sq.rectangle.Left/25, sq.rectangle.Top/25, 25, 25);
                lstRt.Add(r);
            }
            e.Graphics.FillRectangles(Brushes.Black, lstRt.ToArray());
        }
    }
}
