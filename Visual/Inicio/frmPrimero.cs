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
    public partial class frmPrimero : Form
    {
        public frmPrimero()
        {
            InitializeComponent();
            GestorClientes gestorClientes = new GestorClientes();
            gestorClientes.CargarLista();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Hide();
        }

        private void frmPrimero_Load(object sender, EventArgs e)
        {

        }
    }
}
