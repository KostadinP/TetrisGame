using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private Game game;
        public static int MaxTime = 1200;
        public static int CutTime = 100;
        BestPlayersForm bpf;
        Player bestPlayer;

        public Form1()
        {
            InitializeComponent();
            game = new Game(15, 10,timer1);
            this.DoubleBuffered = true;
            timer1.Interval = MaxTime;
            bpf = new BestPlayersForm();
            bestPlayer = bpf.bp.getBestPlayer();
            bestScoreLbl.Text = bestPlayer.Points.ToString();
        }


        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            game.draw(e.Graphics);
            pnlNextForm.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.moveDown();
            if (game.HasNewPoints)
            {
                ScoreLbl.Text = game.player.Points.ToString();
                LevelLbl.Text = game.player.Level.ToString();
                RowsLbl.Text = game.player.Rows.ToString();
                if (game.player.NewLevel)
                {
                    timer1.Interval -= CutTime;
                    game.sound.LevelUpSound();
                    game.player.NewLevel = false;
                }
                if (game.player.Points > bestPlayer.Points) {
                    bestScoreLbl.Text = game.player.Points.ToString();
                }
                game.HasNewPoints = false;
            }
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
            bpf = new BestPlayersForm();
            bestPlayer = bpf.bp.getBestPlayer();
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
