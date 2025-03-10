﻿using Negocio;
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
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
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
            GestorClientes gestorClientes = new GestorClientes();

            if (ControlarTxt() == true)
            {
                if(gestorClientes.EncontrarUsuario(TxtUsername.Text) == true)
            {
                    if(gestorClientes.EncontrarMail(txtMail.Text) == true)
                    {
                        gestorClientes.CambiarContraseña(TxtUsername.Text, TxtPassword.Text);
                        MessageBox.Show("Contraseña cambiada con exito");
                        frmInicio frmInicio = new frmInicio();
                        this.Hide();
                        frmInicio.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mail no encontrado");
                    }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }

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
