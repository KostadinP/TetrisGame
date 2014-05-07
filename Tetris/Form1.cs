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
            game = new Game(15, 10,timer1);
            this.DoubleBuffered = true;
        }


        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            game.draw(e.Graphics);
            pnlNextForm.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.moveDown();
            mainPanel.Invalidate();
        }

        private void pnlNextForm_Paint(object sender, PaintEventArgs e)
        {
            if (game.nextForm != null)
            {
                List<Rectangle> lstRt = new List<Rectangle>();

                foreach (Square sq in game.nextForm.SquareList)
                {
                    int x = game.nextForm.WestField;
                    int y = game.nextForm.SouthField;
                    Rectangle r = new Rectangle(5 + (sq.X - x) * 25, 5 + (sq.Y) * 25, 20, 20);
                    lstRt.Add(r);
                }
                e.Graphics.FillRectangles(Brushes.Black, lstRt.ToArray());
            }
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            BestPlayersForm bpf = new BestPlayersForm();
            bpf.ShowDialog();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData==Keys.Down)
            {
                game.moveDown();
                mainPanel.Invalidate();
                return true;
            }
            else if (keyData==Keys.Left)
            {
                game.moveLeft();
                mainPanel.Invalidate();
                return true;
            }
            else if (keyData==Keys.Right)
            {
                game.moveRight();
                mainPanel.Invalidate();
                return true;
            }
            else if (keyData==Keys.Up)
            {
                game.rotate();
                mainPanel.Invalidate();
                return true;
            }
            else if (keyData==Keys.P)
            {
                game.Pause();
                mainPanel.Invalidate();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            game.newGame();
        }
    }
}
