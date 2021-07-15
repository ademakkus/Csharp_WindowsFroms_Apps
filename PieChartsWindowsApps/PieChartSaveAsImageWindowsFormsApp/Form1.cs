using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PieChartSaveAsImageWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private void PrePareData()
    {
      ArrayList data = new ArrayList();
      //data.Add(new PieChartElement("FB", (float)45,Color.Navy,Color.Yellow));
      //data.Add(new PieChartElement("GS", (float)60,Color.Red,Color.Yellow));
      //data.Add(new PieChartElement("BJK", (float)90,Color.Black,Color.White));
      //data.Add(new PieChartElement("TS", (float)135,Color.Blue,Color.Brown));
      //data.Add(new PieChartElement("ÇS", (float)30,Color.Green,Color.Purple)); 
      data.Add(new PieChartElement("FB", (float)60, Color.Navy, Color.Yellow));
      data.Add(new PieChartElement("GS", (float)60, Color.Red, Color.Yellow));
      data.Add(new PieChartElement("BJK", (float)60, Color.Black, Color.White));
      data.Add(new PieChartElement("TS", (float)60, Color.Blue, Color.Brown));
      data.Add(new PieChartElement("ÇS", (float)60, Color.Green, Color.Purple));
      //data arraylist tipinde
      pcbChart.Image = DrawPieCharts(data, new Size(pcbChart.Width, pcbChart.Height));
    }

    private Image DrawPieCharts(ArrayList elements, Size s)
    {
      Bitmap bm = new Bitmap(s.Width, s.Height);
      Graphics g = Graphics.FromImage(bm);
      float total = 0;
      foreach (PieChartElement item in elements)
      {
        total += item.Value;
      }
      Rectangle rect = new Rectangle(1, 1, s.Width, s.Height);
      Pen p = new Pen(Color.Black, 1);

      float startAngle = 0;
      foreach (PieChartElement item in elements)
      {
        Brush b = new LinearGradientBrush(rect, item.Color1, item.Color2, (float)60);
        float sweepAngle = (item.Value / total) * 360;
        g.FillPie(b, rect, startAngle, sweepAngle);
        g.DrawPie(p, rect, startAngle, sweepAngle);
        startAngle += sweepAngle;
      }
      return bm;
    }

    private void pcbChart_Paint(object sender, PaintEventArgs e)
    {
      PrePareData();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      saveFileDialog1.DefaultExt = ".jpg";
      saveFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
      if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
        pcbChart.Image.Save(saveFileDialog1.FileName,ImageFormat.Jpeg);
    }
  }
}
