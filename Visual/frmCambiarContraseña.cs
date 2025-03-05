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
    public partial class frmCambiarContraseña: Form
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
