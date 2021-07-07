
namespace TextFontPropCopyPastWindowsFormsApp
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
      this.txtMetin = new System.Windows.Forms.TextBox();
      this.btnKes = new System.Windows.Forms.Button();
      this.btnKopyala = new System.Windows.Forms.Button();
      this.btnGeriAl = new System.Windows.Forms.Button();
      this.btnYapistir = new System.Windows.Forms.Button();
      this.btnKalinItalik = new System.Windows.Forms.Button();
      this.btnAltiCizili = new System.Windows.Forms.Button();
      this.btnEgik = new System.Windows.Forms.Button();
      this.btnKalin = new System.Windows.Forms.Button();
      this.btnYaziRengi = new System.Windows.Forms.Button();
      this.btnYaziTipi = new System.Windows.Forms.Button();
      this.fontDialog1 = new System.Windows.Forms.FontDialog();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.btnUstuCizili = new System.Windows.Forms.Button();
      this.btnCiftCizgili = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtMetin
      // 
      this.txtMetin.Location = new System.Drawing.Point(0, 0);
      this.txtMetin.Multiline = true;
      this.txtMetin.Name = "txtMetin";
      this.txtMetin.Size = new System.Drawing.Size(640, 310);
      this.txtMetin.TabIndex = 0;
      this.txtMetin.Text = "merhaba C# dünyasına. ";
      // 
      // btnKes
      // 
      this.btnKes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnKes.Location = new System.Drawing.Point(16, 334);
      this.btnKes.Name = "btnKes";
      this.btnKes.Size = new System.Drawing.Size(105, 33);
      this.btnKes.TabIndex = 1;
      this.btnKes.Text = "&Kes";
      this.btnKes.UseVisualStyleBackColor = true;
      this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
      // 
      // btnKopyala
      // 
      this.btnKopyala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnKopyala.Location = new System.Drawing.Point(148, 334);
      this.btnKopyala.Name = "btnKopyala";
      this.btnKopyala.Size = new System.Drawing.Size(105, 33);
      this.btnKopyala.TabIndex = 2;
      this.btnKopyala.Text = "&Kopyala";
      this.btnKopyala.UseVisualStyleBackColor = true;
      this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
      // 
      // btnGeriAl
      // 
      this.btnGeriAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnGeriAl.Location = new System.Drawing.Point(412, 334);
      this.btnGeriAl.Name = "btnGeriAl";
      this.btnGeriAl.Size = new System.Drawing.Size(105, 33);
      this.btnGeriAl.TabIndex = 3;
      this.btnGeriAl.Text = "&Geri Al";
      this.btnGeriAl.UseVisualStyleBackColor = true;
      this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
      // 
      // btnYapistir
      // 
      this.btnYapistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnYapistir.Location = new System.Drawing.Point(280, 334);
      this.btnYapistir.Name = "btnYapistir";
      this.btnYapistir.Size = new System.Drawing.Size(105, 33);
      this.btnYapistir.TabIndex = 4;
      this.btnYapistir.Text = "&Yapıştır";
      this.btnYapistir.UseVisualStyleBackColor = true;
      this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
      // 
      // btnKalinItalik
      // 
      this.btnKalinItalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnKalinItalik.Location = new System.Drawing.Point(662, 362);
      this.btnKalinItalik.Name = "btnKalinItalik";
      this.btnKalinItalik.Size = new System.Drawing.Size(136, 33);
      this.btnKalinItalik.TabIndex = 5;
      this.btnKalinItalik.Text = "Kalın İtalik";
      this.btnKalinItalik.UseVisualStyleBackColor = true;
      this.btnKalinItalik.Click += new System.EventHandler(this.btnKalinItalik_Click);
      // 
      // btnAltiCizili
      // 
      this.btnAltiCizili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnAltiCizili.Location = new System.Drawing.Point(662, 215);
      this.btnAltiCizili.Name = "btnAltiCizili";
      this.btnAltiCizili.Size = new System.Drawing.Size(136, 33);
      this.btnAltiCizili.TabIndex = 6;
      this.btnAltiCizili.Text = "Altı Çizili";
      this.btnAltiCizili.UseVisualStyleBackColor = true;
      this.btnAltiCizili.Click += new System.EventHandler(this.btnAltiCizili_Click);
      // 
      // btnEgik
      // 
      this.btnEgik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnEgik.Location = new System.Drawing.Point(662, 166);
      this.btnEgik.Name = "btnEgik";
      this.btnEgik.Size = new System.Drawing.Size(136, 33);
      this.btnEgik.TabIndex = 7;
      this.btnEgik.Text = "Eğik";
      this.btnEgik.UseVisualStyleBackColor = true;
      this.btnEgik.Click += new System.EventHandler(this.btnEgik_Click);
      // 
      // btnKalin
      // 
      this.btnKalin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnKalin.Location = new System.Drawing.Point(662, 117);
      this.btnKalin.Name = "btnKalin";
      this.btnKalin.Size = new System.Drawing.Size(136, 33);
      this.btnKalin.TabIndex = 8;
      this.btnKalin.Text = "Kalın";
      this.btnKalin.UseVisualStyleBackColor = true;
      this.btnKalin.Click += new System.EventHandler(this.btnKalin_Click);
      // 
      // btnYaziRengi
      // 
      this.btnYaziRengi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnYaziRengi.Location = new System.Drawing.Point(662, 68);
      this.btnYaziRengi.Name = "btnYaziRengi";
      this.btnYaziRengi.Size = new System.Drawing.Size(136, 33);
      this.btnYaziRengi.TabIndex = 9;
      this.btnYaziRengi.Text = "Yazı Rengi";
      this.btnYaziRengi.UseVisualStyleBackColor = true;
      this.btnYaziRengi.Click += new System.EventHandler(this.btnYaziRengi_Click);
      // 
      // btnYaziTipi
      // 
      this.btnYaziTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnYaziTipi.Location = new System.Drawing.Point(662, 19);
      this.btnYaziTipi.Name = "btnYaziTipi";
      this.btnYaziTipi.Size = new System.Drawing.Size(136, 33);
      this.btnYaziTipi.TabIndex = 10;
      this.btnYaziTipi.Text = "Yazı Tipi";
      this.btnYaziTipi.UseVisualStyleBackColor = true;
      this.btnYaziTipi.Click += new System.EventHandler(this.btnYaziTipi_Click);
      // 
      // btnUstuCizili
      // 
      this.btnUstuCizili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnUstuCizili.Location = new System.Drawing.Point(662, 264);
      this.btnUstuCizili.Name = "btnUstuCizili";
      this.btnUstuCizili.Size = new System.Drawing.Size(136, 33);
      this.btnUstuCizili.TabIndex = 6;
      this.btnUstuCizili.Text = "Üstü Çizili";
      this.btnUstuCizili.UseVisualStyleBackColor = true;
      this.btnUstuCizili.Click += new System.EventHandler(this.btnUstuCizili_Click);
      // 
      // btnCiftCizgili
      // 
      this.btnCiftCizgili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnCiftCizgili.Location = new System.Drawing.Point(662, 313);
      this.btnCiftCizgili.Name = "btnCiftCizgili";
      this.btnCiftCizgili.Size = new System.Drawing.Size(136, 33);
      this.btnCiftCizgili.TabIndex = 6;
      this.btnCiftCizgili.Text = "Normal Font";
      this.btnCiftCizgili.UseVisualStyleBackColor = true;
      this.btnCiftCizgili.Click += new System.EventHandler(this.btnCiftCizgili_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(892, 450);
      this.Controls.Add(this.btnYaziTipi);
      this.Controls.Add(this.btnYaziRengi);
      this.Controls.Add(this.btnKalin);
      this.Controls.Add(this.btnEgik);
      this.Controls.Add(this.btnCiftCizgili);
      this.Controls.Add(this.btnUstuCizili);
      this.Controls.Add(this.btnAltiCizili);
      this.Controls.Add(this.btnKalinItalik);
      this.Controls.Add(this.btnYapistir);
      this.Controls.Add(this.btnGeriAl);
      this.Controls.Add(this.btnKopyala);
      this.Controls.Add(this.btnKes);
      this.Controls.Add(this.txtMetin);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtMetin;
    private System.Windows.Forms.Button btnKes;
    private System.Windows.Forms.Button btnKopyala;
    private System.Windows.Forms.Button btnGeriAl;
    private System.Windows.Forms.Button btnYapistir;
    private System.Windows.Forms.Button btnKalinItalik;
    private System.Windows.Forms.Button btnAltiCizili;
    private System.Windows.Forms.Button btnEgik;
    private System.Windows.Forms.Button btnKalin;
    private System.Windows.Forms.Button btnYaziRengi;
    private System.Windows.Forms.Button btnYaziTipi;
    private System.Windows.Forms.FontDialog fontDialog1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button btnUstuCizili;
    private System.Windows.Forms.Button btnCiftCizgili;
  }
}

