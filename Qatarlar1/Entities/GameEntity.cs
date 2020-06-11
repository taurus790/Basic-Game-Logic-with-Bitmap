using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Qatarlar1.Entities
{
    //Abstract game entity, all elements in the game inherit from this. 
    public abstract class GameEntity
    {
        //The position of this game entity.
        public Vector2 Position { get; set; }

        //The Velocity of this game entity, pixels per second.
        public Vector2 Velocity { get; set; }



        //Contains game logic. milliseconds elapsed indicates how much game time has passed since this function was last executed.
        public virtual void GameTick(double millisecondsElapsed)
        {

        }

        //Entities draw themselves in this function 
        public virtual void Draw(WriteableBitmap surface)
        {

        }

    }
}
