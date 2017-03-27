using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowFRApp
{
    public partial class GestionTypeAdhesion : UserControl
    {
        private static GestionTypeAdhesion _instance;

        public static GestionTypeAdhesion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GestionTypeAdhesion();
                return _instance;

            }
        }
        public GestionTypeAdhesion()
        {
            InitializeComponent();
        }

        private void TypeAdhesion_Load(object sender, EventArgs e)
        {
            //Récupération de tous les adhérents et affichage dans une listView qui a pour nom listViewAdherents
            TypeAdhesionDB adhDB = new TypeAdhesionDB();
            List<ArrowFRApp.TypeAdhesion> lesTypesAdhesions = adhDB.GetAllTypeAdhesion();
            foreach (var item in lesTypesAdhesions)
            {

                ListViewItem listItem = new ListViewItem(item.Libelle);

                listItem.SubItems.Add(item.Tarif.ToString());
                
                

                listViewTypeAdhesion.Items.Add(listItem);
            }
        }

        private void buttonCreerTypeAdhesion_Click(object sender, EventArgs e)
        {
            TypeAdhesionDB typeadhDB = new TypeAdhesionDB();
            TypeAdhesionDB typeDB = new TypeAdhesionDB();
            TypeAdhesion ta = new TypeAdhesion(0,textBoxLibelle.Text, Convert.ToInt32(textBoxTarif.Text));
            typeadhDB.Save(ta);
            listViewTypeAdhesion.Refresh();
            MessageBox.Show("Type Adhesion ajouté: " + textBoxLibelle.Text);
        }

        private void buttonModifierTypeAdhesion_Click(object sender, EventArgs e)
        {

        }

        private void buttonSupprimerTypeAdhesion_Click(object sender, EventArgs e)
        {

        }
    }
}
