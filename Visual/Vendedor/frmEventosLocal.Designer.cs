namespace Visual
{
    partial class frmEventosLocal
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
            btnNuevoEventoLocal = new System.Windows.Forms.Button();
            dgvLocales = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            btnVolver = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvLocales).BeginInit();
            SuspendLayout();
            // 
            // btnNuevoEventoLocal
            // 
            btnNuevoEventoLocal.BackColor = System.Drawing.Color.FromArgb(116, 86, 174);
            btnNuevoEventoLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNuevoEventoLocal.FlatAppearance.BorderSize = 0;
            btnNuevoEventoLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNuevoEventoLocal.ForeColor = System.Drawing.Color.White;
            btnNuevoEventoLocal.Location = new System.Drawing.Point(279, 348);
            btnNuevoEventoLocal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            btnNuevoEventoLocal.Name = "btnNuevoEventoLocal";
            btnNuevoEventoLocal.Size = new System.Drawing.Size(215, 42);
            btnNuevoEventoLocal.TabIndex = 45;
            btnNuevoEventoLocal.Text = "Nuevo evento";
            btnNuevoEventoLocal.UseVisualStyleBackColor = false;
            btnNuevoEventoLocal.Click += btnNuevoEventoLocal_Click;
            // 
            // dgvLocales
            // 
            dgvLocales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLocales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvLocales.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dgvLocales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocales.Cursor = System.Windows.Forms.Cursors.Hand;
            dgvLocales.Location = new System.Drawing.Point(8, 109);
            dgvLocales.Name = "dgvLocales";
            dgvLocales.RowHeadersWidth = 51;
            dgvLocales.Size = new System.Drawing.Size(876, 233);
            dgvLocales.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Nirmala UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
            label2.Location = new System.Drawing.Point(138, 9);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(233, 62);
            label2.TabIndex = 43;
            label2.Text = "EVENTOS";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.White;
            btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVolver.ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            btnVolver.Location = new System.Drawing.Point(326, 395);
            btnVolver.Margin = new System.Windows.Forms.Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(121, 33);
            btnVolver.TabIndex = 42;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Nirmala UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
            label1.Location = new System.Drawing.Point(390, 9);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(422, 62);
            label1.TabIndex = 46;
            label1.Text = "[NOMBRE LOCAL]";
            // 
            // frmEventosLocal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(893, 438);
            Controls.Add(label1);
            Controls.Add(btnNuevoEventoLocal);
            Controls.Add(dgvLocales);
            Controls.Add(label2);
            Controls.Add(btnVolver);
            Name = "frmEventosLocal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "EventosLocal";
            ((System.ComponentModel.ISupportInitialize)dgvLocales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnNuevoEventoLocal;
        private System.Windows.Forms.DataGridView dgvLocales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
    }
}