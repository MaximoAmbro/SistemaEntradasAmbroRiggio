﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class frmRegistrarLocal : Form
    {
        public string NombreUsuario { get; set; }
        public frmRegistrarLocal()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuVendedor frm = new frmMenuVendedor();
            frm.Show(); this.Hide();
        }
    }
}
