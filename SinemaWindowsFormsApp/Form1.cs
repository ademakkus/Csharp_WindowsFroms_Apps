using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaWindowsFormsApp
{
  
  public partial class Form1 : Form
  {
    bool[] koltuklar;
    public Form1()
    {
      InitializeComponent();
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {

      try
      {

        koltuklar = new bool[int.Parse(txtAdet.Text)];
        int kactane = 0;
        int ust = 70;
        for (int i = 0; i < int.Parse(txtAdet.Text); i++)
        {
          Button btn = new Button();
          btn.Text = "";
          btn.Name = i.ToString();
          btn.Text = "Koltuk " + (i + 1);
          btn.BackColor = Color.DarkGray;
          if (i % 5 == 0) { ust += 25; kactane = 0; }
          kactane++;

          btn.Left = kactane * 80;
          btn.Top = ust;
          btn.Click += new EventHandler(buton_islem);
          groupBox1.Controls.Add(btn);

        }
      }
      catch 
      {
        MessageBox.Show("Koltuk adet giriniz","Test",MessageBoxButtons.OK,MessageBoxIcon.Information);
      }
    }

    private void buton_islem(object sender, EventArgs e)
    {
      Button myButton = (Button)sender;
      if (koltuklar[int.Parse(myButton.Name)]==true)
      {
        myButton.BackColor = Color.Gray;
        koltuklar[int.Parse(myButton.Name)] = false;
      }
      else
      {
        myButton.BackColor = Color.YellowGreen;
        koltuklar[int.Parse(myButton.Name)] = true;
      }
      label2.Text = "";
      for (int i = 0; i < int.Parse(txtAdet.Text); i++)
      {
        if (koltuklar[i])
        {
          label2.Text += "Koltuk- " + (i + 1).ToString()+" ";
        }
      }
    }

    private void btnUcretHesapla_Click(object sender, EventArgs e)
    {
      int seciliKoltukSayisi = 0;
      try
      {
        for (int i = 0; i < int.Parse(txtAdet.Text); i++)
        {
          if (koltuklar[i]) seciliKoltukSayisi++;
          label4.Text = "Toplam Ücret= "+(int.Parse(txtBirimUcret.Text) * seciliKoltukSayisi).ToString();
        }
      }
      catch ( FormatException)
      {

        MessageBox.Show("Geçerli birim ücret giriniz","Geçersiz Birim Ücret",MessageBoxButtons.OK,MessageBoxIcon.Warning);
      }
    }
  }
}
