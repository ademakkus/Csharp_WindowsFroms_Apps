using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDialogWindowsFormsApp
{
  public partial class Form1 : Form
  {
    Color[] renkler = { Color.Red, 
      Color.Green, 
      Color.Yellow,
      Color.White, 
      Color.Purple, 
      Color.Blue, 
      Color.Magenta, 
      Color.Black };
    public Form1()
    {
      InitializeComponent();
    }
    Color arkaPlanRengi;
    private void Form1_Load(object sender, EventArgs e)
    {
      arkaPlanRengi = this.BackColor;
    }
    int sayac = 1;   
    DialogResult result; 
    private void Form1_Click(object sender, EventArgs e)
    {
   
      if(sayac==1)
        result = MessageBox.Show("Tıklayınca renk değişecektir", "Renk Değiştirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
      if (result==DialogResult.Yes)
      {
        Random random = new Random();
        int sayi = random.Next(7);
        this.BackColor = renkler[sayi];
          sayac++;
        if (sayac == 5) {
          sayac = 1;
          this.BackColor = arkaPlanRengi;

        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Form2 frm = new Form2();
      Form1 frm1 = new Form1();
      frm1.Close();
      frm.ShowDialog();
    }
  }
}
