using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatergameWindowsFormsAppV3
{
  class TimerDisplay
  {

    public Point Position = new Point(0, 0);
    public Font myFont = new Font("Compact", 32.0f, GraphicsUnit.Pixel);
    public string TheString;
    public TimerDisplay()
    {

    }
    public TimerDisplay(int x,int y)
    {
      Position.X = x;
      Position.Y = y;
    }

    public void Draw(Graphics g,int secs) {
      string strTime = FormatTime(secs);
      TheString = strTime;
      g.DrawString(strTime, myFont, Brushes.DarkGreen, Position.X, Position.Y, new StringFormat());
    }
public Rectangle GetFrame()
    {
      Rectangle myRect = new Rectangle(Position.X, Position.Y, (int)(myFont.SizeInPoints * TheString.Length), myFont.Height);
      return myRect;
    }
    private string FormatTime(int secs)
    {
      int hrs = secs / 3600;
      int mins = (secs%360)/60;
      int secs2 = secs % 60;
      string sHrs = hrs.ToString();
      string sMins = mins.ToString();
      string sSecs = secs2.ToString();
      if (hrs<10)
      {
        sHrs = "0" + sHrs;
      }
      if (mins<10)
      {
        sMins = "0" + sMins;
      }
      if (secs2<10)
      {
        sSecs = "0" + sSecs;
      }
      return (sHrs + ":" + sMins + ":" + sSecs);
    }
  }
}
