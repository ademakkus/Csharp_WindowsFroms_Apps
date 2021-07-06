
namespace RadioGroupBoxButtonWindowsFormsApp
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
      this.rdbEvli = new System.Windows.Forms.RadioButton();
      this.rdbBekar = new System.Windows.Forms.RadioButton();
      this.rdbDul = new System.Windows.Forms.RadioButton();
      this.lblMedeniDurum = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.rdbOrtaOkul = new System.Windows.Forms.RadioButton();
      this.rdbLise = new System.Windows.Forms.RadioButton();
      this.rdbLisans = new System.Windows.Forms.RadioButton();
      this.rdbYuksekLisans = new System.Windows.Forms.RadioButton();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.btnEkle = new System.Windows.Forms.Button();
      this.btnCikar = new System.Windows.Forms.Button();
      this.chbYuzme = new System.Windows.Forms.CheckBox();
      this.chbGezi = new System.Windows.Forms.CheckBox();
      this.chbFutbol = new System.Windows.Forms.CheckBox();
      this.chbKitap = new System.Windows.Forms.CheckBox();
      this.lsbHobiler = new System.Windows.Forms.ListBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lblMedeniDurum);
      this.groupBox1.Controls.Add(this.rdbBekar);
      this.groupBox1.Controls.Add(this.rdbDul);
      this.groupBox1.Controls.Add(this.rdbEvli);
      this.groupBox1.Location = new System.Drawing.Point(12, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(776, 110);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Medeni Durumu";
      // 
      // rdbEvli
      // 
      this.rdbEvli.AutoSize = true;
      this.rdbEvli.Location = new System.Drawing.Point(15, 47);
      this.rdbEvli.Name = "rdbEvli";
      this.rdbEvli.Size = new System.Drawing.Size(51, 21);
      this.rdbEvli.TabIndex = 0;
      this.rdbEvli.TabStop = true;
      this.rdbEvli.Text = "Evli";
      this.rdbEvli.UseVisualStyleBackColor = true;
      this.rdbEvli.CheckedChanged += new System.EventHandler(this.rdbEvli_CheckedChanged);
      // 
      // rdbBekar
      // 
      this.rdbBekar.AutoSize = true;
      this.rdbBekar.Location = new System.Drawing.Point(172, 47);
      this.rdbBekar.Name = "rdbBekar";
      this.rdbBekar.Size = new System.Drawing.Size(66, 21);
      this.rdbBekar.TabIndex = 1;
      this.rdbBekar.TabStop = true;
      this.rdbBekar.Text = "Bekar";
      this.rdbBekar.UseVisualStyleBackColor = true;
      this.rdbBekar.Click += new System.EventHandler(this.rdbEvli_CheckedChanged);
      // 
      // rdbDul
      // 
      this.rdbDul.AutoSize = true;
      this.rdbDul.Location = new System.Drawing.Point(319, 47);
      this.rdbDul.Name = "rdbDul";
      this.rdbDul.Size = new System.Drawing.Size(50, 21);
      this.rdbDul.TabIndex = 2;
      this.rdbDul.TabStop = true;
      this.rdbDul.Text = "Dul";
      this.rdbDul.UseVisualStyleBackColor = true;
      this.rdbDul.Click += new System.EventHandler(this.rdbEvli_CheckedChanged);
      // 
      // lblMedeniDurum
      // 
      this.lblMedeniDurum.AutoSize = true;
      this.lblMedeniDurum.Location = new System.Drawing.Point(654, 49);
      this.lblMedeniDurum.Name = "lblMedeniDurum";
      this.lblMedeniDurum.Size = new System.Drawing.Size(46, 17);
      this.lblMedeniDurum.TabIndex = 3;
      this.lblMedeniDurum.Text = "label1";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.rdbYuksekLisans);
      this.groupBox2.Controls.Add(this.rdbLisans);
      this.groupBox2.Controls.Add(this.rdbLise);
      this.groupBox2.Controls.Add(this.rdbOrtaOkul);
      this.groupBox2.Location = new System.Drawing.Point(12, 119);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(776, 110);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Öğrenim Durumu";
      // 
      // rdbOrtaOkul
      // 
      this.rdbOrtaOkul.AutoSize = true;
      this.rdbOrtaOkul.Location = new System.Drawing.Point(9, 40);
      this.rdbOrtaOkul.Name = "rdbOrtaOkul";
      this.rdbOrtaOkul.Size = new System.Drawing.Size(90, 21);
      this.rdbOrtaOkul.TabIndex = 0;
      this.rdbOrtaOkul.TabStop = true;
      this.rdbOrtaOkul.Text = "Orta Okul";
      this.rdbOrtaOkul.UseVisualStyleBackColor = true;
      // 
      // rdbLise
      // 
      this.rdbLise.AutoSize = true;
      this.rdbLise.Location = new System.Drawing.Point(138, 21);
      this.rdbLise.Name = "rdbLise";
      this.rdbLise.Size = new System.Drawing.Size(55, 21);
      this.rdbLise.TabIndex = 1;
      this.rdbLise.TabStop = true;
      this.rdbLise.Text = "Lise";
      this.rdbLise.UseVisualStyleBackColor = true;
      // 
      // rdbLisans
      // 
      this.rdbLisans.AutoSize = true;
      this.rdbLisans.Location = new System.Drawing.Point(281, 40);
      this.rdbLisans.Name = "rdbLisans";
      this.rdbLisans.Size = new System.Drawing.Size(70, 21);
      this.rdbLisans.TabIndex = 2;
      this.rdbLisans.TabStop = true;
      this.rdbLisans.Text = "Lisans";
      this.rdbLisans.UseVisualStyleBackColor = true;
      // 
      // rdbYuksekLisans
      // 
      this.rdbYuksekLisans.AutoSize = true;
      this.rdbYuksekLisans.Location = new System.Drawing.Point(458, 40);
      this.rdbYuksekLisans.Name = "rdbYuksekLisans";
      this.rdbYuksekLisans.Size = new System.Drawing.Size(120, 21);
      this.rdbYuksekLisans.TabIndex = 3;
      this.rdbYuksekLisans.TabStop = true;
      this.rdbYuksekLisans.Text = "Yüksek Lisans";
      this.rdbYuksekLisans.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(673, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "label2";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.lsbHobiler);
      this.groupBox3.Controls.Add(this.chbKitap);
      this.groupBox3.Controls.Add(this.chbFutbol);
      this.groupBox3.Controls.Add(this.chbGezi);
      this.groupBox3.Controls.Add(this.chbYuzme);
      this.groupBox3.Controls.Add(this.btnCikar);
      this.groupBox3.Controls.Add(this.btnEkle);
      this.groupBox3.Location = new System.Drawing.Point(2, 250);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(786, 177);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Hobiler";
      // 
      // btnEkle
      // 
      this.btnEkle.Location = new System.Drawing.Point(491, 21);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(97, 35);
      this.btnEkle.TabIndex = 0;
      this.btnEkle.Text = "Ekle";
      this.btnEkle.UseVisualStyleBackColor = true;
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // btnCikar
      // 
      this.btnCikar.Location = new System.Drawing.Point(491, 72);
      this.btnCikar.Name = "btnCikar";
      this.btnCikar.Size = new System.Drawing.Size(97, 26);
      this.btnCikar.TabIndex = 1;
      this.btnCikar.Text = "Çıkar";
      this.btnCikar.UseVisualStyleBackColor = true;
      this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
      // 
      // chbYuzme
      // 
      this.chbYuzme.AutoSize = true;
      this.chbYuzme.Location = new System.Drawing.Point(25, 18);
      this.chbYuzme.Name = "chbYuzme";
      this.chbYuzme.Size = new System.Drawing.Size(73, 21);
      this.chbYuzme.TabIndex = 2;
      this.chbYuzme.Text = "Yüzme";
      this.chbYuzme.UseVisualStyleBackColor = true;
      // 
      // chbGezi
      // 
      this.chbGezi.AutoSize = true;
      this.chbGezi.Location = new System.Drawing.Point(200, 21);
      this.chbGezi.Name = "chbGezi";
      this.chbGezi.Size = new System.Drawing.Size(59, 21);
      this.chbGezi.TabIndex = 3;
      this.chbGezi.Text = "Gezi";
      this.chbGezi.UseVisualStyleBackColor = true;
      // 
      // chbFutbol
      // 
      this.chbFutbol.AutoSize = true;
      this.chbFutbol.Location = new System.Drawing.Point(25, 60);
      this.chbFutbol.Name = "chbFutbol";
      this.chbFutbol.Size = new System.Drawing.Size(69, 21);
      this.chbFutbol.TabIndex = 4;
      this.chbFutbol.Text = "Futbol";
      this.chbFutbol.UseVisualStyleBackColor = true;
      // 
      // chbKitap
      // 
      this.chbKitap.AutoSize = true;
      this.chbKitap.Location = new System.Drawing.Point(200, 60);
      this.chbKitap.Name = "chbKitap";
      this.chbKitap.Size = new System.Drawing.Size(62, 21);
      this.chbKitap.TabIndex = 5;
      this.chbKitap.Text = "Kitap";
      this.chbKitap.UseVisualStyleBackColor = true;
      // 
      // lsbHobiler
      // 
      this.lsbHobiler.Dock = System.Windows.Forms.DockStyle.Right;
      this.lsbHobiler.FormattingEnabled = true;
      this.lsbHobiler.ItemHeight = 16;
      this.lsbHobiler.Location = new System.Drawing.Point(663, 18);
      this.lsbHobiler.Name = "lsbHobiler";
      this.lsbHobiler.Size = new System.Drawing.Size(120, 156);
      this.lsbHobiler.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rdbEvli;
    private System.Windows.Forms.Label lblMedeniDurum;
    private System.Windows.Forms.RadioButton rdbBekar;
    private System.Windows.Forms.RadioButton rdbDul;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RadioButton rdbYuksekLisans;
    private System.Windows.Forms.RadioButton rdbLisans;
    private System.Windows.Forms.RadioButton rdbLise;
    private System.Windows.Forms.RadioButton rdbOrtaOkul;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ListBox lsbHobiler;
    private System.Windows.Forms.CheckBox chbKitap;
    private System.Windows.Forms.CheckBox chbFutbol;
    private System.Windows.Forms.CheckBox chbGezi;
    private System.Windows.Forms.CheckBox chbYuzme;
    private System.Windows.Forms.Button btnCikar;
    private System.Windows.Forms.Button btnEkle;
  }
}

