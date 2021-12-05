using System;
using System.Collections.Generic;

namespace cse210_batter_csharp.Casting
{
    public class Paddle : Actor
    {
        public Paddle()
        {
            SetWidth(Constants.PADDLE_WIDTH);
            SetHeight(Constants.PADDLE_HEIGHT);
            SetImage(Constants.IMAGE_PADDLE);
        }
    }
}