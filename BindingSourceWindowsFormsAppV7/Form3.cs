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

namespace BindingSourceWindowsFormsAppV7
{
  public partial class Form3 : Form
  {
    private int kacinciKayit;
    
    readonly static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\ogrenciler.mdb";
    OleDbConnection conn = new OleDbConnection(connectionString);
    public static DataSet ds = new DataSet();
    BindingSource bs = new BindingSource();
  private  string ilkAdSoyad ;
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
      VeritabaninaBaglan();
      ilerigerikontrol(sender, e);
      dataGridView1_SelectionChanged(sender, e);
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
      bs.PositionChanged += new EventHandler(ilerigerikontrol);
    }

    private void ilerigerikontrol(object sender, EventArgs e)
    {
     ilkAdSoyad = txtAdi.Text + " " + txtSoyadi.Text;
      if (bs.Position == 0) btnGeri.Enabled = false;
      else btnGeri.Enabled = true; 
      if (bs.Position == bs.Count-1) btnIleri.Enabled = false;
      else btnIleri.Enabled = true;

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
      if (!KayitVarMi(txtNumara.Text))
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
          MessageBox.Show(txtAdi.Text + " " + txtSoyadi.Text + " eklendi", "Bölüm Ekleme");


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
      else MessageBox.Show(txtNumara.Text+" numaralı öğrenci zaten kayıtlı.","Test");
    }
    
   private  bool KayitVarMi(string arananNumara)
    {
      string query = "SELECT  * FROM genel WHERE numara='"+arananNumara+"'";   
      OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
       if (ds.Tables["arama"] != null) ds.Tables["arama"].Clear();
      adapter.Fill(ds, "arama");
      if (ds.Tables["arama"].Rows.Count <= 0) return false;
      else return true;
    }
    private void VeritabaninaBaglan()
    {
      txtNumara.DataBindings.Add("Text", bs, "numara");
      txtAdi.DataBindings.Add("Text", bs, "adi");
      txtSoyadi.DataBindings.Add("Text", bs, "soyadi");
      txtDogumYeri.DataBindings.Add("Text", bs, "dyeri");
      cmbBolumAdi.DataBindings.Add("SelectedValue", bs, "bkodu");
      cmbAnaBilimDali.DataBindings.Add("SelectedValue", bs, "abdkodu");
      dtpDogumTarihi.DataBindings.Add("Text", bs, "dtarihi");
      cmbCinsiyet.DataBindings.Add("SelectedItem", bs, "cinsiyet");
      pcbResimEkle.DataBindings.Add("ImageLocation", bs, "resim");
      dataGridView1.DataSource = bs;
    }

    private void btnGeri_Click(object sender, EventArgs e)
    {
      bs.Position--;
    }

    private void btnIleri_Click(object sender, EventArgs e)
    {
      bs.Position++;
    }

