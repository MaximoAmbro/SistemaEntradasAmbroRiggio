namespace Visual.Vendedor
{
    partial class frmRegistrarSector
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
            txtCapacidad = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            btnRegistrarSector = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            txtPrecio = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new System.Drawing.Point(12, 185);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(142, 27);
            btnVolver.TabIndex = 28;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new System.Drawing.Point(10, 134);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new System.Drawing.Size(142, 27);
            txtCapacidad.TabIndex = 27;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(10, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(142, 27);
            txtNombre.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(111, 11);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(112, 20);
            label6.TabIndex = 25;
            label6.Text = "Registrar sector";
            // 
            // btnRegistrarSector
            // 
            btnRegistrarSector.Location = new System.Drawing.Point(186, 185);
            btnRegistrarSector.Name = "btnRegistrarSector";
            btnRegistrarSector.Size = new System.Drawing.Size(142, 27);
            btnRegistrarSector.TabIndex = 24;
            btnRegistrarSector.Text = "Registrar sector";
            btnRegistrarSector.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(186, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 20);
            label4.TabIndex = 23;
            label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(185, 80);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(142, 27);
            txtPrecio.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 20);
            label1.TabIndex = 20;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 111);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 20);
            label2.TabIndex = 29;
            label2.Text = "Capacidad";
            // 
            // frmRegistrarSector
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnVolver);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(btnRegistrarSector);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Name = "frmRegistrarSector";
            Text = "frmRegistrarSector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarSector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}