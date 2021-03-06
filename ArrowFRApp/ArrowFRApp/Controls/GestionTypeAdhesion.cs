﻿using System;
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

        //affichage de la partie gestion des types d'adhésions
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
                listItem.SubItems.Add(item.idTypeAdhesion.ToString());
                
                listViewTypeAdhesion.Items.Add(listItem);
            }
        }

        private void buttonCreerTypeAdhesion_Click(object sender, EventArgs e)
        {
            
            TypeAdhesionDB typeadhDB = new TypeAdhesionDB(); 
            TypeAdhesion ta = new TypeAdhesion(textBoxLibelle.Text, Convert.ToInt32(textBoxTarif.Text));
            typeadhDB.Save(ta);
            
            MessageBox.Show("Type Adhesion ajouté: " + textBoxLibelle.Text);
            //Efface champs
            textBoxLibelle.Clear();
            textBoxTarif.Clear();

            //actualiser
            reload();
        }

        private void buttonModifierTypeAdhesion_Click(object sender, EventArgs e)
        {
            TypeAdhesionDB typeadhDB = new TypeAdhesionDB();
            TypeAdhesion a1 = typeadhDB.GetTypeAdhesion(Convert.ToInt32(listViewTypeAdhesion.SelectedItems[0].SubItems[2].Text));
            a1.Libelle = textBoxLibelle.Text;
            a1.Tarif = Convert.ToInt32(textBoxTarif.Text);
            
            typeadhDB.Save(a1);
            MessageBox.Show("Type Adhesion modifié: ");
            //Efface champs
            textBoxLibelle.Clear();
            textBoxTarif.Clear();

            //actualiser
            reload();
        }

        private void buttonSupprimerTypeAdhesion_Click(object sender, EventArgs e)
        {
            if (listViewTypeAdhesion.SelectedItems.Count > 0)
            {
                // adhDB.Delete();
               TypeAdhesionDB adhesionDB = new TypeAdhesionDB();
                ListViewItem listItem = listViewTypeAdhesion.SelectedItems[0];
                int id = Convert.ToInt32(listViewTypeAdhesion.SelectedItems[0].SubItems[2].Text);
                
                adhesionDB.Delete(id);
                MessageBox.Show("Suprimer le type d'adhésion " + textBoxLibelle.Text + " ?");
                //Efface champs
                textBoxLibelle.Clear();
                textBoxTarif.Clear();
                
                //actualiser
                reload();
            }
        }
        //actualisation de la listview
        private void reload()
        {
            listViewTypeAdhesion.Items.Clear();
            TypeAdhesionDB adhDB = new TypeAdhesionDB();
            List<ArrowFRApp.TypeAdhesion> lesTypesAdhesions = adhDB.GetAllTypeAdhesion();
            foreach (var item in lesTypesAdhesions)
            {

                ListViewItem listItem = new ListViewItem(item.Libelle);

                listItem.SubItems.Add(item.Tarif.ToString());
                listItem.SubItems.Add(item.idTypeAdhesion.ToString());

                listViewTypeAdhesion.Items.Add(listItem);
            }
        }

       
        //aficher infos dans des textbox du type d'adhésion selectionner dans la listview
        private void listViewTypeAdhesion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewTypeAdhesion.SelectedItems.Count > 0)
            {
                textBoxLibelle.Text = listViewTypeAdhesion.SelectedItems[0].Text;
                textBoxTarif.Text = listViewTypeAdhesion.SelectedItems[0].SubItems[1].Text;
            }
        }

    }
}
