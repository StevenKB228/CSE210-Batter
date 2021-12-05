using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp.Scripting
{
    public class HandleCollisionsActions : Action
    {
        AudioService audioService = new AudioService();
        PhysicsService physicsService = new PhysicsService();
        public HandleCollisionsActions()
        {

        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor orb = cast["balls"][0];
            Actor paddle = cast["paddle"][0];
            //Actor brick = cast["brick"][0];
            List<Actor> bricks = cast["bricks"];
            List<Actor> bricksThatTouchTheBall = new List<Actor>();
            foreach (Actor brick in bricks)
            { 
                bool brickcollision = physicsService.IsCollision(orb, brick);
                if (brickcollision)
                {
                    int x = orb.GetX();
                    int y = orb.GetY();

                    int dx = orb.GetVelocity().GetX();
                    int dy = orb.GetVelocity().GetY();

                    dy = -dy;                
                    orb.SetVelocity(new Point(dx, dy));

                    audioService.PlaySound(Constants.SOUND_BOUNCE);

                    // This brick touched the ball
                    bricksThatTouchTheBall.Add(brick);
                    // Put this brick in the list


                }

            

                
            }
        
             foreach (Actor brick in bricksThatTouchTheBall)
             {
                 cast ["bricks"].Remove (brick);
             }


            bool collision = physicsService.IsCollision(orb, paddle);
            //bool brickcollision = physicsService.IsCollision(orb, brick);


            if (collision)
            {
                int x = orb.GetX();
                int y = orb.GetY();

                int dx = orb.GetVelocity().GetX();
                int dy = orb.GetVelocity().GetY();

                dy = -dy;                
                orb.SetVelocity(new Point(dx, dy));

                audioService.PlaySound(Constants.SOUND_BOUNCE);
            }
        
        }
    }
}