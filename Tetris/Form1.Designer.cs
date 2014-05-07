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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlNextForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LevelLbl = new System.Windows.Forms.Label();
            this.btnNewGame = new Tetris.TetrisButton();
            this.btnScores = new Tetris.TetrisButton();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(152, 15);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(295, 465);
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
            this.pnlNextForm.Location = new System.Drawing.Point(14, 15);
            this.pnlNextForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlNextForm.Name = "pnlNextForm";
            this.pnlNextForm.Size = new System.Drawing.Size(114, 123);
            this.pnlNextForm.TabIndex = 1;
            this.pnlNextForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNextForm_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Score";
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLbl.Location = new System.Drawing.Point(57, 186);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(20, 23);
            this.ScoreLbl.TabIndex = 5;
            this.ScoreLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Level";
            // 
            // LevelLbl
            // 
            this.LevelLbl.AutoSize = true;
            this.LevelLbl.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLbl.Location = new System.Drawing.Point(57, 284);
            this.LevelLbl.Name = "LevelLbl";
            this.LevelLbl.Size = new System.Drawing.Size(20, 23);
            this.LevelLbl.TabIndex = 7;
            this.LevelLbl.Text = "0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Black;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(2, 390);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnNewGame.MinimumSize = new System.Drawing.Size(117, 37);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewGame.Size = new System.Drawing.Size(140, 42);
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
            this.btnScores.Location = new System.Drawing.Point(2, 443);
            this.btnScores.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnScores.MinimumSize = new System.Drawing.Size(117, 37);
            this.btnScores.Name = "btnScores";
            this.btnScores.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScores.Size = new System.Drawing.Size(140, 37);
            this.btnScores.TabIndex = 2;
            this.btnScores.TabStop = false;
            this.btnScores.Text = "Best results";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 491);
            this.Controls.Add(this.LevelLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.pnlNextForm);
            this.Controls.Add(this.mainPanel);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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



    }
}

