﻿using Negocio;
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
        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            txtmail.Text="";
            txtnombre.Text = "";
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtPassword.PasswordChar = '*';
            TxtConfirmpassword.PasswordChar='*';
        }
        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbxShowPass.Checked == true)
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
        private void lblyatengocuen_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Hide();
        }
        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            if (RevisarTextbox()== true)
            {

                if(ValidarLista(TxtUsername.Text, txtmail.Text) == true)
                {
                    string nombre = txtnombre.Text;
                    string usuario = TxtUsername.Text;
                    string correo = txtmail.Text;
                    string contraseña = TxtPassword.Text;
                    string confirmarContraseña = TxtConfirmpassword.Text;
                }
            }
            else { return; }
        }
        private bool RevisarTextbox()
        {
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Ingrese nombre: ");
                return false;
            }
            if (string.IsNullOrEmpty(TxtUsername.Text))
            {
                MessageBox.Show("Ingrese Usuario: ");
                return false;

            }
            if (string.IsNullOrEmpty(txtmail.Text))
            {
                MessageBox.Show("Ingrese Mail: ");
                return false;

            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Ingrese contraseña: ");
                return false;

            }
            if (string.IsNullOrEmpty(TxtConfirmpassword.Text))
            {
                MessageBox.Show("Ingrese segunda contraseña: ");
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
        public bool ValidarLista(string usuario, string mail)
        {
            Negocio.GestorClientes gestorClientes = new Negocio.GestorClientes();

            if (gestorClientes.RevisarMailyUsuario(usuario, mail) == false)
            {
                MessageBox.Show("Usuario no disponible // Mail ya existe");
                return false;
            }
            else
            {
                AgregarUsuario(txtnombre.Text, TxtUsername.Text, txtmail.Text,  TxtPassword.Text);
                MessageBox.Show("Usuario creado");
                frmInicio frm = new frmInicio();
                frm.Show();
                this.Hide();
                return true;
            }
        }
        public void AgregarUsuario(string nombre, string usuario, string mail, string contraseña)
        {
            Negocio.GestorClientes gestorClientes = new Negocio.GestorClientes();
            gestorClientes.AgregarCliente(nombre, usuario, mail, contraseña);
        }
    }
}
    


    

