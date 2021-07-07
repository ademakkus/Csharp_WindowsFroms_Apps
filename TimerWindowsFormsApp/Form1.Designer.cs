
namespace TimerWindowsFormsApp
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
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
      this.label1.Location = new System.Drawing.Point(301, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(148, 91);
      this.label1.TabIndex = 0;
      this.label1.Text = " 60";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button1.ForeColor = System.Drawing.Color.Red;
      this.button1.Location = new System.Drawing.Point(266, 131);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(219, 75);
      this.button1.TabIndex = 1;
      this.button1.Text = "Saymaya Başla";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // timer2
      // 
      this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
      // 
      // progressBar1
      // 
      this.progressBar1.BackColor = System.Drawing.Color.Red;
      this.progressBar1.Location = new System.Drawing.Point(12, 246);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(657, 40);
      this.progressBar1.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(681, 291);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.ProgressBar progressBar1;
  }
}

