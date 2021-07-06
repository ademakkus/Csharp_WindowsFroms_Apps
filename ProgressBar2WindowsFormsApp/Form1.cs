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
namespace ProgressBar2WindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnVeriGirisi_Click(object sender, EventArgs e)
    {
      int x = int.Parse(txtAdet.Text);
      progressBar1.Minimum = 0;
      progressBar1.Maximum = x;
      Double toplam = 0;
      try
      {
       

        for (int i = 1; i <= x; i++)
        {
          int puan = int.Parse(Interaction.InputBox(i + ". değeri "));
          /// int puan = int.TryParse(Interaction.InputBox(i + ". değeri "),out int  number);

          toplam += puan;
          progressBar1.Value = i; ;
        }
      }
      catch (InvalidEnumArgumentException)
      {

        MessageBox.Show("Değer giriniz","Test");
      } 
    
      catch (FormatException)
      {

        MessageBox.Show("Geçersiz Değer girdiniz", "Test");
      }
      txtAdet.Text = string.Empty;
      txtOrtalama.Text = (toplam / x).ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    { 
      txtAdet.Focus();
      txtOrtalama.ReadOnly = true;
     
    }
  }
}
