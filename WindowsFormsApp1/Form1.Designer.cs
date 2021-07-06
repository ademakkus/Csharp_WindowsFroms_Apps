
namespace WindowsFormsApp1
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
      this.btnControlBoxGoster = new System.Windows.Forms.Button();
      this.btnLabelGoster = new System.Windows.Forms.Button();
      this.lblMerhaba = new System.Windows.Forms.Label();
      this.btnRenkDegistir = new System.Windows.Forms.Button();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.SuspendLayout();
      // 
      // btnControlBoxGoster
      // 
      this.btnControlBoxGoster.Location = new System.Drawing.Point(469, 214);
      this.btnControlBoxGoster.Name = "btnControlBoxGoster";
      this.btnControlBoxGoster.Size = new System.Drawing.Size(179, 42);
      this.btnControlBoxGoster.TabIndex = 0;
      this.btnControlBoxGoster.Text = "Control Box Göster";
      this.btnControlBoxGoster.UseVisualStyleBackColor = true;
      this.btnControlBoxGoster.Click += new System.EventHandler(this.btnControlBoxGoster_Click);
      // 
      // btnLabelGoster
      // 
      this.btnLabelGoster.Location = new System.Drawing.Point(48, 185);
      this.btnLabelGoster.Name = "btnLabelGoster";
      this.btnLabelGoster.Size = new System.Drawing.Size(195, 44);
      this.btnLabelGoster.TabIndex = 1;
      this.btnLabelGoster.Text = "Label Göster ve Renk Değiştir";
      this.btnLabelGoster.UseVisualStyleBackColor = true;
      this.btnLabelGoster.Click += new System.EventHandler(this.btnLabelGoster_Click);
      // 
      // lblMerhaba
      // 
      this.lblMerhaba.AutoSize = true;
      this.lblMerhaba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblMerhaba.ForeColor = System.Drawing.Color.Teal;
      this.lblMerhaba.Location = new System.Drawing.Point(215, 56);
      this.lblMerhaba.Name = "lblMerhaba";
      this.lblMerhaba.Size = new System.Drawing.Size(158, 25);
      this.lblMerhaba.TabIndex = 2;
      this.lblMerhaba.Text = "Merhaba Dünya!";
      // 
      // btnRenkDegistir
      // 
      this.btnRenkDegistir.Location = new System.Drawing.Point(316, 323);
      this.btnRenkDegistir.Name = "btnRenkDegistir";
      this.btnRenkDegistir.Size = new System.Drawing.Size(176, 39);
      this.btnRenkDegistir.TabIndex = 3;
      this.btnRenkDegistir.Text = "Renk Değiştir";
      this.btnRenkDegistir.UseVisualStyleBackColor = true;
      this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.ControlBox = false;
      this.Controls.Add(this.btnRenkDegistir);
      this.Controls.Add(this.lblMerhaba);
      this.Controls.Add(this.btnLabelGoster);
      this.Controls.Add(this.btnControlBoxGoster);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnControlBoxGoster;
    private System.Windows.Forms.Button btnLabelGoster;
    private System.Windows.Forms.Label lblMerhaba;
    private System.Windows.Forms.Button btnRenkDegistir;
    private System.Windows.Forms.ColorDialog colorDialog1;
  }
}

