using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFontPropCopyPastWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
   
    private void btnYaziTipi_Click(object sender, EventArgs e)
    {
      if (DialogResult.OK == fontDialog1.ShowDialog())
      {
        txtMetin.Font = fontDialog1.Font;
      }
    }

    private void btnYaziRengi_Click(object sender, EventArgs e)
    {
      if (DialogResult.OK == colorDialog1.ShowDialog())
      {
        txtMetin.ForeColor = colorDialog1.Color;
      }
    }

    private void btnKalin_Click(object sender, EventArgs e)
    {
      Font eskiFont = txtMetin.Font;
      txtMetin.Font = new Font(eskiFont, FontStyle.Bold^eskiFont.Style); ///XOR işlemi önemli
    }

    private void btnEgik_Click(object sender, EventArgs e)
    {
      Font eskiFont = txtMetin.Font;
      txtMetin.Font = new Font(eskiFont, FontStyle.Italic ^ eskiFont.Style); ///XOR işlemi önemli
    }

    private void btnAltiCizili_Click(object sender, EventArgs e)
    {
      Font eskiFont = txtMetin.Font;
      txtMetin.Font = new Font(eskiFont, FontStyle.Underline^ eskiFont.Style); ///XOR işlemi önemli
    }

    private void btnUstuCizili_Click(object sender, EventArgs e)
    {
      Font eskiFont = txtMetin.Font;
      txtMetin.Font = new Font(eskiFont, FontStyle.Strikeout ^ eskiFont.Style); ///XOR işlemi önemli
    }

    private void btnCiftCizgili_Click(object sender, EventArgs e)
    {
      Font eskiFont = txtMetin.Font;
      txtMetin.Font = new Font(eskiFont, FontStyle.Regular ^ eskiFont.Style); ///XOR işlemi önemli
    }

    private void btnKalinItalik_Click(object sender, EventArgs e)
    {
      Font eskiFont = txtMetin.Font;
      txtMetin.Font = new Font(eskiFont, FontStyle.Bold ^FontStyle.Italic^ eskiFont.Style); ///XOR işlemi önemli
    }

    private void btnKes_Click(object sender, EventArgs e)
    {
      if (txtMetin.SelectionLength > 0) txtMetin.Cut();
    else
        MessageBox.Show("Metin seçiniz ","Metin Kesme",MessageBoxButtons.OK,MessageBoxIcon.Information);
    }

    private void btnKopyala_Click(object sender, EventArgs e)
    {
      if (txtMetin.SelectionLength > 0) txtMetin.Copy();
      else
        MessageBox.Show("Kopyalanacak metin seçiniz ", "Metin Koyalama", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnYapistir_Click(object sender, EventArgs e)
    {
      txtMetin.Paste();
    }

    private void btnGeriAl_Click(object sender, EventArgs e)
    {
      txtMetin.Undo();
    }
  }
}
