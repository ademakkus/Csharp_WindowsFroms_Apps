using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ListToolStripMenuProgressBarWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      txtEkle.Visible = false;
      lsbDersler.Items.Add("İşletim Sistemleri");
      lsbDersler.Items.Add("Nesne Yönelimli Programlama");
      lsbDersler.Items.Add("Açık Kaynak İşletim Sistemleri");
      lsbDersler.Items.Add("Java");
      lsbDersler.Items.Add("Veri Yapıları");
      lsbDersler.Items.Add("Algoritma ve Akış Diyagramları");
      btnDersCikar.Visible = false;
      progressBar1.Maximum = lsbDersler.Items.Count;
      if (lsbDersler.Items.Count == 0) btnEkle.Enabled = false;
      if (lsbSecilenDersler.Items.Count == 0) btnDersCikar.Enabled = false;
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      int selectedIndex = lsbDersler.SelectedIndex;
    
        if (selectedIndex>=0)
        {
          lsbSecilenDersler.Items.Add(lsbDersler.SelectedItem.ToString());
          lsbDersler.Items.Remove(lsbDersler.SelectedItem);
        btnDersCikar.Visible = true;
        btnDersCikar.Enabled = true;
          if (lsbDersler.Items.Count == 0) btnEkle.Enabled = false;
        progressBar1.Value++;
        }
      
    else
      {
        MessageBox.Show("Ders seçiniz","Ders Seçme Hatası",MessageBoxButtons.OK,MessageBoxIcon.Information);
      }
    }

    private void btnDersCikar_Click(object sender, EventArgs e)
    {
      int selectedIndex = lsbSecilenDersler.SelectedIndex;

      if (selectedIndex > 0)
      {
        lsbDersler.Items.Add(lsbSecilenDersler.SelectedItem.ToString());
        lsbSecilenDersler.Items.Remove(lsbSecilenDersler.SelectedItem);
      //  lsbSecilenDersler.SelectedIndex = selectedIndex;////
 progressBar1.Value--;
        if (lsbSecilenDersler.Items.Count == 0)
        {
          btnDersCikar.Enabled = false;
       //   lsbSecilenDersler.SelectedIndex = -1;////
        }
        else
          btnDersCikar.Enabled = true;
      }

      else
      {
        MessageBox.Show("Ders seçiniz", "Ders Seçme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void chbDersEkle_CheckedChanged(object sender, EventArgs e)
    {
      if (chbDersEkle.Checked) txtEkle.Visible = true;
      else
        txtEkle.Visible = false;
    }

    private void txtEkle_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (txtEkle.Text == string.Empty||string.IsNullOrWhiteSpace(txtEkle.Text))    //boşukları ders olarak eklemesin diye string.IsNullOrWhiteSpace(txtEkle.Text)
          MessageBox.Show("Lütfen ders ismini giriniz!", "Ders İsmi Girişi");

        else
        {
          lsbDersler.Items.Add(txtEkle.Text);
          txtEkle.Text = string.Empty;
          progressBar1.Maximum++;

        }
      }
    }

    private void btnCokluDersEkle_Click(object sender, EventArgs e)
    {
     
     
      try
      {  
        string eklenen = null;
        byte dersSayisi =byte.Parse( Interaction.InputBox("Kaç ders eklencek?"));
        for (int i = 1; i <= dersSayisi; i++)
        {
          eklenen = Interaction.InputBox(i + ".dersi giriniz");
          if (eklenen == null || String.IsNullOrEmpty(eklenen))   //boşukları ders olarak eklemesin diye  string.IsNullOrWhiteSpace(Interaction.InputBox
            MessageBox.Show("Lütfen ders ismini giriniz!", "Ders İsmi Girişi");

          else
          {
            //   eklenen= Interaction.InputBox(i+". dersi giriniz");
            lsbDersler.Items.Add(eklenen);
            progressBar1.Maximum++;

          }
        }
      }
      catch (FormatException)
      {
        MessageBox.Show("Lütfen rakam giriniz! ","Yanlış değer");
      }   
      catch (OverflowException)
      {
        MessageBox.Show("Lütfen 0-255 arası değer giriniz! ", "Yanlış değer");
      }
      }

    private void seçimiİptalEtToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lsbDersler.SelectedIndex = -1;
    }

    private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Çıkmak istiyor musunuz?","Çıkış Bilgisi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,0);
      if (result == DialogResult.Yes)
        // this.Close();
        Application.Exit();
    }

    private void seçimiİptalEtToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      lsbSecilenDersler.SelectedIndex = -1;
    }
  }
}
