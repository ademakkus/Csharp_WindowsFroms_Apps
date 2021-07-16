using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatergameWindowsFormsApp
{
  class Stone
  {
    private string FileName = "stone.ico";
    public Point Position;
    public static Bitmap StoneImage = null;
    public Stone()
    {

    }
    public Stone(int x,int y)
    {
      Position.X = x;
      Position.Y = y;
      if (StoneImage==null)
      {
        StoneImage = new Bitmap(FileName);
      }
    }
  public Rectangle GetFrame()
    {
      Rectangle myRect = new Rectangle(Position.X, Position.Y, StoneImage.Width, StoneImage.Height);
      return myRect;
    }
  public void Draw(Graphics g)
    {
      Rectangle destR = new Rectangle(Position.X, Position.Y, StoneImage.Width, StoneImage.Height);
      Rectangle srcR = new Rectangle(0, 0, StoneImage.Width, StoneImage.Height);
      g.DrawImage(StoneImage, destR, srcR, GraphicsUnit.Pixel);

     
    }
  }
}
