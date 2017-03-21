using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowFRApp
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelAccueil.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelAccueil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelGestion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGestionAdherent_Click(object sender, EventArgs e)
        {
            if (!panelAccueil.Controls.Contains(GestionAdherent.Instance))
            {
               panelAccueil.Controls.Add(GestionAdherent.Instance);
                GestionAdherent.Instance.Dock = DockStyle.Fill;
                GestionAdherent.Instance.BringToFront();
            }
            else
                GestionAdherent.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panelAccueil.Controls.Contains(GestionTypeAdhesion.Instance))
            {
                panelAccueil.Controls.Add(GestionTypeAdhesion.Instance);
                GestionTypeAdhesion.Instance.Dock = DockStyle.Fill;
                GestionTypeAdhesion.Instance.BringToFront();
            }
            else
                GestionTypeAdhesion.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
