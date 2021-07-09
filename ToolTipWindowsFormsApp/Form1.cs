using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTipWindowsFormsApp
{
  public partial class Form1 : Form
  {

    object[] cb1Copy, cb2Copy;
   
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      cb1Copy = new object[listBox1.Items.Count];
      listBox1.Items.CopyTo(cb1Copy,0);
      
      cb2Copy = new object[comboBox1.Items.Count];
comboBox1.Items.CopyTo(cb2Copy,0);
      for (int i = 0; i < comboBox1.Items.Count; i++)
      {
        listBox1.Items.Add(comboBox1.Items[i]);
      }
      Guncelle();
      toolStripLabel1.Text = "Gözünüz burda olsun";
    }
    private void Guncelle()
    {
      toolTip1.SetToolTip(listBox1, "Kayıt sayısı=" + listBox1.Items.Count);
      toolTip1.SetToolTip(comboBox1, "Kayıt sayısı=" + comboBox1.Items.Count);
    }
    private void btnEkle_Click(object sender, EventArgs e)
    {

      try
      {
        if (!String.IsNullOrWhiteSpace(txtEklenen.Text))
        {
          if (rdbComboBoxa.Checked)
          {
            comboBox1.Items.Add(txtEklenen.Text);
            txtEklenen.Text = "";
        }
        else if (rdbListBoxa.Checked)
          {
            listBox1.Items.Add(txtEklenen.Text);
            txtEklenen.Text = "";
          }
        else
        {
          comboBox1.Items.Add(txtEklenen.Text);
          listBox1.Items.Add(txtEklenen.Text);
        }
        }
        else
        {
          MessageBox.Show("Eklenecek değer yok .", "Değer Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch
      {

        MessageBox.Show("Geçersiz değer  .","Değer Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
      }
      finally
      {
        Guncelle();
      }
    }

    private void listBox1_MouseEnter(object sender, EventArgs e)
    {
      toolStripLabel1.Text = "Kayıt sayısı=" + listBox1.Items.Count;
    }

    private void listBox1_MouseLeave(object sender, EventArgs e)
    {
      toolStripLabel1.Text = "Gözünüz burda olsun.";
    }
    private void ToolStripEski(object sender, EventArgs e)
    {
      toolStripLabel1.Text= "Gözünüz burda olsun.";
    }
    private void ToolStripGoster(object sender, EventArgs e)
    {

    }

    private void comboBox1_MouseEnter(object sender, EventArgs e)
    {
      toolStripLabel1.Text = "Kayıt sayısı=" + comboBox1.Items.Count;
    }

    private void txtEklenen_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode==Keys.Enter)
      {
        btnEkle_Click(sender, e);
      }
    }

    private void txtAranan_TextChanged(object sender, EventArgs e)
    {
      listBox1.SelectedIndex = listBox1.FindString(txtAranan.Text);
      comboBox1.SelectedIndex = comboBox1.FindString(txtAranan.Text);

    }

    private void btnArtanSıralama_Click(object sender, EventArgs e)
    {
      listBox1.Sorted = false;
      comboBox1.Sorted = false;
      if (listBox1.Sorted&&comboBox1.Sorted)
      {
       
        listBox1.Items.AddRange(cb1Copy);
        comboBox1.Items.AddRange(cb2Copy);
       listBox1.Sorted = false;
        comboBox1.Sorted = false;
        comboBox1.Refresh();
        listBox1.Refresh();
      }
      else
      {
        
        listBox1.Sorted = true;
        comboBox1.Sorted = true;

      }
    }
  }
}
