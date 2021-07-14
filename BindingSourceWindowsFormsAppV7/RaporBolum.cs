using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindingSourceWindowsFormsAppV7
{
  public partial class RaporBolum : Form
  {
    public RaporBolum()
    {
      InitializeComponent();
    }

    private void RaporBolum_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'DataSet1.bolumler' table. You can move, or remove it, as needed.
      this.bolumlerTableAdapter.Fill(this.DataSet1.bolumler);
      ReportDataSource rds = new ReportDataSource("DataSet1", Form1.ds.Tables["bolumler"]);
      this.reportViewer1.LocalReport.DataSources.Clear();
      this.reportViewer1.LocalReport.DataSources.Add(rds);
      this.reportViewer1.LocalReport.Refresh();
      this.reportViewer1.RefreshReport();

      this.reportViewer1.RefreshReport();
    }
  }
}
