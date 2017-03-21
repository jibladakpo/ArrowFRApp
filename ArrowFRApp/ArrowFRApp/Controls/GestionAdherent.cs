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
            //Récupération de tous les adhérents et affichage dans une listView qui a pour nom listViewAdherents
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
        }
    }
}
