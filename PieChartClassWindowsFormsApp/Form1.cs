using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PieChartClassWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Series mySeries = new Series("series");
      double[] data = new double[] { 65.62, 75.54, 60.45, 55.73, 70.42 };
      string[] country = new string[] { "France", "Canada", "UK", "USA", "Italy" };
      mySeries.Points.DataBindXY(country, data);
      //Setup pie chart
      mySeries.ChartType = SeriesChartType.Pie;
      mySeries["PieLabelStyle"] = "Inside";
      mySeries["PieDrawingStyle"] = "Default";
      //Setup the chart
      ChartArea myArea = new ChartArea("area");
      chart1.ChartAreas.Add("area");
      chart1.Series.Add(mySeries);
      mySeries.ChartArea = "area";
      //Setup legend
      chart1.Legends.Add(new Legend("Default"));
      // Add Color column
      LegendCellColumn firstColumn = new LegendCellColumn();
      firstColumn.ColumnType = LegendCellColumnType.SeriesSymbol;
      firstColumn.HeaderText = "";
      chart1.Legends["Default"].CellColumns.Add(firstColumn);
      // Add name cell column
      LegendCellColumn percentColumn = new LegendCellColumn();
      percentColumn.Text = "#PERCENT";
      percentColumn.HeaderText = "Percentage";
      percentColumn.Name = "nameColumn";
      chart1.Legends["Default"].CellColumns.Add(percentColumn);
      //Format the legend
      chart1.Legends["Default"].LegendStyle = LegendStyle.Table;
      chart1.Legends["Default"].TableStyle = LegendTableStyle.Tall;
      chart1.Legends["Default"].DockedToChartArea = "area";
      chart1.Legends["Default"].IsDockedInsideChartArea = false;
      chart1.Legends["Default"].Docking = Docking.Bottom;
    }
  }
}
