namespace Kovid_Imenik
{
    partial class KorigujSifru
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonMinimiziraj = new System.Windows.Forms.Button();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSifraPonovo = new System.Windows.Forms.TextBox();
            this.textBoxSifraKor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonKorigujKor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonKorigujKor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxSifraPonovo);
            this.panel1.Controls.Add(this.textBoxSifraKor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.buttonMinimiziraj);
            this.panel3.Controls.Add(this.buttonZatvori);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 64);
            this.panel3.TabIndex = 3;
            // 
            // buttonMinimiziraj
            // 
            this.buttonMinimiziraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonMinimiziraj.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimiziraj.Location = new System.Drawing.Point(347, 0);
            this.buttonMinimiziraj.Name = "buttonMinimiziraj";
            this.buttonMinimiziraj.Size = new System.Drawing.Size(64, 64);
            this.buttonMinimiziraj.TabIndex = 2;
            this.buttonMinimiziraj.Text = "-";
            this.buttonMinimiziraj.UseVisualStyleBackColor = false;
            this.buttonMinimiziraj.Click += new System.EventHandler(this.buttonMinimiziraj_Click);
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonZatvori.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZatvori.Location = new System.Drawing.Point(417, 0);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(70, 64);
            this.buttonZatvori.TabIndex = 1;
            this.buttonZatvori.Text = "X";
            this.buttonZatvori.UseVisualStyleBackColor = false;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 38);
            this.label6.TabIndex = 16;
            this.label6.Text = "Šifra ponovo:";
            // 
            // textBoxSifraPonovo
            // 
            this.textBoxSifraPonovo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSifraPonovo.Location = new System.Drawing.Point(250, 207);
            this.textBoxSifraPonovo.Name = "textBoxSifraPonovo";
            this.textBoxSifraPonovo.Size = new System.Drawing.Size(220, 43);
            this.textBoxSifraPonovo.TabIndex = 15;
            // 
            // textBoxSifraKor
            // 
            this.textBoxSifraKor.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSifraKor.Location = new System.Drawing.Point(250, 132);
            this.textBoxSifraKor.Name = "textBoxSifraKor";
            this.textBoxSifraKor.Size = new System.Drawing.Size(220, 43);
            this.textBoxSifraKor.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "Šifra:";
            // 
            // buttonKorigujKor
            // 
            this.buttonKorigujKor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonKorigujKor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKorigujKor.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKorigujKor.Location = new System.Drawing.Point(76, 306);
            this.buttonKorigujKor.Name = "buttonKorigujKor";
            this.buttonKorigujKor.Size = new System.Drawing.Size(338, 87);
            this.buttonKorigujKor.TabIndex = 17;
            this.buttonKorigujKor.Text = "Koriguj svoje podatke";
            this.buttonKorigujKor.UseVisualStyleBackColor = false;
            this.buttonKorigujKor.Click += new System.EventHandler(this.buttonKorigujKor_Click);
            // 
            // KorigujSifru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KorigujSifru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KorigujSifru";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonMinimiziraj;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSifraPonovo;
        private System.Windows.Forms.TextBox textBoxSifraKor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonKorigujKor;
    }
}