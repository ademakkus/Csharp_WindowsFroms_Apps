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
  public partial class frmGiris : Form
  {
    public frmGiris()
    {
      InitializeComponent();
    }
    public static string adsoyad;

    private void btnCikis_Click(object sender, EventArgs e)
    {
      Application.Exit();
     
    }

    private void btnGiris_Click(object sender, EventArgs e)
    {
      DataSet ds = new DataSet();
      ds.ReadXml("Users.xml");
      bool kontrol = false;
      for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      {
        if(txtKullaniciAdi.Text==ds.Tables[0].Rows[i]["ka"].ToString()&&
          txtSifre.Text == ds.Tables[0].Rows[i]["sf"].ToString())
        {
          kontrol = true;
          Form1 frm1 = new Form1();
          adsoyad = ds.Tables[0].Rows[i]["adi"].ToString() + " " + ds.Tables[0].Rows[i]["soyadi"].ToString();
          frm1.Show();
          this.Hide();
        }
      }
    }
  }
}
