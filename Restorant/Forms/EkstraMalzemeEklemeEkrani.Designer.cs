namespace Restorant
{
    partial class EkstraMalzemeEklemeEkrani
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
            lblEkstraMalzemeAdi = new Label();
            lblEkstraMalzemeFiyati = new Label();
            txtEkstraMalzemeAdi = new TextBox();
            nudEkstraMalzemeFiyati = new NumericUpDown();
            btnEkstraMalzemeEklemeEkrani = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyati).BeginInit();
            SuspendLayout();
            // 
            // lblEkstraMalzemeAdi
            // 
            lblEkstraMalzemeAdi.AutoSize = true;
            lblEkstraMalzemeAdi.Location = new Point(23, 64);
            lblEkstraMalzemeAdi.Name = "lblEkstraMalzemeAdi";
            lblEkstraMalzemeAdi.Size = new Size(32, 20);
            lblEkstraMalzemeAdi.TabIndex = 0;
            lblEkstraMalzemeAdi.Text = "Adı";
            // 
            // lblEkstraMalzemeFiyati
            // 
            lblEkstraMalzemeFiyati.AutoSize = true;
            lblEkstraMalzemeFiyati.Location = new Point(23, 122);
            lblEkstraMalzemeFiyati.Name = "lblEkstraMalzemeFiyati";
            lblEkstraMalzemeFiyati.Size = new Size(44, 20);
            lblEkstraMalzemeFiyati.TabIndex = 1;
            lblEkstraMalzemeFiyati.Text = "Fiyatı";
            // 
            // txtEkstraMalzemeAdi
            // 
            txtEkstraMalzemeAdi.Location = new Point(85, 64);
            txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            txtEkstraMalzemeAdi.Size = new Size(150, 27);
            txtEkstraMalzemeAdi.TabIndex = 2;
            // 
            // nudEkstraMalzemeFiyati
            // 
            nudEkstraMalzemeFiyati.Location = new Point(85, 122);
            nudEkstraMalzemeFiyati.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudEkstraMalzemeFiyati.Name = "nudEkstraMalzemeFiyati";
            nudEkstraMalzemeFiyati.Size = new Size(150, 27);
            nudEkstraMalzemeFiyati.TabIndex = 3;
            // 
            // btnEkstraMalzemeEklemeEkrani
            // 
            btnEkstraMalzemeEklemeEkrani.Location = new Point(101, 191);
            btnEkstraMalzemeEklemeEkrani.Name = "btnEkstraMalzemeEklemeEkrani";
            btnEkstraMalzemeEklemeEkrani.Size = new Size(131, 37);
            btnEkstraMalzemeEklemeEkrani.TabIndex = 4;
            btnEkstraMalzemeEklemeEkrani.Text = "Ekle";
            btnEkstraMalzemeEklemeEkrani.UseVisualStyleBackColor = true;
            btnEkstraMalzemeEklemeEkrani.Click += btnEkstraMalzemeEklemeEkrani_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 5;
            label1.Text = "Ekstra Malzeme Ekleme Ekranı";
            // 
            // EkstraMalzemeEklemeEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 293);
            Controls.Add(label1);
            Controls.Add(btnEkstraMalzemeEklemeEkrani);
            Controls.Add(nudEkstraMalzemeFiyati);
            Controls.Add(txtEkstraMalzemeAdi);
            Controls.Add(lblEkstraMalzemeFiyati);
            Controls.Add(lblEkstraMalzemeAdi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EkstraMalzemeEklemeEkrani";
            Text = "EkstraMalzemeEklemeEkrani";
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyati).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEkstraMalzemeAdi;
        private Label lblEkstraMalzemeFiyati;
        private TextBox txtEkstraMalzemeAdi;
        private NumericUpDown nudEkstraMalzemeFiyati;
        private Button btnEkstraMalzemeEklemeEkrani;
        private Label label1;
    }
}