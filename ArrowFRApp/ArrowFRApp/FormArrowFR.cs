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
            if (!panelAccueil.Controls.Contains(Adherent.Instance))
            {
               panelAccueil.Controls.Add(Adherent.Instance);
                Adherent.Instance.Dock = DockStyle.Fill;
                Adherent.Instance.BringToFront();
            }
            else
                Adherent.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panelAccueil.Controls.Contains(TypeAdhesion.Instance))
            {
                panelAccueil.Controls.Add(TypeAdhesion.Instance);
                TypeAdhesion.Instance.Dock = DockStyle.Fill;
                TypeAdhesion.Instance.BringToFront();
            }
            else
                TypeAdhesion.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
