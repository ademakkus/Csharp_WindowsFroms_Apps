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

namespace WindowsFormsApp1
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }
    Color arka, yazi;
    private void Form2_Load(object sender, EventArgs e)
    {
      lblSayac.Visible = btnSay.Visible = false;
      arka = btnTiklaSay.BackColor;
      yazi = btnTiklaSay.ForeColor;
    }

    private void btnTiklaSay_Click(object sender, EventArgs e)
    {
      DialogResult dialogResult;
      dialogResult = MessageBox.Show("Saymak istiyor musunuz?", "Onay Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
      if (dialogResult == DialogResult.Yes)
      {
        lblSayac.Visible = btnSay.Visible = true;
      }
    }
    int sayac = 0;
    int sayac2;
    private void btnSay_Click(object sender, EventArgs e)
    {
      sayac++;
      if (sayac > 10)
      {
        lblSayac.Visible = btnSay.Visible = false;
        sayac = 0;
      }

      lblSayac.Text = sayac.ToString();


      
    }

    private void btnSay100_Click(object sender, EventArgs e)
    {
      sayac2 = 0;
      while (sayac2 < 100)
      {
      
        sayac2++;
        lblSayac2.Text = sayac2.ToString();
       Thread.Sleep(100);
        if (sayac2 > 100)
        {
         sayac2 = 0;
        } 
        
      }
    }

    private void btnTiklaSay_MouseEnter(object sender, EventArgs e)
    {
      btnTiklaSay.ForeColor = Color.White;
      btnTiklaSay.BackColor = Color.Red;
    }

    private void btnTiklaSay_MouseLeave(object sender, EventArgs e)
    {
      btnTiklaSay.BackColor = arka;
      btnTiklaSay.ForeColor = yazi;
    }
  }
}
