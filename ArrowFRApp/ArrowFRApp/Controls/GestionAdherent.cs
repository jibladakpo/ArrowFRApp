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
                listItem.SubItems.Add(item.GetId().ToString());

                listViewAdherent.Items.Add(listItem);
            }
            //Récupération de tous les types adhésions et affichage dans une listbox qui a pour nom listBoxTypeAdhesion
            TypeAdhesionDB adhesionDB = new TypeAdhesionDB();
            List<ArrowFRApp.TypeAdhesion> lesTypesAdhesions = adhesionDB.GetAllTypeAdhesion();
            foreach (var item in lesTypesAdhesions)
            {
                CheckedListBox listBoxItem = new CheckedListBox();

                listBoxTypeAdhesion.Items.Add(item.Libelle);
                
            }
        }

        private void buttonCreerAdherent_Click(object sender, EventArgs e)
        {
            listViewAdherent.Refresh();
            AdherentDB adhDB = new AdherentDB();
            TypeAdhesionDB typeDB = new TypeAdhesionDB();
            var index = listBoxTypeAdhesion.SelectedIndex;
            TypeAdhesion t = typeDB.GetTypeAdhesion(index);
            Adherent a = new Adherent(textBoxNom.Text, textBoxPrenom.Text, dateTimePicker1.Value, textBoxVille.Text, textBoxCodePostale.Text, t);
            adhDB.Save(a);
            
            MessageBox.Show("Adherent ajouté: "+ textBoxNom.Text +" "+textBoxPrenom.Text);
            //Efface champs
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBoxVille.Clear();
            textBoxCodePostale.Clear();
            listBoxTypeAdhesion.ClearSelected();
            foreach (int i in listBoxTypeAdhesion.CheckedIndices)
            {
                listBoxTypeAdhesion.SetItemCheckState(i, CheckState.Unchecked);
            }
            //actualiser
            reload();
        }

        private void buttonModifierAdherent_Click(object sender, EventArgs e)
        {
            AdherentDB adhDB = new AdherentDB();
            AdherentDB adhesionDB = new AdherentDB();
            TypeAdhesionDB typeDB = new TypeAdhesionDB();
            int index = listBoxTypeAdhesion.SelectedIndex;
            TypeAdhesion t = typeDB.GetTypeAdhesion(index);
            Adherent a1 = adhDB.GetAdherent(Convert.ToInt32(listViewAdherent.SelectedItems[0].SubItems[6].Text));
            a1.SetNom(textBoxNom.Text);
            a1.SetPrenom(textBoxPrenom.Text);
            a1.SetDateNaissance(dateTimePicker1.Value);
            a1.SetVille(textBoxVille.Text);
            a1.SetCodePostal(textBoxCodePostale.Text);
            a1.SetTypeAdherent(t);

            adhDB.Save(a1);
            
            
            MessageBox.Show("Infos modifiées sur: " + textBoxNom.Text + " " + textBoxPrenom.Text);
            //Efface champs
            textBoxNom.Clear();
            textBoxPrenom.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBoxVille.Clear();
            textBoxCodePostale.Clear();
            listBoxTypeAdhesion.ClearSelected();
            foreach (int i in listBoxTypeAdhesion.CheckedIndices)
            {
                listBoxTypeAdhesion.SetItemCheckState(i, CheckState.Unchecked);
            }
            //actualiser
            reload();
        }

        private void buttonSupprimerAdherent_Click(object sender, EventArgs e)
        {
            if (listViewAdherent.SelectedItems.Count > 0)
            {
                // adhDB.Delete();
                AdherentDB adhDB = new AdherentDB();
                ListViewItem listItem = listViewAdherent.SelectedItems[0];
                int id = Convert.ToInt32(listViewAdherent.SelectedItems[0].SubItems[6].Text);
                adhDB.Delete(id);
                MessageBox.Show("Suprimer l'adhérent " + textBoxNom.Text + " " + textBoxPrenom.Text + " ?");
                //Efface champs
                textBoxNom.Clear();
                textBoxPrenom.Clear();
                dateTimePicker1.Value = DateTime.Now;
                textBoxVille.Clear();
                textBoxCodePostale.Clear();
                listBoxTypeAdhesion.ClearSelected();
                
                foreach (int i in listBoxTypeAdhesion.CheckedIndices)
                {
                    listBoxTypeAdhesion.SetItemCheckState(i, CheckState.Unchecked);
                }
                //actualiser
                reload();
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
        //Aficher les infos de l'adhérent dans les textbox
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

         private void reload()
        {
            listViewAdherent.Items.Clear();
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
                listItem.SubItems.Add(item.GetId().ToString());
                listViewAdherent.Items.Add(listItem);
            }
        }

        

       
    }
}
