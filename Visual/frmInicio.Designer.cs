namespace Visual
{
    partial class frmInicio
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
            TxtUsername = new System.Windows.Forms.TextBox();
            TxtPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            checkbxShowPass = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            lblolividarcontra = new System.Windows.Forms.Label();
            lblcrearcuenta = new System.Windows.Forms.Label();
            btninicio = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtUsername.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtUsername.Location = new System.Drawing.Point(36, 172);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new System.Drawing.Size(216, 27);
            TxtUsername.TabIndex = 5;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = System.Drawing.Color.FromArgb(230, 231, 233);
            TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TxtPassword.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            TxtPassword.Location = new System.Drawing.Point(36, 234);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new System.Drawing.Size(216, 27);
            TxtPassword.TabIndex = 7;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(33, 214);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 17);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            checkbxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            checkbxShowPass.Location = new System.Drawing.Point(133, 267);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new System.Drawing.Size(119, 21);
            checkbxShowPass.TabIndex = 10;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(283, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 17);
            label4.TabIndex = 16;
            label4.Text = "label4";
            // 
            // lblolividarcontra
            // 
            lblolividarcontra.AutoSize = true;
            lblolividarcontra.Location = new System.Drawing.Point(57, 376);
            lblolividarcontra.Name = "lblolividarcontra";
            lblolividarcontra.Size = new System.Drawing.Size(166, 17);
            lblolividarcontra.TabIndex = 18;
            lblolividarcontra.Text = "¿Olvidaste tu contraseña?";
            lblolividarcontra.Click += lblolividarcontra_Click;
            // 
            // lblcrearcuenta
            // 
            lblcrearcuenta.AutoSize = true;
            lblcrearcuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            lblcrearcuenta.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
            lblcrearcuenta.Location = new System.Drawing.Point(93, 406);
            lblcrearcuenta.Name = "lblcrearcuenta";
            lblcrearcuenta.Size = new System.Drawing.Size(87, 17);
            lblcrearcuenta.TabIndex = 19;
            lblcrearcuenta.Text = "Crear Cuenta";
            lblcrearcuenta.Click += lblcrearcuenta_Click;
            // 
            // btninicio
            // 
            btninicio.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            btninicio.Cursor = System.Windows.Forms.Cursors.Hand;
            btninicio.FlatAppearance.BorderSize = 0;
            btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btninicio.ForeColor = System.Drawing.Color.White;
            btninicio.Location = new System.Drawing.Point(33, 328);
            btninicio.Name = "btninicio";
            btninicio.Size = new System.Drawing.Size(216, 35);
            btninicio.TabIndex = 20;
            btninicio.Text = "INICIAR SESION ";
            btninicio.UseVisualStyleBackColor = false;
            btninicio.Click += btninicio_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(33, 152);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 17);
            label5.TabIndex = 21;
            label5.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
            label2.Location = new System.Drawing.Point(13, 80);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 27);
            label2.TabIndex = 22;
            label2.Text = "LOGIN";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(282, 473);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(btninicio);
            Controls.Add(lblcrearcuenta);
            Controls.Add(lblolividarcontra);
            Controls.Add(label4);
            Controls.Add(checkbxShowPass);
            Controls.Add(TxtPassword);
            Controls.Add(label3);
            Controls.Add(TxtUsername);
            Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "frmInicio";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmInicio";
            Load += frmInicio_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkbxShowPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblolividarcontra;
        private System.Windows.Forms.Label lblcrearcuenta;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}