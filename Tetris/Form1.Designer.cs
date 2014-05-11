namespace Tetris
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlNextForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LevelLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RowsLbl = new System.Windows.Forms.Label();
            this.bestScoreLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewGame = new Tetris.TetrisButton();
            this.btnScores = new Tetris.TetrisButton();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(130, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(253, 378);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlNextForm
            // 
            this.pnlNextForm.BackColor = System.Drawing.Color.White;
            this.pnlNextForm.Location = new System.Drawing.Point(12, 65);
            this.pnlNextForm.Name = "pnlNextForm";
            this.pnlNextForm.Size = new System.Drawing.Size(98, 100);
            this.pnlNextForm.TabIndex = 1;
            this.pnlNextForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNextForm_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Score";
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLbl.Location = new System.Drawing.Point(49, 190);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(20, 23);
            this.ScoreLbl.TabIndex = 5;
            this.ScoreLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Level";
            // 
            // LevelLbl
            // 
            this.LevelLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelLbl.AutoSize = true;
            this.LevelLbl.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLbl.Location = new System.Drawing.Point(49, 240);
            this.LevelLbl.Name = "LevelLbl";
            this.LevelLbl.Size = new System.Drawing.Size(20, 23);
            this.LevelLbl.TabIndex = 7;
            this.LevelLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rows";
            // 
            // RowsLbl
            // 
            this.RowsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RowsLbl.AutoSize = true;
            this.RowsLbl.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowsLbl.Location = new System.Drawing.Point(49, 290);
            this.RowsLbl.Name = "RowsLbl";
            this.RowsLbl.Size = new System.Drawing.Size(20, 23);
            this.RowsLbl.TabIndex = 9;
            this.RowsLbl.Text = "0";
            // 
            // bestScoreLbl
            // 
            this.bestScoreLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bestScoreLbl.AutoSize = true;
            this.bestScoreLbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bestScoreLbl.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestScoreLbl.Location = new System.Drawing.Point(49, 39);
            this.bestScoreLbl.Name = "bestScoreLbl";
            this.bestScoreLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bestScoreLbl.Size = new System.Drawing.Size(20, 23);
            this.bestScoreLbl.TabIndex = 11;
            this.bestScoreLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Best Score";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Black;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(2, 317);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnNewGame.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Padding = new System.Windows.Forms.Padding(3);
            this.btnNewGame.Size = new System.Drawing.Size(120, 34);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.TabStop = false;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.Black;
            this.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScores.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.ForeColor = System.Drawing.Color.White;
            this.btnScores.Location = new System.Drawing.Point(2, 360);
            this.btnScores.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnScores.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnScores.Name = "btnScores";
            this.btnScores.Padding = new System.Windows.Forms.Padding(3);
            this.btnScores.Size = new System.Drawing.Size(120, 30);
            this.btnScores.TabIndex = 2;
            this.btnScores.TabStop = false;
            this.btnScores.Text = "Best results";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 399);
            this.Controls.Add(this.bestScoreLbl);
            this.Controls.Add(this.RowsLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LevelLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.pnlNextForm);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Tetris Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlNextForm;
        private TetrisButton btnScores;
        private TetrisButton btnNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LevelLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RowsLbl;
        private System.Windows.Forms.Label bestScoreLbl;
        private System.Windows.Forms.Label label5;



    }
}

