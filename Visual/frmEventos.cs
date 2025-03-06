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
    public partial class FormEventos : Form
    {
        private GestorEventos gestorEventos;

        public FormEventos()
        {
            InitializeComponent();
            gestorEventos = new GestorEventos();
            CargarEventosEnDataGridView();
        }

        private void CargarEventosEnDataGridView()
        {
            // Obtener la lista de eventos desde el gestor
            List<Evento> listaEventos = gestorEventos.ObtenerListaEventos();

            // Vincular la lista al DataGridView
            dgveventos.DataSource = listaEventos;

            // Personalizar las columnas
            dgveventos.Columns["Id"].HeaderText = "ID";
            dgveventos.Columns["NombreEstablecimiento"].HeaderText = "Nombre del Establecimiento";
            dgveventos.Columns["DiaHora"].HeaderText = "Día y Hora";
            dgveventos.Columns["CuposTotales"].HeaderText = "Cupos Totales";
            dgveventos.Columns["LimiteMaximo"].HeaderText = "Límite Máximo";
        }
    

        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frm = new frmMenuUsuario();
            frm.Show();
            this.Hide();
        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            frmMenuUsuario frm = new frmMenuUsuario();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
