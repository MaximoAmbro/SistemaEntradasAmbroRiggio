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
    public partial class frmCambiarContraseña : Form
    {
        int checkcount = 0;

        public frmCambiarContraseña()
        {
            InitializeComponent();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Hide();
        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtPassword.PasswordChar = '*';
            TxtConfirmpassword.PasswordChar = '*';
        }
        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked == true)
            {
                TxtPassword.PasswordChar = '\0';
                TxtConfirmpassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '*';
                TxtConfirmpassword.PasswordChar = '*';
            }
        }
        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (ControlarTxt() == true)
            {
                GestorClientes gestorClientes = new GestorClientes();
                gestorClientes.CambiarContraseña(TxtUsername.Text, TxtPassword.Text);
                MessageBox.Show("Contraseña cambiada con exito");
                    frmInicio frm = new frmInicio();
                    frm.Show();
                    this.Hide();

            }
        }
        public bool ControlarTxt()
        {
            if (string.IsNullOrEmpty(TxtUsername.Text))
            {
                MessageBox.Show("Ingrese Usuario: ");
                return false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Ingrese contraseña: ");
                return false;
            }
            if (string.IsNullOrEmpty(TxtConfirmpassword.Text))
            {
                MessageBox.Show("Ingrese confirmacion de contraseña: ");
                return false;
            }
            if(string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Ingrese Mail: ");
                return false;
            }
            if (TxtPassword.Text != TxtConfirmpassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }  
}
