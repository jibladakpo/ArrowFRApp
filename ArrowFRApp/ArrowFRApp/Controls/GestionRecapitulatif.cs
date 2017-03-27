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
    }
}
