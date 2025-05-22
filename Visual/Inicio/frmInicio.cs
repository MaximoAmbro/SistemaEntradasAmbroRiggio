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
using Repositorio;

namespace Visual
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            GestorClientes.Instance.CargarLista();
            GestorVendedores.Instance.CargarLista();
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
        public void ValidarLista(string usuario, string contraseña)
        {
            if (GestorClientes.Instance.EncontrarMail(usuario))
            {
                if (GestorClientes.Instance.EncontrarMail(usuario))
                {
                    if (GestorClientes.Instance.EncontrarContraseña(contraseña, usuario))
                    {
                        frmMenuUsuario frm = new frmMenuUsuario();
                        frm.NombreUsuario = usuario;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta",
                                          "Error",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no registrado",
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                }
            }
            if (GestorVendedores.Instance.EncontrarMail(usuario))
            {
                if (GestorVendedores.Instance.EncontrarMail(usuario))
                {
                    if (GestorVendedores.Instance.EncontrarContraseña(contraseña, usuario))
                    {
                        frmMenuVendedor frm = new frmMenuVendedor();
                        frm.NombreUsuario = usuario;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta",
                                          "Error",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                    }
                }
                    else
                {
                    MessageBox.Show("Usuario no registrado",
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                }
            }
        }
    }
}
