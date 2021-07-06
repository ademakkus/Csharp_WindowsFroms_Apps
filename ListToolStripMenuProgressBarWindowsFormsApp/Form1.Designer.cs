
namespace ListToolStripMenuProgressBarWindowsFormsApp
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lsbDersler = new System.Windows.Forms.ListBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lsbSecilenDersler = new System.Windows.Forms.ListBox();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.btnEkle = new System.Windows.Forms.Button();
      this.btnCokluDersEkle = new System.Windows.Forms.Button();
      this.btnDersCikar = new System.Windows.Forms.Button();
      this.chbDersEkle = new System.Windows.Forms.CheckBox();
      this.txtEkle = new System.Windows.Forms.TextBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.seçimiİptalEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.dersÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.seçimiİptalEtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.contextMenuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lsbDersler);
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(378, 416);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Dersler";
      // 
      // lsbDersler
      // 
      this.lsbDersler.ContextMenuStrip = this.contextMenuStrip1;
      this.lsbDersler.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lsbDersler.FormattingEnabled = true;
      this.lsbDersler.ItemHeight = 16;
      this.lsbDersler.Location = new System.Drawing.Point(3, 18);
      this.lsbDersler.Name = "lsbDersler";
      this.lsbDersler.Size = new System.Drawing.Size(372, 395);
      this.lsbDersler.TabIndex = 0;
      this.lsbDersler.DoubleClick += new System.EventHandler(this.btnEkle_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lsbSecilenDersler);
      this.groupBox2.Location = new System.Drawing.Point(524, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(378, 416);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Seçilen Dersler";
      // 
      // lsbSecilenDersler
      // 
      this.lsbSecilenDersler.ContextMenuStrip = this.contextMenuStrip2;
      this.lsbSecilenDersler.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lsbSecilenDersler.FormattingEnabled = true;
      this.lsbSecilenDersler.ItemHeight = 16;
      this.lsbSecilenDersler.Location = new System.Drawing.Point(3, 18);
      this.lsbSecilenDersler.Name = "lsbSecilenDersler";
      this.lsbSecilenDersler.Size = new System.Drawing.Size(372, 395);
      this.lsbSecilenDersler.TabIndex = 0;
      this.lsbSecilenDersler.DoubleClick += new System.EventHandler(this.btnDersCikar_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(378, 0);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(146, 410);
      this.progressBar1.TabIndex = 2;
      // 
      // btnEkle
      // 
      this.btnEkle.Location = new System.Drawing.Point(70, 434);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(184, 34);
      this.btnEkle.TabIndex = 3;
      this.btnEkle.Text = "&Ekle";
      this.btnEkle.UseVisualStyleBackColor = true;
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // btnCokluDersEkle
      // 
      this.btnCokluDersEkle.Location = new System.Drawing.Point(378, 434);
      this.btnCokluDersEkle.Name = "btnCokluDersEkle";
      this.btnCokluDersEkle.Size = new System.Drawing.Size(184, 34);
      this.btnCokluDersEkle.TabIndex = 4;
      this.btnCokluDersEkle.Text = "&Çoklu Ders Ekle";
      this.btnCokluDersEkle.UseVisualStyleBackColor = true;
      this.btnCokluDersEkle.Click += new System.EventHandler(this.btnCokluDersEkle_Click);
      // 
      // btnDersCikar
      // 
      this.btnDersCikar.Location = new System.Drawing.Point(638, 434);
      this.btnDersCikar.Name = "btnDersCikar";
      this.btnDersCikar.Size = new System.Drawing.Size(184, 34);
      this.btnDersCikar.TabIndex = 5;
      this.btnDersCikar.Text = "&Ders Çıkar";
      this.btnDersCikar.UseVisualStyleBackColor = true;
      this.btnDersCikar.Click += new System.EventHandler(this.btnDersCikar_Click);
      // 
      // chbDersEkle
      // 
      this.chbDersEkle.AutoSize = true;
      this.chbDersEkle.Location = new System.Drawing.Point(25, 483);
      this.chbDersEkle.Name = "chbDersEkle";
      this.chbDersEkle.Size = new System.Drawing.Size(123, 21);
      this.chbDersEkle.TabIndex = 6;
      this.chbDersEkle.Text = "Yeni Ders Ekle";
      this.chbDersEkle.UseVisualStyleBackColor = true;
      this.chbDersEkle.CheckedChanged += new System.EventHandler(this.chbDersEkle_CheckedChanged);
      // 
      // txtEkle
      // 
      this.txtEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtEkle.Location = new System.Drawing.Point(25, 510);
      this.txtEkle.Name = "txtEkle";
      this.txtEkle.Size = new System.Drawing.Size(581, 30);
      this.txtEkle.TabIndex = 7;
      this.txtEkle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEkle_KeyDown);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.seçimiİptalEtToolStripMenuItem,
            this.çıkışToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(174, 76);
      // 
      // ekleToolStripMenuItem
      // 
      this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
      this.ekleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.ekleToolStripMenuItem.Text = "&Ekle";
      this.ekleToolStripMenuItem.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // seçimiİptalEtToolStripMenuItem
      // 
      this.seçimiİptalEtToolStripMenuItem.Name = "seçimiİptalEtToolStripMenuItem";
      this.seçimiİptalEtToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.seçimiİptalEtToolStripMenuItem.Text = "&Seçimi İptal Et";
      this.seçimiİptalEtToolStripMenuItem.Click += new System.EventHandler(this.seçimiİptalEtToolStripMenuItem_Click);
      // 
      // çıkışToolStripMenuItem
      // 
      this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
      this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.çıkışToolStripMenuItem.Text = "&Çıkış";
      this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
      // 
      // contextMenuStrip2
      // 
      this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersÇıkarToolStripMenuItem,
            this.seçimiİptalEtToolStripMenuItem1,
            this.çıkışToolStripMenuItem1});
      this.contextMenuStrip2.Name = "contextMenuStrip2";
      this.contextMenuStrip2.Size = new System.Drawing.Size(174, 76);
      // 
      // dersÇıkarToolStripMenuItem
      // 
      this.dersÇıkarToolStripMenuItem.Name = "dersÇıkarToolStripMenuItem";
      this.dersÇıkarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.dersÇıkarToolStripMenuItem.Text = "&Ders Çıkar";
      this.dersÇıkarToolStripMenuItem.Click += new System.EventHandler(this.btnDersCikar_Click);
      // 
      // seçimiİptalEtToolStripMenuItem1
      // 
      this.seçimiİptalEtToolStripMenuItem1.Name = "seçimiİptalEtToolStripMenuItem1";
      this.seçimiİptalEtToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
      this.seçimiİptalEtToolStripMenuItem1.Text = "&Seçimi İptal Et";
      this.seçimiİptalEtToolStripMenuItem1.Click += new System.EventHandler(this.seçimiİptalEtToolStripMenuItem1_Click);
      // 
      // çıkışToolStripMenuItem1
      // 
      this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
      this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(173, 24);
      this.çıkışToolStripMenuItem1.Text = "&Çıkış";
      this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(902, 579);
      this.Controls.Add(this.txtEkle);
      this.Controls.Add(this.chbDersEkle);
      this.Controls.Add(this.btnDersCikar);
      this.Controls.Add(this.btnCokluDersEkle);
      this.Controls.Add(this.btnEkle);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Dersler Formu";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.contextMenuStrip2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox lsbDersler;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListBox lsbSecilenDersler;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button btnEkle;
    private System.Windows.Forms.Button btnCokluDersEkle;
    private System.Windows.Forms.Button btnDersCikar;
    private System.Windows.Forms.CheckBox chbDersEkle;
    private System.Windows.Forms.TextBox txtEkle;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem seçimiİptalEtToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    private System.Windows.Forms.ToolStripMenuItem dersÇıkarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem seçimiİptalEtToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
  }
}

