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
    public partial class  GestionAdherent : UserControl
    {
        private static GestionAdherent _instance;

        public static GestionAdherent Instance
        {
        get
            {
                if (_instance == null)
                    _instance = new GestionAdherent();
                return _instance;
           
            }
        }
        public GestionAdherent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Adherent_Load(object sender, EventArgs e)
        {
            //Récupération de tous les adhérents et affichage dans une listView qui a pour nom listViewAdherent
            AdherentDB adhDB = new AdherentDB();
            List<ArrowFRApp.Adherent> lesAdherents = adhDB.GetAllAdherent();
            foreach (var item in lesAdherents)
            {

                ListViewItem listItem = new ListViewItem(item.GetNom());
                listItem.SubItems.Add(item.GetPrenom());
                listItem.SubItems.Add(item.GetDateDeNaissance().ToShortDateString());
                listItem.SubItems.Add(item.GetVille());
                listItem.SubItems.Add(item.GetCodePostal());
                listItem.SubItems.Add(item.GetTypeAdherent().Libelle);

                listViewAdherent.Items.Add(listItem);
            }
            //Récupération de tous les types adhésions et affichage dans une listbox qui pour nom listBoxTypeAdhesion
            TypeAdhesionDB adhesionDB = new TypeAdhesionDB();
            List<ArrowFRApp.TypeAdhesion> lesTypesAdhesions = adhesionDB.GetAllTypeAdhesion();
            foreach (var item in lesTypesAdhesions)
            {
                CheckedListBox listBoxItem = new CheckedListBox();

                checkedListBoxAdhesion.Items.Add(item.Libelle);
                
            }
        }

        private void buttonCreerAdherent_Click(object sender, EventArgs e)
        {
            AdherentDB adhDB = new AdherentDB();
            TypeAdhesionDB typeDB = new TypeAdhesionDB();
            TypeAdhesion t = typeDB.GetTypeAdhesion(checkedListBoxAdhesion.SelectedIndex);
            Adherent a = new Adherent(textBoxNom.Text, textBoxPrenom.Text, dateTimePicker1.Value, textBoxVille.Text, textBoxCodePostale.Text, t);
            adhDB.Save(a);
            listViewAdherent.Refresh();
            MessageBox.Show("Adherent ajouté: "+ textBoxNom.Text +" "+textBoxPrenom.Text);
        }

       
    }
}
