using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace DateTimePickerTrackBarWindowsFormsApp2
{
  public partial class Form1 : Form
  {
    int bekle;
    public Form1()
    {
      InitializeComponent();
    }

    private void btnYasimiHesapla_Click(object sender, EventArgs e)
    {
      label2.Font = new Font(label1.Font.Name, 17, FontStyle.Bold);
      label2.Text = "Hesaplanıyor....";
      int yas = DateTime.Now.Year - dtpDTarihi.Value.Year;
      progressBar1.Maximum = yas;
      for (int i = 0; i <=yas; i++)
      {
        progressBar1.Value = i;
        Random random = new Random();
        label2.Text = "Hesaplanıyor..." + random.Next(0, 100).ToString();
        label2.Refresh();
        Thread.Sleep(bekle);
      }
      label2.Text = "Yaşınız: "+yas.ToString();
    }

    private void btnGitsinYas_Click(object sender, EventArgs e)
    {
      btnGitsinYas.Enabled = false;
      btnGelsinYas.Enabled = true;
      for (int i = 0; i <=35; i++)
      {
        label2.Location = new Point(label2.Location.X + i, label2.Location.Y);
     label2.Refresh();
        //this.Refresh();
        Thread.Sleep(bekle);
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      bekle = trbHiz.Value; ;
      label2.Text = "Yaşınızı burdan takip ediniz....";
      btnGelsinYas.Enabled = false;
    }

    private void txtHiz_KeyDown(object sender, KeyEventArgs e)
    {
      try
      {
        if (e.KeyCode == Keys.Enter)
        {
          trbHiz.Value = int.Parse(txtHiz.Text);
          bekle = trbHiz.Value;
        }
      }
      catch 
      {
        MessageBox.Show("0 - 300 arası sayı giriniz","Test");
      
      }
    }

    private void trbHiz_ValueChanged(object sender, EventArgs e)
    {
      txtHiz.Text = trbHiz.Value.ToString();
      bekle = trbHiz.Value;
    }

    private void btnGelsinYas_Click(object sender, EventArgs e)
    {
      btnGelsinYas.Enabled = false;
      btnGitsinYas.Enabled = true;
      for (int i = 1; i <=35; i++)
      {
        label2.Location = new Point(label2.Location.X - i, label2.Location.Y);
        label2.Refresh();
       // this.Refresh();
        Thread.Sleep(bekle);
      }
    }

    private void btnYasinizinRengi_Click(object sender, EventArgs e)
    {
      colorDialog1.ShowDialog();
      label2.ForeColor = colorDialog1.Color;
    }
  }
}
