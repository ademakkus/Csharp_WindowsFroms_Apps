using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    DataSet ds = new DataSet();

    private void Form1_Load(object sender, EventArgs e)
    {
      label1.Text = "Hoş geldiniz ," + frmGiris.adsoyad;
      btnTamam.Enabled = btnIptal.Enabled = false;
      ds.ReadXml("Users.xml");
      dataGridView1.DataSource = ds.Tables[0];
    }

    private void btnYeni_Click(object sender, EventArgs e)
    {
      btnTamam.Enabled = btnIptal.Enabled = true;
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    { 
      
    }

    private void btnTamam_Click(object sender, EventArgs e)
    {
      btnTamam.Enabled = btnIptal.Enabled= false;
      DataRow dataRow = ds.Tables[0].NewRow();
      dataRow["adi"] = txtAdi.Text;
      dataRow["soyadi"] = txtSoyadi.Text;
      dataRow["ka"] = txtKullaniciAdi.Text;
      dataRow["sf"] = txtSifre.Text;
      ds.Tables[0].Rows.Add(dataRow);   //bellekteki sanal dosyada
      ds.WriteXml("Users.xml");             //xml dosyasına yaz.
    }

    private void btnIptal_Click(object sender, EventArgs e)
    {
      btnTamam.Enabled = btnIptal.Enabled = false;
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      int kayitNo = dataGridView1.CurrentRow.Index;
      
      try
      {

        if (kayitNo >= -1)
        {
          DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
          if (result == DialogResult.Yes)
          {
            ds.Tables[0].Rows[kayitNo].Delete();
            ds.WriteXml("Users.xml");
          }
         
        }
      }
      catch { }
    }

    private void btnDuzelt_Click(object sender, EventArgs e)
    {
      int kayitNo = dataGridView1.CurrentRow.Index;

      try
      {

        if (kayitNo >= -1)
        {
          DialogResult result = MessageBox.Show("Güncellemek istediğinizden emin misiniz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == DialogResult.Yes)
          {
            ds.Tables[0].Rows[kayitNo]["ka"]=txtKullaniciAdi.Text;
            ds.Tables[0].Rows[kayitNo]["sf"]=txtSifre.Text;
            ds.Tables[0].Rows[kayitNo]["adi"]=txtAdi.Text;
            ds.Tables[0].Rows[kayitNo]["soyadi"]=txtSoyadi.Text;
            ds.WriteXml("Users.xml");
          }
          
        }
      }
      catch { }
    }
  }
}
