
namespace XMLWindowsFormsApp
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtSifre = new System.Windows.Forms.TextBox();
      this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
      this.txtSoyadi = new System.Windows.Forms.TextBox();
      this.txtAdi = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnYeni = new System.Windows.Forms.Button();
      this.btnDuzelt = new System.Windows.Forms.Button();
      this.btnSil = new System.Windows.Forms.Button();
      this.btnTamam = new System.Windows.Forms.Button();
      this.btnIptal = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtAdi);
      this.groupBox1.Controls.Add(this.txtSoyadi);
      this.groupBox1.Controls.Add(this.txtKullaniciAdi);
      this.groupBox1.Controls.Add(this.txtSifre);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(2, 23);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(742, 130);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(-1, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(42, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 17);
      this.label2.TabIndex = 0;
      this.label2.Text = "Kullanıcı Adı:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(89, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 17);
      this.label3.TabIndex = 1;
      this.label3.Text = "Şifre:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(386, 42);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(32, 17);
      this.label4.TabIndex = 2;
      this.label4.Text = "Adı:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(386, 88);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(55, 17);
      this.label5.TabIndex = 3;
      this.label5.Text = "Soyadı:";
      // 
      // txtSifre
      // 
      this.txtSifre.Location = new System.Drawing.Point(141, 85);
      this.txtSifre.Name = "txtSifre";
      this.txtSifre.PasswordChar = '*';
      this.txtSifre.Size = new System.Drawing.Size(180, 22);
      this.txtSifre.TabIndex = 4;
      // 
      // txtKullaniciAdi
      // 
      this.txtKullaniciAdi.Location = new System.Drawing.Point(141, 39);
      this.txtKullaniciAdi.Name = "txtKullaniciAdi";
      this.txtKullaniciAdi.Size = new System.Drawing.Size(180, 22);
      this.txtKullaniciAdi.TabIndex = 5;
      // 
      // txtSoyadi
      // 
      this.txtSoyadi.Location = new System.Drawing.Point(466, 85);
      this.txtSoyadi.Name = "txtSoyadi";
      this.txtSoyadi.Size = new System.Drawing.Size(180, 22);
      this.txtSoyadi.TabIndex = 6;
      // 
      // txtAdi
      // 
      this.txtAdi.Location = new System.Drawing.Point(466, 39);
      this.txtAdi.Name = "txtAdi";
      this.txtAdi.Size = new System.Drawing.Size(180, 22);
      this.txtAdi.TabIndex = 7;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnIptal);
      this.groupBox2.Controls.Add(this.btnTamam);
      this.groupBox2.Controls.Add(this.btnSil);
      this.groupBox2.Controls.Add(this.btnDuzelt);
      this.groupBox2.Controls.Add(this.btnYeni);
      this.groupBox2.Location = new System.Drawing.Point(2, 159);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(786, 98);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "İşlemler";
      // 
      // btnYeni
      // 
      this.btnYeni.Location = new System.Drawing.Point(12, 37);
      this.btnYeni.Name = "btnYeni";
      this.btnYeni.Size = new System.Drawing.Size(102, 36);
      this.btnYeni.TabIndex = 0;
      this.btnYeni.Text = "Yeni";
      this.btnYeni.UseVisualStyleBackColor = true;
      this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
      // 
      // btnDuzelt
      // 
      this.btnDuzelt.Location = new System.Drawing.Point(153, 37);
      this.btnDuzelt.Name = "btnDuzelt";
      this.btnDuzelt.Size = new System.Drawing.Size(102, 36);
      this.btnDuzelt.TabIndex = 1;
      this.btnDuzelt.Text = "Düzelt";
      this.btnDuzelt.UseVisualStyleBackColor = true;
      this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
      // 
      // btnSil
      // 
      this.btnSil.Location = new System.Drawing.Point(290, 37);
      this.btnSil.Name = "btnSil";
      this.btnSil.Size = new System.Drawing.Size(102, 36);
      this.btnSil.TabIndex = 2;
      this.btnSil.Text = "Sil";
      this.btnSil.UseVisualStyleBackColor = true;
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnTamam
      // 
      this.btnTamam.Location = new System.Drawing.Point(500, 37);
      this.btnTamam.Name = "btnTamam";
      this.btnTamam.Size = new System.Drawing.Size(146, 36);
      this.btnTamam.TabIndex = 3;
      this.btnTamam.Text = "Tamam ve Kaydet";
      this.btnTamam.UseVisualStyleBackColor = true;
      this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
      // 
      // btnIptal
      // 
      this.btnIptal.Location = new System.Drawing.Point(660, 37);
      this.btnIptal.Name = "btnIptal";
      this.btnIptal.Size = new System.Drawing.Size(102, 36);
      this.btnIptal.TabIndex = 3;
      this.btnIptal.Text = "İptal";
      this.btnIptal.UseVisualStyleBackColor = true;
      this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.dataGridView1);
      this.groupBox3.Location = new System.Drawing.Point(2, 263);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(904, 285);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Kayıtlar";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(3, 21);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(895, 258);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(918, 560);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Kullanıcı Formu";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtAdi;
    private System.Windows.Forms.TextBox txtSoyadi;
    private System.Windows.Forms.TextBox txtKullaniciAdi;
    private System.Windows.Forms.TextBox txtSifre;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnIptal;
    private System.Windows.Forms.Button btnTamam;
    private System.Windows.Forms.Button btnSil;
    private System.Windows.Forms.Button btnDuzelt;
    private System.Windows.Forms.Button btnYeni;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}

