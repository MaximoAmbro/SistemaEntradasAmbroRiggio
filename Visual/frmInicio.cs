﻿using System;
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
        int checkcount = 0;

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
        } //ya está

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

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
            Negocio.GestorClientes gestorClientes = new Negocio.GestorClientes();
            
            if (gestorClientes.RevisarLogin(usuario, contraseña) == false)
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
