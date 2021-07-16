using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieChartAddTextWindowsFormsApp
{
  class PieChartElement
  {
    private string _name;
    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }
    private float _value;
    public float Value
    {
      get { return _value; }
      set { _value = value; }
    }
    public Color Color1 { get; set; }
    public Color Color2 { get; set; }

    public PieChartElement(string name, float value, Color color1, Color color2) 
    { 
      Name = name;
       Value = value;
      Color1 = color1;
      Color2 = color2;
    }

   
  }
}
