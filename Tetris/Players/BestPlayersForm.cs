using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class BestPlayersForm : Form
    {
        BestPlayers bp;
        public BestPlayersForm()
        {
            InitializeComponent();
            bp = new BestPlayers();
            Deserialize();
            bp.orderList();
            foreach (Player p in bp.bestPlayers)
            {
                ListViewItem lv = new ListViewItem(p.Name);
                lv.SubItems.Add(p.Points.ToString());
                lv.SubItems.Add(p.Date.ToShortDateString());
                listView1.Items.Add(lv);
            }
        }

        public BestPlayersForm(Player player)
        {
            InitializeComponent();
            bp = new BestPlayers();
            Deserialize();
            bp.bestPlayers.Add(player);
            bp.orderList();
            foreach (Player p in bp.bestPlayers)
            {
                ListViewItem lv = new ListViewItem(p.Name);
                lv.SubItems.Add(p.Points.ToString());
                lv.SubItems.Add(p.Date.ToShortDateString());
                listView1.Items.Add(lv);
            }
        }

        public void Serialize()
        {
            string dataFile = AppDomain.CurrentDomain.BaseDirectory + @"\DataFile.dat";
            FileStream fs = new FileStream(@"../../DataFile.dat", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, bp);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public void Deserialize()
        {
            string dataFile = AppDomain.CurrentDomain.BaseDirectory + @"\DataFile.dat";
            FileStream fs = new FileStream(@"../../DataFile.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                bp = (BestPlayers)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        private void BestPlayersForm_Load(object sender, EventArgs e)
        {

        }

        private void BestPlayersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialize();
        }
    }
}
