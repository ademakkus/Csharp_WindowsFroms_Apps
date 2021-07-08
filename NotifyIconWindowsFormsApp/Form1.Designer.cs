
namespace NotifyIconWindowsFormsApp
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "notifyIcon1";
      this.notifyIcon1.Visible = true;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.çıkışToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(109, 52);
      // 
      // açToolStripMenuItem
      // 
      this.açToolStripMenuItem.Name = "açToolStripMenuItem";
      this.açToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
      this.açToolStripMenuItem.Text = "Aç";
      this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
      // 
      // çıkışToolStripMenuItem
      // 
      this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
      this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
      this.çıkışToolStripMenuItem.Text = "Çıkış";
      this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.ContextMenuStrip = this.contextMenuStrip1;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
  }
}

