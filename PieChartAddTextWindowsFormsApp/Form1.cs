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

namespace PieChartAddTextWindowsFormsApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
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
      g.SmoothingMode = SmoothingMode.HighQuality;
      float total = 0;
      foreach (PieChartElement item in elements)
      {
        total += item.Value;
      }
      Rectangle rect = new Rectangle(1, 1, s.Width-10, s.Height-10);
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
      //Point lRectCorner = new Point((s.Width / 2) + 2, 1);
      //Size lRectSize = new Size(s.Width - (s.Width / 2) - 4, s.Height - 2);
      //Rectangle lRect = new Rectangle(lRectCorner, lRectSize);
      //Brush lb = new SolidBrush(Color.White);
      //Pen lp = new Pen(Color.Black);
      //g.FillRectangle(lb, lRect);
      //g.DrawRectangle(lp, lRect);
      //int vert = (lRect.Height - 10) / elements.Count;
      //int legendWidth = lRect.Width / 5;
      //int legendHeight = (int)(vert * 0.75);

      //write string on pie chart
      Font f = new Font("Arial", 16);
      Brush b1 = new SolidBrush(Color.White);
      Brush b2 = new SolidBrush(Color.Black);
      string str = "Copyright 2021, ademakkus.com";
      g.DrawString(str, f, b2, 4, 4);
      g.DrawString(str, f, b2, 4, 6);
      g.DrawString(str, f, b2, 6, 4);
      g.DrawString(str, f, b2, 6, 6);
      g.DrawString(str, f, b1, 5, 5);
      return bm;
    }

    private void pcbChart_Paint(object sender, PaintEventArgs e)
    {
      PrePareData();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      saveFileDialog1.DefaultExt = ".jpg";
      saveFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
      if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
      {
        Bitmap bm = (Bitmap)pcbChart.Image;
        Graphics g = Graphics.FromImage(bm);
        Font f = new Font("Arial", 16);
        Brush b = new SolidBrush(Color.White);
        Brush b2 = new SolidBrush(Color.Black);
        string str = "Copyrigth 2021, ademakkus.com";
        g.DrawString(str, f, b2, 4, 4);
        g.DrawString(str, f, b2, 4, 6);
        g.DrawString(str, f, b2, 6, 4);
        g.DrawString(str, f, b2, 6, 6);
        g.DrawString(str, f, b, 5, 5);
        pcbChart.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
        

      }
    }
  }
}
