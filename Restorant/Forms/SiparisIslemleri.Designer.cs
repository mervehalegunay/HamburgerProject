namespace Restorant
{
    partial class SiparisIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisIslemleri));
            pictureBox1 = new PictureBox();
            lblMenuSeciniz = new Label();
            cboxMenuSeciniz = new ComboBox();
            lblEkstraMalzemeSeciniz = new Label();
            lblBoyuSeciniz = new Label();
            lblAdet = new Label();
            nudAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            btnSiparisiOnayla = new Button();
            lblToplam = new Label();
            lblGenelToplam = new Label();
            lstBoxSiparisBilgi = new ListBox();
            flwPnlEkstraMalzeme = new FlowLayoutPanel();
            flwPnlMenuBoyu = new FlowLayoutPanel();
            rbKucuk = new RadioButton();
            rbOrta = new RadioButton();
            rbBuyuk = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            flwPnlMenuBoyu.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // lblMenuSeciniz
            // 
            lblMenuSeciniz.AutoSize = true;
            lblMenuSeciniz.Location = new Point(34, 188);
            lblMenuSeciniz.Name = "lblMenuSeciniz";
            lblMenuSeciniz.Size = new Size(100, 20);
            lblMenuSeciniz.TabIndex = 1;
            lblMenuSeciniz.Text = "Menu Seçiniz ";
            // 
            // cboxMenuSeciniz
            // 
            cboxMenuSeciniz.FormattingEnabled = true;
            cboxMenuSeciniz.Location = new Point(34, 221);
            cboxMenuSeciniz.Name = "cboxMenuSeciniz";
            cboxMenuSeciniz.Size = new Size(206, 28);
            cboxMenuSeciniz.TabIndex = 2;
            // 
            // lblEkstraMalzemeSeciniz
            // 
            lblEkstraMalzemeSeciniz.AutoSize = true;
            lblEkstraMalzemeSeciniz.Location = new Point(34, 270);
            lblEkstraMalzemeSeciniz.Name = "lblEkstraMalzemeSeciniz";
            lblEkstraMalzemeSeciniz.Size = new Size(167, 20);
            lblEkstraMalzemeSeciniz.TabIndex = 3;
            lblEkstraMalzemeSeciniz.Text = "Ekstra Malzeme Seçiniz ";
            // 
            // lblBoyuSeciniz
            // 
            lblBoyuSeciniz.AutoSize = true;
            lblBoyuSeciniz.Location = new Point(34, 399);
            lblBoyuSeciniz.Name = "lblBoyuSeciniz";
            lblBoyuSeciniz.Size = new Size(96, 20);
            lblBoyuSeciniz.TabIndex = 6;
            lblBoyuSeciniz.Text = "Boyu Seçiniz ";
            // 
            // lblAdet
            // 
            lblAdet.AutoSize = true;
            lblAdet.Location = new Point(36, 477);
            lblAdet.Name = "lblAdet";
            lblAdet.Size = new Size(41, 20);
            lblAdet.TabIndex = 10;
            lblAdet.Text = "Adet";
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(116, 470);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(150, 27);
            nudAdet.TabIndex = 11;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.BackColor = SystemColors.ControlDark;
            btnSiparisEkle.Location = new Point(37, 531);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(229, 35);
            btnSiparisEkle.TabIndex = 12;
            btnSiparisEkle.Text = "Sipariş Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = false;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // btnSiparisiOnayla
            // 
            btnSiparisiOnayla.BackColor = SystemColors.ControlDark;
            btnSiparisiOnayla.Location = new Point(630, 523);
            btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            btnSiparisiOnayla.Size = new Size(241, 50);
            btnSiparisiOnayla.TabIndex = 13;
            btnSiparisiOnayla.Text = "Siparişi Onayla";
            btnSiparisiOnayla.UseVisualStyleBackColor = false;
            btnSiparisiOnayla.Click += btnSiparisiOnayla_Click;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplam.ForeColor = Color.Black;
            lblToplam.Location = new Point(355, 538);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(93, 31);
            lblToplam.TabIndex = 14;
            lblToplam.Text = "Toplam";
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenelToplam.ForeColor = Color.Red;
            lblGenelToplam.Location = new Point(469, 538);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(59, 31);
            lblGenelToplam.TabIndex = 15;
            lblGenelToplam.Text = "0.00";
            // 
            // lstBoxSiparisBilgi
            // 
            lstBoxSiparisBilgi.FormattingEnabled = true;
            lstBoxSiparisBilgi.ItemHeight = 20;
            lstBoxSiparisBilgi.Location = new Point(298, 38);
            lstBoxSiparisBilgi.Name = "lstBoxSiparisBilgi";
            lstBoxSiparisBilgi.Size = new Size(586, 464);
            lstBoxSiparisBilgi.TabIndex = 16;
            // 
            // flwPnlEkstraMalzeme
            // 
            flwPnlEkstraMalzeme.FlowDirection = FlowDirection.TopDown;
            flwPnlEkstraMalzeme.Location = new Point(34, 293);
            flwPnlEkstraMalzeme.Name = "flwPnlEkstraMalzeme";
            flwPnlEkstraMalzeme.Size = new Size(206, 84);
            flwPnlEkstraMalzeme.TabIndex = 17;
            // 
            // flwPnlMenuBoyu
            // 
            flwPnlMenuBoyu.Controls.Add(rbKucuk);
            flwPnlMenuBoyu.Controls.Add(rbOrta);
            flwPnlMenuBoyu.Controls.Add(rbBuyuk);
            flwPnlMenuBoyu.Location = new Point(37, 426);
            flwPnlMenuBoyu.Name = "flwPnlMenuBoyu";
            flwPnlMenuBoyu.Size = new Size(229, 38);
            flwPnlMenuBoyu.TabIndex = 18;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(3, 3);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(69, 24);
            rbKucuk.TabIndex = 10;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(78, 3);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(59, 24);
            rbOrta.TabIndex = 11;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(143, 3);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(69, 24);
            rbBuyuk.TabIndex = 13;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // SiparisIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 630);
            Controls.Add(flwPnlMenuBoyu);
            Controls.Add(flwPnlEkstraMalzeme);
            Controls.Add(lstBoxSiparisBilgi);
            Controls.Add(lblGenelToplam);
            Controls.Add(lblToplam);
            Controls.Add(btnSiparisiOnayla);
            Controls.Add(btnSiparisEkle);
            Controls.Add(nudAdet);
            Controls.Add(lblAdet);
            Controls.Add(lblBoyuSeciniz);
            Controls.Add(lblEkstraMalzemeSeciniz);
            Controls.Add(cboxMenuSeciniz);
            Controls.Add(lblMenuSeciniz);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisIslemleri";
            Text = "SiparisIslemleri";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            flwPnlMenuBoyu.ResumeLayout(false);
            flwPnlMenuBoyu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblMenuSeciniz;
        private ComboBox cboxMenuSeciniz;
        private Label lblEkstraMalzemeSeciniz;
        private Label lblBoyuSeciniz;
        private Label lblAdet;
        private NumericUpDown nudAdet;
        private Button btnSiparisEkle;
        private Button btnSiparisiOnayla;
        private Label lblToplam;
        private Label lblGenelToplam;
        private ListBox lstBoxSiparisBilgi;
        private FlowLayoutPanel flwPnlEkstraMalzeme;
        private FlowLayoutPanel flwPnlMenuBoyu;
        private RadioButton rbOrta;
        private RadioButton rbKucuk;
        private RadioButton rbBuyuk;
    }
}