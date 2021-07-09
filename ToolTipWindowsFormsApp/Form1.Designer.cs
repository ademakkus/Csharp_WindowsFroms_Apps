
namespace ToolTipWindowsFormsApp
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
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.rdbHerikisine = new System.Windows.Forms.RadioButton();
      this.rdbListBoxa = new System.Windows.Forms.RadioButton();
      this.rdbComboBoxa = new System.Windows.Forms.RadioButton();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.txtAranan = new System.Windows.Forms.TextBox();
      this.btnArtanSıralama = new System.Windows.Forms.Button();
      this.btnEkle = new System.Windows.Forms.Button();
      this.txtEklenen = new System.Windows.Forms.TextBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.groupBox1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.toolStrip1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.rdbHerikisine);
      this.groupBox1.Controls.Add(this.rdbListBoxa);
      this.groupBox1.Controls.Add(this.rdbComboBoxa);
      this.groupBox1.Controls.Add(this.listBox1);
      this.groupBox1.Controls.Add(this.comboBox1);
      this.groupBox1.Controls.Add(this.txtAranan);
      this.groupBox1.Controls.Add(this.btnArtanSıralama);
      this.groupBox1.Controls.Add(this.btnEkle);
      this.groupBox1.Controls.Add(this.txtEklenen);
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(777, 583);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Atama İşlemleri";
      // 
      // toolStrip1
      // 
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
      this.toolStrip1.Location = new System.Drawing.Point(3, 555);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(771, 25);
      this.toolStrip1.TabIndex = 12;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(111, 22);
      this.toolStripLabel1.Text = "toolStripLabel1";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 163);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 17);
      this.label3.TabIndex = 11;
      this.label3.Text = "Liste";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(253, 343);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 17);
      this.label2.TabIndex = 10;
      this.label2.Text = "Ekleme";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 66);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 17);
      this.label1.TabIndex = 9;
      this.label1.Text = "Atanacak Değer";
      // 
      // rdbHerikisine
      // 
      this.rdbHerikisine.AutoSize = true;
      this.rdbHerikisine.Location = new System.Drawing.Point(528, 421);
      this.rdbHerikisine.Name = "rdbHerikisine";
      this.rdbHerikisine.Size = new System.Drawing.Size(99, 21);
      this.rdbHerikisine.TabIndex = 8;
      this.rdbHerikisine.TabStop = true;
      this.rdbHerikisine.Text = " Her ikisine";
      this.rdbHerikisine.UseVisualStyleBackColor = true;
      // 
      // rdbListBoxa
      // 
      this.rdbListBoxa.AutoSize = true;
      this.rdbListBoxa.Checked = true;
      this.rdbListBoxa.Location = new System.Drawing.Point(390, 421);
      this.rdbListBoxa.Name = "rdbListBoxa";
      this.rdbListBoxa.Size = new System.Drawing.Size(86, 21);
      this.rdbListBoxa.TabIndex = 7;
      this.rdbListBoxa.TabStop = true;
      this.rdbListBoxa.Text = " ListBoxa";
      this.rdbListBoxa.UseVisualStyleBackColor = true;
      // 
      // rdbComboBoxa
      // 
      this.rdbComboBoxa.AutoSize = true;
      this.rdbComboBoxa.Location = new System.Drawing.Point(256, 421);
      this.rdbComboBoxa.Name = "rdbComboBoxa";
      this.rdbComboBoxa.Size = new System.Drawing.Size(108, 21);
      this.rdbComboBoxa.TabIndex = 6;
      this.rdbComboBoxa.TabStop = true;
      this.rdbComboBoxa.Text = " ComboBoxa";
      this.rdbComboBoxa.UseVisualStyleBackColor = true;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Location = new System.Drawing.Point(15, 187);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(158, 356);
      this.listBox1.TabIndex = 5;
      this.listBox1.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
      this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Adem AKKUŞ",
            "Gülten AKKUş",
            "Furkan AKKUŞ",
            "Ayşenur AKKUŞ",
            "Kerem AKKUŞ"});
      this.comboBox1.Location = new System.Drawing.Point(256, 187);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(415, 24);
      this.comboBox1.TabIndex = 4;
      this.comboBox1.MouseEnter += new System.EventHandler(this.comboBox1_MouseEnter);
      this.comboBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
      // 
      // txtAranan
      // 
      this.txtAranan.Location = new System.Drawing.Point(154, 63);
      this.txtAranan.Name = "txtAranan";
      this.txtAranan.Size = new System.Drawing.Size(324, 22);
      this.txtAranan.TabIndex = 3;
      this.txtAranan.TextChanged += new System.EventHandler(this.txtAranan_TextChanged);
      // 
      // btnArtanSıralama
      // 
      this.btnArtanSıralama.Location = new System.Drawing.Point(461, 490);
      this.btnArtanSıralama.Name = "btnArtanSıralama";
      this.btnArtanSıralama.Size = new System.Drawing.Size(162, 40);
      this.btnArtanSıralama.TabIndex = 2;
      this.btnArtanSıralama.Text = "Artan Sıralama";
      this.btnArtanSıralama.UseVisualStyleBackColor = true;
      this.btnArtanSıralama.Click += new System.EventHandler(this.btnArtanSıralama_Click);
      // 
      // btnEkle
      // 
      this.btnEkle.Location = new System.Drawing.Point(256, 490);
      this.btnEkle.Name = "btnEkle";
      this.btnEkle.Size = new System.Drawing.Size(162, 40);
      this.btnEkle.TabIndex = 1;
      this.btnEkle.Text = "Ekle";
      this.btnEkle.UseVisualStyleBackColor = true;
      this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
      // 
      // txtEklenen
      // 
      this.txtEklenen.Location = new System.Drawing.Point(256, 376);
      this.txtEklenen.Name = "txtEklenen";
      this.txtEklenen.Size = new System.Drawing.Size(415, 22);
      this.txtEklenen.TabIndex = 0;
      this.txtEklenen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEklenen_KeyDown);
      // 
      // toolTip1
      // 
      this.toolTip1.IsBalloon = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 595);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton rdbHerikisine;
    private System.Windows.Forms.RadioButton rdbListBoxa;
    private System.Windows.Forms.RadioButton rdbComboBoxa;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox txtAranan;
    private System.Windows.Forms.Button btnArtanSıralama;
    private System.Windows.Forms.Button btnEkle;
    private System.Windows.Forms.TextBox txtEklenen;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
  }
}

