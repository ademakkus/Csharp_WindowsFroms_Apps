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

namespace BindingSourceWindowsFormsAppV6

{
  public partial class Form1 : Form
  {
    private int kacinciKayit;
    bool yeniKayitMi;
    string eskiBolumAdi;
    private int kayitSayisi;
    readonly static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\ogrenciler.mdb";
    OleDbConnection conn = new OleDbConnection(connectionString);
    DataSet ds = new DataSet();
    BindingSource bs = new BindingSource();
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      btnIptal.Visible = false;
      txtBolumAdi.ReadOnly=txtBolumKodu.ReadOnly = true;
      btnKaydet.Visible = false;
      if (conn.State == ConnectionState.Closed) conn.Open();
      //string query = "SELECT * FROM bolumler";
      //OleDbDataAdapter adapter = new OleDbDataAdapter(query,conn);
      //adapter.Fill(ds, "bolumler");
      VerileriCek();
      bs.DataSource=ds.Tables["bolumler"];
      dataGridView1.DataSource = bs;
      txtBolumAdi.DataBindings.Add("Text", bs, "badi");
      txtBolumKodu.DataBindings.Add("Text", bs, "bkodu");
      //txtBolumKodu.DataBindings.Add("Text", bs, "bkodu");
      ToolStripLabelKayitGoster();
    
    }
    private void ToolStripLabelKayitGoster()
    {
      kayitSayisi = ds.Tables["bolumler"].Rows.Count;
    
      toolStripLabel1.Text = "Toplam Kayıt Sayısı:" + kayitSayisi+" ,ve Şu andaki kayıt : "+bs.Position;
    }
    private void btnYeniKayit_Click(object sender, EventArgs e)
    {
      txtBolumAdi.ReadOnly = false;
      txtBolumAdi.Clear();
      txtBolumKodu.Clear();
      txtBolumAdi.Focus();
      btnKaydet.Visible = btnIptal.Visible = true;
      btnYeniKayit.Visible = false;
      kacinciKayit = ds.Tables["bolumler"].Rows.Count;
      yeniKayitMi = true;
      ToolStripLabelKayitGoster();
    }
    private void VerileriCek()
    {
      string query = "SELECT * FROM bolumler";
      OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      if (ds.Tables["bolumler"]!=null)ds.Tables["bolumler"].Clear();
       
      adapter.Fill(ds, "bolumler");

    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = conn;
        string aranan = txtBolumAdi.Text;
        bool result = VarMi(aranan);
        if (yeniKayitMi)
        {
          if (!result)
          {
            cmd.CommandText = "INSERT INTO bolumler(badi) VALUES(@badi)";
            cmd.Parameters.AddWithValue("@badi", txtBolumAdi.Text);
            MessageBox.Show(txtBolumAdi.Text + " eklendi", "Bölüm Ekleme");
            btnKaydet.Visible = btnIptal.Visible = false;
            btnYeniKayit.Visible = true;
          }
          else
          {
            MessageBox.Show("Eklemeye çalıştığınız bölüm sistemde kayıtlı.","Yeni Bölüm Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btnKaydet.Visible = btnIptal.Visible = true;
          }
        }
        else
        {
          cmd.CommandText = "UPDATE bolumler SET badi=@badi WHERE bkodu=@bkodu";
          cmd.Parameters.AddWithValue("@badi", txtBolumAdi.Text);
          cmd.Parameters.AddWithValue("@bkdou", txtBolumKodu.Text);
          MessageBox.Show(eskiBolumAdi+","+txtBolumAdi.Text + " olarak değişti.", "Bölüm Ekleme");
        }
        
        cmd.ExecuteNonQuery();
       
        VerileriCek();
      }
      catch (Exception exc)
      {
        MessageBox.Show("Kaydetme hatası:"+exc.ToString(),"Kaydetme İşlemi");

      }
     
      bs.Position = kacinciKayit;
      txtBolumAdi.ReadOnly = true;
     
      ToolStripLabelKayitGoster();
    }
    private bool VarMi(string aranan)
    {
      int sonuc;
      string query = "SELECT COUNT(badi) FROM bolumler WHERE badi='" + aranan+ "'";
      OleDbCommand cmd = new OleDbCommand(query, conn);
      sonuc = Convert.ToInt32(cmd.ExecuteScalar());
      if (sonuc > 0) return true;
      else return false;

      //OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
      //if (ds.Tables["bolumler"] != null) ds.Tables["bolumler"].Clear();
      //da.Fill(ds, "bolumler");

    }
    private void btnIptal_Click(object sender, EventArgs e)
    {
  txtBolumAdi.ReadOnly = true;
      btnKaydet.Visible = btnIptal.Visible = false;
      btnYeniKayit.Visible = true;
    }

    private void btnIleri_Click(object sender, EventArgs e)
    {
      if (++bs.Position == ds.Tables["bolumler"].Rows.Count-1) btnIleri.Enabled = false;
      btnGeri.Enabled = true;
      
    }

    private void btnGeri_Click(object sender, EventArgs e)
    {
      if (--bs.Position <=0) btnGeri.Enabled = false;
      btnIleri.Enabled = true;
    }

    private void btnDuzelt_Click(object sender, EventArgs e)
    {
      if (txtBolumAdi.Text==null)
      {
        MessageBox.Show("Düzletilecek bölüm seçiniz.","Bölüm Seçme");
      }
      try
      {
        eskiBolumAdi = txtBolumAdi.Text;
        txtBolumAdi.ReadOnly = false;
        txtBolumAdi.Focus();
        btnKaydet.Visible = btnIptal.Visible = true;
        yeniKayitMi = false;
        kacinciKayit = bs.Position;
        ToolStripLabelKayitGoster();
      }
      catch (Exception)
      {

        MessageBox.Show("Düzeltmede hata var. ","Hatalı Düzeltme İşlemi");
      }
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      kacinciKayit = bs.Position;
      DialogResult result = MessageBox.Show("Kayıt kalıcı olarak silinecektir. Emin misiniz?","Kayıt Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
      if (result == DialogResult.Yes)
      {
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = conn;
        cmd.CommandText = "DELETE FROM bolumler WHERE bkodu=@bkodu";
        cmd.Parameters.AddWithValue("@bkodu", txtBolumKodu.Text);
        cmd.ExecuteNonQuery();
        MessageBox.Show(txtBolumAdi.Text + " veritabanından silindi.", "Bölüm Silme İşlemi");
        VerileriCek();
        bs.Position = kacinciKayit;
        ToolStripLabelKayitGoster();
      }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      conn.Close();
    }

    private void txtBolumAdi_Arama_TextChanged(object sender, EventArgs e)
    {
      string query = "SELECT * FROM bolumler WHERE badi like'%"+txtBolumAdi_Arama.Text.ToLower()+"%'";
      OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
      if (ds.Tables["bolumler"] != null) ds.Tables["bolumler"].Clear();
      da.Fill(ds, "bolumler");
    }

    private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete) btnSil_Click(sender, e);
      ToolStripLabelKayitGoster();
    }

    private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Çıkmak istediğinizden emin misiniz?","Test",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);;
      if (result == DialogResult.Yes) Application.Exit();
      
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
      kacinciKayit = bs.Position;
      ToolStripLabelKayitGoster();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Form2 frm2 = new Form2();
      frm2.Show();
      this.Hide();
    }
  }
}
