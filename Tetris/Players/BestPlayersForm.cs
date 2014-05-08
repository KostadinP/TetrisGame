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
    public partial class BestPlayersForm : Form
    {
        BestPlayers bp;
        public BestPlayersForm(Player p)
        {
            InitializeComponent();
            bp = new BestPlayers();
            ListViewItem lv = new ListViewItem(p.Name);
            lv.SubItems.Add(p.Points.ToString());
            lv.SubItems.Add(p.Date.ToShortDateString());
            listView1.Items.Add(lv);
        }
    }
}
