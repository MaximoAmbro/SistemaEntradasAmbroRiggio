namespace Visual
{
    partial class frmHistorial
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            btnVolver.Location = new System.Drawing.Point(11, 441);
            btnVolver.Margin = new System.Windows.Forms.Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(92, 43);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(116, 86, 174);
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridView1.Location = new System.Drawing.Point(88, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new System.Drawing.Size(324, 321);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(116, 86, 174);
            label1.Location = new System.Drawing.Point(14, 9);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(397, 60);
            label1.TabIndex = 28;
            label1.Text = "Historial Compras";
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(501, 495);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ForeColor = System.Drawing.Color.FromArgb(164, 165, 169);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmHistorial";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmHistorial";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}