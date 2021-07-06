using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioGroupBoxButtonWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
   public   void MedeniDurumGoster(Object sender)
    {
      lblMedeniDurum.Text =((RadioButton) sender).Text;
    }

    private void rdbEvli_CheckedChanged(object sender, EventArgs e)
    {
      MedeniDurumGoster(sender);
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      var checkBoxes = groupBox3.Controls.OfType<CheckBox>().Where(c => c.Checked);
      if(checkBoxes.Count()==0)
        MessageBox.Show("Hobi seçimi yapınız! ", "Hobi Seçimi ");
      foreach (CheckBox control in checkBoxes)
      {

        if (!lsbHobiler.Items.Contains(control.Text))   //varsa ekleme yapma!!
          lsbHobiler.Items.Add(control.Text);
      }
      /* #region
       //2. yol
       lsbHobiler.Items.Clear();
       var checkBoxes = groupBox3.Controls.OfType<CheckBox>().Where(c => c.Checked);
       foreach (CheckBox control in checkBoxes)
       {


           lsbHobiler.Items.Add(control.Text);
       }
       #endregion
      */
    }

    private void btnCikar_Click(object sender, EventArgs e)
    {
     
      // lsbHobiler.Items.RemoveAt(lsbHobiler.SelectedIndex);
      var checkBoxes = groupBox3.Controls.OfType<CheckBox>().Where(c => c.Checked);
      string selectedText = lsbHobiler.SelectedItem.ToString();
      if (lsbHobiler.Items.Count == 0)
        MessageBox.Show("Ders kalmadı ! ", "Hobi Silme ");
   else
      {
        foreach (CheckBox control in checkBoxes)
        {

          if (selectedText== control.Text)   //varsa ekleme yapma!!
            control.Checked = false;
          lsbHobiler.Items.Remove(lsbHobiler.SelectedItem);

        }
      }
    }
  }
}
