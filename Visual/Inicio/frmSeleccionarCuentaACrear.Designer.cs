namespace Visual.Inicio
{
    partial class frmSeleccionarCuentaACrear
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
            btnCliente = new System.Windows.Forms.Button();
            btnVendedor = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.Location = new System.Drawing.Point(240, 109);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new System.Drawing.Size(204, 102);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnVendedor
            // 
            btnVendedor.Location = new System.Drawing.Point(239, 249);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new System.Drawing.Size(205, 131);
            btnVendedor.TabIndex = 1;
            btnVendedor.Text = "Vendedor";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // frmSeleccionarCuentaACrear
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnVendedor);
            Controls.Add(btnCliente);
            Name = "frmSeleccionarCuentaACrear";
            Text = "frmSeleccionarCuentaACrear";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVendedor;
    }
}