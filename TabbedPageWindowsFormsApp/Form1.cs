using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabbedPageWindowsFormsApp
{
  public partial class Form1 : Form
  {
    object[] obj;
    object[] obj2;
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {


    }
    private void tabControl1_Click(object sender, EventArgs e)
    {
      lblNumara.Text = txtNumara.Text;
      lblAdSoyad.Text = txtAdSoyad.Text;
      lblBolum.Text = (cmbBolum.SelectedIndex == -1) ? "Bölüm :Seçilmedi " : cmbBolum.SelectedItem.ToString();
      lblCinsiyet.Text = (rdbErkek.Checked) ? rdbErkek.Text : rdbKadin.Checked ? rdbKadin.Text : "Cinsiyet :Seçilmedi ";
      lblDogumYeri.Text = txtDogumYeri.Text;
    }

    private void listBox1_DoubleClick(object sender, EventArgs e)
    {
      listBox2.Items.Add(listBox1.SelectedItem);
      listBox1.Items.Remove(listBox1.SelectedItem);
      ArrayList list = new ArrayList();
      list.Sort();
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {

      obj = new object[listBox1.Items.Count];
      listBox1.Items.CopyTo(obj, 0);
      if (checkBox3.Checked)
        listBox1.Sorted = true;
      else if (!checkBox3.Checked)
      {
        listBox1.Sorted = false;

        listBox1.Items.Clear();
        listBox1.Items.AddRange(obj);
        //  foreach (var item in obj)
        //  {
        //    listBox1.Items.Add(item);
        //  }    
      }
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e)
    {
      obj2 = new object[listBox2.Items.Count];
      listBox2.Items.CopyTo(obj2, 0);
      if (checkBox4.Checked)
        listBox2.Sorted = true;
      else //if (!checkBox4.Checked)
      {
        listBox2.Sorted = false;

        listBox2.Items.Clear();
        listBox2.Items.AddRange(obj2);
        //  foreach (var item in obj2)
        //  {
        //    listBox2.Items.Add(item);
        //  }    
      }
    }

    private void listBox2_DoubleClick(object sender, EventArgs e)
    {
      listBox1.Items.Add(listBox2.SelectedItem);
      listBox2.Items.Remove(listBox2.SelectedItem);
    }
  }
}

