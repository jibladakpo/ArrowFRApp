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
    public partial class Adherent : UserControl
    {
        private static Adherent _instance;

        public static Adherent Instance
        {
        get
            {
                if (_instance == null)
                    _instance = new Adherent();
                return _instance;
           
            }
        }
        public Adherent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Adherent_Load(object sender, EventArgs e)
        {

        }
    }
}
