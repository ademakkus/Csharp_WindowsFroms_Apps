
namespace PieChartSaveAsImageWindowsFormsApp
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
      this.pcbChart = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.pcbChart)).BeginInit();
      this.SuspendLayout();
      // 
      // pcbChart
      // 
      this.pcbChart.Location = new System.Drawing.Point(44, 8);
      this.pcbChart.Margin = new System.Windows.Forms.Padding(10);
      this.pcbChart.Name = "pcbChart";
      this.pcbChart.Padding = new System.Windows.Forms.Padding(5);
      this.pcbChart.Size = new System.Drawing.Size(806, 507);
      this.pcbChart.TabIndex = 1;
      this.pcbChart.TabStop = false;
      this.pcbChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbChart_Paint);
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
      this.button1.Location = new System.Drawing.Point(468, 528);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(239, 63);
      this.button1.TabIndex = 2;
      this.button1.Text = "Kaydet";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(903, 636);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pcbChart);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pcbChart)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pcbChart;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
  }
}

