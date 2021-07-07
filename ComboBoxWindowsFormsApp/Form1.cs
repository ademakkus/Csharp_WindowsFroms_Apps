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
namespace ComboBoxWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      int sayi = 0;
      int kactane = int.Parse(Interaction.InputBox("Kaç değer eklensin"));
      for (int i = 0; i < kactane; i++,sayi+=2)
      {
        comboBox1.Items.Add(sayi);    //çift sayıları ekle
        comboBox1.SelectedIndex = 0;
       
      }
      label2.Text = "Eleman sayısı:" + comboBox1.Items.Count;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      label1.Text = "Seçilen eleman: " + comboBox1.SelectedItem + " Indexi : " + comboBox1.SelectedIndex;
    }

    private void btnTemizle_Click(object sender, EventArgs e)
    {
      comboBox1.Items.Clear();
      label2.Text = "Madde sayısı:" + comboBox1.Items.Count;
      label1.Text = "Eleman yok ";
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      if (comboBox1.SelectedIndex >= 0)
      {
        DialogResult result = new DialogResult();
        int indeks = comboBox1.SelectedIndex;
       result= MessageBox.Show(comboBox1.SelectedItem.ToString()+" silme istediğinizden emin misiniz? ","Test",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
          comboBox1.Items.Remove(comboBox1.SelectedItem);
          //    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
          comboBox1.SelectedIndex = indeks;
        }
      }
      else
      {
        MessageBox.Show("Silinecek Eleman Seçiniz","Eleman Seçme");
      }
    }

    private void btnYerlestir_Click(object sender, EventArgs e)
    {
      int nereye = int.Parse(Interaction.InputBox("Hangi sıraya yerleştirilsin (index) ?"));
      int deger = int.Parse(Interaction.InputBox("Hangi değer yerleştirilsin?"));
      comboBox1.Items.Insert(nereye, deger);
      comboBox1.SelectedIndex = nereye;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing)
      {
        string sifre = Interaction.InputBox("Çıkış için şifre giriniz.");
        if (sifre != "deneme")
        {
          e.Cancel = true;
          progressBar1.Maximum = 100;
          for (int i =100; i >=100; i--)
          {
            progressBar1.Value = i;
            Thread.Sleep(100);
          }
        }
      }
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Control && e.KeyCode ==Keys.Q)
        this.Close();
    }
  }
}
