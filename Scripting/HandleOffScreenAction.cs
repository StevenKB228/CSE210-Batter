using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;


namespace cse210_batter_csharp.Scripting
{
        public class HandleOffScreenAction : Action
    

    {
        public HandleOffScreenAction()
        {

        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor orb = cast["balls"][0];
            Actor HandleOffScreenAction = cast ["balls"] [0];

            int x = orb.GetX();
            int y = orb.GetY();

            int dx = orb.GetVelocity().GetX();
            int dy = orb.GetVelocity().GetY();

            if (x > Constants.MAX_X-50|| x < 5)
            {
                dx = -dx;
                Console.WriteLine("brick");
            }
            if (y > Constants.MAX_Y-50 || y < 5)
            {
                dy = -dy;
            }

            orb.SetVelocity(new Point(dx, dy));
        }
         
    }
}