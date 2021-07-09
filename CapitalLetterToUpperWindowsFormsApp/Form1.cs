using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapitalLetterToUpperWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      if (textBox1.Text.Length == 1)
      {
        string ilk = textBox1.Text.Substring(0, 1);
        ilk = ilk.ToUpper();
        textBox1.Text = ilk;
        textBox1.Select(textBox1.Text.Length, 1);   //imleci string sonuna konumlandırma
      }
    }
  }
}
