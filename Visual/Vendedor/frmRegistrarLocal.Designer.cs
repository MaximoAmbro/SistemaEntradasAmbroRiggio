namespace Visual
{
    partial class frmRegistrarLocal
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
            btnRegistrarEvento = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtDireccion = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtMail = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtCapacidad = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnRegistrarEvento
            // 
            btnRegistrarEvento.Location = new System.Drawing.Point(185, 253);
            btnRegistrarEvento.Name = "btnRegistrarEvento";
            btnRegistrarEvento.Size = new System.Drawing.Size(142, 27);
            btnRegistrarEvento.TabIndex = 30;
            btnRegistrarEvento.Text = "Registrar evento";
            btnRegistrarEvento.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new System.Drawing.Point(12, 253);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(142, 27);
            btnVolver.TabIndex = 29;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(12, 155);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(142, 27);
            txtTelefono.TabIndex = 28;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(10, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(142, 27);
            txtNombre.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(111, 25);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(117, 20);
            label6.TabIndex = 26;
            label6.Text = "Registrar evento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(186, 69);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 20);
            label4.TabIndex = 24;
            label4.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(185, 94);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(142, 27);
            txtDireccion.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 20);
            label2.TabIndex = 21;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 20);
            label1.TabIndex = 20;
            label1.Text = "Nombre";
            // 
            // txtMail
            // 
            txtMail.Location = new System.Drawing.Point(186, 155);
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(142, 27);
            txtMail.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(186, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 20);
            label3.TabIndex = 31;
            label3.Text = "Mail";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new System.Drawing.Point(12, 208);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new System.Drawing.Size(142, 27);
            txtCapacidad.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 183);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(80, 20);
            label5.TabIndex = 33;
            label5.Text = "Capacidad";
            // 
            // frmRegistrarLocal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtCapacidad);
            Controls.Add(label5);
            Controls.Add(txtMail);
            Controls.Add(label3);
            Controls.Add(btnRegistrarEvento);
            Controls.Add(btnVolver);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistrarLocal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RegistrarLocal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarEvento;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label label5;
    }
}