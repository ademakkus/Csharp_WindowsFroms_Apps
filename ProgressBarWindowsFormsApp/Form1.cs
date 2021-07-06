using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int deger = int.Parse(txtKacDefa.Text);
      progressBar1.Maximum = deger;
      progressBar1.Minimum = 0;
      progressBar1.Value = 0;
      for (int i = 0; i <= deger; i++)
      {
        progressBar1.Value= i;
      }
    }
  }
}
