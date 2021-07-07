
namespace DateTimePickerTrackBarWindowsFormsApp2
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
      this.label1 = new System.Windows.Forms.Label();
      this.dtpDTarihi = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.btnGitsinYas = new System.Windows.Forms.Button();
      this.btnGelsinYas = new System.Windows.Forms.Button();
      this.btnYasinizinRengi = new System.Windows.Forms.Button();
      this.btnYasimiHesapla = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.trbHiz = new System.Windows.Forms.TrackBar();
      this.txtHiz = new System.Windows.Forms.TextBox();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      ((System.ComponentModel.ISupportInitialize)(this.trbHiz)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Doğum Tarihi:";
      // 
      // dtpDTarihi
      // 
      this.dtpDTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.dtpDTarihi.Location = new System.Drawing.Point(115, 24);
      this.dtpDTarihi.Name = "dtpDTarihi";
      this.dtpDTarihi.Size = new System.Drawing.Size(228, 28);
      this.dtpDTarihi.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 313);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 17);
      this.label2.TabIndex = 2;
      this.label2.Text = "label2";
      // 
      // btnGitsinYas
      // 
      this.btnGitsinYas.Location = new System.Drawing.Point(34, 117);
      this.btnGitsinYas.Name = "btnGitsinYas";
      this.btnGitsinYas.Size = new System.Drawing.Size(162, 32);
      this.btnGitsinYas.TabIndex = 3;
      this.btnGitsinYas.Text = "Gitsin Yaş";
      this.btnGitsinYas.UseVisualStyleBackColor = true;
      this.btnGitsinYas.Click += new System.EventHandler(this.btnGitsinYas_Click);
      // 
      // btnGelsinYas
      // 
      this.btnGelsinYas.Location = new System.Drawing.Point(224, 117);
      this.btnGelsinYas.Name = "btnGelsinYas";
      this.btnGelsinYas.Size = new System.Drawing.Size(162, 32);
      this.btnGelsinYas.TabIndex = 4;
      this.btnGelsinYas.Text = "Gelsin Yaş";
      this.btnGelsinYas.UseVisualStyleBackColor = true;
      this.btnGelsinYas.Click += new System.EventHandler(this.btnGelsinYas_Click);
      // 
      // btnYasinizinRengi
      // 
      this.btnYasinizinRengi.Location = new System.Drawing.Point(414, 117);
      this.btnYasinizinRengi.Name = "btnYasinizinRengi";
      this.btnYasinizinRengi.Size = new System.Drawing.Size(162, 32);
      this.btnYasinizinRengi.TabIndex = 5;
      this.btnYasinizinRengi.Text = "Yaşınızın Rengi";
      this.btnYasinizinRengi.UseVisualStyleBackColor = true;
      this.btnYasinizinRengi.Click += new System.EventHandler(this.btnYasinizinRengi_Click);
      // 
      // btnYasimiHesapla
      // 
      this.btnYasimiHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnYasimiHesapla.Location = new System.Drawing.Point(349, 19);
      this.btnYasimiHesapla.Name = "btnYasimiHesapla";
      this.btnYasimiHesapla.Size = new System.Drawing.Size(175, 38);
      this.btnYasimiHesapla.TabIndex = 6;
      this.btnYasimiHesapla.Text = "Yaşımı Hesapla";
      this.btnYasimiHesapla.UseVisualStyleBackColor = true;
      this.btnYasimiHesapla.Click += new System.EventHandler(this.btnYasimiHesapla_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 363);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(776, 47);
      this.progressBar1.TabIndex = 7;
      // 
      // trbHiz
      // 
      this.trbHiz.Location = new System.Drawing.Point(664, 44);
      this.trbHiz.Maximum = 300;
      this.trbHiz.Minimum = 10;
      this.trbHiz.Name = "trbHiz";
      this.trbHiz.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.trbHiz.Size = new System.Drawing.Size(56, 104);
      this.trbHiz.TabIndex = 8;
      this.trbHiz.Value = 10;
      this.trbHiz.ValueChanged += new System.EventHandler(this.trbHiz_ValueChanged);
      // 
      // txtHiz
      // 
      this.txtHiz.Location = new System.Drawing.Point(653, 154);
      this.txtHiz.Name = "txtHiz";
      this.txtHiz.Size = new System.Drawing.Size(88, 22);
      this.txtHiz.TabIndex = 0;
      this.txtHiz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHiz_KeyDown);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.txtHiz);
      this.Controls.Add(this.trbHiz);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.btnYasimiHesapla);
      this.Controls.Add(this.btnYasinizinRengi);
      this.Controls.Add(this.btnGelsinYas);
      this.Controls.Add(this.btnGitsinYas);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dtpDTarihi);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.trbHiz)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dtpDTarihi;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnGitsinYas;
    private System.Windows.Forms.Button btnGelsinYas;
    private System.Windows.Forms.Button btnYasinizinRengi;
    private System.Windows.Forms.Button btnYasimiHesapla;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.TrackBar trbHiz;
    private System.Windows.Forms.TextBox txtHiz;
    private System.Windows.Forms.ColorDialog colorDialog1;
  }
}

