
namespace ProgressBar2WindowsFormsApp
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
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtOrtalama = new System.Windows.Forms.TextBox();
      this.txtAdet = new System.Windows.Forms.TextBox();
      this.btnVeriGirisi = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // progressBar1
      // 
      this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
      this.progressBar1.Location = new System.Drawing.Point(0, 0);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(635, 37);
      this.progressBar1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(34, 100);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Adet:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 133);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 17);
      this.label2.TabIndex = 2;
      this.label2.Text = "Ortalama:";
      // 
      // txtOrtalama
      // 
      this.txtOrtalama.Location = new System.Drawing.Point(137, 128);
      this.txtOrtalama.Name = "txtOrtalama";
      this.txtOrtalama.Size = new System.Drawing.Size(144, 22);
      this.txtOrtalama.TabIndex = 1;
      // 
      // txtAdet
      // 
      this.txtAdet.Location = new System.Drawing.Point(137, 100);
      this.txtAdet.Name = "txtAdet";
      this.txtAdet.Size = new System.Drawing.Size(144, 22);
      this.txtAdet.TabIndex = 0;
      // 
      // btnVeriGirisi
      // 
      this.btnVeriGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnVeriGirisi.Location = new System.Drawing.Point(323, 91);
      this.btnVeriGirisi.Name = "btnVeriGirisi";
      this.btnVeriGirisi.Size = new System.Drawing.Size(145, 80);
      this.btnVeriGirisi.TabIndex = 2;
      this.btnVeriGirisi.Text = "Veri Girişi";
      this.btnVeriGirisi.UseVisualStyleBackColor = true;
      this.btnVeriGirisi.Click += new System.EventHandler(this.btnVeriGirisi_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.btnVeriGirisi;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(635, 374);
      this.Controls.Add(this.btnVeriGirisi);
      this.Controls.Add(this.txtAdet);
      this.Controls.Add(this.txtOrtalama);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.progressBar1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtOrtalama;
    private System.Windows.Forms.TextBox txtAdet;
    private System.Windows.Forms.Button btnVeriGirisi;
  }
}

