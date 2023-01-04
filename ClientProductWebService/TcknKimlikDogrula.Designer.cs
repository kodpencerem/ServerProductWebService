namespace ClientProductWebService
{
    partial class TcknKimlikDogrula
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
            this.lblTckn = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblDogumYili = new System.Windows.Forms.Label();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtDogumYili = new System.Windows.Forms.TextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTckn
            // 
            this.lblTckn.AutoSize = true;
            this.lblTckn.Location = new System.Drawing.Point(122, 89);
            this.lblTckn.Name = "lblTckn";
            this.lblTckn.Size = new System.Drawing.Size(49, 16);
            this.lblTckn.TabIndex = 0;
            this.lblTckn.Text = "TCKN: ";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(122, 138);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(30, 16);
            this.lblAdi.TabIndex = 1;
            this.lblAdi.Text = "Adı:";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(122, 190);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(66, 20);
            this.lblSoyadi.TabIndex = 2;
            this.lblSoyadi.Text = "Soyad: ";
            // 
            // lblDogumYili
            // 
            this.lblDogumYili.AutoSize = true;
            this.lblDogumYili.Location = new System.Drawing.Point(122, 233);
            this.lblDogumYili.Name = "lblDogumYili";
            this.lblDogumYili.Size = new System.Drawing.Size(72, 16);
            this.lblDogumYili.TabIndex = 3;
            this.lblDogumYili.Text = "Doğum Yılı";
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(235, 83);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(249, 22);
            this.txtTckn.TabIndex = 4;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(235, 138);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(249, 22);
            this.txtAdi.TabIndex = 5;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(235, 190);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(249, 22);
            this.txtSoyadi.TabIndex = 6;
            // 
            // txtDogumYili
            // 
            this.txtDogumYili.Location = new System.Drawing.Point(235, 233);
            this.txtDogumYili.Name = "txtDogumYili";
            this.txtDogumYili.Size = new System.Drawing.Size(249, 22);
            this.txtDogumYili.TabIndex = 7;
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(258, 292);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(181, 43);
            this.btnDogrula.TabIndex = 8;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // TcknKimlikDogrula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 380);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.txtDogumYili);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtTckn);
            this.Controls.Add(this.lblDogumYili);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblTckn);
            this.Name = "TcknKimlikDogrula";
            this.Text = "TC Kimlik Numarası Doğrulama Formu";
            this.Load += new System.EventHandler(this.TcknKimlikDogrula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTckn;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblDogumYili;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtDogumYili;
        private System.Windows.Forms.Button btnDogrula;
    }
}