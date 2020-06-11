using Qatarlar1.Entities;
using Qatarlar1.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Qatarlar1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WriteableBitmap writeableBmp;
        GameWorld world;

        public MainWindow()
        {
            InitializeComponent();
        }



        private void ViewPort_Loaded(object sender, RoutedEventArgs e)
        {
            int width = 500;
            int height = 500;
            
            writeableBmp = BitmapFactory.New(width, height);
            ViewPort.Source = writeableBmp;

            CreateWorld();
            world.StartTimer();

            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        private void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            world.GameTick();

            writeableBmp.Clear();

            foreach (var entity in world.GameEntities)
            {
                entity.Draw(writeableBmp);
            }
        }

        private void CreateWorld()
        {
            world = new GameWorld();

            var ball = new Ball()
            {
                Diameter = 20,
                Position = new System.Numerics.Vector2(100, 100),
                Velocity = new System.Numerics.Vector2(60, 60)
            };

            world.AddEntity(ball);
        }
    }
}
