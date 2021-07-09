
namespace XMLWindowsFormsApp
{
  partial class frmGiris
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
      this.txtSifre = new System.Windows.Forms.TextBox();
      this.btnGiris = new System.Windows.Forms.Button();
      this.btnCikis = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(40, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Kullanıcı Adı";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(87, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Şifre";
      // 
      // txtKullaniciAdi
      // 
      this.txtKullaniciAdi.Location = new System.Drawing.Point(128, 19);
      this.txtKullaniciAdi.Name = "txtKullaniciAdi";
      this.txtKullaniciAdi.Size = new System.Drawing.Size(138, 22);
      this.txtKullaniciAdi.TabIndex = 2;
      // 
      // txtSifre
      // 
      this.txtSifre.Location = new System.Drawing.Point(128, 55);
      this.txtSifre.Name = "txtSifre";
      this.txtSifre.PasswordChar = '*';
      this.txtSifre.Size = new System.Drawing.Size(138, 22);
      this.txtSifre.TabIndex = 3;
      // 
      // btnGiris
      // 
      this.btnGiris.Location = new System.Drawing.Point(105, 95);
      this.btnGiris.Name = "btnGiris";
      this.btnGiris.Size = new System.Drawing.Size(104, 29);
      this.btnGiris.TabIndex = 4;
      this.btnGiris.Text = "Giriş";
      this.btnGiris.UseVisualStyleBackColor = true;
      this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
      // 
      // btnCikis
      // 
      this.btnCikis.Location = new System.Drawing.Point(248, 95);
      this.btnCikis.Name = "btnCikis";
      this.btnCikis.Size = new System.Drawing.Size(104, 29);
      this.btnCikis.TabIndex = 5;
      this.btnCikis.Text = "Çıkış";
      this.btnCikis.UseVisualStyleBackColor = true;
      this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
      // 
      // frmGiris
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(462, 218);
      this.Controls.Add(this.btnCikis);
      this.Controls.Add(this.btnGiris);
      this.Controls.Add(this.txtSifre);
      this.Controls.Add(this.txtKullaniciAdi);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "frmGiris";
      this.Text = "Kullanıcı Girişi";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtKullaniciAdi;
    private System.Windows.Forms.TextBox txtSifre;
    private System.Windows.Forms.Button btnGiris;
    private System.Windows.Forms.Button btnCikis;
  }
}