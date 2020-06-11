using Qatarlar1.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qatarlar1.World
{
    class GameWorld
    {
        public GameWorld()
        {
            GameEntities = new List<GameEntity>();
            GameTimer = new Stopwatch();
        }

        public List<GameEntity> GameEntities { get; set; }

        public Stopwatch GameTimer { get; }

        private TimeSpan previousGameTick;



        public void AddEntity(GameEntity entity)
        {
            GameEntities.Add(entity);
        }

        public void StartTimer()
        {
            GameTimer.Start();
        }

        public void GameTick()
        {
            foreach (var entity in GameEntities)
            {
                entity.GameTick(ElapsedMSecondsSinceLastTick);

                previousGameTick = GameTimer.Elapsed;
            }
        }

        public double ElapsedMSecondsSinceLastTick
        {
            get
            {
                return (double)(GameTimer.Elapsed - previousGameTick).TotalMilliseconds;
            }
        }

    }
}
