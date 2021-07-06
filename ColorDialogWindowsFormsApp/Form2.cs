using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDialogWindowsFormsApp
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void Form2_Click(object sender, EventArgs e)
    {
      //  this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      Random random = new Random();
      int col1, col2, col3;
      for (int i = 1; i <=100; i++)
      {
        col1 = random.Next(255);
        col2 = random.Next(255);
        col3 = random.Next( 255);
        label1.Text = col1.ToString();
        label3.Text = col2.ToString();
        label4.Text = col3.ToString();
        this.BackColor = Color.FromArgb(col1, col2, col3);
        this.Refresh();
        col1 = random.Next(255);
        col2 = random.Next(255);
        col3 = random.Next(255);
        label2.ForeColor = Color.FromArgb(col1, col2, col3);
        label2.Text = "Merhaba Dünya "+ i;
        label2.Refresh();
        Thread.Sleep(100);
      }
    }
  }
}
