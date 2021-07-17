
namespace SerilizationWindowsFormsApp
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
      this.btnSave = new System.Windows.Forms.Button();
      this.txtTelefon = new System.Windows.Forms.TextBox();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtSoyadi = new System.Windows.Forms.TextBox();
      this.txtAdi = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnYukle = new System.Windows.Forms.Button();
      this.txtTelefon_ = new System.Windows.Forms.TextBox();
      this.txtEmail_ = new System.Windows.Forms.TextBox();
      this.txtSoyadi_ = new System.Windows.Forms.TextBox();
      this.txtAdi_ = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnSave);
      this.groupBox1.Controls.Add(this.txtTelefon);
      this.groupBox1.Controls.Add(this.txtEmail);
      this.groupBox1.Controls.Add(this.txtSoyadi);
      this.groupBox1.Controls.Add(this.txtAdi);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.groupBox1.Location = new System.Drawing.Point(16, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(461, 378);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Müşteri Bilgileri";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(207, 246);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(151, 36);
      this.btnSave.TabIndex = 9;
      this.btnSave.Text = "Kaydet";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // txtTelefon
      // 
      this.txtTelefon.Location = new System.Drawing.Point(166, 197);
      this.txtTelefon.Name = "txtTelefon";
      this.txtTelefon.Size = new System.Drawing.Size(255, 28);
      this.txtTelefon.TabIndex = 7;
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(166, 146);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(255, 28);
      this.txtEmail.TabIndex = 6;
      // 
      // txtSoyadi
      // 
      this.txtSoyadi.Location = new System.Drawing.Point(166, 95);
      this.txtSoyadi.Name = "txtSoyadi";
      this.txtSoyadi.Size = new System.Drawing.Size(255, 28);
      this.txtSoyadi.TabIndex = 5;
      // 
      // txtAdi
      // 
      this.txtAdi.Location = new System.Drawing.Point(166, 44);
      this.txtAdi.Name = "txtAdi";
      this.txtAdi.Size = new System.Drawing.Size(255, 28);
      this.txtAdi.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.label4.Location = new System.Drawing.Point(71, 199);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(79, 24);
      this.label4.TabIndex = 3;
      this.label4.Text = "Telefon:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.label3.Location = new System.Drawing.Point(88, 148);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(62, 24);
      this.label3.TabIndex = 2;
      this.label3.Text = "Email:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.label2.Location = new System.Drawing.Point(78, 97);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 24);
      this.label2.TabIndex = 1;
      this.label2.Text = "Soyadı:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.label1.Location = new System.Drawing.Point(107, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Adı:";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.InitialDirectory = "C:\\Users\\mypc\\source\\repos\\SerilizationWindowsFormsApp\\SerilizationWindowsFormsAp" +
    "p\\bin\\Debug";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnYukle);
      this.groupBox2.Controls.Add(this.txtTelefon_);
      this.groupBox2.Controls.Add(this.txtEmail_);
      this.groupBox2.Controls.Add(this.txtSoyadi_);
      this.groupBox2.Controls.Add(this.txtAdi_);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox2.ForeColor = System.Drawing.Color.Purple;
      this.groupBox2.Location = new System.Drawing.Point(492, 27);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(484, 378);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Müşteri Bilgilerini Getir";
      // 
      // btnYukle
      // 
      this.btnYukle.Location = new System.Drawing.Point(199, 251);
      this.btnYukle.Name = "btnYukle";
      this.btnYukle.Size = new System.Drawing.Size(151, 36);
      this.btnYukle.TabIndex = 8;
      this.btnYukle.Text = "Yükle";
      this.btnYukle.UseVisualStyleBackColor = true;
      this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
      // 
      // txtTelefon_
      // 
      this.txtTelefon_.ForeColor = System.Drawing.Color.Red;
      this.txtTelefon_.Location = new System.Drawing.Point(166, 197);
      this.txtTelefon_.Name = "txtTelefon_";
      this.txtTelefon_.ReadOnly = true;
      this.txtTelefon_.Size = new System.Drawing.Size(255, 28);
      this.txtTelefon_.TabIndex = 7;
      // 
      // txtEmail_
      // 
      this.txtEmail_.ForeColor = System.Drawing.Color.Red;
      this.txtEmail_.Location = new System.Drawing.Point(166, 146);
      this.txtEmail_.Name = "txtEmail_";
      this.txtEmail_.ReadOnly = true;
      this.txtEmail_.Size = new System.Drawing.Size(255, 28);
      this.txtEmail_.TabIndex = 6;
      // 
      // txtSoyadi_
      // 
      this.txtSoyadi_.ForeColor = System.Drawing.Color.Red;
      this.txtSoyadi_.Location = new System.Drawing.Point(166, 95);
      this.txtSoyadi_.Name = "txtSoyadi_";
      this.txtSoyadi_.ReadOnly = true;
      this.txtSoyadi_.Size = new System.Drawing.Size(255, 28);
      this.txtSoyadi_.TabIndex = 5;
      // 
      // txtAdi_
      // 
      this.txtAdi_.ForeColor = System.Drawing.Color.Red;
      this.txtAdi_.Location = new System.Drawing.Point(166, 44);
      this.txtAdi_.Name = "txtAdi_";
      this.txtAdi_.ReadOnly = true;
      this.txtAdi_.Size = new System.Drawing.Size(255, 28);
      this.txtAdi_.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.label5.Location = new System.Drawing.Point(71, 199);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(79, 24);
      this.label5.TabIndex = 3;
      this.label5.Text = "Telefon:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.label6.Location = new System.Drawing.Point(88, 148);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(62, 24);
      this.label6.TabIndex = 2;
      this.label6.Text = "Email:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.label7.Location = new System.Drawing.Point(78, 97);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(72, 24);
      this.label7.TabIndex = 1;
      this.label7.Text = "Soyadı:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.label8.Location = new System.Drawing.Point(107, 46);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(43, 24);
      this.label8.TabIndex = 0;
      this.label8.Text = "Adı:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(996, 450);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtTelefon;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtSoyadi;
    private System.Windows.Forms.TextBox txtAdi;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnYukle;
    private System.Windows.Forms.TextBox txtTelefon_;
    private System.Windows.Forms.TextBox txtEmail_;
    private System.Windows.Forms.TextBox txtSoyadi_;
    private System.Windows.Forms.TextBox txtAdi_;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    public System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}

