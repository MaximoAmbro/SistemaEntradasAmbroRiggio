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
            frm.Mail = Mail;
            frm.EventoSeleccionado = EventoSeleccionado;
            frm.Show(); this.Hide();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuVendedor frm = new frmMenuVendedor();
            frm.Mail = Mail;
            frm.Show(); this.Hide();
        }
        private void frmMisLocales_Load(object sender, EventArgs e)
        {
            ListaLocales = GestorVendedores.Instance.ObtenerListaLocales(Mail);
            dgvLocales.DataSource = GestorVendedores.Instance.ObtenerListaLocales(Mail);

            ListaLocales = GestorVendedores.Instance.ObtenerListaLocales(Mail);
            dgvLocales.DataSource = GestorVendedores.Instance.ObtenerListaLocales(Mail);
            dgvLocales.Refresh();
            DataGridViewColumn columnaNombre = new DataGridViewColumn();
            DataGridViewColumn columnaUbicacion = new DataGridViewColumn();
            dgvLocales.AutoGenerateColumns = true;
            dgvLocales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
