namespace Visual
{
    partial class frmCambiarContraseña
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
            btnVolver = new System.Windows.Forms.Button();
            checkbxShowPass = new System.Windows.Forms.CheckBox();
            TxtConfirmpassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            TxtPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            TxtUsername = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnconfirmar = new System.Windows.Forms.Button();
            txtMail = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVolver.Location = new System.Drawing.Point(19, 865);
            btnVolver.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(149, 54);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver ";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            checkbxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkbxShowPass.Location = new System.Drawing.Point(308, 614);
            checkbxShowPass.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new System.Drawing.Size(157, 29);
            checkbxShowPass.TabIndex = 36;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // TxtConfirmpassword
            // 
            TxtConfirmpassword.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            TxtConfirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtConfirmpassword.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtConfirmpassword.Location = new System.Drawing.Point(51, 549);
            TxtConfirmpassword.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            TxtConfirmpassword.Multiline = true;
            TxtConfirmpassword.Name = "TxtConfirmpassword";
            TxtConfirmpassword.Size = new System.Drawing.Size(420, 54);
            TxtConfirmpassword.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(48, 510);
            label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(185, 25);
            label4.TabIndex = 34;
            label4.Text = "Confirmar Contraseña";
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtPassword.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtPassword.Location = new System.Drawing.Point(51, 425);
            TxtPassword.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new System.Drawing.Size(420, 54);
            TxtPassword.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(48, 388);
            label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(156, 25);
            label3.TabIndex = 32;
            label3.Text = "Nueva Contraseña";
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtUsername.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtUsername.Location = new System.Drawing.Point(51, 234);
            TxtUsername.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new System.Drawing.Size(420, 54);
            TxtUsername.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(48, 195);
            label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 25);
            label2.TabIndex = 30;
            label2.Text = "Usuario ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
            label1.Location = new System.Drawing.Point(22, 96);
            label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(478, 60);
            label1.TabIndex = 29;
            label1.Text = "NUEVA CONTRASEÑA";
            // 
            // btnconfirmar
            // 
            btnconfirmar.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            btnconfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnconfirmar.FlatAppearance.BorderSize = 0;
            btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnconfirmar.ForeColor = System.Drawing.Color.White;
            btnconfirmar.Location = new System.Drawing.Point(51, 707);
            btnconfirmar.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            btnconfirmar.Name = "btnconfirmar";
            btnconfirmar.Size = new System.Drawing.Size(420, 66);
            btnconfirmar.TabIndex = 40;
            btnconfirmar.Text = "CONFIRMAR";
            btnconfirmar.UseVisualStyleBackColor = false;
            btnconfirmar.Click += btnconfirmar_Click;
            // 
            // txtMail
            // 
            txtMail.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtMail.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtMail.Location = new System.Drawing.Point(51, 329);
            txtMail.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(420, 54);
            txtMail.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(48, 290);
            label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 25);
            label5.TabIndex = 41;
            label5.Text = "Mail";
            // 
            // frmCambiarContraseña
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(542, 940);
            Controls.Add(txtMail);
            Controls.Add(label5);
            Controls.Add(btnconfirmar);
            Controls.Add(checkbxShowPass);
            Controls.Add(TxtConfirmpassword);
            Controls.Add(label4);
            Controls.Add(TxtPassword);
            Controls.Add(label3);
            Controls.Add(TxtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            Name = "frmCambiarContraseña";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCambiarContraseña";
            Load += frmCambiarContraseña_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.CheckBox checkbxShowPass;
        private System.Windows.Forms.TextBox TxtConfirmpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
    }
}