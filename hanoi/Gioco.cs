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

        Color[] colori = new Color[] { Color.Orange, Color.Yellow, Color.Lime, Color.DeepSkyBlue, Color.Blue, Color.Purple, Color.Red };

        List<Panel>[] cosi;

        Panel[] sfondi;

        private void Gioco_Load(object sender, EventArgs e)
        {
            cosi = new List<Panel>[] { dischi1, dischi2, dischi3 };
            sfondi = new Panel[6] { panel1, panel2, panel3, panel4, panel5, panel6 };
            nmr_dischi_ValueChanged(null, EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AlgoritmoHanoi(int n, int inizio,int fine, int aux)
        {
            if (n == 1) { Sposta(cosi[inizio], cosi[fine]); return; }
            AlgoritmoHanoi(n - 1, inizio, aux, fine);
            Sposta(cosi[inizio], cosi[fine]);
            AlgoritmoHanoi(n - 1, aux, fine, inizio);
        }

        //private int DueAllaX(int x)
        //{
        //    if(x==0) return 0;
        //    return 2 * DueAllaX(x - 1);
        //}

        private int MosseMinime(int n)
        {
            if (n == 1) return 1;
            return ((int)Math.Pow(2,n-1) + MosseMinime(n-1));
        }

        private void Disegna()
        {
            
            pnl_uno.Controls.Clear(); pnl_uno.Controls.Add(sfondi[0]); pnl_uno.Controls.Add(sfondi[1]);
            pnl_due.Controls.Clear(); pnl_due.Controls.Add(sfondi[2]); pnl_due.Controls.Add(sfondi[3]);
            pnl_tre.Controls.Clear(); pnl_tre.Controls.Add(sfondi[4]); pnl_tre.Controls.Add(sfondi[5]);

            foreach (Panel disco in dischi1) { pnl_uno.Controls.Add(disco); disco.BringToFront(); }
            foreach (Panel disco in dischi2) { pnl_due.Controls.Add(disco); disco.BringToFront(); }
            foreach (Panel disco in dischi3) { pnl_tre.Controls.Add(disco); disco.BringToFront(); }
        }

        private void Reset()
        {
            dischi1.Clear(); dischi2.Clear(); dischi3.Clear();
            //pnl_uno.Controls.Clear(); pnl_due.Controls.Clear(); pnl_tre.Controls.Clear();
        }

        private async Task Sposta(List<Panel> inizio, List<Panel> fine)
        {
            Panel temp = inizio[inizio.Count - 1];
            inizio.RemoveAt(inizio.Count - 1);
            temp.Location = new Point(temp.Location.X, pnl_uno.Size.Height - 16 - 16 * (fine.Count+1));
            fine.Add(temp);
            Disegna();

            System.Threading.Thread.Sleep(1000);
        }

        

        private void btn_avvia_Click(object sender, EventArgs e)
        {
            btn_avvia.Enabled = false;
            AlgoritmoHanoi((int)nmr_dischi.Value, 0, 2, 1);
            
        }

        private void nmr_dischi_ValueChanged(object sender, EventArgs e)
        {
            btn_avvia.Enabled = true;
            Reset();
            lbl_minime.Text = $"Mosse minime: {MosseMinime((int)nmr_dischi.Value)}";

            for (int i = 0; i < nmr_dischi.Value; i++)
            {
                Panel nuovo = new Panel();
                nuovo.BackColor = colori[i];
                nuovo.Size = new Size(180 - i * 20, 16);
                nuovo.Location = new Point(pnl_uno.Size.Width / 2 - nuovo.Size.Width / 2, pnl_uno.Size.Height - 16 - 16 * (i + 1));
                dischi1.Add(nuovo);
            }
            Disegna();
        }
    }
}
