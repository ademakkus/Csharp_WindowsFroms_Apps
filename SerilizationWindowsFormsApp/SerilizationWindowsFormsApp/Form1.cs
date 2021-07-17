using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerilizationWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      Musteri yeniMusteri = new Musteri();
      yeniMusteri.Ad = txtAdi.Text;
      yeniMusteri.Soyad = txtSoyadi.Text;
      yeniMusteri.Email = txtEmail.Text;
      yeniMusteri.Telefon = txtTelefon.Text;
      FileStream fs = new FileStream("Musteri.dat", FileMode.Create);
      BinaryFormatter bf = new BinaryFormatter();
      bf.Serialize(fs, yeniMusteri);
      fs.Close();
      MessageBox.Show(yeniMusteri.Ad+" "+yeniMusteri.Soyad+"başarıyla kaydedildi.","Kaydetme İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Information);

    }

    private void btnYukle_Click(object sender, EventArgs e)
    {
      DialogResult myResult = openFileDialog1.ShowDialog();
      //openFileDialog1.InitialDirectory = Application.StartupPath+"\\";
      if (myResult==DialogResult.OK)
      {
        try
        {
          FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
          BinaryFormatter bf = new BinaryFormatter();
          object objMusteri = bf.Deserialize(fs);
          fs.Close();
          Musteri oldMusteri = null;
          if (objMusteri is Musteri)
          {
            oldMusteri = (Musteri)objMusteri;
          }
          txtAdi_.Text = oldMusteri.Ad;
          txtSoyadi_.Text = oldMusteri.Soyad;
          txtEmail_.Text = oldMusteri.Email;
          txtTelefon_.Text = oldMusteri.Telefon;
        }
        catch (Exception)
        {

          MessageBox.Show("Hata oluştu.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
      }
    }
  }
}
