using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyIconWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason==CloseReason.UserClosing)
      {
        e.Cancel = true;
        notifyIcon1.Visible = true;
        notifyIcon1.ShowBalloonTip(1000, "Merhba", "Merhaba", ToolTipIcon.Info);
        this.Hide();
      }
    }

    private void açToolStripMenuItem_Click(object sender, EventArgs e)
    {
      notifyIcon1.Visible = false;
      this.Show();
    }

    private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
