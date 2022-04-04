using System;
using Microsoft.Xna.Framework;

namespace MonoAsteroids
{
    public class Globals
    {
        public static int ScreenWidth = 1280;
        public static int ScreenHeight = 720;

        public static Rectangle GameArea
        {
            get
            {
                return new Rectangle(-50, -50, ScreenWidth + 100, ScreenHeight + 100);
            }
        }

    }
}