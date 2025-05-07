using Negocio;
using System;
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
    public partial class frmMenuVendedor : Form
    {
        public string NombreUsuario { get; set; }
        public frmMenuVendedor()
        {
            InitializeComponent();
        }
        private void frmMenuVendedor_Load(object sender, EventArgs e)
        {
            GestorClientes gestorClientes = new GestorClientes();
            lblNombre.Text = NombreUsuario;
        }

        private void btnMisLocales_Click(object sender, EventArgs e)
        {
            frmMisLocales frm = new frmMisLocales();
            frm.NombreUsuario = NombreUsuario;
            frm.Show(); this.Hide();
        }
        private void btnRegistrarLocal_Click(object sender, EventArgs e)
        {
            frmRegistrarLocal frm = new frmRegistrarLocal();
            frm.NombreUsuario = NombreUsuario;
            frm.Show(); this.Hide();
        }
    }
}
