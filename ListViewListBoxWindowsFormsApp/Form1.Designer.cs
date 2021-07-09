
namespace ListViewListBoxWindowsFormsApp
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
      System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "1234",
            "Adem",
            "AKKUŞ"}, -1);
      System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "1235",
            "Kerem",
            "AKKUŞ"}, -1);
      this.listView1 = new System.Windows.Forms.ListView();
      this.lsbAd = new System.Windows.Forms.ListBox();
      this.lsbNumara = new System.Windows.Forms.ListBox();
      this.lsbSoyad = new System.Windows.Forms.ListBox();
      this.rdbArtan = new System.Windows.Forms.RadioButton();
      this.rdbAzalan = new System.Windows.Forms.RadioButton();
      this.columnHeaderNumara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeaderSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.txtNumara = new System.Windows.Forms.TextBox();
      this.txtAd = new System.Windows.Forms.TextBox();
      this.txtSoyad = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listView1
      // 
      this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumara,
            this.columnHeaderAd,
            this.columnHeaderSoyad});
      this.listView1.FullRowSelect = true;
      this.listView1.GridLines = true;
      this.listView1.HideSelection = false;
      listViewItem7.StateImageIndex = 0;
      listViewItem7.Tag = "";
      listViewItem8.StateImageIndex = 0;
      this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8});
      this.listView1.Location = new System.Drawing.Point(0, 38);
      this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(445, 504);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = System.Windows.Forms.View.Details;
      this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
      // 
      // lsbAd
      // 
      this.lsbAd.FormattingEnabled = true;
      this.lsbAd.ItemHeight = 20;
      this.lsbAd.Location = new System.Drawing.Point(676, 38);
      this.lsbAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lsbAd.Name = "lsbAd";
      this.lsbAd.Size = new System.Drawing.Size(165, 504);
      this.lsbAd.TabIndex = 1;
      // 
      // lsbNumara
      // 
      this.lsbNumara.FormattingEnabled = true;
      this.lsbNumara.ItemHeight = 20;
      this.lsbNumara.Location = new System.Drawing.Point(503, 38);
      this.lsbNumara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lsbNumara.Name = "lsbNumara";
      this.lsbNumara.Size = new System.Drawing.Size(165, 504);
      this.lsbNumara.TabIndex = 2;
      // 
      // lsbSoyad
      // 
      this.lsbSoyad.FormattingEnabled = true;
      this.lsbSoyad.ItemHeight = 20;
      this.lsbSoyad.Location = new System.Drawing.Point(862, 38);
      this.lsbSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lsbSoyad.Name = "lsbSoyad";
      this.lsbSoyad.Size = new System.Drawing.Size(165, 504);
      this.lsbSoyad.TabIndex = 3;
      // 
      // rdbArtan
      // 
      this.rdbArtan.AutoSize = true;
      this.rdbArtan.Location = new System.Drawing.Point(15, 550);
      this.rdbArtan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rdbArtan.Name = "rdbArtan";
      this.rdbArtan.Size = new System.Drawing.Size(141, 24);
      this.rdbArtan.TabIndex = 4;
      this.rdbArtan.TabStop = true;
      this.rdbArtan.Text = "Artan Sıralama";
      this.rdbArtan.UseVisualStyleBackColor = true;
      this.rdbArtan.CheckedChanged += new System.EventHandler(this.rdbArtan_CheckedChanged);
      // 
      // rdbAzalan
      // 
      this.rdbAzalan.AutoSize = true;
      this.rdbAzalan.Location = new System.Drawing.Point(218, 550);
      this.rdbAzalan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.rdbAzalan.Name = "rdbAzalan";
      this.rdbAzalan.Size = new System.Drawing.Size(152, 24);
      this.rdbAzalan.TabIndex = 5;
      this.rdbAzalan.TabStop = true;
      this.rdbAzalan.Text = "Azalan Sıralama";
      this.rdbAzalan.UseVisualStyleBackColor = true;
      this.rdbAzalan.CheckedChanged += new System.EventHandler(this.rdbAzalan_CheckedChanged);
      // 
      // columnHeaderNumara
      // 
      this.columnHeaderNumara.Text = "Numara";
      this.columnHeaderNumara.Width = 76;
      // 
      // columnHeaderAd
      // 
      this.columnHeaderAd.Text = "Ad";
      this.columnHeaderAd.Width = 126;
      // 
      // columnHeaderSoyad
      // 
      this.columnHeaderSoyad.Text = "Soyad";
      this.columnHeaderSoyad.Width = 142;
      // 
      // txtNumara
      // 
      this.txtNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtNumara.Location = new System.Drawing.Point(308, 591);
      this.txtNumara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtNumara.Name = "txtNumara";
      this.txtNumara.Size = new System.Drawing.Size(192, 26);
      this.txtNumara.TabIndex = 0;
      // 
      // txtAd
      // 
      this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtAd.Location = new System.Drawing.Point(308, 633);
      this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtAd.Name = "txtAd";
      this.txtAd.Size = new System.Drawing.Size(192, 26);
      this.txtAd.TabIndex = 7;
      // 
      // txtSoyad
      // 
      this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtSoyad.Location = new System.Drawing.Point(308, 685);
      this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtSoyad.Name = "txtSoyad";
      this.txtSoyad.Size = new System.Drawing.Size(192, 26);
      this.txtSoyad.TabIndex = 8;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(222, 594);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 20);
      this.label1.TabIndex = 9;
      this.label1.Text = "Numara";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(261, 636);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 20);
      this.label2.TabIndex = 10;
      this.label2.Text = "Ad";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(235, 688);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 20);
      this.label3.TabIndex = 11;
      this.label3.Text = "Soyad";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(541, 646);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(158, 49);
      this.button1.TabIndex = 12;
      this.button1.Text = "Ekle";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1044, 872);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtSoyad);
      this.Controls.Add(this.txtAd);
      this.Controls.Add(this.txtNumara);
      this.Controls.Add(this.rdbAzalan);
      this.Controls.Add(this.rdbArtan);
      this.Controls.Add(this.lsbSoyad);
      this.Controls.Add(this.lsbNumara);
      this.Controls.Add(this.lsbAd);
      this.Controls.Add(this.listView1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ColumnHeader columnHeaderNumara;
    private System.Windows.Forms.ColumnHeader columnHeaderAd;
    private System.Windows.Forms.ColumnHeader columnHeaderSoyad;
    private System.Windows.Forms.ListBox lsbAd;
    private System.Windows.Forms.ListBox lsbNumara;
    private System.Windows.Forms.ListBox lsbSoyad;
    private System.Windows.Forms.RadioButton rdbArtan;
    private System.Windows.Forms.RadioButton rdbAzalan;
    private System.Windows.Forms.TextBox txtNumara;
    private System.Windows.Forms.TextBox txtAd;
    private System.Windows.Forms.TextBox txtSoyad;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button1;
  }
}

