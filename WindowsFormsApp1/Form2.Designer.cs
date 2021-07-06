
namespace WindowsFormsApp1
{
  partial class Form2
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
      this.btnSay = new System.Windows.Forms.Button();
      this.btnTiklaSay = new System.Windows.Forms.Button();
      this.lblSayac = new System.Windows.Forms.Label();
      this.lblSayac2 = new System.Windows.Forms.Label();
      this.btnSay100 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnSay
      // 
      this.btnSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnSay.Location = new System.Drawing.Point(264, 189);
      this.btnSay.Name = "btnSay";
      this.btnSay.Size = new System.Drawing.Size(168, 50);
      this.btnSay.TabIndex = 0;
      this.btnSay.Text = "Say";
      this.btnSay.UseVisualStyleBackColor = true;
      this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
      // 
      // btnTiklaSay
      // 
      this.btnTiklaSay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTiklaSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnTiklaSay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.btnTiklaSay.Location = new System.Drawing.Point(259, 55);
      this.btnTiklaSay.Name = "btnTiklaSay";
      this.btnTiklaSay.Size = new System.Drawing.Size(173, 44);
      this.btnTiklaSay.TabIndex = 1;
      this.btnTiklaSay.Text = "Tıkla-Say";
      this.btnTiklaSay.UseVisualStyleBackColor = true;
      this.btnTiklaSay.Click += new System.EventHandler(this.btnTiklaSay_Click);
      this.btnTiklaSay.MouseEnter += new System.EventHandler(this.btnTiklaSay_MouseEnter);
      this.btnTiklaSay.MouseLeave += new System.EventHandler(this.btnTiklaSay_MouseLeave);
      // 
      // lblSayac
      // 
      this.lblSayac.AutoSize = true;
      this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblSayac.Location = new System.Drawing.Point(324, 140);
      this.lblSayac.Name = "lblSayac";
      this.lblSayac.Size = new System.Drawing.Size(42, 46);
      this.lblSayac.TabIndex = 2;
      this.lblSayac.Text = "0";
      // 
      // lblSayac2
      // 
      this.lblSayac2.AutoSize = true;
      this.lblSayac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblSayac2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblSayac2.Location = new System.Drawing.Point(68, 128);
      this.lblSayac2.Name = "lblSayac2";
      this.lblSayac2.Size = new System.Drawing.Size(57, 63);
      this.lblSayac2.TabIndex = 2;
      this.lblSayac2.Text = "0";
      // 
      // btnSay100
      // 
      this.btnSay100.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnSay100.Location = new System.Drawing.Point(68, 194);
      this.btnSay100.Name = "btnSay100";
      this.btnSay100.Size = new System.Drawing.Size(168, 50);
      this.btnSay100.TabIndex = 0;
      this.btnSay100.Text = "Say 100";
      this.btnSay100.UseVisualStyleBackColor = true;
      this.btnSay100.Click += new System.EventHandler(this.btnSay100_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblSayac2);
      this.Controls.Add(this.lblSayac);
      this.Controls.Add(this.btnTiklaSay);
      this.Controls.Add(this.btnSay100);
      this.Controls.Add(this.btnSay);
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form2";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSay;
    private System.Windows.Forms.Button btnTiklaSay;
    private System.Windows.Forms.Label lblSayac;
    private System.Windows.Forms.Label lblSayac2;
    private System.Windows.Forms.Button btnSay100;
  }
}