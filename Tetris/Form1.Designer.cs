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
            this.btnScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(116, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(253, 378);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlNextForm
            // 
            this.pnlNextForm.BackColor = System.Drawing.Color.White;
            this.pnlNextForm.Location = new System.Drawing.Point(12, 85);
            this.pnlNextForm.Name = "pnlNextForm";
            this.pnlNextForm.Size = new System.Drawing.Size(98, 100);
            this.pnlNextForm.TabIndex = 1;
            this.pnlNextForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNextForm_Paint);
            // 
            // btnScores
            // 
            this.btnScores.Location = new System.Drawing.Point(12, 364);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(98, 23);
            this.btnScores.TabIndex = 2;
            this.btnScores.Text = "Best results";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 399);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.pnlNextForm);
            this.Controls.Add(this.mainPanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Тетрис";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlNextForm;
        private System.Windows.Forms.Button btnScores;



    }
}

