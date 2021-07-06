
namespace ProgressBarWindowsFormsApp
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
      this.txtKacDefa = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(43, 48);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(646, 46);
      this.progressBar1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(40, 193);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Kaç Defa:";
      // 
      // txtKacDefa
      // 
      this.txtKacDefa.Location = new System.Drawing.Point(134, 190);
      this.txtKacDefa.Name = "txtKacDefa";
      this.txtKacDefa.Size = new System.Drawing.Size(176, 22);
      this.txtKacDefa.TabIndex = 2;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(85, 235);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(178, 46);
      this.button1.TabIndex = 3;
      this.button1.Text = "Say";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtKacDefa);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.progressBar1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtKacDefa;
    private System.Windows.Forms.Button button1;
  }
}

