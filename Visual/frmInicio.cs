using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; 
using Negocio;

namespace Visual
{
    public partial class frmInicio: Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtPassword.PasswordChar = '*';
        }
        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked == true)
            {
                TxtPassword.PasswordChar = '\0';
            }
            else 
            {
                TxtPassword.PasswordChar = '*'; 
            }
        } //ya está
        private void lblolividarcontra_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña frm = new frmCambiarContraseña();
            frm.Show();
            this.Hide();
        } //ya está
        private void lblcrearcuenta_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frm = new frmCrearUsuario();
            frm.Show();
            this.Hide();
        }// ya está
        private void btninicio_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(TxtUsername.Text))
                {
                    MessageBox.Show("Por favor, ingrese usuario",
                                  "Campo vacíos",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(TxtPassword.Text))
                {
                    MessageBox.Show("Por favor, ingrese contraseña",
                                  "Campo vacíos",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }             
                else
                {
                    ValidarLista(TxtUsername.Text, TxtPassword.Text);
                }
            }
        }
        public bool ValidarLista(string usuario, string contraseña)
        {
            GestorClientes gestorClientes = new GestorClientes();
            if (gestorClientes.RevisarUsuarioYContraseña(usuario, contraseña) == false)
            {
                MessageBox.Show("Usuario no encontrado",
                                  "Hola Pedro",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return false;
            }
            else 
            {
                frmMenuUsuario frm = new frmMenuUsuario();
                frm.Show();
                this.Hide();
                return true
            ;}
        }
    }
}
