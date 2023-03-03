using System;

namespace Ders2_ÖğrenciBilgileriKaydetme
{
    partial class OgrenciBilgileri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBVeriMaden = new System.Windows.Forms.CheckBox();
            this.cbVTYS = new System.Windows.Forms.CheckBox();
            this.cbProg2 = new System.Windows.Forms.CheckBox();
            this.cbAlgoritma = new System.Windows.Forms.CheckBox();
            this.cbProg1 = new System.Windows.Forms.CheckBox();
            this.cbGorselPrg = new System.Windows.Forms.CheckBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SecilenAkts = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSecilenDersler = new System.Windows.Forms.ListBox();
            this.lbBolum = new System.Windows.Forms.ListBox();
            this.lbSinif = new System.Windows.Forms.ListBox();
            this.lbNo = new System.Windows.Forms.ListBox();
            this.lbAd = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBVeriMaden);
            this.groupBox1.Controls.Add(this.cbVTYS);
            this.groupBox1.Controls.Add(this.cbProg2);
            this.groupBox1.Controls.Add(this.cbAlgoritma);
            this.groupBox1.Controls.Add(this.cbProg1);
            this.groupBox1.Controls.Add(this.cbGorselPrg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Seçimi";
            // 
            // cBVeriMaden
            // 
            this.cBVeriMaden.AutoSize = true;
            this.cBVeriMaden.Location = new System.Drawing.Point(574, 123);
            this.cBVeriMaden.Name = "cBVeriMaden";
            this.cBVeriMaden.Size = new System.Drawing.Size(150, 24);
            this.cBVeriMaden.TabIndex = 0;
            this.cBVeriMaden.Text = "Veri Madenciliği";
            this.cBVeriMaden.UseVisualStyleBackColor = true;
            this.cBVeriMaden.CheckedChanged += new System.EventHandler(this.cBVeriMaden_CheckedChanged);
            // 
            // cbVTYS
            // 
            this.cbVTYS.AutoSize = true;
            this.cbVTYS.Location = new System.Drawing.Point(26, 123);
            this.cbVTYS.Name = "cbVTYS";
            this.cbVTYS.Size = new System.Drawing.Size(261, 24);
            this.cbVTYS.TabIndex = 0;
            this.cbVTYS.Text = "Veri Tabanı Yönetim Sistemleri";
            this.cbVTYS.UseVisualStyleBackColor = true;
            this.cbVTYS.CheckedChanged += new System.EventHandler(this.cbVTYS_CheckedChanged);
            // 
            // cbProg2
            // 
            this.cbProg2.AutoSize = true;
            this.cbProg2.Location = new System.Drawing.Point(574, 78);
            this.cbProg2.Name = "cbProg2";
            this.cbProg2.Size = new System.Drawing.Size(194, 24);
            this.cbProg2.TabIndex = 0;
            this.cbProg2.Text = "Programlama Dilleri 2";
            this.cbProg2.UseVisualStyleBackColor = true;
            this.cbProg2.CheckedChanged += new System.EventHandler(this.cbProg2_CheckedChanged);
            // 
            // cbAlgoritma
            // 
            this.cbAlgoritma.AutoSize = true;
            this.cbAlgoritma.Location = new System.Drawing.Point(26, 78);
            this.cbAlgoritma.Name = "cbAlgoritma";
            this.cbAlgoritma.Size = new System.Drawing.Size(234, 24);
            this.cbAlgoritma.TabIndex = 0;
            this.cbAlgoritma.Text = " Algoritma ve Programlama";
            this.cbAlgoritma.UseVisualStyleBackColor = true;
            this.cbAlgoritma.CheckedChanged += new System.EventHandler(this.cbAlgoritma_CheckedChanged);
            // 
            // cbProg1
            // 
            this.cbProg1.AutoSize = true;
            this.cbProg1.Location = new System.Drawing.Point(574, 38);
            this.cbProg1.Name = "cbProg1";
            this.cbProg1.Size = new System.Drawing.Size(194, 24);
            this.cbProg1.TabIndex = 0;
            this.cbProg1.Text = "Programlama Dilleri 1";
            this.cbProg1.UseVisualStyleBackColor = true;
            this.cbProg1.CheckedChanged += new System.EventHandler(this.cbProg1_CheckedChanged);
            // 
            // cbGorselPrg
            // 
            this.cbGorselPrg.AutoSize = true;
            this.cbGorselPrg.Location = new System.Drawing.Point(26, 38);
            this.cbGorselPrg.Name = "cbGorselPrg";
            this.cbGorselPrg.Size = new System.Drawing.Size(186, 24);
            this.cbGorselPrg.TabIndex = 0;
            this.cbGorselPrg.Text = "Görsel Programlama";
            this.cbGorselPrg.UseVisualStyleBackColor = true;
            this.cbGorselPrg.CheckedChanged += new System.EventHandler(this.cbGorselPrg_CheckedChanged);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(63, 227);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(131, 52);
            this.btnDersEkle.TabIndex = 1;
            this.btnDersEkle.Text = " Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(359, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seçilen AKTS:";
            // 
            // SecilenAkts
            // 
            this.SecilenAkts.AutoSize = true;
            this.SecilenAkts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SecilenAkts.Location = new System.Drawing.Point(499, 243);
            this.SecilenAkts.Name = "SecilenAkts";
            this.SecilenAkts.Size = new System.Drawing.Size(21, 22);
            this.SecilenAkts.TabIndex = 3;
            this.SecilenAkts.Text = "0";
            this.SecilenAkts.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSecilenDersler);
            this.groupBox2.Controls.Add(this.lbBolum);
            this.groupBox2.Controls.Add(this.lbSinif);
            this.groupBox2.Controls.Add(this.lbNo);
            this.groupBox2.Controls.Add(this.lbAd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(37, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1025, 254);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Ders Seçimi";
            // 
            // lbSecilenDersler
            // 
            this.lbSecilenDersler.FormattingEnabled = true;
            this.lbSecilenDersler.ItemHeight = 20;
            this.lbSecilenDersler.Location = new System.Drawing.Point(729, 74);
            this.lbSecilenDersler.Name = "lbSecilenDersler";
            this.lbSecilenDersler.Size = new System.Drawing.Size(227, 144);
            this.lbSecilenDersler.TabIndex = 8;
            // 
            // lbBolum
            // 
            this.lbBolum.FormattingEnabled = true;
            this.lbBolum.ItemHeight = 20;
            this.lbBolum.Location = new System.Drawing.Point(539, 74);
            this.lbBolum.Name = "lbBolum";
            this.lbBolum.Size = new System.Drawing.Size(142, 144);
            this.lbBolum.TabIndex = 8;
            // 
            // lbSinif
            // 
            this.lbSinif.FormattingEnabled = true;
            this.lbSinif.ItemHeight = 20;
            this.lbSinif.Location = new System.Drawing.Point(357, 74);
            this.lbSinif.Name = "lbSinif";
            this.lbSinif.Size = new System.Drawing.Size(139, 144);
            this.lbSinif.TabIndex = 8;
            // 
            // lbNo
            // 
            this.lbNo.FormattingEnabled = true;
            this.lbNo.ItemHeight = 20;
            this.lbNo.Location = new System.Drawing.Point(198, 74);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(128, 144);
            this.lbNo.TabIndex = 8;
            // 
            // lbAd
            // 
            this.lbAd.FormattingEnabled = true;
            this.lbAd.ItemHeight = 20;
            this.lbAd.Location = new System.Drawing.Point(37, 74);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(138, 144);
            this.lbAd.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Seçilen Dersler:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bölüm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sınıf:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numara:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ado Soyadı:";
            // 
            // OgrenciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1090, 602);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SecilenAkts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "OgrenciBilgileri";
            this.Text = "OgrenciBilgileri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBVeriMaden;
        private System.Windows.Forms.CheckBox cbVTYS;
        private System.Windows.Forms.CheckBox cbProg2;
        private System.Windows.Forms.CheckBox cbAlgoritma;
        private System.Windows.Forms.CheckBox cbProg1;
        private System.Windows.Forms.CheckBox cbGorselPrg;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SecilenAkts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox lbSecilenDersler;
        public System.Windows.Forms.ListBox lbBolum;
        public System.Windows.Forms.ListBox lbSinif;
        public System.Windows.Forms.ListBox lbNo;
        public System.Windows.Forms.ListBox lbAd;
    }
}