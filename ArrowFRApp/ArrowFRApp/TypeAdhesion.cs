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
    public partial class TypeAdhesion : UserControl
    {
        private static TypeAdhesion _instance;

        public static TypeAdhesion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TypeAdhesion();
                return _instance;

            }
        }
        public TypeAdhesion()
        {
            InitializeComponent();
        }

        private void TypeAdhesion_Load(object sender, EventArgs e)
        {

        }
    }
}
