using Entidades;
using Negocio;
using Repositorio;
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
    public partial class frmMisLocales : Form
    {
        public string NombreUsuario { get; set; }
        public string Mail { get; set; }
        public string EventoSeleccionado { get; set; }
        public List<Local> ListaLocales { get; set; }
        public frmMisLocales()
        {
            InitializeComponent();
            GestorVendedores.Instance.CargarLista();
        }
        private void btnEventosLocal_Click(object sender, EventArgs e)
        {
            frmEventosLocal frm = new frmEventosLocal();
            frm.NombreUsuario = NombreUsuario;
            frm.EventoSeleccionado = EventoSeleccionado;
            frm.Show(); this.Hide();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuVendedor frm = new frmMenuVendedor();
            frm.NombreUsuario = NombreUsuario;
            frm.Show(); this.Hide();
        }

        private void frmMisLocales_Load(object sender, EventArgs e)
        {
            GestorVendedores gestorVendedores = GestorVendedores.Instance;
            ListaLocales = gestorVendedores.ObtenerListaLocales(NombreUsuario);
            dgvLocales.DataSource = gestorVendedores.ObtenerListaLocales(NombreUsuario);

            ListaLocales = gestorVendedores.ObtenerListaLocales(NombreUsuario);
            dgvLocales.DataSource = gestorVendedores.ObtenerListaLocales(NombreUsuario);
            dgvLocales.Refresh();
            DataGridViewColumn columnaNombre = new DataGridViewColumn();
            DataGridViewColumn columnaUbicacion = new DataGridViewColumn();
            dgvLocales.AutoGenerateColumns = true;
            dgvLocales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
