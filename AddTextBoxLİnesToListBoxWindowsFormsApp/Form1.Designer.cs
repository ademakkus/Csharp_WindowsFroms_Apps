
namespace AddTextBoxLİnesToListBoxWindowsFormsApp
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.button2 = new System.Windows.Forms.Button();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 42);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(325, 260);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(343, 106);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(131, 37);
      this.button1.TabIndex = 1;
      this.button1.Text = "Aktar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Location = new System.Drawing.Point(744, 42);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(283, 260);
      this.listBox1.TabIndex = 2;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(459, 42);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(283, 24);
      this.comboBox1.TabIndex = 3;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(322, 347);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(170, 37);
      this.button2.TabIndex = 4;
      this.button2.Text = "Seçili Satırları Aktar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.ItemHeight = 16;
      this.listBox2.Location = new System.Drawing.Point(744, 336);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(283, 228);
      this.listBox2.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1039, 592);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ListBox listBox2;
  }
}

