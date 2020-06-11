using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Qatarlar1.Entities
{
    public class Ball : GameEntity
    {
        public double Diameter { get; set; }
        // // elə belə 
        public override void GameTick(double millisecondsElapsed)
        {
            Position = Position + Velocity * (float)millisecondsElapsed / 1000;
        }

        public override void Draw(WriteableBitmap surface)
        {
            surface.FillEllipse((int)Position.X, (int)Position.Y,
                (int)(Position.X + Diameter), (int)(Position.Y + Diameter),
                Colors.Blue);
        }
    }
}
