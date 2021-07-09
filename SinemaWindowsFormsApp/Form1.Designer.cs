
namespace SinemaWindowsFormsApp
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
      this.txtAdet = new System.Windows.Forms.TextBox();
      this.btnEkle = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.btnUcretHesapla = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txtBirimUcret = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.groupBox1.Controls.Add(this.btnEkle);
      this.groupBox1.Controls.Add(this.txtAdet);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(788, 307);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Ekleme Seçenekleri";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Adet:";
      // 
      // txtAdet
      // 
      this.txtAdet.Location = new System.Drawing.Point(88, 38);
      this.txtAdet.Name = "txtAdet";
      this.txtAdet.Size = new System.Drawing.Size(100, 26);
      this.txtAdet.TabIndex = 1;
      // 
      // btnEkle
      // 
      this.btnEkle.Location = new System.Drawing.Point(207, 28);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(158, 46);
      this.btnEkle.TabIndex = 2;
      this.btnEkle.Text = "Ekle";
      this.btnEkle.UseVisualStyleBackColor = true;
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox2.Location = new System.Drawing.Point(0, 313);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(800, 146);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Seçilen Koltuklar";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 33);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "label2";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.txtBirimUcret);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Controls.Add(this.btnUcretHesapla);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox3.Location = new System.Drawing.Point(0, 458);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(800, 133);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Ücretler";
      // 
      // btnUcretHesapla
      // 
      this.btnUcretHesapla.Location = new System.Drawing.Point(228, 23);
      this.btnUcretHesapla.Name = "btnUcretHesapla";
      this.btnUcretHesapla.Size = new System.Drawing.Size(192, 45);
      this.btnUcretHesapla.TabIndex = 0;
      this.btnUcretHesapla.Text = "Ücret Hesapla";
      this.btnUcretHesapla.UseVisualStyleBackColor = true;
      this.btnUcretHesapla.Click += new System.EventHandler(this.btnUcretHesapla_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 35);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 20);
      this.label3.TabIndex = 1;
      this.label3.Text = "Birim Ücret:";
      // 
      // txtBirimUcret
      // 
      this.txtBirimUcret.Location = new System.Drawing.Point(122, 32);
      this.txtBirimUcret.Name = "txtBirimUcret";
      this.txtBirimUcret.Size = new System.Drawing.Size(100, 26);
      this.txtBirimUcret.TabIndex = 2;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(84, 104);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(120, 20);
      this.label4.TabIndex = 3;
      this.label4.Text = "Toplam Ücret=";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(800, 591);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Sinema Salonu";
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
    private System.Windows.Forms.Button btnEkle;
    private System.Windows.Forms.TextBox txtAdet;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtBirimUcret;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnUcretHesapla;
  }
}

