
namespace TabbedPageWindowsFormsApp
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabpageOgrenciBilgileri = new System.Windows.Forms.TabPage();
      this.tabpageDigerBilgiler = new System.Windows.Forms.TabPage();
      this.tabpageIletisim = new System.Windows.Forms.TabPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtNumara = new System.Windows.Forms.TextBox();
      this.txtAdSoyad = new System.Windows.Forms.TextBox();
      this.txtDogumYeri = new System.Windows.Forms.TextBox();
      this.cmbBolum = new System.Windows.Forms.ComboBox();
      this.rdbErkek = new System.Windows.Forms.RadioButton();
      this.rdbKadin = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.lblNumara = new System.Windows.Forms.Label();
      this.lblBolum = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.lblAdSoyad = new System.Windows.Forms.Label();
      this.lblCinsiyet = new System.Windows.Forms.Label();
      this.lblDogumYeri = new System.Windows.Forms.Label();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.tabControl1.SuspendLayout();
      this.tabpageOgrenciBilgileri.SuspendLayout();
      this.tabpageDigerBilgiler.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabpageOgrenciBilgileri);
      this.tabControl1.Controls.Add(this.tabpageDigerBilgiler);
      this.tabControl1.Controls.Add(this.tabpageIletisim);
      this.tabControl1.Location = new System.Drawing.Point(0, 4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(788, 586);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
      // 
      // tabpageOgrenciBilgileri
      // 
      this.tabpageOgrenciBilgileri.BackColor = System.Drawing.Color.CadetBlue;
      this.tabpageOgrenciBilgileri.Controls.Add(this.groupBox1);
      this.tabpageOgrenciBilgileri.Location = new System.Drawing.Point(4, 25);
      this.tabpageOgrenciBilgileri.Name = "tabpageOgrenciBilgileri";
      this.tabpageOgrenciBilgileri.Padding = new System.Windows.Forms.Padding(3);
      this.tabpageOgrenciBilgileri.Size = new System.Drawing.Size(780, 501);
      this.tabpageOgrenciBilgileri.TabIndex = 0;
      this.tabpageOgrenciBilgileri.Text = "Öğrenci Biligleri";
      // 
      // tabpageDigerBilgiler
      // 
      this.tabpageDigerBilgiler.AllowDrop = true;
      this.tabpageDigerBilgiler.BackColor = System.Drawing.Color.FloralWhite;
      this.tabpageDigerBilgiler.Controls.Add(this.groupBox3);
      this.tabpageDigerBilgiler.Controls.Add(this.groupBox2);
      this.tabpageDigerBilgiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      this.tabpageDigerBilgiler.Location = new System.Drawing.Point(4, 25);
      this.tabpageDigerBilgiler.Name = "tabpageDigerBilgiler";
      this.tabpageDigerBilgiler.Padding = new System.Windows.Forms.Padding(3);
      this.tabpageDigerBilgiler.Size = new System.Drawing.Size(780, 557);
      this.tabpageDigerBilgiler.TabIndex = 1;
      this.tabpageDigerBilgiler.Text = "Diğer Bilgiler";
      // 
      // tabpageIletisim
      // 
      this.tabpageIletisim.Location = new System.Drawing.Point(4, 25);
      this.tabpageIletisim.Name = "tabpageIletisim";
      this.tabpageIletisim.Padding = new System.Windows.Forms.Padding(3);
      this.tabpageIletisim.Size = new System.Drawing.Size(780, 501);
      this.tabpageIletisim.TabIndex = 2;
      this.tabpageIletisim.Text = "İletişim";
      this.tabpageIletisim.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rdbKadin);
      this.groupBox1.Controls.Add(this.rdbErkek);
      this.groupBox1.Controls.Add(this.cmbBolum);
      this.groupBox1.Controls.Add(this.txtDogumYeri);
      this.groupBox1.Controls.Add(this.txtAdSoyad);
      this.groupBox1.Controls.Add(this.txtNumara);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox1.ForeColor = System.Drawing.Color.White;
      this.groupBox1.Location = new System.Drawing.Point(5, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(772, 473);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Öğrenci Bilgileri";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(45, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Numara";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(33, 96);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Ad Soyad";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(56, 146);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Bölüm";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(44, 196);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(69, 20);
      this.label4.TabIndex = 4;
      this.label4.Text = "Cinsiyet";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(35, 246);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(97, 20);
      this.label5.TabIndex = 5;
      this.label5.Text = "Doğum Yeri";
      // 
      // txtNumara
      // 
      this.txtNumara.Location = new System.Drawing.Point(139, 43);
      this.txtNumara.Name = "txtNumara";
      this.txtNumara.Size = new System.Drawing.Size(316, 26);
      this.txtNumara.TabIndex = 7;
      // 
      // txtAdSoyad
      // 
      this.txtAdSoyad.Location = new System.Drawing.Point(139, 93);
      this.txtAdSoyad.Name = "txtAdSoyad";
      this.txtAdSoyad.Size = new System.Drawing.Size(316, 26);
      this.txtAdSoyad.TabIndex = 8;
      // 
      // txtDogumYeri
      // 
      this.txtDogumYeri.Location = new System.Drawing.Point(139, 243);
      this.txtDogumYeri.Name = "txtDogumYeri";
      this.txtDogumYeri.Size = new System.Drawing.Size(316, 26);
      this.txtDogumYeri.TabIndex = 9;
      // 
      // cmbBolum
      // 
      this.cmbBolum.FormattingEnabled = true;
      this.cmbBolum.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği",
            "Bilgisayar Öğretmenliği",
            "Yazılım Mühendisliği"});
      this.cmbBolum.Location = new System.Drawing.Point(138, 142);
      this.cmbBolum.Name = "cmbBolum";
      this.cmbBolum.Size = new System.Drawing.Size(316, 28);
      this.cmbBolum.TabIndex = 10;
      // 
      // rdbErkek
      // 
      this.rdbErkek.AutoSize = true;
      this.rdbErkek.Location = new System.Drawing.Point(138, 194);
      this.rdbErkek.Name = "rdbErkek";
      this.rdbErkek.Size = new System.Drawing.Size(72, 24);
      this.rdbErkek.TabIndex = 11;
      this.rdbErkek.TabStop = true;
      this.rdbErkek.Text = "Erkek";
      this.rdbErkek.UseVisualStyleBackColor = true;
      // 
      // rdbKadin
      // 
      this.rdbKadin.AutoSize = true;
      this.rdbKadin.Location = new System.Drawing.Point(329, 194);
      this.rdbKadin.Name = "rdbKadin";
      this.rdbKadin.Size = new System.Drawing.Size(72, 24);
      this.rdbKadin.TabIndex = 12;
      this.rdbKadin.TabStop = true;
      this.rdbKadin.Text = "Kadın";
      this.rdbKadin.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lblDogumYeri);
      this.groupBox2.Controls.Add(this.lblCinsiyet);
      this.groupBox2.Controls.Add(this.lblBolum);
      this.groupBox2.Controls.Add(this.lblAdSoyad);
      this.groupBox2.Controls.Add(this.lblNumara);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(780, 157);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.checkBox3);
      this.groupBox3.Controls.Add(this.checkBox4);
      this.groupBox3.Controls.Add(this.comboBox1);
      this.groupBox3.Controls.Add(this.listBox2);
      this.groupBox3.Controls.Add(this.listBox1);
      this.groupBox3.Controls.Add(this.checkBox2);
      this.groupBox3.Controls.Add(this.checkBox1);
      this.groupBox3.Controls.Add(this.label13);
      this.groupBox3.Controls.Add(this.label12);
      this.groupBox3.Controls.Add(this.label11);
      this.groupBox3.Controls.Add(this.label10);
      this.groupBox3.Controls.Add(this.label9);
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.groupBox3.Location = new System.Drawing.Point(0, 163);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(774, 398);
      this.groupBox3.TabIndex = 1;
      this.groupBox3.TabStop = false;
      // 
      // lblNumara
      // 
      this.lblNumara.AutoSize = true;
      this.lblNumara.Location = new System.Drawing.Point(3, 18);
      this.lblNumara.Name = "lblNumara";
      this.lblNumara.Size = new System.Drawing.Size(69, 20);
      this.lblNumara.TabIndex = 0;
      this.lblNumara.Text = "Okul No";
      // 
      // lblBolum
      // 
      this.lblBolum.AutoSize = true;
      this.lblBolum.Location = new System.Drawing.Point(8, 67);
      this.lblBolum.Name = "lblBolum";
      this.lblBolum.Size = new System.Drawing.Size(57, 20);
      this.lblBolum.TabIndex = 1;
      this.lblBolum.Text = "Bölüm";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(37, 31);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(103, 20);
      this.label9.TabIndex = 0;
      this.label9.Text = "Harç Kredisi";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(10, 86);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(130, 20);
      this.label10.TabIndex = 1;
      this.label10.Text = "Öğrenim Kredisi";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(8, 141);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(92, 20);
      this.label11.TabIndex = 2;
      this.label11.Text = "İkamet Yeri";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(8, 172);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(122, 20);
      this.label12.TabIndex = 2;
      this.label12.Text = "Tanımlı Hobiler";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(261, 184);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(63, 20);
      this.label13.TabIndex = 3;
      this.label13.Text = "Hobiler";
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Location = new System.Drawing.Point(148, 29);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(87, 24);
      this.checkBox1.TabIndex = 4;
      this.checkBox1.Text = "Almıyor";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Checked = true;
      this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox2.Location = new System.Drawing.Point(148, 84);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(87, 24);
      this.checkBox2.TabIndex = 5;
      this.checkBox2.Text = "Almıyor";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Items.AddRange(new object[] {
            "Yüzme",
            "Futbol",
            "Sinema",
            "Kitap",
            "Oryantring"});
      this.listBox1.Location = new System.Drawing.Point(12, 211);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(142, 124);
      this.listBox1.TabIndex = 6;
      this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.ItemHeight = 20;
      this.listBox2.Location = new System.Drawing.Point(245, 211);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(142, 124);
      this.listBox2.TabIndex = 7;
      this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(156, 141);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(221, 28);
      this.comboBox1.TabIndex = 8;
      // 
      // lblAdSoyad
      // 
      this.lblAdSoyad.AutoSize = true;
      this.lblAdSoyad.Location = new System.Drawing.Point(6, 47);
      this.lblAdSoyad.Name = "lblAdSoyad";
      this.lblAdSoyad.Size = new System.Drawing.Size(80, 20);
      this.lblAdSoyad.TabIndex = 0;
      this.lblAdSoyad.Text = "Ad Soyad";
      // 
      // lblCinsiyet
      // 
      this.lblCinsiyet.AutoSize = true;
      this.lblCinsiyet.Location = new System.Drawing.Point(10, 87);
      this.lblCinsiyet.Name = "lblCinsiyet";
      this.lblCinsiyet.Size = new System.Drawing.Size(69, 20);
      this.lblCinsiyet.TabIndex = 1;
      this.lblCinsiyet.Text = "Cinsiyet";
      // 
      // lblDogumYeri
      // 
      this.lblDogumYeri.AutoSize = true;
      this.lblDogumYeri.Location = new System.Drawing.Point(10, 118);
      this.lblDogumYeri.Name = "lblDogumYeri";
      this.lblDogumYeri.Size = new System.Drawing.Size(97, 20);
      this.lblDogumYeri.TabIndex = 1;
      this.lblDogumYeri.Text = "Doğum Yeri";
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new System.Drawing.Point(14, 341);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(74, 24);
      this.checkBox3.TabIndex = 2;
      this.checkBox3.Text = "Sırala";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new System.Drawing.Point(250, 341);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(74, 24);
      this.checkBox4.TabIndex = 3;
      this.checkBox4.Text = "Sırala";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 602);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabpageOgrenciBilgileri.ResumeLayout(false);
      this.tabpageDigerBilgiler.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabpageOgrenciBilgileri;
    private System.Windows.Forms.TabPage tabpageDigerBilgiler;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rdbKadin;
    private System.Windows.Forms.RadioButton rdbErkek;
    private System.Windows.Forms.ComboBox cmbBolum;
    private System.Windows.Forms.TextBox txtDogumYeri;
    private System.Windows.Forms.TextBox txtAdSoyad;
    private System.Windows.Forms.TextBox txtNumara;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TabPage tabpageIletisim;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label lblBolum;
    private System.Windows.Forms.Label lblNumara;
    private System.Windows.Forms.Label lblAdSoyad;
    private System.Windows.Forms.Label lblCinsiyet;
    private System.Windows.Forms.Label lblDogumYeri;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;
  }
}

