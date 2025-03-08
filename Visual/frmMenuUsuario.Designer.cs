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
            btnVolver = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnEventos
            // 
            btnEventos.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            btnEventos.ForeColor = System.Drawing.Color.White;
            btnEventos.Location = new System.Drawing.Point(50, 180);
            btnEventos.Margin = new System.Windows.Forms.Padding(2);
            btnEventos.Name = "btnEventos";
            btnEventos.Size = new System.Drawing.Size(150, 40);
            btnEventos.TabIndex = 5;
            btnEventos.Text = "Eventos";
            btnEventos.UseVisualStyleBackColor = false;
            btnEventos.Click += btnEventos_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            btnHistorial.ForeColor = System.Drawing.Color.White;
            btnHistorial.Location = new System.Drawing.Point(50, 230);
            btnHistorial.Margin = new System.Windows.Forms.Padding(2);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new System.Drawing.Size(148, 41);
            btnHistorial.TabIndex = 6;
            btnHistorial.Text = "Historial de compras";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.White;
            btnVolver.ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            btnVolver.Location = new System.Drawing.Point(11, 364);
            btnVolver.Margin = new System.Windows.Forms.Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(89, 28);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver a incio ";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
            label1.Location = new System.Drawing.Point(25, 50);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(231, 34);
            label1.TabIndex = 30;
            label1.Text = "Bienvenidos ";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenuUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(282, 403);
            Controls.Add(label1);
            Controls.Add(btnVolver);
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
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
    }
}