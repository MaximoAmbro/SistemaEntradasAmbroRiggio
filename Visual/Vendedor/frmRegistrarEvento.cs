using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual.Vendedor
{
    public partial class frmRegistrarEvento : Form
    {
        public string NombreUsuario { get; set; }
        public string EventoSeleccionado { get; set; }
        public frmRegistrarEvento()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMisLocales formMisLocales = new frmMisLocales();
            formMisLocales.Show();
            this.Hide();
        }

        private void btnRegistrarSector_Click(object sender, EventArgs e)
        {
            frmRegistrarSector frm = new frmRegistrarSector();
            frm.Show(); this.Hide();
        }
    }
}
