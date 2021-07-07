using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTextBoxLİnesToListBoxWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      listBox1.Items.Clear();
      comboBox1.Items.Clear();
      for (int i = 0; i < textBox1.Lines.Length; i++)
      {
        listBox1.Items.Add(textBox1.Lines[i]);
        comboBox1.Items.Add(textBox1.Lines[i]);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
    
      if(textBox1.SelectedText.Length<0)
        MessageBox.Show("Satır seçiniz. ","Satır Seçme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
      else
      {
       
          listBox2.Items.Add(textBox1.SelectedText);
       
      }
    }
  }
}
