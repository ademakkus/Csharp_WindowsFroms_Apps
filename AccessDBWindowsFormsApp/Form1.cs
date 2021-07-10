using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessDBWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    readonly static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\ogrenciler.mdb";
    OleDbConnection conn = new OleDbConnection(connectionString);
    DataSet ds = new DataSet();
    BindingSource bs = new BindingSource();
    private void Form1_Load(object sender, EventArgs e)
    {
      if (conn.State == ConnectionState.Closed) conn.Open();
      string query = "SELECT * FROM bolumler";
      OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      adapter.Fill(ds, "bolumler");
      dataGridView1.DataSource = ds.Tables["bolumler"];

      ////BindingSource göre 
      //if (conn.State == ConnectionState.Closed) conn.Open();
      //string query = "SELECT * FROM bolumler";
      //OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
      //adapter.Fill(ds, "bolumler");
      //bs.DataSource = ds.Tables["bolumler"];
      //dataGridView1.DataSource = bs;

    }
  }
}
