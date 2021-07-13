using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingSourceWindowsFormsAppV5
{
  public partial class Form3 : Form
  {
    private int kacinciKayit;
    bool yeniKayitMi;
    string eskiABDAdi;
    private int kayitSayisi;
    readonly static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\ogrenciler.mdb";
    OleDbConnection conn = new OleDbConnection(connectionString);
    DataSet ds = new DataSet();
    BindingSource bs = new BindingSource();
    public Form3()
    {
      InitializeComponent();
    }

    private void label6_Click(object sender, EventArgs e)
    {

    }
    private void VerileriCek()
    {
      string query = "SELECT g.*,a.abdadi,b.badi FROM anabilimdali as a,genel as g,bolumler as b WHERE g.bkodu=b.bkodu AND g.abdkodu=a.abdkodu";
      OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      if (ds.Tables["genel"] != null) ds.Tables["genel"].Clear();

      adapter.Fill(ds, "genel");

    }
    private void Form3_Load(object sender, EventArgs e)
    {
      //MessageBox.Show(connectionString,"Test");
      if (conn.State == ConnectionState.Closed) conn.Open();
      string query = "SELECT * FROM bolumler";
      OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      adapter.Fill(ds, "bolumler");
      adapter.Fill(ds, "bolumler1");
      cmbBolumAdi.DataSource = ds.Tables["bolumler"];
      cmbBolumAdi.DisplayMember = "badi";
      cmbBolumAdi.ValueMember = "bkodu";
      //arama kısmı için
      cmbBolumAdi_la.DataSource = ds.Tables["bolumler1"];
      cmbBolumAdi_la.DisplayMember = "badi";
      cmbBolumAdi_la.ValueMember = "bkodu";
      cmbBolumAdi_SelectedIndexChanged(sender, e);
      btnKaydet.Visible = btnIptal.Visible = false;
      VerileriCek();
      bs.DataSource = ds.Tables["genel"];
      dataGridView1.DataSource = bs;
    }

    private void cmbBolumAdi_SelectedIndexChanged(object sender, EventArgs e)
    {
      //
      try
      {
       // string query = "SELECT * FROM anabilimdali WHERE bkodu="+cmbBolumAdi.SelectedValue; //bkodu integer tipinde olduğundan +cmbBolumAdi.SelectedValue
        string query = $"SELECT * FROM anabilimdali WHERE bkodu={cmbBolumAdi.SelectedValue}"; //bkodu integer tipinde olduğundan +cmbBolumAdi.SelectedValue
        //MessageBox.Show(cmbBolumAdi.SelectedValue.ToString(),"Test");
        OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
        if (ds.Tables["anabilimdali"] != null) ds.Tables["anabilimdali"].Clear();
        da.Fill(ds, "anabilimdali");
        cmbAnaBilimDali.DataSource = ds.Tables["anabilimdali"];
        cmbAnaBilimDali.DisplayMember = "abdadi";
        cmbAnaBilimDali.ValueMember = "abdkodu";
      }
      catch{}
     // conn.Close();
      //conn.Dispose();
    }
  
    private void btnYeniKayit_Click(object sender, EventArgs e)
    {
      btnKaydet.Visible = btnIptal.Visible = true;
      txtAdi.Clear();
      txtNumara.Clear();
      txtSoyadi.Clear();
      txtDogumYeri.Clear();
      pcbResimEkle.ImageLocation = "";
      cmbCinsiyet.SelectedIndex = 0;
      txtNumara.Focus();
      btnYeniKayit.Visible = false;
      //kacinciKayit = ds.Tables["genel"];
    }

    private void btnResimEkle_Click(object sender, EventArgs e)
    {
      openFileDialog1.InitialDirectory = Application.StartupPath + "\\images\\";
     DialogResult result = openFileDialog1.ShowDialog();
      if (result == DialogResult.OK)
    pcbResimEkle.ImageLocation = openFileDialog1.FileName;
    
      //MessageBox.Show(openFileDialog1.FileName,"Test");

    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
    //    if (conn.State == ConnectionState.Closed) conn.Open();
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = conn;
        
            cmd.CommandText = "INSERT INTO genel(numara,adi,soyadi,dtarihi,dyeri,cinsiyet,resim,abdkodu,bkodu) VALUES(@numara,@adi,@soyadi,@dtarihi,@dyeri,@cinsiyet,@resim,@abdkodu,@bkodu)";
            cmd.Parameters.AddWithValue("@numara", txtNumara.Text);
            cmd.Parameters.AddWithValue("@adi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
   
        cmd.Parameters.AddWithValue("@dtarihi", dtpDogumTarihi.Text);
            cmd.Parameters.AddWithValue("@dyeri", txtDogumYeri.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.SelectedItem);
            cmd.Parameters.AddWithValue("@resim", pcbResimEkle.ImageLocation);     
       cmd.Parameters.AddWithValue("@abdkodu", cmbAnaBilimDali.SelectedValue);
            cmd.Parameters.AddWithValue("@bkodu", cmbBolumAdi.SelectedValue);
      cmd.ExecuteNonQuery();
            MessageBox.Show(txtAdi.Text+" "+txtSoyadi.Text + " eklendi", "Bölüm Ekleme");
          
          
                }
      catch (Exception exc)
      {
        MessageBox.Show("Kaydetme hatası:" + exc.ToString(), "Kaydetme İşlemi");

      }
      VerileriCek();
  btnYeniKayit.Visible = true;
         
            btnKaydet.Visible = btnIptal.Visible = false;
      bs.Position = kacinciKayit;
      
    }
  }
}
