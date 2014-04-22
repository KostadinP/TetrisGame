﻿using System;
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
            game.addNewForm();
            timer1.Enabled = true;
            timer1.Start();
        }


        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

            List<TetrisForm> tetrisFormsList = game.getListToDraw();

            foreach(TetrisForm t in tetrisFormsList){
                List<Square> list = t.SquareList;
                
                foreach (Square s in list)
                {
                    e.Graphics.FillRectangle(t.Color, s.rectangle);
                }
            
            }
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
                game.activeForm.rotate();
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
