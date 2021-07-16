using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatergameWindowsFormsAppV2
{
  class Score
  {
    int count = 0;
    public Point Position;
    public Font myFont = new Font("Compact", 32.0f, GraphicsUnit.Pixel);
    public Score()
    {

    }
    public Score(int x,int y)
    {
      Position.X = x;
      Position.Y = y;

    }
public Rectangle GetFrame()
    {

      Rectangle myRect = new Rectangle(Position.X, Position.Y, (int)myFont.SizeInPoints * count.ToString().Length, myFont.Height);
      return myRect;
    }
public void Draw(Graphics g)
    {
      g.DrawString(count.ToString(), myFont, Brushes.RoyalBlue, Position.X, Position.Y);
    }
  public void Reset()
    {
      count = 0;
    }
    public void Increment()
    {
      count++;
    }
  }
}
