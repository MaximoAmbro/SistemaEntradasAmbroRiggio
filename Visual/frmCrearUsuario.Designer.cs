namespace Visual
{
    partial class frmCrearUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkbxShowPass = new System.Windows.Forms.CheckBox();
            TxtConfirmpassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            TxtPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            TxtUsername = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtnombre = new System.Windows.Forms.TextBox();
            lblmail = new System.Windows.Forms.Label();
            txtmail = new System.Windows.Forms.TextBox();
            lblyatengocuen = new System.Windows.Forms.Label();
            btnregistrarse = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            checkbxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkbxShowPass.Location = new System.Drawing.Point(181, 370);
            checkbxShowPass.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new System.Drawing.Size(105, 17);
            checkbxShowPass.TabIndex = 23;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // TxtConfirmpassword
            // 
            TxtConfirmpassword.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            TxtConfirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtConfirmpassword.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtConfirmpassword.Location = new System.Drawing.Point(34, 343);
            TxtConfirmpassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            TxtConfirmpassword.Name = "TxtConfirmpassword";
            TxtConfirmpassword.Size = new System.Drawing.Size(252, 21);
            TxtConfirmpassword.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(31, 327);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(121, 13);
            label4.TabIndex = 21;
            label4.Text = "Confirmar Contraseña";
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtPassword.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtPassword.Location = new System.Drawing.Point(34, 296);
            TxtPassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new System.Drawing.Size(252, 21);
            TxtPassword.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(31, 280);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 13);
            label3.TabIndex = 19;
            label3.Text = "Contraseña";
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtUsername.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtUsername.Location = new System.Drawing.Point(34, 149);
            TxtUsername.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new System.Drawing.Size(252, 21);
            TxtUsername.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(31, 233);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 17;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
            label1.Location = new System.Drawing.Point(14, 47);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(222, 27);
            label1.TabIndex = 16;
            label1.Text = "CREAR USUARIO ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(31, 133);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(106, 13);
            label6.TabIndex = 27;
            label6.Text = "Nombre y Apellido";
            // 
            // txtnombre
            // 
            txtnombre.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtnombre.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtnombre.Location = new System.Drawing.Point(34, 249);
            txtnombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new System.Drawing.Size(252, 21);
            txtnombre.TabIndex = 28;
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.Location = new System.Drawing.Point(31, 180);
            lblmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblmail.Name = "lblmail";
            lblmail.Size = new System.Drawing.Size(30, 13);
            lblmail.TabIndex = 29;
            lblmail.Text = "Mail";
            // 
            // txtmail
            // 
            txtmail.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            txtmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtmail.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtmail.Location = new System.Drawing.Point(34, 196);
            txtmail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            txtmail.Name = "txtmail";
            txtmail.Size = new System.Drawing.Size(252, 21);
            txtmail.TabIndex = 30;
            // 
            // lblyatengocuen
            // 
            lblyatengocuen.AutoSize = true;
            lblyatengocuen.Cursor = System.Windows.Forms.Cursors.Hand;
            lblyatengocuen.Location = new System.Drawing.Point(109, 463);
            lblyatengocuen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblyatengocuen.Name = "lblyatengocuen";
            lblyatengocuen.Size = new System.Drawing.Size(91, 13);
            lblyatengocuen.TabIndex = 31;
            lblyatengocuen.Text = "Ya tengo cuenta";
            lblyatengocuen.Click += lblyatengocuen_Click;
            // 
            // btnregistrarse
            // 
            btnregistrarse.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            btnregistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            btnregistrarse.FlatAppearance.BorderSize = 0;
            btnregistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnregistrarse.ForeColor = System.Drawing.Color.White;
            btnregistrarse.Location = new System.Drawing.Point(34, 414);
            btnregistrarse.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            btnregistrarse.Name = "btnregistrarse";
            btnregistrarse.Size = new System.Drawing.Size(252, 35);
            btnregistrarse.TabIndex = 32;
            btnregistrarse.Text = "REGISTRARSE";
            btnregistrarse.UseVisualStyleBackColor = false;
            btnregistrarse.Click += btnregistrarse_Click;
            // 
            // frmCrearUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(332, 544);
            Controls.Add(btnregistrarse);
            Controls.Add(lblyatengocuen);
            Controls.Add(txtmail);
            Controls.Add(lblmail);
            Controls.Add(txtnombre);
            Controls.Add(label6);
            Controls.Add(checkbxShowPass);
            Controls.Add(TxtConfirmpassword);
            Controls.Add(label4);
            Controls.Add(TxtPassword);
            Controls.Add(label3);
            Controls.Add(TxtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmCrearUsuario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCrearUsuario";
            Load += frmCrearUsuario_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkbxShowPass;
        private System.Windows.Forms.TextBox TxtConfirmpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label lblyatengocuen;
        private System.Windows.Forms.Button btnregistrarse;
    }
}