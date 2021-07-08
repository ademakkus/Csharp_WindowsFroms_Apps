
namespace ReverseStringWindowsFormsApp
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
      this.txtMetin = new System.Windows.Forms.TextBox();
      this.btnTerstenYazdir = new System.Windows.Forms.Button();
      this.btnKelimelereAyir = new System.Windows.Forms.Button();
      this.txtTersten = new System.Windows.Forms.TextBox();
      this.nudNereden = new System.Windows.Forms.NumericUpDown();
      this.nudKacTane = new System.Windows.Forms.NumericUpDown();
      this.btnAlGoster = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.nudNereden)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudKacTane)).BeginInit();
      this.SuspendLayout();
      // 
      // txtMetin
      // 
      this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtMetin.Location = new System.Drawing.Point(156, 134);
      this.txtMetin.Name = "txtMetin";
      this.txtMetin.Size = new System.Drawing.Size(344, 28);
      this.txtMetin.TabIndex = 0;
      // 
      // btnTerstenYazdir
      // 
      this.btnTerstenYazdir.Location = new System.Drawing.Point(12, 301);
      this.btnTerstenYazdir.Name = "btnTerstenYazdir";
      this.btnTerstenYazdir.Size = new System.Drawing.Size(178, 51);
      this.btnTerstenYazdir.TabIndex = 1;
      this.btnTerstenYazdir.Text = "Tersten Yazdır";
      this.btnTerstenYazdir.UseVisualStyleBackColor = true;
      this.btnTerstenYazdir.Click += new System.EventHandler(this.btnTerstenYazdir_Click);
      // 
      // btnKelimelereAyir
      // 
      this.btnKelimelereAyir.Location = new System.Drawing.Point(235, 301);
      this.btnKelimelereAyir.Name = "btnKelimelereAyir";
      this.btnKelimelereAyir.Size = new System.Drawing.Size(201, 51);
      this.btnKelimelereAyir.TabIndex = 2;
      this.btnKelimelereAyir.Text = "button2";
      this.btnKelimelereAyir.UseVisualStyleBackColor = true;
      this.btnKelimelereAyir.Click += new System.EventHandler(this.btnKelimelereAyir_Click);
      // 
      // txtTersten
      // 
      this.txtTersten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtTersten.Location = new System.Drawing.Point(156, 186);
      this.txtTersten.Name = "txtTersten";
      this.txtTersten.Size = new System.Drawing.Size(344, 28);
      this.txtTersten.TabIndex = 3;
      // 
      // nudNereden
      // 
      this.nudNereden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.nudNereden.Location = new System.Drawing.Point(577, 297);
      this.nudNereden.Name = "nudNereden";
      this.nudNereden.Size = new System.Drawing.Size(53, 28);
      this.nudNereden.TabIndex = 4;
      // 
      // nudKacTane
      // 
      this.nudKacTane.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.nudKacTane.Location = new System.Drawing.Point(705, 297);
      this.nudKacTane.Name = "nudKacTane";
      this.nudKacTane.Size = new System.Drawing.Size(53, 28);
      this.nudKacTane.TabIndex = 5;
      // 
      // btnAlGoster
      // 
      this.btnAlGoster.Location = new System.Drawing.Point(596, 367);
      this.btnAlGoster.Name = "btnAlGoster";
      this.btnAlGoster.Size = new System.Drawing.Size(196, 51);
      this.btnAlGoster.TabIndex = 6;
      this.btnAlGoster.Text = "Al Göster";
      this.btnAlGoster.UseVisualStyleBackColor = true;
      this.btnAlGoster.Click += new System.EventHandler(this.btnAlGoster_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Location = new System.Drawing.Point(593, 15);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(272, 228);
      this.listBox1.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(568, 267);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 17);
      this.label1.TabIndex = 8;
      this.label1.Text = "Nereden?";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(700, 267);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(77, 17);
      this.label2.TabIndex = 9;
      this.label2.Text = "Kaç Tane?";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(5, 192);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(132, 17);
      this.label3.TabIndex = 10;
      this.label3.Text = "Tersten Yazdırılmış:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(42, 140);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(95, 17);
      this.label4.TabIndex = 11;
      this.label4.Text = "Normal Metin:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(911, 450);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.btnAlGoster);
      this.Controls.Add(this.nudKacTane);
      this.Controls.Add(this.nudNereden);
      this.Controls.Add(this.txtTersten);
      this.Controls.Add(this.btnKelimelereAyir);
      this.Controls.Add(this.btnTerstenYazdir);
      this.Controls.Add(this.txtMetin);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.nudNereden)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudKacTane)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtMetin;
    private System.Windows.Forms.Button btnTerstenYazdir;
    private System.Windows.Forms.Button btnKelimelereAyir;
    private System.Windows.Forms.TextBox txtTersten;
    private System.Windows.Forms.NumericUpDown nudNereden;
    private System.Windows.Forms.NumericUpDown nudKacTane;
    private System.Windows.Forms.Button btnAlGoster;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
  }
}

