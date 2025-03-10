using Entidades;
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
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frm = new frmMenuUsuario();
            frm.Show();
            this.Hide();
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            GestorClientes gestorClientes = new GestorClientes();
            dgvHistorial.DataSource = gestorClientes.ObtenerListaEventos();
            DataGridViewColumn columnaNombre = new DataGridViewColumn();
            DataGridViewColumn columnaUbicacion = new DataGridViewColumn();
            dgvHistorial.AutoGenerateColumns = true;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
