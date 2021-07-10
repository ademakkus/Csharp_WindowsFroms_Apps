
namespace BindingSourceWindowsFormsApp
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtBolumAdi = new System.Windows.Forms.TextBox();
      this.txtBolumKodu = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnRaporla = new System.Windows.Forms.Button();
      this.btnKaydet = new System.Windows.Forms.Button();
      this.btnDuzelt = new System.Windows.Forms.Button();
      this.btnSil = new System.Windows.Forms.Button();
      this.btnYeniKayit = new System.Windows.Forms.Button();
      this.btnIptal = new System.Windows.Forms.Button();
      this.btnGeri = new System.Windows.Forms.Button();
      this.btnIleri = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.txtBolumAdi_Arama = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.düzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.toolStrip1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtBolumAdi);
      this.groupBox1.Controls.Add(this.txtBolumKodu);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(538, 128);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Bölüm Tanımları";
      // 
      // txtBolumAdi
      // 
      this.txtBolumAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtBolumAdi.Location = new System.Drawing.Point(164, 60);
      this.txtBolumAdi.Name = "txtBolumAdi";
      this.txtBolumAdi.Size = new System.Drawing.Size(342, 28);
      this.txtBolumAdi.TabIndex = 3;
      // 
      // txtBolumKodu
      // 
      this.txtBolumKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtBolumKodu.Location = new System.Drawing.Point(164, 20);
      this.txtBolumKodu.Name = "txtBolumKodu";
      this.txtBolumKodu.Size = new System.Drawing.Size(342, 28);
      this.txtBolumKodu.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(56, 63);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Bölüm Adı";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(40, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Bölüm Kodu";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnRaporla);
      this.groupBox2.Controls.Add(this.btnKaydet);
      this.groupBox2.Controls.Add(this.btnDuzelt);
      this.groupBox2.Controls.Add(this.btnSil);
      this.groupBox2.Controls.Add(this.btnYeniKayit);
      this.groupBox2.Controls.Add(this.btnIptal);
      this.groupBox2.Controls.Add(this.btnGeri);
      this.groupBox2.Controls.Add(this.btnIleri);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.groupBox2.Location = new System.Drawing.Point(0, 134);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(538, 276);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "İşlemler";
      // 
      // btnRaporla
      // 
      this.btnRaporla.Location = new System.Drawing.Point(406, 75);
      this.btnRaporla.Name = "btnRaporla";
      this.btnRaporla.Size = new System.Drawing.Size(100, 30);
      this.btnRaporla.TabIndex = 15;
      this.btnRaporla.Text = "Raporla";
      this.btnRaporla.UseVisualStyleBackColor = true;
      // 
      // btnKaydet
      // 
      this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnKaydet.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.btnKaydet.Location = new System.Drawing.Point(278, 33);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(100, 30);
      this.btnKaydet.TabIndex = 14;
      this.btnKaydet.Text = "Kaydet";
      this.btnKaydet.UseVisualStyleBackColor = true;
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // btnDuzelt
      // 
      this.btnDuzelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnDuzelt.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.btnDuzelt.Location = new System.Drawing.Point(150, 78);
      this.btnDuzelt.Name = "btnDuzelt";
      this.btnDuzelt.Size = new System.Drawing.Size(100, 30);
      this.btnDuzelt.TabIndex = 13;
      this.btnDuzelt.Text = "Düzelt";
      this.btnDuzelt.UseVisualStyleBackColor = true;
      this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
      // 
      // btnSil
      // 
      this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnSil.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.btnSil.Location = new System.Drawing.Point(278, 78);
      this.btnSil.Name = "btnSil";
      this.btnSil.Size = new System.Drawing.Size(100, 30);
      this.btnSil.TabIndex = 12;
      this.btnSil.Text = "Sil";
      this.btnSil.UseVisualStyleBackColor = true;
      this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // btnYeniKayit
      // 
      this.btnYeniKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnYeniKayit.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.btnYeniKayit.Location = new System.Drawing.Point(22, 78);
      this.btnYeniKayit.Name = "btnYeniKayit";
      this.btnYeniKayit.Size = new System.Drawing.Size(118, 30);
      this.btnYeniKayit.TabIndex = 11;
      this.btnYeniKayit.Text = "Yeni Kayıt";
      this.btnYeniKayit.UseVisualStyleBackColor = true;
      this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
      // 
      // btnIptal
      // 
      this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnIptal.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.btnIptal.Location = new System.Drawing.Point(406, 33);
      this.btnIptal.Name = "btnIptal";
      this.btnIptal.Size = new System.Drawing.Size(100, 30);
      this.btnIptal.TabIndex = 10;
      this.btnIptal.Text = "İptal";
      this.btnIptal.UseVisualStyleBackColor = true;
      this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
      // 
      // btnGeri
      // 
      this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnGeri.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.btnGeri.Location = new System.Drawing.Point(22, 33);
      this.btnGeri.Name = "btnGeri";
      this.btnGeri.Size = new System.Drawing.Size(100, 30);
      this.btnGeri.TabIndex = 9;
      this.btnGeri.Text = "<< Geri";
      this.btnGeri.UseVisualStyleBackColor = true;
      this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
      // 
      // btnIleri
      // 
      this.btnIleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnIleri.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.btnIleri.Location = new System.Drawing.Point(150, 33);
      this.btnIleri.Name = "btnIleri";
      this.btnIleri.Size = new System.Drawing.Size(100, 30);
      this.btnIleri.TabIndex = 8;
      this.btnIleri.Text = "İleri >>";
      this.btnIleri.UseVisualStyleBackColor = true;
      this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.txtBolumAdi_Arama);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Controls.Add(this.dataGridView1);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.groupBox3.ForeColor = System.Drawing.Color.Violet;
      this.groupBox3.Location = new System.Drawing.Point(544, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(506, 513);
      this.groupBox3.TabIndex = 0;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Kayıt Arama ve Listeleme";
      // 
      // txtBolumAdi_Arama
      // 
      this.txtBolumAdi_Arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtBolumAdi_Arama.Location = new System.Drawing.Point(38, 46);
      this.txtBolumAdi_Arama.Name = "txtBolumAdi_Arama";
      this.txtBolumAdi_Arama.Size = new System.Drawing.Size(432, 28);
      this.txtBolumAdi_Arama.TabIndex = 3;
      this.txtBolumAdi_Arama.TextChanged += new System.EventHandler(this.txtBolumAdi_Arama_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.Location = new System.Drawing.Point(35, 18);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(75, 18);
      this.label3.TabIndex = 2;
      this.label3.Text = "Bölüm Adı";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
      this.dataGridView1.Location = new System.Drawing.Point(24, 121);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(482, 349);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
      this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
      // 
      // Column1
      // 
      this.Column1.DataPropertyName = "bkodu";
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      this.Column1.DefaultCellStyle = dataGridViewCellStyle8;
      this.Column1.HeaderText = "Bölüm Kodu";
      this.Column1.MinimumWidth = 6;
      this.Column1.Name = "Column1";
      this.Column1.ToolTipText = "Bölüm Kodu";
      this.Column1.Width = 125;
      // 
      // Column2
      // 
      this.Column2.DataPropertyName = "badi";
      this.Column2.HeaderText = "Bölüm  Adı";
      this.Column2.MinimumWidth = 6;
      this.Column2.Name = "Column2";
      this.Column2.Width = 200;
      // 
      // toolStrip1
      // 
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 488);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(544, 25);
      this.toolStrip1.TabIndex = 1;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(111, 22);
      this.toolStripLabel1.Text = "toolStripLabel1";
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.düzeltToolStripMenuItem,
            this.silToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem,
            this.geriToolStripMenuItem,
            this.toolStripSeparator1,
            this.çıkışToolStripMenuItem1});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(143, 160);
      // 
      // yeniKayıtToolStripMenuItem
      // 
      this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
      this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
      this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.btnYeniKayit_Click);
      // 
      // düzeltToolStripMenuItem
      // 
      this.düzeltToolStripMenuItem.Name = "düzeltToolStripMenuItem";
      this.düzeltToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.düzeltToolStripMenuItem.Text = "Düzelt";
      this.düzeltToolStripMenuItem.Click += new System.EventHandler(this.btnDuzelt_Click);
      // 
      // silToolStripMenuItem
      // 
      this.silToolStripMenuItem.Name = "silToolStripMenuItem";
      this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.silToolStripMenuItem.Text = "Sil";
      this.silToolStripMenuItem.Click += new System.EventHandler(this.btnSil_Click);
      // 
      // çıkışToolStripMenuItem
      // 
      this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
      this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.çıkışToolStripMenuItem.Text = "İleri";
      this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.btnIleri_Click);
      // 
      // geriToolStripMenuItem
      // 
      this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
      this.geriToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
      this.geriToolStripMenuItem.Text = "Geri";
      this.geriToolStripMenuItem.Click += new System.EventHandler(this.btnGeri_Click);
      // 
      // çıkışToolStripMenuItem1
      // 
      this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
      this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
      this.çıkışToolStripMenuItem1.Text = "Çıkış";
      this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1050, 513);
      this.ContextMenuStrip = this.contextMenuStrip1;
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtBolumAdi;
    private System.Windows.Forms.TextBox txtBolumKodu;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnRaporla;
    private System.Windows.Forms.Button btnKaydet;
    private System.Windows.Forms.Button btnDuzelt;
    private System.Windows.Forms.Button btnSil;
    private System.Windows.Forms.Button btnYeniKayit;
    private System.Windows.Forms.Button btnIptal;
    private System.Windows.Forms.Button btnGeri;
    private System.Windows.Forms.Button btnIleri;
    private System.Windows.Forms.TextBox txtBolumAdi_Arama;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
  }
}

