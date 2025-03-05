﻿using System;
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
    public partial class frmCrearUsuario: Form
    {
        int checkcount = 0;

        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            frm.Show();
            this.Hide();
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
        }
    }
}
