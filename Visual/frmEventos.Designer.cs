namespace Visual
{
    partial class frmEventos
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
            label2 = new System.Windows.Forms.Label();
            dgveventos = new System.Windows.Forms.DataGridView();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgveventos).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.White;
            btnVolver.ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            btnVolver.Location = new System.Drawing.Point(11, 410);
            btnVolver.Margin = new System.Windows.Forms.Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(52, 28);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
            label2.Location = new System.Drawing.Point(6, 33);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 34);
            label2.TabIndex = 28;
            label2.Text = "EVENTOS";
            label2.Click += label2_Click;
            // 
            // dgveventos
            // 
            dgveventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgveventos.Location = new System.Drawing.Point(11, 87);
            dgveventos.Name = "dgveventos";
            dgveventos.RowHeadersWidth = 51;
            dgveventos.Size = new System.Drawing.Size(268, 252);
            dgveventos.TabIndex = 29;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(204, 401);
            button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(101, 35);
            button2.TabIndex = 36;
            button2.Text = "COMPRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmEventos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(319, 448);
            Controls.Add(button2);
            Controls.Add(dgveventos);
            Controls.Add(label2);
            Controls.Add(btnVolver);
            Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmEventos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmEventos";
            Load += frmEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgveventos).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgveventos;
        private System.Windows.Forms.Button button2;
    }
}