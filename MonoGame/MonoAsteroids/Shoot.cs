using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoAsteroids
{
    public class Shoot : Player
    {
        public bool IsDead { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 BulletPosition { get; set; }
        public float Radius { get; set; }
        public Vector2 Speed { get; set; }
        public Vector2 bulletSpeed { get; set; }
        public float Rotation { get; set; }
        //private Texture2D playerTexture;
        private Texture2D bulletTexture;

        public Shoot(Game game) : base(game)
        {

        }

        protected override void LoadContent()
        {
            bulletTexture = Game.Content.Load<Texture2D>("laser");

            base.LoadContent();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bulletTexture, Position, null, Color.White, Rotation + MathHelper.PiOver2, new Vector2(bulletTexture.Width / 2, bulletTexture.Height / 2), 1.0f, SpriteEffects.None, 0f);

        }

        public override void Update(GameTime gameTime)
        {
            BulletPosition += bulletSpeed;


            base.Update(gameTime);
        }


        public void Bullet()
        {
            bulletSpeed += new Vector2((float)Math.Cos(Rotation), (float)Math.Sin(Rotation)) * (0.60f);
        }


    }
}