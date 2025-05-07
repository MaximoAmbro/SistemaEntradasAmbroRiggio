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
    public partial class frmRegistrarEvento: Form
    {
        public string NombreUsuario { get; set; }
        public string EventoSeleccionado { get; set; }
        public frmRegistrarEvento()
        {
            InitializeComponent();
        }
    }
}
