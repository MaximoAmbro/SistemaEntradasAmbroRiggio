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
    public partial class frmEventos : Form
    {
        private GestorEventos gestorEventos;

        public frmEventos()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frm = new frmMenuUsuario();
            frm.Show();
            this.Hide();
        }
        private void frmEventos_Load(object sender, EventArgs e)
        {
            gestorEventos = new GestorEventos();
            dgveventos.DataSource = gestorEventos.ObtenerListaEventos();
            DataGridViewColumn columnaNombre = new DataGridViewColumn();
            DataGridViewColumn columnaUbicacion = new DataGridViewColumn();
            dgveventos.AutoGenerateColumns = true;
            //falta hacer para que no queden espacios grises
        }
        private void btnComprar_Click_1(object sender, EventArgs e)
        {
            if (dgveventos.SelectedRows.Count > 0)
            {
                FrmCompra frm = new FrmCompra();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un evento para comprar", "Hola Pedro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }
    }
}