    private void btnDuzelt_Click(object sender, EventArgs e)
    {
      if (!KayitVarMi(txtNumara.Text) & txtNumara.Text != duzeltilecekNumara)
      {
        MessageBox.Show(txtNumara.Text + " zaten var.", "Kayıt Düzelme İşlemi");
        return;
      }
      int kayitno = bs.Position;
      OleDbCommand cmd = new OleDbCommand();
      cmd.Connection = conn;
      cmd.CommandText = "UPDATE genel SET numara=@numara,adi=@adi,soyadi=@soyadi,dtarihi=@dtarihi,dyeri=@dyeri,cinsiyet=@cinsiyet,resim=@resim,abdkodu=@abdkodu,bkodu=@bkodu WHERE numara=@tutnumara";
      cmd.Parameters.AddWithValue("@numara", txtNumara.Text);
      cmd.Parameters.AddWithValue("@adi", txtAdi.Text);
      cmd.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
      cmd.Parameters.AddWithValue("@dtarihi", dtpDogumTarihi.Text);
      cmd.Parameters.AddWithValue("@dyeri", txtDogumYeri.Text);
      cmd.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.SelectedItem);
      cmd.Parameters.AddWithValue("@resim", pcbResimEkle.ImageLocation);
      cmd.Parameters.AddWithValue("@abdkodu", cmbAnaBilimDali.SelectedValue);
      cmd.Parameters.AddWithValue("@bkodu", cmbBolumAdi.SelectedValue);
      cmd.Parameters.AddWithValue("@tutnumara", duzeltilecekNumara);
      cmd.ExecuteNonQuery();
      string degisenAdSoyad = txtAdi.Text + " " + txtSoyadi.Text;
      MessageBox.Show("İlk kayıt olan, " + ilkAdSoyad + " kaydı " + degisenAdSoyad + " olarak " + " düzenlendi.", "Kişi Bilgilerini Düzeltme", MessageBoxButtons.OK, MessageBoxIcon.Information);
      VerileriCek();
      bs.Position = kayitno;

    }
    private string duzeltilecekNumara;
    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
      duzeltilecekNumara = txtNumara.Text;
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      kacinciKayit = bs.Position;
      DialogResult result = MessageBox.Show("Kayıt kalıcı olarak silinecektir. Emin misiniz?", "Kayıt Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (result == DialogResult.Yes)
      {
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = conn;
        cmd.CommandText = "DELETE FROM genel  WHERE numara=@numara";
        cmd.Parameters.AddWithValue("@numara", txtNumara.Text);
        cmd.ExecuteNonQuery();
        MessageBox.Show(txtNumara.Text + "  numaralı kayıt veritabanından silindi.", "Kişi Kayıt Silme İşlemi");
        VerileriCek();
        bs.Position = kacinciKayit;

      }
    }

    private void cmbBolumAdi_la_SelectedIndexChanged(object sender, EventArgs e)
    {
       string query = "SELECT g.*,a.abdadi,b.badi FROM anabilimdali as a,genel as g,bolumler as b WHERE g.bkodu=b.bkodu AND g.abdkodu=a.abdkodu AND g.bkodu=" + cmbBolumAdi_la.SelectedValue;
      SonucGoster(query, cmbBolumAdi_la.Text);
      #region MyRegion
      //try
      //{
      // string query = "SELECT g.*,a.abdadi,b.badi FROM anabilimdali as a,genel as g,bolumler as b WHERE g.bkodu=b.bkodu AND g.abdkodu=a.abdkodu AND g.bkodu=" + cmbBolumAdi_la.SelectedValue;

      //  OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      //  if (ds.Tables["genel"] != null) ds.Tables["genel"].Clear();

      //  adapter.Fill(ds, "genel");
      //}
      //catch  { } 
      #endregion

    }

    private void txtNumara_la_TextChanged(object sender, EventArgs e)
    {
      string query = "SELECT g.*,a.abdadi,b.badi FROM anabilimdali as a,genel as g,bolumler as b WHERE g.bkodu=b.bkodu AND g.abdkodu=a.abdkodu AND  numara LIKE '%" + txtNumara_la.Text + "%'";
      SonucGoster(query, txtNumara_la.Text);
      #region MyRegion
      //try
      //{
      //  string query = "SELECT g.*,a.abdadi,b.badi FROM anabilimdali as a,genel as g,bolumler as b WHERE g.bkodu=b.bkodu AND g.abdkodu=a.abdkodu AND  numara LIKE '%" + txtNumara_la.Text + "%'";
      //  OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      //  if (ds.Tables["genel"] != null) ds.Tables["genel"].Clear();

      //  adapter.Fill(ds, "genel");
      //  if (ds.Tables["genel"].Rows.Count <= 0) MessageBox.Show(txtNumara_la.Text + " içeren kayıt bulunmamaktadır.", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      //}
      //catch { } 
      #endregion
    }

    private void txtAdi_la_TextChanged(object sender, EventArgs e)
    {        string query = "SELECT g.*,a.abdadi,b.badi FROM anabilimdali as a,genel as g,bolumler as b WHERE g.bkodu=b.bkodu AND g.abdkodu=a.abdkodu AND  adi LIKE '%" + txtAdi_la.Text + "%'";
      SonucGoster(query, txtAdi_la.Text);
      #region MyRegion
      //try
      //{
      //  string query = "SELECT g.*,a.abdadi,b.badi FROM anabilimdali as a,genel as g,bolumler as b WHERE g.bkodu=b.bkodu AND g.abdkodu=a.abdkodu AND  adi LIKE '%" + txtAdi_la.Text + "%'";
      //  OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      //  if (ds.Tables["genel"] != null) ds.Tables["genel"].Clear();

      //  adapter.Fill(ds, "genel");
      //  if (ds.Tables["genel"].Rows.Count <= 0) MessageBox.Show(txtAdi_la.Text + " içeren kayıt bulunmamaktadır.", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      //}
      //catch { } 
      #endregion
    }

    private void txtSoyadi_la_TextChanged(object sender, EventArgs e)
    {
      string query = "SELECT g.*,a.abdadi,b.badi FROM anabilimdali as a,genel as g,bolumler as b WHERE g.bkodu=b.bkodu AND g.abdkodu=a.abdkodu AND  soyadi LIKE '%" + txtSoyadi_la.Text + "%'";     
      SonucGoster(query,txtSoyadi_la.Text);
      #region MyRegion
      //try
      //{
      //  string query = "SELECT g.*,a.abdadi,b.badi FROM anabilimdali as a,genel as g,bolumler as b WHERE g.bkodu=b.bkodu AND g.abdkodu=a.abdkodu AND  soyad LIKE '%" + txtSoyadi_la.Text + "%'";
      //  OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      //  if (ds.Tables["genel"] != null) ds.Tables["genel"].Clear();

      //  adapter.Fill(ds, "genel");
      //  if (ds.Tables["genel"].Rows.Count <= 0) MessageBox.Show(txtSoyadi_la.Text + " içeren kayıt bulunmamaktadır.", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      //}
      //catch { } 
      #endregion


    }
    private void SonucGoster(string sorgu,string textAlani) {
      try
      {
        string query = sorgu;
               OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
        if (ds.Tables["genel"] != null) ds.Tables["genel"].Clear();

        adapter.Fill(ds, "genel");
        if (ds.Tables["genel"].Rows.Count <= 0) MessageBox.Show(textAlani + " içeren kayıt bulunmamaktadır.", "Kayıt Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
VerileriCek();
      }
      catch { }
 
    }
    private void chbTKG_Click(object sender, EventArgs e)
    {
     if(chbTKG.Checked)VerileriCek();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void Form3_FormClosing(object sender, FormClosingEventArgs e)
    {
      
      Form1 form1 = new Form1();
      form1.Show();
    }

    private void btnRaporla_Click(object sender, EventArgs e)
    {
      RaporGenel rg = new RaporGenel();
      rg.ShowDialog();
    }
  }
  }

