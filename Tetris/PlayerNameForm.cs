using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class PlayerNameForm : Form
    {
        public String Ime { get; set; }
        public PlayerNameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ime = tbName.Text;
            DialogResult = DialogResult.OK;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Enter your name!");
            }
            else
                errorProvider1.SetError(tbName, "");
        }
    }
}
