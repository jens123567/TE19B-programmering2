using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoAsteroids
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D backgroundTexture;
        Player player;
        Shoot shoot;

        KeyboardState previousKeyboardState;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferHeight = Globals.ScreenHeight;
            _graphics.PreferredBackBufferWidth = Globals.ScreenWidth;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferHeight = Globals.ScreenHeight;
            _graphics.PreferredBackBufferWidth = Globals.ScreenWidth;
            _graphics.ApplyChanges();

            // TODO: Add your initialization logic here
            player = new Player(this);
            Components.Add(player);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            backgroundTexture = Content.Load<Texture2D>("background");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.Up))
            {
                player.Accelerate(1);
            }
            if (state.IsKeyDown(Keys.Down))
            {
                player.Accelerate(-1);
            }

            if (state.IsKeyDown(Keys.Left))
            {
                player.Rotation -= 0.05f;
            }
            else if (state.IsKeyDown(Keys.Right))
            {
                player.Rotation += 0.05f;
            }

            if (state.IsKeyDown(Keys.Space))
            {
                //shoot.Bullet();
                player.Bullet();
            }



            player.Update(gameTime);
            // TODO: Add your update logic here
            previousKeyboardState = state;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);



            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            for (int y = 0; y < Globals.ScreenHeight; y += backgroundTexture.Height)
            {

                for (int x = 0; x < Globals.ScreenWidth; x += backgroundTexture.Width)
                {
                    _spriteBatch.Draw(backgroundTexture, new Vector2(x, y), Color.White);
                }
            }

            player.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
