using ArrowFRApp.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArrowFRApp.Controls
{
    public partial class GestionAccueil : UserControl
    {
         private static GestionAccueil _instance;

        public static GestionAccueil Instance
        {
        get
            {
                if (_instance == null)
                    _instance = new GestionAccueil();
                return _instance;
           
            }
        }
        public Accueil Accueil;

        public GestionAccueil()
        {
            InitializeComponent();
        }

        
       
        //affichage gestion Adherent
        private void buttonGestionAdherent_Click(object sender, EventArgs e)
        {
            if (!panelGestion.Controls.Contains(GestionAdherent.Instance))
            {
                panelGestion.Controls.Add(GestionAdherent.Instance);
                GestionAdherent.Instance.Dock = DockStyle.Fill;
                GestionAdherent.Instance.BringToFront();
                buttonDeconnexion.BringToFront();
            }
            else
                GestionAdherent.Instance.BringToFront();
            buttonDeconnexion.BringToFront();
        }
        //affichage gestion typeAdhesion
        private void buttonGestionTypeAdhesion_Click_1(object sender, EventArgs e)
        {
            if (!panelGestion.Controls.Contains(GestionTypeAdhesion.Instance))
            {
                panelGestion.Controls.Add(GestionTypeAdhesion.Instance);
                GestionTypeAdhesion.Instance.Dock = DockStyle.Fill;
                GestionTypeAdhesion.Instance.BringToFront();
                buttonDeconnexion.BringToFront();
            }
            else
                GestionTypeAdhesion.Instance.BringToFront();
            buttonDeconnexion.BringToFront();
        }

        private void buttonRecapitulatif_Click(object sender, EventArgs e)
        {
            if (!panelGestion.Controls.Contains(GestionRecapitulatif.Instance))
            {
                panelGestion.Controls.Add(GestionRecapitulatif.Instance);
                GestionRecapitulatif.Instance.Dock = DockStyle.Fill;
                GestionRecapitulatif.Instance.BringToFront();
                buttonDeconnexion.BringToFront();
            }
            else
                GestionRecapitulatif.Instance.BringToFront();
            buttonDeconnexion.BringToFront();
        }

        
        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vous déconnecter ?";
            string titre = "Déconnexion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titre, buttons);

            if (result == DialogResult.Yes)

            {
                Accueil.panelA.Visible = false;
            }
            else
            {


            }



           
            

            
            
            
            
        }
    }
        
    }


