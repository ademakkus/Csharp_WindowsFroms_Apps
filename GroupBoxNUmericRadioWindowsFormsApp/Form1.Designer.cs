
namespace GroupBoxNUmericRadioWindowsFormsApp
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
      this.nuYas = new System.Windows.Forms.NumericUpDown();
      this.rbKadin = new System.Windows.Forms.RadioButton();
      this.rbErkek = new System.Windows.Forms.RadioButton();
      this.txtAdSoyad = new System.Windows.Forms.TextBox();
      this.txtNumara = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnIzinver = new System.Windows.Forms.Button();
      this.rbArkaPlanRengi = new System.Windows.Forms.RadioButton();
      this.rbYaziRengi = new System.Windows.Forms.RadioButton();
      this.btnRenkDegistir = new System.Windows.Forms.Button();
      this.btnMesajVer = new System.Windows.Forms.Button();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nuYas)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.nuYas);
      this.groupBox1.Controls.Add(this.rbKadin);
      this.groupBox1.Controls.Add(this.rbErkek);
      this.groupBox1.Controls.Add(this.txtAdSoyad);
      this.groupBox1.Controls.Add(this.txtNumara);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(-3, 8);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(803, 170);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Kişi Bilgileri";
      this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
      // 
      // nuYas
      // 
      this.nuYas.Location = new System.Drawing.Point(103, 128);
      this.nuYas.Name = "nuYas";
      this.nuYas.Size = new System.Drawing.Size(120, 22);
      this.nuYas.TabIndex = 8;
      // 
      // rbKadin
      // 
      this.rbKadin.AutoSize = true;
      this.rbKadin.Location = new System.Drawing.Point(191, 96);
      this.rbKadin.Name = "rbKadin";
      this.rbKadin.Size = new System.Drawing.Size(65, 21);
      this.rbKadin.TabIndex = 7;
      this.rbKadin.TabStop = true;
      this.rbKadin.Text = "Kadın";
      this.rbKadin.UseVisualStyleBackColor = true;
      // 
      // rbErkek
      // 
      this.rbErkek.AutoSize = true;
      this.rbErkek.Location = new System.Drawing.Point(103, 96);
      this.rbErkek.Name = "rbErkek";
      this.rbErkek.Size = new System.Drawing.Size(65, 21);
      this.rbErkek.TabIndex = 6;
      this.rbErkek.TabStop = true;
      this.rbErkek.Text = "Erkek";
      this.rbErkek.UseVisualStyleBackColor = true;
      // 
      // txtAdSoyad
      // 
      this.txtAdSoyad.Location = new System.Drawing.Point(103, 64);
      this.txtAdSoyad.Name = "txtAdSoyad";
      this.txtAdSoyad.Size = new System.Drawing.Size(177, 22);
      this.txtAdSoyad.TabIndex = 5;
      this.txtAdSoyad.Enter += new System.EventHandler(this.txtNumara_Enter);
      this.txtAdSoyad.Leave += new System.EventHandler(this.txtNumara_Leave);
      // 
      // txtNumara
      // 
      this.txtNumara.Location = new System.Drawing.Point(103, 31);
      this.txtNumara.Name = "txtNumara";
      this.txtNumara.Size = new System.Drawing.Size(177, 22);
      this.txtNumara.TabIndex = 4;
      this.txtNumara.Enter += new System.EventHandler(this.txtNumara_Enter);
      this.txtNumara.Leave += new System.EventHandler(this.txtNumara_Leave);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(56, 131);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(32, 17);
      this.label4.TabIndex = 3;
      this.label4.Text = "Yaş";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(31, 98);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 17);
      this.label3.TabIndex = 2;
      this.label3.Text = "Cinsiyet";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(0, 67);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Ad ve Soyad";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(30, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Numara";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnIzinver);
      this.groupBox2.Controls.Add(this.rbArkaPlanRengi);
      this.groupBox2.Controls.Add(this.rbYaziRengi);
      this.groupBox2.Controls.Add(this.btnRenkDegistir);
      this.groupBox2.Controls.Add(this.btnMesajVer);
      this.groupBox2.Location = new System.Drawing.Point(2, 182);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(786, 256);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "İşlemler";
      // 
      // btnIzinver
      // 
      this.btnIzinver.Location = new System.Drawing.Point(10, 36);
      this.btnIzinver.Name = "btnIzinver";
      this.btnIzinver.Size = new System.Drawing.Size(114, 37);
      this.btnIzinver.TabIndex = 4;
      this.btnIzinver.Text = "İzin Ver";
      this.btnIzinver.UseVisualStyleBackColor = true;
      this.btnIzinver.Click += new System.EventHandler(this.btnIzinver_Click);
      // 
      // rbArkaPlanRengi
      // 
      this.rbArkaPlanRengi.AutoSize = true;
      this.rbArkaPlanRengi.Location = new System.Drawing.Point(557, 77);
      this.rbArkaPlanRengi.Name = "rbArkaPlanRengi";
      this.rbArkaPlanRengi.Size = new System.Drawing.Size(126, 21);
      this.rbArkaPlanRengi.TabIndex = 3;
      this.rbArkaPlanRengi.TabStop = true;
      this.rbArkaPlanRengi.Text = "Arkaplan Rengi";
      this.rbArkaPlanRengi.UseVisualStyleBackColor = true;
      // 
      // rbYaziRengi
      // 
      this.rbYaziRengi.AutoSize = true;
      this.rbYaziRengi.Location = new System.Drawing.Point(424, 77);
      this.rbYaziRengi.Name = "rbYaziRengi";
      this.rbYaziRengi.Size = new System.Drawing.Size(97, 21);
      this.rbYaziRengi.TabIndex = 2;
      this.rbYaziRengi.TabStop = true;
      this.rbYaziRengi.Text = "Yazı Rengi";
      this.rbYaziRengi.UseVisualStyleBackColor = true;
      // 
      // btnRenkDegistir
      // 
      this.btnRenkDegistir.Location = new System.Drawing.Point(455, 122);
      this.btnRenkDegistir.Name = "btnRenkDegistir";
      this.btnRenkDegistir.Size = new System.Drawing.Size(114, 37);
      this.btnRenkDegistir.TabIndex = 1;
      this.btnRenkDegistir.Text = "Renk Değiştir";
      this.btnRenkDegistir.UseVisualStyleBackColor = true;
      this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
      // 
      // btnMesajVer
      // 
      this.btnMesajVer.Location = new System.Drawing.Point(174, 36);
      this.btnMesajVer.Name = "btnMesajVer";
      this.btnMesajVer.Size = new System.Drawing.Size(114, 37);
      this.btnMesajVer.TabIndex = 0;
      this.btnMesajVer.Text = "Mesaj Ver";
      this.btnMesajVer.UseVisualStyleBackColor = true;
      this.btnMesajVer.Click += new System.EventHandler(this.btnMesajVer_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nuYas)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.NumericUpDown nuYas;
    private System.Windows.Forms.RadioButton rbKadin;
    private System.Windows.Forms.RadioButton rbErkek;
    private System.Windows.Forms.TextBox txtAdSoyad;
    private System.Windows.Forms.TextBox txtNumara;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnIzinver;
    private System.Windows.Forms.RadioButton rbArkaPlanRengi;
    private System.Windows.Forms.RadioButton rbYaziRengi;
    private System.Windows.Forms.Button btnRenkDegistir;
    private System.Windows.Forms.Button btnMesajVer;
    private System.Windows.Forms.ColorDialog colorDialog1;
  }
}

