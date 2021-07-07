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

namespace PanelWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    int panelBaslangicKonumu;
    private void Form1_Load(object sender, EventArgs e)
    {
      panelBaslangicKonumu = panel1.Left;
      panel1.Left = 20 - panel1.Width;
    }

    private void panel1_MouseEnter(object sender, EventArgs e)
    {
      for (int i = panel1.Left; i <=panelBaslangicKonumu; i+=2)
      {
        panel1.Left = i;
      
        Thread.Sleep(20);
      }
    }

    private void panel1_MouseLeave(object sender, EventArgs e)
    {
      
      for (int i = panel1.Left; i >= 10 - panel1.Width; i -= 2)
      {
        panel1.Left = i;
        Thread.Sleep(10);
      }
      
    }
  }
}
