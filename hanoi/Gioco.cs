using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hanoi
{
    public partial class Gioco : Form
    {
        public Gioco()
        {
            InitializeComponent();
        }

        List<Panel> dischi1 = new List<Panel>();
        List<Panel> dischi2 = new List<Panel>();
        List<Panel> dischi3 = new List<Panel>();

        Color[] colori = new Color[] { Color.Orange, Color.Yellow, Color.Green, Color.LightBlue, Color.Blue, Color.Purple, Color.Red };

        private void Gioco_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Disegna()
        {
            pnl_uno.Controls.Clear();
            pnl_due.Controls.Clear();
            pnl_tre.Controls.Clear();

            foreach (Panel disco in dischi1) { pnl_uno.Controls.Add(disco); }
            foreach (Panel disco in dischi2) { pnl_due.Controls.Add(disco); }
            foreach (Panel disco in dischi3) { pnl_tre.Controls.Add(disco); }
        }

        private void Sposta(List<Panel> inizio, List<Panel> fine)
        {
            Panel temp = inizio[inizio.Count - 1];
            inizio.RemoveAt(inizio.Count - 1);
            temp.Location = new Point(temp.Location.X, pnl_uno.Size.Height - 16 - 16 * (fine.Count+1));
            fine.Add(temp);
        }

        private void btn_gioca_Click(object sender, EventArgs e)
        {
            for(int i=0;i<nmr_dischi.Value;i++)
            {
                Panel nuovo = new Panel();
                nuovo.BackColor = colori[i];
                nuovo.Size = new Size(180 - i * 20, 16);
                nuovo.Location = new Point(pnl_uno.Size.Width / 2 - nuovo.Size.Width/2, pnl_uno.Size.Height-16- 16 * (i + 1));
                dischi1.Add(nuovo);
            }
            Sposta(dischi1, dischi2);
            Sposta(dischi1, dischi3);
            Sposta(dischi2, dischi3);
            Disegna();
        }
    }
}
