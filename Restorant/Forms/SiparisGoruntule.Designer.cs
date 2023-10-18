namespace Restorant
{
    partial class SiparisGoruntule
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
            lblAlinanTumSiparisler = new Label();
            lstBoxAlinanTumSiparisler = new ListBox();
            groupBox1 = new GroupBox();
            lblCiro = new Label();
            groupBox5 = new GroupBox();
            lblToplamSiparis = new Label();
            groupBox3 = new GroupBox();
            lblEkstraMalzemeGeliri = new Label();
            groupBox4 = new GroupBox();
            lblSatilanUrunAdedi = new Label();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lblAlinanTumSiparisler
            // 
            lblAlinanTumSiparisler.AutoSize = true;
            lblAlinanTumSiparisler.Location = new Point(41, 30);
            lblAlinanTumSiparisler.Name = "lblAlinanTumSiparisler";
            lblAlinanTumSiparisler.Size = new Size(149, 20);
            lblAlinanTumSiparisler.TabIndex = 0;
            lblAlinanTumSiparisler.Text = "Alınan Tüm Siparişler";
            // 
            // lstBoxAlinanTumSiparisler
            // 
            lstBoxAlinanTumSiparisler.FormattingEnabled = true;
            lstBoxAlinanTumSiparisler.ItemHeight = 20;
            lstBoxAlinanTumSiparisler.Location = new Point(41, 72);
            lstBoxAlinanTumSiparisler.Name = "lstBoxAlinanTumSiparisler";
            lstBoxAlinanTumSiparisler.Size = new Size(595, 344);
            lstBoxAlinanTumSiparisler.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCiro);
            groupBox1.Location = new Point(659, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 77);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(16, 33);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(79, 31);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "label1";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblToplamSiparis);
            groupBox5.Location = new Point(659, 155);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(193, 77);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Toplam Sipariş";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamSiparis.ForeColor = Color.Red;
            lblToplamSiparis.Location = new Point(16, 43);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new Size(79, 31);
            lblToplamSiparis.TabIndex = 0;
            lblToplamSiparis.Text = "label2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblEkstraMalzemeGeliri);
            groupBox3.Location = new Point(659, 238);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(193, 77);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkstraMalzemeGeliri.ForeColor = Color.Red;
            lblEkstraMalzemeGeliri.Location = new Point(16, 43);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.Size = new Size(79, 31);
            lblEkstraMalzemeGeliri.TabIndex = 1;
            lblEkstraMalzemeGeliri.Text = "label3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblSatilanUrunAdedi);
            groupBox4.Location = new Point(659, 321);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(193, 77);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // lblSatilanUrunAdedi
            // 
            lblSatilanUrunAdedi.AutoSize = true;
            lblSatilanUrunAdedi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSatilanUrunAdedi.ForeColor = Color.Red;
            lblSatilanUrunAdedi.Location = new Point(16, 23);
            lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            lblSatilanUrunAdedi.Size = new Size(79, 31);
            lblSatilanUrunAdedi.TabIndex = 2;
            lblSatilanUrunAdedi.Text = "label4";
            // 
            // SiparisleriGoruntule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(lstBoxAlinanTumSiparisler);
            Controls.Add(lblAlinanTumSiparisler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisleriGoruntule";
            Text = "SiparisleriGoruntule";
            Load += SiparisleriGoruntule_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlinanTumSiparisler;
        private ListBox lstBoxAlinanTumSiparisler;
        private GroupBox groupBox1;
        private Label lblCiro;
        private GroupBox groupBox5;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lblToplamSiparis;
        private Label lblEkstraMalzemeGeliri;
        private Label lblSatilanUrunAdedi;
    }
}