using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ubagame.BaseGraphics;

namespace ubagame.BaseEngine
{
    public static class GameLoop
    {
        private static RenderWindow window;
        public static void InitializeGameLoop(/*Insert arguments here*/)
        {
            //Insert initialization here:     
            window = new RenderWindow(new VideoMode(800, 600), "test");      
            window.SetActive();
            SpriteManager.Initialize();
            SpriteManager.CreateCircle();

            MainLoop();
        }

        public static void MainLoop()
        {
            while (window.IsOpen())
            {

                SpriteManager.DrawAll(ref window);
                
            }
        }
    }
}
