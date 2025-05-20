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
using Repositorio;
using Visual.Inicio;

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
            TxtMail.Text = "";
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
            frmSeleccionarCuentaACrear frm = new frmSeleccionarCuentaACrear();
            frm.Show();
            this.Hide();
        }
        private void btninicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMail.Text))
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
                BuscarMail(TxtMail.Text);
            }
        }

        public void BuscarMail(string mail)
        {
            if (GestorClientes.Instance.EncontrarMail(mail))
            {
                if (GestorClientes.Instance.EncontrarContraseña(TxtPassword.Text, mail))
                {
                    string nombreusuario;
                    frmMenuUsuario frm = new frmMenuUsuario();
                    GestorClientes.Instance.DevolverUsuario(mail, out nombreusuario);
                    frm.NombreUsuario = nombreusuario;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else if (GestorVendedores.Instance.EncontrarMail(mail))
            {
                if (GestorVendedores.Instance.EncontrarContraseña(TxtPassword.Text, mail))
                {
                    string nombreusuario;
                    frmMenuVendedor frm = new frmMenuVendedor();
                    GestorVendedores.Instance.DevolverUsuario(mail, out nombreusuario);
                    frm.NombreUsuario = nombreusuario;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Mail no encontrado");
            }
        }

    }
}
