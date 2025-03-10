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
    public partial class frmMenuUsuario : Form
    {
        public string NombreUsuario { get; set; }
        public frmMenuUsuario()
        {
            InitializeComponent();
        }
        private void frmMenuUsuario_Load(object sender, EventArgs e)
        {
            GestorClientes gestorClientes = new GestorClientes();
            lblNombre.Text = NombreUsuario;
        }
        private void btnEventos_Click(object sender, EventArgs e)
        {
            frmEventos frm = new frmEventos();
            frm.NombreUsuario = NombreUsuario;
            frm.Show();
            this.Hide();
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorial frm = new frmHistorial();
            frm.NombreUsuario = NombreUsuario;
            frm.Show();
            this.Hide();
        }
        private void lblvolver_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
