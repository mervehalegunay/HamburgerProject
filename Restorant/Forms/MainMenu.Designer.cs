﻿namespace Restorant
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            siparişİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            siparişOluşturToolStripMenuItem = new ToolStripMenuItem();
            siparişleriGörüntüleToolStripMenuItem = new ToolStripMenuItem();
            ürünİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            menüEkleToolStripMenuItem = new ToolStripMenuItem();
            ekstraMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparişİşlemleriToolStripMenuItem, ürünİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparişİşlemleriToolStripMenuItem
            // 
            siparişİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparişOluşturToolStripMenuItem, siparişleriGörüntüleToolStripMenuItem });
            siparişİşlemleriToolStripMenuItem.Name = "siparişİşlemleriToolStripMenuItem";
            siparişİşlemleriToolStripMenuItem.Size = new Size(127, 24);
            siparişİşlemleriToolStripMenuItem.Text = "Sipariş İşlemleri";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            siparişOluşturToolStripMenuItem.Size = new Size(226, 26);
            siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            siparişOluşturToolStripMenuItem.Click += siparişOluşturToolStripMenuItem_Click;
            // 
            // siparişleriGörüntüleToolStripMenuItem
            // 
            siparişleriGörüntüleToolStripMenuItem.Name = "siparişleriGörüntüleToolStripMenuItem";
            siparişleriGörüntüleToolStripMenuItem.Size = new Size(226, 26);
            siparişleriGörüntüleToolStripMenuItem.Text = "Siparişleri Görüntüle";
            siparişleriGörüntüleToolStripMenuItem.Click += siparişleriGörüntüleToolStripMenuItem_Click;
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menüEkleToolStripMenuItem, ekstraMalzemeEkleToolStripMenuItem });
            ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            ürünİşlemleriToolStripMenuItem.Size = new Size(114, 24);
            ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // menüEkleToolStripMenuItem
            // 
            menüEkleToolStripMenuItem.Name = "menüEkleToolStripMenuItem";
            menüEkleToolStripMenuItem.Size = new Size(227, 26);
            menüEkleToolStripMenuItem.Text = "Menü Ekle";
            menüEkleToolStripMenuItem.Click += menüEkleToolStripMenuItem_Click;
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            ekstraMalzemeEkleToolStripMenuItem.Size = new Size(227, 26);
            ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            ekstraMalzemeEkleToolStripMenuItem.Click += ekstraMalzemeEkleToolStripMenuItem_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "Burger Restorant";
            Load += MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparişİşlemleriToolStripMenuItem;
        private ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private ToolStripMenuItem siparişleriGörüntüleToolStripMenuItem;
        private ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private ToolStripMenuItem menüEkleToolStripMenuItem;
        private ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}