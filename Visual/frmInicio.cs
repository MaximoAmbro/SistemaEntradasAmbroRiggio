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
    public partial class frmInicio: Form
    {
        int checkcount = 0;

        public frmInicio()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            checkcount++;
            TxtPassword.PasswordChar = '\0';
            if (checkcount %2 == 0)
            {
                TxtPassword.PasswordChar = '*';
            }
            else
            {
                TxtPassword.PasswordChar = '\0';
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblolividarcontra_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña frm = new frmCambiarContraseña();
            frm.Show();
            this.Hide();


        }

        private void lblcrearcuenta_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frm = new frmCrearUsuario();
            frm.Show();
            this.Hide();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            {
                
                if (string.IsNullOrEmpty(TxtUsername.Text) || string.IsNullOrEmpty(TxtPassword.Text))
                {
                    MessageBox.Show("Por favor, ingrese usuario y contraseña.",
                                  "Campos vacíos",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                bool credencialesValidas = ValidarCredenciales(TxtUsername.Text, TxtPassword.Text);

                if (credencialesValidas)
                {

                    frmInicio frmincio = new frmInicio();
                    frmincio.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, verifica tus datos e intenta de nuevo. En el caso de no tener cuenta crearse una.",
                                  "Error de inicio de sesión",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);

                    TxtPassword.Text = "";
                    TxtUsername.Focus();
                }
            }
        }
            

        private bool ValidarCredenciales(string Username, string Password)
        {

            string UsarnameValido = "admin";
            string PasswordValida = "1234";

            return TxtUsername.Text == UsarnameValido && TxtPassword.Text == PasswordValida;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtPassword.PasswordChar = '*';

        }
    }
    
}
