using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual.Usuario;
using Visual.Vendedor;

namespace Visual.Inicio
{
    public partial class frmSeleccionarCuentaACrear : Form
    {
        public frmSeleccionarCuentaACrear()
        {
            InitializeComponent();
        }
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            frmCrearUsuarioVendedor frm = new frmCrearUsuarioVendedor();
            frm.Show(); this.Hide();
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCrearUsuarioCliente frm = new frmCrearUsuarioCliente();
            frm.Show();
            this.Hide();
        }
    }
}
