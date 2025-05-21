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
    public partial class frmRegistrarSector : Form
    {
        public frmRegistrarSector()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmRegistrarEvento frmRegistrarEvento = new frmRegistrarEvento();
            frmRegistrarEvento.Show();
            this.Hide();
        }
    }
}
