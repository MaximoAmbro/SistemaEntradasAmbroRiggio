using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Visual
{
    public partial class frmCrearUsuario : Form
    {
        int checkcount = 0;

        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            txtmail.Text = "";
            txtnombre.Text = "";
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtPassword.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            checkcount++;
            TxtPassword.PasswordChar = '\0';
            if (checkcount % 2 == 0)
            {
                TxtPassword.PasswordChar = '*';
            }
            else
            {
                TxtPassword.PasswordChar = '\0';
            }

            checkcount++;
            TxtConfirmpassword.PasswordChar = '\0';
            if (checkcount % 2 == 0)
            {
                TxtConfirmpassword.PasswordChar = '*';
            }
            else
            {
                TxtConfirmpassword.PasswordChar = '\0';
            }
        }


        private void lblyatengocuen_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Hide();
        }

        private void TxtConfirmpassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())

            {
                string nombre = txtnombre.Text;
                string usuario = TxtUsername.Text;
                string correo = txtmail.Text;
                string contraseña = TxtPassword.Text;
                string confirmarContraseña = TxtConfirmpassword.Text;
                
            }
        }

        private bool ValidarCampos()

        {
            if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(TxtUsername.Text) || string.IsNullOrEmpty(txtmail.Text) || string.IsNullOrEmpty(TxtPassword.Text) || string.IsNullOrEmpty(TxtConfirmpassword.Text))
            {
                MessageBox.Show("Campo vacío. Por favor, complete todos los campos.");
                return false;
            }

            if (!ValidarNombreApellido(txtnombre.Text))
            {
                MessageBox.Show("El nombre y apellido debe tener más de 6 letras y no puede contener números ni símbolos.");
                return false;
            }


            if (TxtUsername.Text.Length < 8)
            {
                MessageBox.Show("El usuario debe tener al menos 8 letras.");
                return false;
            }



            if (!ValidarCorreo(txtmail.Text))
            {
                MessageBox.Show("El correo electrónico debe tener más de 8 letras y terminar con @gmail.com.");
                return false;
            }

            if (!ValidarContraseña(TxtPassword.Text))
            {
                MessageBox.Show("La contraseña debe tener más de 8 letras y al menos 2 números.");
                return false;
            }

            if (TxtPassword.Text != TxtConfirmpassword.Text)
            {
                MessageBox.Show("Error, las contraseñas no coinciden.");
                return false;
            }

            if (!ValidarUsuario(TxtUsername.Text))
            {
                MessageBox.Show("El usuario no puede contener símbolos.");
                return false;
            }

            if (!ValidarCorreoSinSimbolos(txtmail.Text))
            {
                MessageBox.Show("El correo electrónico no puede contener símbolos.");
                return false;
            }



            return true;

        }


        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
    


    

