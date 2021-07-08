using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseStringWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnTerstenYazdir_Click(object sender, EventArgs e)
    {

   //   txtMetin TextChanged olayına da yazılabilir
      string tersMetin = "";
      string metin = txtMetin.Text;
      for (int i = metin.Length - 1; i >=0 ; i--)
      {
        tersMetin += metin[i];
      }
      txtTersten.Text = tersMetin;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      btnKelimelereAyir.Text = "Kelimelere\n ayır";
      //aşağıdaki gibi de yapılabilir
  //    btnKelimeler.Text = "Kelimelere"+Environment.NewLine+ ""ayır";
    }

    private void btnKelimelereAyir_Click(object sender, EventArgs e)
    {
      string metin = txtMetin.Text;
      string[] kelimeler;
      kelimeler = metin.Split(' ');
      int i = 0;
      foreach (string kelime in kelimeler)
      {
        listBox1.Items.Add(kelime);
      }
    }

    private void btnAlGoster_Click(object sender, EventArgs e)
    {
      try
      {
        //nudKacTane.Maximum = txtMetin.Text.Length-1;
        int nerden = int.Parse(nudNereden.Value.ToString());
        int kactane = int.Parse(nudKacTane.Value.ToString());
        txtTersten.Text = txtMetin.Text.Substring(nerden, kactane);
      }
      catch 
      {

        MessageBox.Show("geeçrsiz değer","Değer Kontrol",MessageBoxButtons.OK,MessageBoxIcon.Information);
      }

    }
  }
}
