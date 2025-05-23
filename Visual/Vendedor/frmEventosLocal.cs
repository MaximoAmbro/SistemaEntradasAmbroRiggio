﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual.Vendedor;

namespace Visual
{
    public partial class frmEventosLocal : Form
    {
        public string NombreUsuario { get; set; }
        public string EventoSeleccionado { get; set; }
        public frmEventosLocal()
        {
            InitializeComponent();
        }
        private void btnNuevoEventoLocal_Click(object sender, EventArgs e)
        {
            frmRegistrarEvento frm = new frmRegistrarEvento();
            frm.NombreUsuario = NombreUsuario;
            frm.EventoSeleccionado = EventoSeleccionado;
            frm.Show(); this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMisLocales frm = new frmMisLocales();
            frm.Show(); this.Hide();
        }
    }
}
