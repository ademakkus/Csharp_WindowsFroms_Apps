using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnControlBoxGoster_Click(object sender, EventArgs e)
    {
     
      if (this.ControlBox == true)
      {
        this.Text = "";
        this.MinimizeBox = this.MaximizeBox = this.ControlBox = false;
        btnControlBoxGoster.Text = "Control Box Göster";
        
      }
      else
      {
        this.Text = "İlk Form Uygulaması";
        this.MinimizeBox = this.MaximizeBox = this.ControlBox = true;
btnControlBoxGoster.Text = "Control Box Gizle"; 
      }
      //this.ControlBox = true; yerine aşağıdaki
      

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Text = "";
      lblMerhaba.Visible = false;
    }

  

    private void btnLabelGoster_Click(object sender, EventArgs e)
    {
      if (lblMerhaba.Visible == true)
      {
        lblMerhaba.Visible = false;
        btnLabelGoster.Text = "Label Göster";
      
      }
      else
      {  
        colorDialog1.ShowDialog(); //renk paletini göster
        lblMerhaba.ForeColor = colorDialog1.Color;
        lblMerhaba.Visible = true;
        btnLabelGoster.Text = "Label Gizle";
        btnLabelGoster.BackColor = colorDialog1.Color;
      }
    }

    private void btnRenkDegistir_Click(object sender, EventArgs e)
    {
      DialogResult result;
      result=colorDialog1.ShowDialog(); //renk paletini göster
      if (result==DialogResult.OK)
        this.BackColor = colorDialog1.Color;

    }
  }
}
