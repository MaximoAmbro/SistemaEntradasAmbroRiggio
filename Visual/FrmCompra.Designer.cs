namespace Visual
{
    partial class FrmCompra
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblticketprevia = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblticketgeneral = new System.Windows.Forms.Label();
            this.lblticketvip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxprevia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxgeneral = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxvip = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(9, 460);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(52, 28);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // lblticketprevia
            // 
            this.lblticketprevia.AutoSize = true;
            this.lblticketprevia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblticketprevia.Location = new System.Drawing.Point(16, 132);
            this.lblticketprevia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblticketprevia.Name = "lblticketprevia";
            this.lblticketprevia.Size = new System.Drawing.Size(83, 13);
            this.lblticketprevia.TabIndex = 37;
            this.lblticketprevia.Text = "TICKET PREVIA";
            this.lblticketprevia.Click += new System.EventHandler(this.lblticketprevia_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(44, 392);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 35);
            this.button2.TabIndex = 35;
            this.button2.Text = "COMPRAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 32;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblticketgeneral
            // 
            this.lblticketgeneral.AutoSize = true;
            this.lblticketgeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblticketgeneral.Location = new System.Drawing.Point(16, 208);
            this.lblticketgeneral.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblticketgeneral.Name = "lblticketgeneral";
            this.lblticketgeneral.Size = new System.Drawing.Size(98, 13);
            this.lblticketgeneral.TabIndex = 30;
            this.lblticketgeneral.Text = "TICKET GENERAL ";
            this.lblticketgeneral.Click += new System.EventHandler(this.lblticketgeneral_Click);
            // 
            // lblticketvip
            // 
            this.lblticketvip.AutoSize = true;
            this.lblticketvip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblticketvip.Location = new System.Drawing.Point(16, 291);
            this.lblticketvip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblticketvip.Name = "lblticketvip";
            this.lblticketvip.Size = new System.Drawing.Size(62, 13);
            this.lblticketvip.TabIndex = 28;
            this.lblticketvip.Text = "TICKET VIP";
            this.lblticketvip.Click += new System.EventHandler(this.lblticketvip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Selecciona tickets";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboxprevia
            // 
            this.cboxprevia.FormattingEnabled = true;
            this.cboxprevia.Location = new System.Drawing.Point(24, 171);
            this.cboxprevia.Name = "cboxprevia";
            this.cboxprevia.Size = new System.Drawing.Size(121, 21);
            this.cboxprevia.TabIndex = 38;
            this.cboxprevia.SelectedIndexChanged += new System.EventHandler(this.cboxprevia_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Valido hasta las 00:30hs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboxgeneral
            // 
            this.cboxgeneral.FormattingEnabled = true;
            this.cboxgeneral.Location = new System.Drawing.Point(24, 246);
            this.cboxgeneral.Name = "cboxgeneral";
            this.cboxgeneral.Size = new System.Drawing.Size(121, 21);
            this.cboxgeneral.TabIndex = 40;
            this.cboxgeneral.SelectedIndexChanged += new System.EventHandler(this.cboxgeneral_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Valido hasta la 1:30hs";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Valido hasta las 3:00hs";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboxvip
            // 
            this.cboxvip.FormattingEnabled = true;
            this.cboxvip.Location = new System.Drawing.Point(24, 329);
            this.cboxvip.Name = "cboxvip";
            this.cboxvip.Size = new System.Drawing.Size(121, 21);
            this.cboxvip.TabIndex = 43;
            this.cboxvip.SelectedIndexChanged += new System.EventHandler(this.cboxvip_SelectedIndexChanged);
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 497);
            this.Controls.Add(this.cboxvip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxgeneral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxprevia);
            this.Controls.Add(this.lblticketprevia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblticketgeneral);
            this.Controls.Add(this.lblticketvip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCompra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblticketprevia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblticketgeneral;
        private System.Windows.Forms.Label lblticketvip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxprevia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxgeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxvip;
    }
}