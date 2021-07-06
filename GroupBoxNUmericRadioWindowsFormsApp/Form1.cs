using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxNUmericRadioWindowsFormsApp
{
  public partial class Form1 : Form
  {
    Color arkaPlanRengi, yaziRengi;
    public Form1()
    {
      InitializeComponent();
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      txtNumara.Enabled = txtAdSoyad.Enabled = false;
      btnMesajVer.Visible = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      arkaPlanRengi = txtNumara.BackColor;
      yaziRengi = txtNumara.ForeColor;
    }

    private void btnIzinver_Click(object sender, EventArgs e)
    {
      DialogResult dialogResult;
    dialogResult=  MessageBox.Show("İzin verislin mi?","İzin Verme işlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
      
      if (dialogResult == DialogResult.Yes)
      {
        //this.StartPosition = FormStartPosition.CenterParent;
        txtNumara.Enabled = txtAdSoyad.Enabled = true;
        btnMesajVer.Visible = true;
        txtNumara.Focus();
        
      }
    }

    private void txtNumara_Leave(object sender, EventArgs e)
    {
      TextBox txtMetin = (TextBox)sender;
      
      //txtNumara.BackColor =arkaPlanRengi;
      //txtNumara.ForeColor = yaziRengi;
      txtMetin.BackColor = arkaPlanRengi;
      txtMetin.ForeColor = yaziRengi;
    }

    private void btnMesajVer_Click(object sender, EventArgs e)
    {
      string cinsiyet=null;
      if (rbErkek.Checked) cinsiyet = rbErkek.Text;        // cinsiyet = "Erkek";
     // if (rbErkek.Checked == true) cinsiyet = rbErkek.Text;        // cinsiyet = "Erkek";
      if (rbKadin.Checked) cinsiyet = rbKadin.Text;        // cinsiyet = "Kadın";
                                                           // if (rbKadin.Checked == true) cinsiyet = rbKadin.Text;        // cinsiyet = "Kadın";
      MessageBox.Show("Numara :"+txtNumara.Text+
        "\nAdı ve Soyad :"+txtAdSoyad.Text+
        "\nCinsiyet :"+cinsiyet+
        "\nYaş :"+nuYas.Value
        ,"Test");
      txtAdSoyad.Enabled = txtNumara.Enabled =btnMesajVer.Visible= false;
    }

    private void btnRenkDegistir_Click(object sender, EventArgs e)
    {


      if (!rbArkaPlanRengi.Checked && !rbYaziRengi.Checked)
        MessageBox.Show("Lütfen rengi değiştirilecek alan seçin!", "Renk Değiştir");
      else
      {
        DialogResult result = colorDialog1.ShowDialog();
        if (result == DialogResult.OK)
        {
          if (rbArkaPlanRengi.Checked)
          {
            //  result = colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
          }
          else if (rbYaziRengi.Checked)
          {
            // result = colorDialog1.ShowDialog();
            this.ForeColor = colorDialog1.Color;
          }

        }
      }
    }

    private void txtNumara_Enter(object sender, EventArgs e)
    {
     TextBox txtMetin= (TextBox)sender;
      //txtNumara.BackColor = Color.Red;
      //txtNumara.ForeColor = Color.White;
      txtMetin.BackColor = Color.Red;
      txtMetin.ForeColor = Color.White;
    }
  }
}
