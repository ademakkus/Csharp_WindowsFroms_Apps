using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewListBoxWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void listView1_DoubleClick(object sender, EventArgs e)
    {
      lsbNumara.Items.Add(listView1.SelectedItems[0].Text);
      lsbAd.Items.Add(listView1.SelectedItems[0].SubItems[1].Text);
      lsbSoyad.Items.Add(listView1.SelectedItems[0].SubItems[2].Text);
      listView1.Items.Remove(listView1.SelectedItems[0]);
  

    }
private void Ekle(string numara,string ad,string soyad)
    {
      ListViewItem viewItem = new ListViewItem();
      viewItem.Text = numara;
      viewItem.SubItems.Add(ad);
      viewItem.SubItems.Add(soyad);
      listView1.Items.Add(viewItem);

    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrWhiteSpace(txtNumara.Text)||
      String.IsNullOrWhiteSpace(txtAd.Text)||
      String.IsNullOrWhiteSpace(txtSoyad.Text)
      )
      {
        MessageBox.Show("Boş geçilemez.","Boş Değer",MessageBoxButtons.OK,MessageBoxIcon.Information);
      }

      else
      {
        string numara, ad, soyad;
        numara = txtNumara.Text;
        ad = txtAd.Text;
        soyad = txtSoyad.Text;
        Ekle(numara, ad, soyad);
        Temizle();
      }
    }

    private void Temizle()
    {
      txtAd.Text = "";
      txtNumara.Text = "";
      txtSoyad.Text = "";
    }

    private void rdbArtan_CheckedChanged(object sender, EventArgs e)
    {
      listView1.Sorting = SortOrder.Ascending;
    }

    private void rdbAzalan_CheckedChanged(object sender, EventArgs e)
    {
      listView1.Sorting = SortOrder.Descending;

    }
  }
}
