
namespace BindingSourceWindowsFormsAppV7
{
  partial class RaporGenel
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
      this.genelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DataSet1 = new BindingSourceWindowsFormsAppV7.DataSet1();
      this.genelTableAdapter = new BindingSourceWindowsFormsAppV7.DataSet1TableAdapters.genelTableAdapter();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      ((System.ComponentModel.ISupportInitialize)(this.genelBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
      this.SuspendLayout();
      // 
      // genelBindingSource
      // 
      this.genelBindingSource.DataMember = "genel";
      this.genelBindingSource.DataSource = this.DataSet1;
      // 
      // DataSet1
      // 
      this.DataSet1.DataSetName = "DataSet1";
      this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // genelTableAdapter
      // 
      this.genelTableAdapter.ClearBeforeFill = true;
      // 
      // reportViewer1
      // 
      reportDataSource1.Name = "DataSet1";
      reportDataSource1.Value = this.genelBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "BindingSourceWindowsFormsAppV7.Report5.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(-11, 13);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.Size = new System.Drawing.Size(811, 370);
      this.reportViewer1.TabIndex = 0;
      // 
      // RaporGenel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.reportViewer1);
      this.Name = "RaporGenel";
      this.Text = "RaporGenel";
      this.Load += new System.EventHandler(this.RaporGenel_Load);
      ((System.ComponentModel.ISupportInitialize)(this.genelBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private DataSet1 DataSet1;
    private DataSet1TableAdapters.genelTableAdapter genelTableAdapter;
    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    public System.Windows.Forms.BindingSource genelBindingSource;
  }
}