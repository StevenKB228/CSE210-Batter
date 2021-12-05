using System;

namespace cse210_batter_csharp.Casting
    
{ 
     public class Ball : Actor
    {
         public Ball()
   {
            SetWidth(Constants.BALL_WIDTH);
            SetHeight(Constants.BALL_HEIGHT);
            SetImage(Constants.IMAGE_BALL);
            SetVelocity(new Point(4, 4));
        }
    }
}
