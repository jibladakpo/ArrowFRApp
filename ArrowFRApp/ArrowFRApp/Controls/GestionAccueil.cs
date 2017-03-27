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
        public GestionAccueil()
        {
            InitializeComponent();
        }

        private void GestionAccueil_Load(object sender, EventArgs e)
        {
        }
            
      
       
        //affichage gestion Adherent
        private void buttonGestionAdherent_Click(object sender, EventArgs e)
        {
            if (!panelGestion.Controls.Contains(GestionAdherent.Instance))
            {
                panelGestion.Controls.Add(GestionAdherent.Instance);
                GestionAdherent.Instance.Dock = DockStyle.Fill;
                GestionAdherent.Instance.BringToFront();
            }
            else
                GestionAdherent.Instance.BringToFront();
        }
        //affichage gestion typeAdhesion
        private void buttonGestionTypeAdhesion_Click_1(object sender, EventArgs e)
        {
            if (!panelGestion.Controls.Contains(GestionTypeAdhesion.Instance))
            {
                panelGestion.Controls.Add(GestionTypeAdhesion.Instance);
                GestionTypeAdhesion.Instance.Dock = DockStyle.Fill;
                GestionTypeAdhesion.Instance.BringToFront();
            }
            else
                GestionTypeAdhesion.Instance.BringToFront();
        }

        private void buttonRecapitulatif_Click(object sender, EventArgs e)
        {
            if (!panelGestion.Controls.Contains(GestionRecapitulatif.Instance))
            {
                panelGestion.Controls.Add(GestionRecapitulatif.Instance);
                GestionRecapitulatif.Instance.Dock = DockStyle.Fill;
                GestionRecapitulatif.Instance.BringToFront();
            }
            else
                GestionRecapitulatif.Instance.BringToFront();
        }
    }
        
    }


