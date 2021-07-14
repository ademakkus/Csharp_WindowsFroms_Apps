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
  public partial class Form2 : Form
  {
    private int kacinciKayit;
    bool yeniKayitMi;
    string eskiABDAdi;
    
    readonly static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\ogrenciler.mdb";
    OleDbConnection conn = new OleDbConnection(connectionString);
  public static  DataSet ds = new DataSet();
    BindingSource bs = new BindingSource();
    public Form2()
    {
      InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
      btnIptal.Visible = false;
      cmbBolumAdi.Enabled = txtAnaBilimDaliKodu.ReadOnly=txtAnaBilimDaliAdi.ReadOnly = false;
      btnKaydet.Visible = false;
      if (conn.State == ConnectionState.Closed) conn.Open();
      VerileriCek();
      //dataGridView1.DataSource = ds.Tables["anabilimdali"];
      bs.DataSource = ds.Tables["anabilimdali"];
      dataGridView1.DataSource = bs;
      txtAnaBilimDaliKodu.DataBindings.Add("Text", bs, "abdkodu");
      txtAnaBilimDaliAdi.DataBindings.Add("Text", bs, "abdadi");
      cmbBolumAdi.DataBindings.Add("SelectedValue", bs, "bkodu");


      string query = "SELECT * FROM bolumler";
      OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      adapter.Fill(ds, "bolumler");
      adapter.Fill(ds, "bolumler1");    //data sette ikinci bir sanal tablo oluşturuldu.
      cmbBolumAdi.DataSource = ds.Tables["bolumler"];
      cmbBolumAdi.DisplayMember = "badi";   //bolumler tablosundaki bölüm adı
      cmbBolumAdi.ValueMember = "bkodu";    //bolumler tablosundaki bölüm kodu
      //
      cmbAnaBilimDaliAdi.DataSource = ds.Tables["bolumler1"];
      cmbAnaBilimDaliAdi.DisplayMember = "badi";   //bolumler tablosundaki bölüm adı
      cmbAnaBilimDaliAdi.ValueMember = "bkodu";    //bolumler tablosundaki bölüm kodu
      cmbAnaBilimDaliAdi_SelectedIndexChanged(sender, e);
      bs.PositionChanged += new EventHandler(ilerigerikontrol);
    }

    private void ilerigerikontrol(object sender, EventArgs e)
    {
      if (bs.Position==0)btnGeri.Enabled = false;
      else btnGeri.Enabled = true;
      if (bs.Position==bs.Count-1)btnGeri.Enabled = true;
      else btnGeri.Enabled = false;
      
    }

    private void VerileriCek()
    {
      string query = "SELECT a.*,b.badi FROM anabilimdali as a,bolumler as b WHERE a.bkodu=b.bkodu";
      OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      if (ds.Tables["anabilimdali"] != null) ds.Tables["anabilimdali"].Clear();

      adapter.Fill(ds, "anabilimdali");

    }

    private void btnYeniKayit_Click(object sender, EventArgs e)
    {
      txtBolumAdiArama.ReadOnly=txtAnaBilimDaliAdi.Enabled = true;
      txtBolumAdiArama.Clear();
      cmbBolumAdi.Enabled = true;
      txtAnaBilimDaliAdi.Text = "";
      txtAnaBilimDaliAdi.Focus();
      btnKaydet.Visible = btnIptal.Visible = true;
      btnYeniKayit.Visible = false;
      kacinciKayit = ds.Tables["anabilimdali"].Rows.Count;
      yeniKayitMi = true;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
    private bool VarMi(string aranan)
    {
      int sonuc;
      string query = "SELECT COUNT(badi) FROM bolumler WHERE badi='" + aranan + "'";
      OleDbCommand cmd = new OleDbCommand(query, conn);
      sonuc = Convert.ToInt32(cmd.ExecuteScalar());
      if (sonuc > 0) return true;
      else return false;

      //OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
      //if (ds.Tables["bolumler"] != null) ds.Tables["bolumler"].Clear();
      //da.Fill(ds, "bolumler");

    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = conn;
        string aranan = txtAnaBilimDaliAdi.Text;
        bool result = VarMi(aranan);
        if (yeniKayitMi)
        {
          if (!result)
          {
            cmd.CommandText = "INSERT INTO anabilimdali(abdadi,bkodu) VALUES(@abdadi,@abkodu)";
            cmd.Parameters.AddWithValue("@abdadi", txtAnaBilimDaliAdi.Text);
            cmd.Parameters.AddWithValue("@bkodu", cmbBolumAdi.SelectedValue);
            MessageBox.Show(txtAnaBilimDaliAdi.Text + " eklendi", "Bölüm Ekleme");
            btnKaydet.Visible = btnIptal.Visible = false;
            btnYeniKayit.Visible = true;
          }
          else
          {
            MessageBox.Show("Eklemeye çalıştığınız ABD sistemde kayıtlı.", "Yeni ABD Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnKaydet.Visible = btnIptal.Visible = true;
          }
        }
        else
        {
          cmd.CommandText = "UPDATE anabilimdali SET abdadi=@abdadi,bkodu=@abdkodu WHERE abdkodu=@abdkodu";
          cmd.Parameters.AddWithValue("@abdadi", txtAnaBilimDaliAdi.Text);
          cmd.Parameters.AddWithValue("@bkodu", cmbBolumAdi.SelectedValue);
          cmd.Parameters.AddWithValue("@abdkdou", txtAnaBilimDaliKodu.Text);
          MessageBox.Show(eskiABDAdi + "," + txtAnaBilimDaliAdi.Text + " olarak değişti.", "Bölüm Ekleme");
        }

        cmd.ExecuteNonQuery();

        VerileriCek();
      }
      catch (Exception exc)
      {
        MessageBox.Show("Kaydetme hatası:" + exc.ToString(), "Kaydetme İşlemi");

      }

      bs.Position = kacinciKayit;
      txtBolumAdiArama.ReadOnly = true;
    }

    private void btnDuzelt_Click(object sender, EventArgs e)
    {
      cmbBolumAdi.Enabled = txtAnaBilimDaliAdi.Enabled = true;
      txtAnaBilimDaliKodu.Enabled = true;
      txtAnaBilimDaliAdi.Focus();
      btnKaydet.Visible = btnIptal.Visible = true;
      yeniKayitMi = false;
      kacinciKayit = bs.Position;
      eskiABDAdi = txtAnaBilimDaliAdi.Text;

    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      kacinciKayit = bs.Position;
      DialogResult result = MessageBox.Show("Kayıt kalıcı olarak silinecektir. Emin misiniz?", "Kayıt Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
      if (result == DialogResult.Yes)
      {
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = conn;
        cmd.CommandText = "DELETE FROM anabilimdali WHERE abdkodu=@abdkodu";
        cmd.Parameters.AddWithValue("@abdkodu", txtAnaBilimDaliKodu.Text);
        cmd.ExecuteNonQuery();
        MessageBox.Show(txtAnaBilimDaliAdi.Text + " veritabanından silindi.", "ABD Silme İşlemi");
        VerileriCek();
        bs.Position = kacinciKayit;

      }
    }
    /*
     * 
      
     * */
    private void txtBolumAdiArama_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtBolumAdiArama_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter) ABDara();
    }
    private void ABDara()
    {
      string query = "SELECT a.*,b.badi FROM anabilimdali as a,bolumler as b WHERE a.bkodu=b.bkodu AND abdadi LIKE '%" + txtBolumAdiArama.Text.ToLower() + "%'";
      OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
     // MessageBox.Show(txtBolumAdiArama.Text,"Test");
     
      adapter.Fill(ds, "anabilimdali");
    }

    private void txtBolumAdiArama_TextChanged_1(object sender, EventArgs e)
    {
      ABDara();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void Form2_FormClosing(object sender, FormClosingEventArgs e)
    {
      Form1 form1 = new Form1();
      form1.Show();
    //  Application.Exit();
    }

    private void cmbAnaBilimDaliAdi_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        string query = "SELECT * FROM anabilimdali as a,bolumler as b WHERE a.bkodu=b.bkodu AND a.bkodu LIKE '%" + cmbAnaBilimDaliAdi.SelectedValue.ToString() + "%'";
        OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
        if (ds.Tables["anabilimdali"] != null) ds.Tables["anabilimdali"].Clear();
        adapter.Fill(ds, "anabilimdali");
      }
      catch 
      {

        
      }
    }

    private void chbTumKAyitlariGoster_CheckedChanged(object sender, EventArgs e)
    {
      if (chbTumKAyitlariGoster.Checked) VerileriCek();
      else
      {
        if (txtBolumAdiArama.Text != "") txtBolumAdiArama_TextChanged_1(sender, e);
        else cmbAnaBilimDaliAdi_SelectedIndexChanged(sender, e);
      }
    }

    private void btnIleri_Click(object sender, EventArgs e)
    {
      //if (++bs.Position == ds.Tables["anabilimdali"].Rows.Count - 1) btnIleri.Enabled = false;
      //btnGeri.Enabled = true;
      bs.Position++;
    }

    private void btnGeri_Click(object sender, EventArgs e)
    {
      //if (--bs.Position <= 0) btnGeri.Enabled = false;
      //btnIleri.Enabled = true;
      bs.Position--;
    }

    private void btnRaporla_Click(object sender, EventArgs e)
    {
      RapoAnaBilimDali ra = new RapoAnaBilimDali();
      ra.ShowDialog();
    }
  }
}
