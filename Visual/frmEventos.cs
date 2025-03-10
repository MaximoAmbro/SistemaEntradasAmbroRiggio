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
        private GestorEntradas gestorEventos;
        public string NombreUsuario {  get; set; }
        public frmEventos()
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
        private void frmEventos_Load(object sender, EventArgs e)
        {
            gestorEventos = new GestorEntradas();
            dgveventos.DataSource = gestorEventos.ObtenerListaEventos();
            DataGridViewColumn columnaNombre = new DataGridViewColumn();
            DataGridViewColumn columnaUbicacion = new DataGridViewColumn();
            dgveventos.AutoGenerateColumns = true;
            dgveventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void btnComprar_Click_1(object sender, EventArgs e)
        {
            if (dgveventos.SelectedCells.Count > 0)
            {
                string nombre = dgveventos.SelectedCells[0].Value.ToString();
                FrmCompra frm = new FrmCompra();
                frm.NombreEvento = nombre;
                frm.NombreUsuario = NombreUsuario;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un evento para comprar", "Hola Pedro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
