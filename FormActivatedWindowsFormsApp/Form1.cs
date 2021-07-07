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

namespace FormActivatedWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
      progressBar1.Maximum = 100;
      for (int i = 0; i <=100; i++)
      {
        progressBar1.Value = i;
        Thread.Sleep(100);
        label1.Text = "Yükleniyor ....%" + progressBar1.Value;
        label1.Refresh();
      }
      Form2 frm2 = new Form2();
      this.Hide();
      frm2.ShowDialog();
    }
  }
}
