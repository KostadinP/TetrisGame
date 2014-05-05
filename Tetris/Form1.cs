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
            Graphics g = pnlNextForm.CreateGraphics();
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
    }
}
