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
    public partial class Inizio : Form
    {
        public Inizio()
        {
            InitializeComponent();
        }

        private void btn_gioca_Click(object sender, EventArgs e)
        {
            Gioco g = new Gioco();
            g.ShowDialog();
        }
    }
}
