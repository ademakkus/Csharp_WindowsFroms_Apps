using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    int count = 60;
    private void timer1_Tick(object sender, EventArgs e)
    {
      count--;
      progressBar1.Value = count;
      label1.Text = count.ToString();
      if (count<=0)
      {
        timer1.Enabled = false;
        timer2.Enabled = true;
      }
    }
    
    private void timer2_Tick(object sender, EventArgs e)
    {
      count++;
      label1.Text = count.ToString();    
      progressBar1.Value = count;
      if (count >= 60)
      {
        timer1.Enabled = true;
        timer2.Enabled = false;
    
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      timer1.Enabled = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      progressBar1.Maximum = 60;
      progressBar1.Minimum = 0;

    }
  }
}
