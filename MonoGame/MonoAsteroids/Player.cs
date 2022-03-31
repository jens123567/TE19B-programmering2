using System;
using Microsoft.Xna.Framework;

namespace MonoAsteroids
{
    public class Player : DrawableGameComponent, IGameObject
    {

        public bool IsDead { get; set; }
        public Vector2 Position { get; set; }
        public float Radius { get; set; }
        public Vector2 Speed { get; set; }
        public float Rotation { get; set; }

        public Player(Game game) : base(game)
        {
            Position = new Vector2(Globals.ScreenWidth / 2, Globals.ScreenHeight / 2);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
        }

    }
}