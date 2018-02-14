using ArrowFRApp.Controls;
using System;
using System.Collections.Generic;
using ArrowFRApp.Classes;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArrowFRApp.DataAccessLayer;
using MySql.Data.MySqlClient;

namespace ArrowFRApp
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panelAccueil.Visible = true;
            string connectionString = Initialisation.InitialiserConnexion();
            MySqlConnection sqlcon = new MySqlConnection(connectionString);
            string query = "Select * From Utilisateur Where login = '" + textLogin.Text.Trim() + "' and mdp = '" + textMdp.Text.Trim() + "'"; 
            MySqlDataAdapter sda =  new MySqlDataAdapter(query, sqlcon);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);


            if (dt1.Rows.Count == 1)
            {
                panelAccueil.Controls.Add(GestionAccueil.Instance);
                GestionAccueil.Instance.Dock = DockStyle.Fill;
                GestionAccueil.Instance.BringToFront();
            }
            else
                panelAccueil.Visible = false;
            MessageBox.Show("Vérifier votre login et mot de passe");
            

        }

        /* private void panelAccueil_Paint(object sender, PaintEventArgs e)
         {

         } */

        /* private void panelGestion_Paint(object sender, PaintEventArgs e)
         {

         } */
    }
}
