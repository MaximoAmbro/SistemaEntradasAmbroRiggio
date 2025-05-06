namespace Visual
{
    partial class frmPrimero
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
            btninicio = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btninicio
            // 
            btninicio.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            btninicio.Cursor = System.Windows.Forms.Cursors.Hand;
            btninicio.FlatAppearance.BorderSize = 0;
            btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btninicio.ForeColor = System.Drawing.Color.White;
            btninicio.Location = new System.Drawing.Point(16, 211);
            btninicio.Name = "btninicio";
            btninicio.Size = new System.Drawing.Size(289, 63);
            btninicio.TabIndex = 21;
            btninicio.Text = "ENTER";
            btninicio.UseVisualStyleBackColor = false;
            btninicio.Click += btninicio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            label1.Location = new System.Drawing.Point(16, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(293, 31);
            label1.TabIndex = 22;
            label1.Text = "Hola! Bienvenido a la web";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            label2.Location = new System.Drawing.Point(69, 167);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(185, 17);
            label2.TabIndex = 23;
            label2.Text = "Presiona el boton para entrar ";
            // 
            // frmPrimero
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(325, 295);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btninicio);
            Name = "frmPrimero";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmPrimero";
            Load += frmPrimero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}