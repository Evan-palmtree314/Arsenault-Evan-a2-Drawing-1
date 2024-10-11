// Include code libraries you need below (use the namespace).
using Game10003;
using System;
using System.Drawing;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    /// Below is the main functions
    /// 
 
    // float[] ColourValue1 = [166,230,242];

    ///     Your game code goes inside this class!

    /// </summary>
    public class Game
    {
        void GenGrass(int BorderSize, float[] x, float[] y, float[] Rad)
        {
            BorderSize = 5;
            Draw.LineSize = 5;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Green;
            Draw.Circle(x[100], y[100], Rad[100]);

        }
        // Place your variables here:
        float[] Xcords = new float [500];
        float[] Ycords = new float [500];
        float[] Radius = new float [500];
        float LineSizeSmall = 5;
        Color SkyBlue1 = new Color(166, 230, 242);
        Color GrassGreen1 = new Color(164, 248, 152);
        Color GrassGreen2 = new Color(183, 250, 173);
        Color SunYellow   = new Color(252, 209, 82);
        Color MoonPurp    = new Color(214, 222, 251);
        /// <summary>
        void SunAndMoon(float x, float y)
        {
            Draw.LineColor = Color.Clear;
            Draw.LineSize = 5;
            Draw.FillColor = SunYellow;
            Draw.Circle(x, y, 25);
            Draw.FillColor = MoonPurp;
            Draw.Circle(y,x,25);
            return;
        }
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
           
            Window.SetTitle("Sun and Moon");
            Window.SetSize(500, 500);
            Window.TargetFPS = 60;

        
        }
      
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            SunAndMoon(Input.GetMouseDeltaX(), Input.GetMouseDeltaY());
            Draw.LineColor = Color.Clear;
            Window.ClearBackground(SkyBlue1);
            
           
            Draw.FillColor = GrassGreen2;
            Draw.Circle(350, 500, 245);
            Draw.FillColor = GrassGreen1;
            Draw.Circle(200, 580, 350);
          
        }
    }
}


//LineSizeSmall = 5;
//Draw.LineSize = 5;
//Draw.LineColor = Color.Black;
//Draw.FillColor = Color.Green;
//Draw.Circle(Xcords[100], Ycords[100], Radius[100]);