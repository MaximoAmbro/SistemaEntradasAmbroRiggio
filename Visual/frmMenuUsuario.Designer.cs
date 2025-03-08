namespace Visual
{
    partial class frmMenuUsuario
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
            btnEventos = new System.Windows.Forms.Button();
            btnHistorial = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            lblvolver = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnEventos
            // 
            btnEventos.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            btnEventos.ForeColor = System.Drawing.Color.White;
            btnEventos.Location = new System.Drawing.Point(11, 115);
            btnEventos.Margin = new System.Windows.Forms.Padding(2);
            btnEventos.Name = "btnEventos";
            btnEventos.Size = new System.Drawing.Size(225, 40);
            btnEventos.TabIndex = 5;
            btnEventos.Text = "Eventos";
            btnEventos.UseVisualStyleBackColor = false;
            btnEventos.Click += btnEventos_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            btnHistorial.ForeColor = System.Drawing.Color.White;
            btnHistorial.Location = new System.Drawing.Point(11, 181);
            btnHistorial.Margin = new System.Windows.Forms.Padding(2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new System.Drawing.Size(225, 41);
            btnHistorial.TabIndex = 6;
            btnHistorial.Text = "Historial de compras";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
            label1.Location = new System.Drawing.Point(14, 36);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 27);
            label1.TabIndex = 30;
            label1.Text = "Bienvenidos ";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblvolver
            // 
            lblvolver.AutoSize = true;
            lblvolver.ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            lblvolver.Location = new System.Drawing.Point(74, 250);
            lblvolver.Name = "lblvolver";
            lblvolver.Size = new System.Drawing.Size(103, 13);
            lblvolver.TabIndex = 32;
            lblvolver.Text = "VOLVER AL INICIO ";
            lblvolver.Click += lblvolver_Click;
            // 
            // frmMenuUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(250, 338);
            Controls.Add(lblvolver);
            Controls.Add(label1);
            Controls.Add(btnHistorial);
            Controls.Add(btnEventos);
            Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmMenuUsuario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMenuUsuario";
            Load += frmMenuUsuario_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblvolver;
    }
}