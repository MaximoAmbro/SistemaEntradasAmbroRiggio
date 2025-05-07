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
        public string EventoSeleccionado { get; set; }
        public frmMisLocales()
        {
            InitializeComponent();
        }

        private void btnEventosLocal_Click(object sender, EventArgs e)
        {
            frmEventosLocal frm = new frmEventosLocal();
            frm.NombreUsuario = NombreUsuario;
            frm.EventoSeleccionado = EventoSeleccionado;
            frm.Show(); this.Hide();
        }
    }
}
