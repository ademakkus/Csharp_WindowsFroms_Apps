
namespace ComboBoxWindowsFormsApp
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
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.btnEkle = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnYerlestir = new System.Windows.Forms.Button();
      this.btnSil = new System.Windows.Forms.Button();
      this.btnTemizle = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnTemizle);
      this.groupBox1.Controls.Add(this.btnSil);
      this.groupBox1.Controls.Add(this.btnYerlestir);
      this.groupBox1.Controls.Add(this.progressBar1);
      this.groupBox1.Controls.Add(this.btnEkle);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.comboBox1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(470, 438);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "ComboBox Uygulama";
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 327);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(357, 27);
      this.progressBar1.TabIndex = 10;
      // 
      // btnEkle
      // 
      this.btnEkle.Location = new System.Drawing.Point(34, 112);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(105, 44);
      this.btnEkle.TabIndex = 9;
      this.btnEkle.Text = "Ekle";
      this.btnEkle.UseVisualStyleBackColor = true;
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 289);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 17);
      this.label2.TabIndex = 8;
      this.label2.Text = "label2";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(24, 30);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(169, 24);
      this.comboBox1.TabIndex = 7;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 70);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 17);
      this.label1.TabIndex = 6;
      this.label1.Text = "label1";
      // 
      // btnYerlestir
      // 
      this.btnYerlestir.Location = new System.Drawing.Point(34, 174);
      this.btnYerlestir.Name = "btnYerlestir";
      this.btnYerlestir.Size = new System.Drawing.Size(105, 44);
      this.btnYerlestir.TabIndex = 11;
      this.btnYerlestir.Text = "Yerleştir";
      this.btnYerlestir.UseVisualStyleBackColor = true;
      this.btnYerlestir.Click += new System.EventHandler(this.btnYerlestir_Click);
      // 
      // btnSil
      // 
      this.btnSil.Location = new System.Drawing.Point(163, 112);
      this.btnSil.Name = "btnSil";
      this.btnSil.Size = new System.Drawing.Size(105, 44);
      this.btnSil.TabIndex = 12;
      this.btnSil.Text = "Sil";
      this.btnSil.UseVisualStyleBackColor = true;
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnTemizle
      // 
      this.btnTemizle.Location = new System.Drawing.Point(163, 174);
      this.btnTemizle.Name = "btnTemizle";
      this.btnTemizle.Size = new System.Drawing.Size(105, 44);
      this.btnTemizle.TabIndex = 13;
      this.btnTemizle.Text = "Temizle";
      this.btnTemizle.UseVisualStyleBackColor = true;
      this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(546, 450);
      this.Controls.Add(this.groupBox1);
      this.KeyPreview = true;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnTemizle;
    private System.Windows.Forms.Button btnSil;
    private System.Windows.Forms.Button btnYerlestir;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button btnEkle;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label1;
  }
}

