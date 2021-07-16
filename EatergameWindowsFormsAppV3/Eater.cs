using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatergameWindowsFormsAppV3
{
  public class Eater
  {
    private const string Filename = "pacman2-32.ico";
    private const string Filename1 = "pacman-32.ico";
    private static Bitmap EaterImage = null;
    private static  Bitmap EaterImage2 = null;
    private int inc = 5;
    private int LastPositionX = 0;
    private int LastPositionY = 0;

    public Point Position;
    public Eater():this(30,35)
    {
      //Position.X = 30;
      //Position.Y = 35;
    }
    public Eater(int x,int y)
    {
      Position.X = x;
      Position.Y = y;
      if (EaterImage==null)
      {
        EaterImage = new Bitmap(Filename);
      }
      if (EaterImage2 == null)
      {
        EaterImage = new Bitmap(Filename1);
      }
    }
 public Rectangle GetFrame()
    {
      Rectangle myRect = new Rectangle(Position.X, Position.Y, EaterImage.Width, EaterImage.Height);
      return myRect;
    }
  public void Draw(Graphics g)
    {
      Rectangle destR = new Rectangle(Position.X, Position.Y, EaterImage.Width, EaterImage.Height);
      Rectangle srcR = new Rectangle(0, 0, EaterImage.Width, EaterImage.Height);
      if (((Position.X%2==1)&&((Position.X-LastPositionX)!=0))||((Position.Y%2==1)&&((Position.Y-LastPositionY)!=0)))
      {
        g.DrawImage(EaterImage, destR, srcR, GraphicsUnit.Pixel);
   
      }    
      else
      {
      g.DrawImage(EaterImage, destR, srcR, GraphicsUnit.Pixel);

      }
      LastPositionX = Position.X;
      LastPositionY = Position.Y;
    }
  public void MoveLeft(Rectangle r)
    {
      if (Position.X<=0)
      {
        return;
      }
      Position.X -= inc;
    } public void MoveRight(Rectangle r)
    {

      if (Position.X>=r.Width-EaterImage.Width)
      {
        return;
      }
      Position.X += inc;
    
    }
    public void MoveUp(Rectangle r)
    {
      if (Position.Y <= 0)
      {
        return;
      }
      Position.Y -= inc;
    }
    public void MoveDown(Rectangle r)
    {  
    
      if (Position.Y>=r.Width-EaterImage.Width)
      {
        return;
      }
      Position.Y += inc;
    
    }
  
  }
}
