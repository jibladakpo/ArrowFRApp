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

                listBoxTypeAdhesion.Items.Add(item.idTypeAdhesion + item.Libelle);
                
            }
        }

        private void buttonCreerAdherent_Click(object sender, EventArgs e)
        {
            AdherentDB adhDB = new AdherentDB();
            TypeAdhesionDB typeDB = new TypeAdhesionDB();
            var index = listBoxTypeAdhesion.SelectedIndex;
            TypeAdhesion t = typeDB.GetTypeAdhesion(index);
            Adherent a = new Adherent(textBoxNom.Text, textBoxPrenom.Text, dateTimePicker1.Value, textBoxVille.Text, textBoxCodePostale.Text, t);
            adhDB.Save(a);
            listViewAdherent.Refresh();
            MessageBox.Show("Adherent ajouté: "+ textBoxNom.Text +" "+textBoxPrenom.Text);
        }

        private void buttonModifierAdherent_Click(object sender, EventArgs e)
        {
            AdherentDB adhDB = new AdherentDB();
            TypeAdhesionDB typeDB = new TypeAdhesionDB();
            var index = listBoxTypeAdhesion.SelectedIndex;
            TypeAdhesion t = typeDB.GetTypeAdhesion(index);
            Adherent a = new Adherent(textBoxNom.Text, textBoxPrenom.Text, dateTimePicker1.Value, textBoxVille.Text, textBoxCodePostale.Text, t);
            adhDB.Save(a);
            listViewAdherent.Refresh();
            MessageBox.Show("Infos modifiées sur: " + textBoxNom.Text + " " + textBoxPrenom.Text);
        }

        private void buttonSupprimerAdherent_Click(object sender, EventArgs e)
        {
            AdherentDB adhDB = new AdherentDB();
            
            if (listViewAdherent.FullRowSelect == true)
            {
               // adhDB.Delete();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBoxVille.Clear();
            textBoxCodePostale.Clear();
            

           
        } 

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listViewAdherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAdherent.SelectedItems.Count > 0)
            {
                textBoxNom.Text = listViewAdherent.SelectedItems[0].Text;
                textBoxPrenom.Text = listViewAdherent.SelectedItems[0].SubItems[1].Text;
                dateTimePicker1.Text = listViewAdherent.SelectedItems[0].SubItems[2].Text;
                textBoxVille.Text = listViewAdherent.SelectedItems[0].SubItems[3].Text;
                textBoxCodePostale.Text = listViewAdherent.SelectedItems[0].SubItems[4].Text;
                listBoxTypeAdhesion.Text = listViewAdherent.SelectedItems[0].SubItems[5].Text;

            }
          
        }

        

       
    }
}
