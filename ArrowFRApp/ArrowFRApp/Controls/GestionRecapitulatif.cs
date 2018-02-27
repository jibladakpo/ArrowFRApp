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
    public partial class GestionRecapitulatif : UserControl
    {

        private static GestionRecapitulatif _instance;

        public static GestionRecapitulatif Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GestionRecapitulatif();
                return _instance;

            }
        }
        public GestionRecapitulatif()
        {
            InitializeComponent();
        }

        private void GestionRecapitulatif_Load(object sender, EventArgs e)
        {
            AdherentDB adhDB = new AdherentDB();
            labelRecapitulatif.Text = "Récapitulatif: " + DateTime.Now.ToShortDateString();
            labelNombreAdherent.Text = "Nombre total d'adhérent: " + adhDB.NbAdherent();
            labelMtTotalAdhesion.Text = "Montant total des adhésions: " + Convert.ToInt32(adhDB.MontantAdhesion()) + "€";
            TypeAdhesionDB adhesionDB = new TypeAdhesionDB();
            List<ArrowFRApp.TypeAdhesion> lesTypesAdhesions = adhesionDB.GetAllTypeAdhesion();
            
            foreach (var item in lesTypesAdhesions)
            {

                ListViewItem listItem = new ListViewItem(item.Libelle);
                listItem.SubItems.Add(Convert.ToString(adhesionDB.NbAdhesionParType(item.Libelle)));
                listItem.SubItems.Add(item.Tarif.ToString());
                listItem.SubItems.Add(Convert.ToString(adhesionDB.MontantAdhesionParType(item.Libelle)));
                listViewAdhesionType.Items.Add(listItem);

            }
            
        }

        
    }
}
