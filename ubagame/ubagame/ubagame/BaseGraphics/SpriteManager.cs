using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ubagame.BaseGraphics
{
    public static class SpriteManager
    {
        private static List<Sprite> spriteList;
        private static List<Shape> shapeList;

        public static void Initialize()
        {
            spriteList = new List<Sprite>();
            shapeList  = new List<Shape>();
        }

        public static void CreateSprite()
        {

        }

        public static void CreateCircle()
        {
            CircleShape cs = new CircleShape(100.0f);
            cs.FillColor   = Color.Green;
            shapeList.Add(cs);
        }

        public static void DrawAll(ref RenderWindow window)
        {
            window.Clear();
            window.DispatchEvents();

            foreach (Shape s in shapeList)
                window.Draw(s);

            foreach (Sprite s in spriteList)
                window.Draw(s);

            window.Display();
        }
    }
}
