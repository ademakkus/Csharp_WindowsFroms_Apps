using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EatergameWindowsFormsAppV3
{
  public partial class Form1 : Form
  {
    private readonly Eater TheEater = new Eater(100, 100); 
    private const int NUMBEROFSTONES = 25;
    private ArrayList Stones = new ArrayList(NUMBEROFSTONES);
    //position of score table
    private Score TheScore = new Score(640, 380);
    private Random random = new Random();
    private TimerDisplay TheTime = new TimerDisplay(20, 380);
    private int TheSecond = 0;
    SoundPlayer mPlayer = new SoundPlayer("eatghost.wav");
    public Form1()
    {
      InitializeComponent();
      InitializeStone();
      InitializeTimer();
    }
    private void  InitializeStone()
    {
      for (int i = 0; i < NUMBEROFSTONES; i++)
      {
        Stones.Add(new Stone(random.Next(10,ClientRectangle.Right-10), random.Next(10, ClientRectangle.Bottom- 30)));
      }
    }
    private void InitializeTimer()
    {
      timer1.Start();
    }
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      g.FillRectangle(Brushes.White, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
      TheScore.Draw(g);
      TheTime.Draw(g,TheSecond);
      for (int i = 0; i < Stones.Count; i++)
      {
        ((Stone)Stones[i]).Draw(g);
      }
      
      TheEater.Draw(g);
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      string result = e.KeyData.ToString();
      Invalidate(TheEater.GetFrame());
      switch (result)
      {
        case "Left":TheEater.MoveLeft(ClientRectangle); break; ;
        case "Right":TheEater.MoveRight(ClientRectangle);break;
        case "Up":TheEater.MoveUp(ClientRectangle);break;
        case "Down":TheEater.MoveDown(ClientRectangle);break;
        default:
          break;
      }
      Invalidate(TheEater.GetFrame());
      int hit = CheckIntersection();
      if (hit!=-1)
      { 
        //score artır
        TheScore.Increment();
        Invalidate(TheScore.GetFrame());
    
       
        Invalidate(((Stone)Stones[hit]).GetFrame());
        //ses çal
        mPlayer.Play();
        Stones.RemoveAt(hit);
        if (Stones.Count==0)
        {
          MessageBox.Show("Tebrilker !Kazandınız.\nSüre:  "+TheTime.TheString+" saniye.","Oyun Bitti",MessageBoxButtons.OK,MessageBoxIcon.Information);
          Application.Exit();
        }
      }
    }
private int CheckIntersection()
    {
      for (int i = 0; i < Stones.Count; i++)
      {
        Rectangle stoneRect = ((Stone)Stones[i]).GetFrame();
        if (TheEater.GetFrame().IntersectsWith(stoneRect))
        {
          return i;
        }
      }
      return -1;
    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      TheSecond++;
      Invalidate(TheTime.GetFrame());
    }
  }
}
