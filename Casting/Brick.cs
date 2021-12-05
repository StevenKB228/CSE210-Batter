using System;
using System.Collections.Generic;


namespace cse210_batter_csharp.Casting
{
    public class Brick : Actor
    {
        public Brick()
        {
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BRICK_HEIGHT);
            SetImage(Constants.IMAGE_BRICK);
        }
    }

}