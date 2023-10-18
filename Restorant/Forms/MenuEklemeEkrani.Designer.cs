namespace Restorant
{
    partial class MenuEklemeEkrani
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
            lblMenuEklemeEkrani = new Label();
            btnMenuEklemeEkrani = new Button();
            nudMenuEklemeFiyati = new NumericUpDown();
            txtMenuEklemeAdi = new TextBox();
            lblMenuEklemeFiyati = new Label();
            lblMenuEklemeAdi = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMenuEklemeFiyati).BeginInit();
            SuspendLayout();
            // 
            // lblMenuEklemeEkrani
            // 
            lblMenuEklemeEkrani.AutoSize = true;
            lblMenuEklemeEkrani.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuEklemeEkrani.Location = new Point(24, 26);
            lblMenuEklemeEkrani.Name = "lblMenuEklemeEkrani";
            lblMenuEklemeEkrani.Size = new Size(150, 20);
            lblMenuEklemeEkrani.TabIndex = 11;
            lblMenuEklemeEkrani.Text = "Menü Ekleme Ekranı";
            // 
            // btnMenuEklemeEkrani
            // 
            btnMenuEklemeEkrani.Location = new Point(102, 199);
            btnMenuEklemeEkrani.Name = "btnMenuEklemeEkrani";
            btnMenuEklemeEkrani.Size = new Size(131, 37);
            btnMenuEklemeEkrani.TabIndex = 10;
            btnMenuEklemeEkrani.Text = "Ekle";
            btnMenuEklemeEkrani.UseVisualStyleBackColor = true;
            btnMenuEklemeEkrani.Click += btnMenuEklemeEkrani_Click;
            // 
            // nudMenuEklemeFiyati
            // 
            nudMenuEklemeFiyati.Location = new Point(86, 130);
            nudMenuEklemeFiyati.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMenuEklemeFiyati.Name = "nudMenuEklemeFiyati";
            nudMenuEklemeFiyati.Size = new Size(150, 27);
            nudMenuEklemeFiyati.TabIndex = 9;
            // 
            // txtMenuEklemeAdi
            // 
            txtMenuEklemeAdi.Location = new Point(86, 72);
            txtMenuEklemeAdi.Name = "txtMenuEklemeAdi";
            txtMenuEklemeAdi.Size = new Size(150, 27);
            txtMenuEklemeAdi.TabIndex = 8;
            // 
            // lblMenuEklemeFiyati
            // 
            lblMenuEklemeFiyati.AutoSize = true;
            lblMenuEklemeFiyati.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuEklemeFiyati.Location = new Point(24, 130);
            lblMenuEklemeFiyati.Name = "lblMenuEklemeFiyati";
            lblMenuEklemeFiyati.Size = new Size(47, 20);
            lblMenuEklemeFiyati.TabIndex = 7;
            lblMenuEklemeFiyati.Text = "Fiyatı";
            // 
            // lblMenuEklemeAdi
            // 
            lblMenuEklemeAdi.AutoSize = true;
            lblMenuEklemeAdi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuEklemeAdi.Location = new Point(24, 72);
            lblMenuEklemeAdi.Name = "lblMenuEklemeAdi";
            lblMenuEklemeAdi.Size = new Size(33, 20);
            lblMenuEklemeAdi.TabIndex = 6;
            lblMenuEklemeAdi.Text = "Adı";
            // 
            // MenuEklemeEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 328);
            Controls.Add(lblMenuEklemeEkrani);
            Controls.Add(btnMenuEklemeEkrani);
            Controls.Add(nudMenuEklemeFiyati);
            Controls.Add(txtMenuEklemeAdi);
            Controls.Add(lblMenuEklemeFiyati);
            Controls.Add(lblMenuEklemeAdi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEklemeEkrani";
            Text = "MenuEklemeEkrani";
            ((System.ComponentModel.ISupportInitialize)nudMenuEklemeFiyati).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenuEklemeEkrani;
        private Button btnMenuEklemeEkrani;
        private NumericUpDown nudMenuEklemeFiyati;
        private TextBox txtMenuEklemeAdi;
        private Label lblMenuEklemeFiyati;
        private Label lblMenuEklemeAdi;
    }
}