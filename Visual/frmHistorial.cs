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
        public string NombreUsuario { get; set; }
        public frmHistorial()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frm = new frmMenuUsuario();
            frm.NombreUsuario = NombreUsuario;
            frm.Show();
            this.Hide();
        }
        private void frmHistorial_Load(object sender, EventArgs e)
        {
            GestorClientes gestorClientes = GestorClientes.Instance;
            dgvHistorial.DataSource = gestorClientes.ObtenerListaEventos(NombreUsuario);
            dgvHistorial.Refresh();
            DataGridViewColumn columnaNombre = new DataGridViewColumn();
            DataGridViewColumn columnaUbicacion = new DataGridViewColumn();
            dgvHistorial.AutoGenerateColumns = true;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
