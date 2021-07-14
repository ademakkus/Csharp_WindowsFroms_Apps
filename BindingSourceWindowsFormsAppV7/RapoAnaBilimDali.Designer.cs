
namespace BindingSourceWindowsFormsAppV7
{
  partial class RapoAnaBilimDali
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
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.DataSet1 = new BindingSourceWindowsFormsAppV7.DataSet1();
      this.anabilimdaliBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.anabilimdaliTableAdapter = new BindingSourceWindowsFormsAppV7.DataSet1TableAdapters.anabilimdaliTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.anabilimdaliBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // reportViewer1
      // 
      reportDataSource1.Name = "DataSet1";
      reportDataSource1.Value = this.anabilimdaliBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "BindingSourceWindowsFormsAppV7.abdReport.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(-1, 12);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.Size = new System.Drawing.Size(797, 319);
      this.reportViewer1.TabIndex = 0;
      // 
      // DataSet1
      // 
      this.DataSet1.DataSetName = "DataSet1";
      this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // anabilimdaliBindingSource
      // 
      this.anabilimdaliBindingSource.DataMember = "anabilimdali";
      this.anabilimdaliBindingSource.DataSource = this.DataSet1;
      // 
      // anabilimdaliTableAdapter
      // 
      this.anabilimdaliTableAdapter.ClearBeforeFill = true;
      // 
      // RapoAnaBilimDali
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.reportViewer1);
      this.Name = "RapoAnaBilimDali";
      this.Text = "RapoAnaBilimDali";
      this.Load += new System.EventHandler(this.RapoAnaBilimDali_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.anabilimdaliBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private System.Windows.Forms.BindingSource anabilimdaliBindingSource;
    private DataSet1 DataSet1;
    private DataSet1TableAdapters.anabilimdaliTableAdapter anabilimdaliTableAdapter;
  }
}