namespace ClientProductWebService
{
    partial class Form1
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
            this.btnUrunGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMusteriGetir = new System.Windows.Forms.Button();
            this.btnTcknSor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunGetir
            // 
            this.btnUrunGetir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUrunGetir.Location = new System.Drawing.Point(12, 25);
            this.btnUrunGetir.Name = "btnUrunGetir";
            this.btnUrunGetir.Size = new System.Drawing.Size(151, 61);
            this.btnUrunGetir.TabIndex = 0;
            this.btnUrunGetir.Text = "Ürünleri Getir";
            this.btnUrunGetir.UseVisualStyleBackColor = false;
            this.btnUrunGetir.Click += new System.EventHandler(this.btnUrunGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnMusteriGetir
            // 
            this.btnMusteriGetir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMusteriGetir.Location = new System.Drawing.Point(434, 25);
            this.btnMusteriGetir.Name = "btnMusteriGetir";
            this.btnMusteriGetir.Size = new System.Drawing.Size(151, 61);
            this.btnMusteriGetir.TabIndex = 2;
            this.btnMusteriGetir.Text = "Müşterileri Getir";
            this.btnMusteriGetir.UseVisualStyleBackColor = false;
            this.btnMusteriGetir.Click += new System.EventHandler(this.btnMusteriGetir_Click);
            // 
            // btnTcknSor
            // 
            this.btnTcknSor.Location = new System.Drawing.Point(226, 25);
            this.btnTcknSor.Name = "btnTcknSor";
            this.btnTcknSor.Size = new System.Drawing.Size(128, 61);
            this.btnTcknSor.TabIndex = 3;
            this.btnTcknSor.Text = "Tckn Sorgula";
            this.btnTcknSor.UseVisualStyleBackColor = true;
            this.btnTcknSor.Click += new System.EventHandler(this.btnTcknSor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 501);
            this.Controls.Add(this.btnTcknSor);
            this.Controls.Add(this.btnMusteriGetir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUrunGetir);
            this.Name = "Form1";
            this.Text = "Ürün Bilgileri Formu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMusteriGetir;
        private System.Windows.Forms.Button btnTcknSor;
    }
}

