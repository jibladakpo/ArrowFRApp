using ArrowFRApp.Controls;
using System;
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
             if (!panelAccueil.Controls.Contains(GestionAccueil.Instance))
            {
                panelAccueil.Controls.Add(GestionAccueil.Instance);
                GestionAccueil.Instance.Dock = DockStyle.Fill;
                GestionAccueil.Instance.BringToFront();
            }
            else
                GestionAccueil.Instance.BringToFront();
        
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

       
    }
}
