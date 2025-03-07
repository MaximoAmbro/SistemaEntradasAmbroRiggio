using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; using Negocio;

namespace Visual
{
    public partial class frmMenuUsuario: Form
    {
        public frmMenuUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Hide();
        }
        private void frmMenuUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FrmCompra frm = new FrmCompra();
            frm.Show();
            this.Hide();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            FormEventos frm = new FormEventos();
            frm.Show();
            this.Hide();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorial frm = new frmHistorial();
            frm.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Hide();
        }
    }
}
