namespace Visual.Vendedor
{
    partial class frmRegistrarEvento
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtPrecio = new System.Windows.Forms.TextBox();
            btnRegistrarSector = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtLocal = new System.Windows.Forms.TextBox();
            btnVolver = new System.Windows.Forms.Button();
            btnRegistrarEvento = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 184);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Local";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(123, 129);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 20);
            label3.TabIndex = 5;
            label3.Text = "Fecha y hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(188, 74);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(187, 99);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(142, 27);
            txtPrecio.TabIndex = 6;
            // 
            // btnRegistrarSector
            // 
            btnRegistrarSector.Location = new System.Drawing.Point(187, 210);
            btnRegistrarSector.Name = "btnRegistrarSector";
            btnRegistrarSector.Size = new System.Drawing.Size(142, 27);
            btnRegistrarSector.TabIndex = 10;
            btnRegistrarSector.Text = "Registrar sector";
            btnRegistrarSector.UseVisualStyleBackColor = true;
            btnRegistrarSector.Click += btnRegistrarSector_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(113, 30);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(117, 20);
            label6.TabIndex = 13;
            label6.Text = "Registrar evento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(12, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(142, 27);
            txtNombre.TabIndex = 14;
            // 
            // txtLocal
            // 
            txtLocal.Location = new System.Drawing.Point(14, 209);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new System.Drawing.Size(142, 27);
            txtLocal.TabIndex = 16;
            // 
            // btnVolver
            // 
            btnVolver.Location = new System.Drawing.Point(14, 264);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(142, 27);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRegistrarEvento
            // 
            btnRegistrarEvento.Location = new System.Drawing.Point(187, 264);
            btnRegistrarEvento.Name = "btnRegistrarEvento";
            btnRegistrarEvento.Size = new System.Drawing.Size(142, 27);
            btnRegistrarEvento.TabIndex = 18;
            btnRegistrarEvento.Text = "Registrar evento";
            btnRegistrarEvento.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(18, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(311, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // frmRegistrarEvento
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnRegistrarEvento);
            Controls.Add(btnVolver);
            Controls.Add(txtLocal);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(btnRegistrarSector);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistrarEvento";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmRegistrarEvento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnRegistrarSector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrarEvento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}