
namespace PieChartWindowsFormsApp
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
      ((System.ComponentModel.ISupportInitialize)(this.pcbChart)).BeginInit();
      this.SuspendLayout();
      // 
      // pcbChart
      // 
      this.pcbChart.Location = new System.Drawing.Point(12, 12);
      this.pcbChart.Margin = new System.Windows.Forms.Padding(10);
      this.pcbChart.Name = "pcbChart";
      this.pcbChart.Padding = new System.Windows.Forms.Padding(5);
      this.pcbChart.Size = new System.Drawing.Size(756, 488);
      this.pcbChart.TabIndex = 0;
      this.pcbChart.TabStop = false;
      this.pcbChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pcbChart_Paint);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(913, 623);
      this.Controls.Add(this.pcbChart);
      this.Name = "Form1";
      this.Text = "Takımlar Pasta Grafik";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pcbChart)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pcbChart;
  }
}

