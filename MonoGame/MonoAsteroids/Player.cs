using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoAsteroids
{
    public class Player : DrawableGameComponent, IGameObject
    {

        public bool IsDead { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 bulletPostition { get; set; }
        public float Radius { get; set; }
        public Vector2 Speed { get; set; }
        public Vector2 bulletSpeed { get; set; }

        public float Rotation { get; set; }
        public float BulletRotation { get; set; }
        public bool isShooting { get; set; }

        private Texture2D playerTexture;
        private Texture2D bulletTexture;

        public Player(Game game) : base(game)
        {
            Position = new Vector2(Globals.ScreenWidth / 2, Globals.ScreenHeight / 2);
            bulletPostition = Position;

        }

        protected override void LoadContent()
        {
            playerTexture = Game.Content.Load<Texture2D>("player");
            bulletTexture = Game.Content.Load<Texture2D>("laser");



            base.LoadContent();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(playerTexture, Position, null, Color.White, Rotation + MathHelper.PiOver2, new Vector2(playerTexture.Width / 2, playerTexture.Height / 2), 1.0f, SpriteEffects.None, 0f);

            while (isShooting)
            {
                spriteBatch.Draw(bulletTexture, bulletPostition, null, Color.White, Rotation + MathHelper.PiOver2, new Vector2(bulletTexture.Width / 2, bulletTexture.Height / 2), 1.0f, SpriteEffects.None, 0f);

            }

        }

        public override void Update(GameTime gameTime)
        {
            Position += Speed;

            if (Position.X < Globals.GameArea.Left)
                Position = new Vector2(Globals.GameArea.Right, Position.Y);
            if (Position.X > Globals.GameArea.Right)
                Position = new Vector2(Globals.GameArea.Left, Position.Y);
            if (Position.Y < Globals.GameArea.Top)
                Position = new Vector2(Position.X, Globals.GameArea.Bottom);
            if (Position.Y > Globals.GameArea.Bottom)
                Position = new Vector2(Position.X, Globals.GameArea.Top);


            // KeyboardState state = Keyboard.GetState();

            KeyboardState state = Keyboard.GetState();

            isShooting = false;
            if (state.IsKeyDown(Keys.Space))
            {

                bulletPostition = Position;
                isShooting = true;
            }


            BulletRotation = Rotation;
            bulletPostition += bulletSpeed;


            // bulletPostition += bulletSpeed;

            base.Update(gameTime);
        }


        public void Accelerate(float direction)
        {
            Speed += new Vector2((float)Math.Cos(Rotation), (float)Math.Sin(Rotation)) * (0.20f * direction);

            if (Speed.LengthSquared() > 25)
                Speed = Vector2.Normalize(Speed) * 5;
        }


        public void Bullet()
        {

            bulletSpeed = new Vector2((float)Math.Cos(BulletRotation), (float)Math.Sin(BulletRotation)) * (1.30f);

        }

    }
}