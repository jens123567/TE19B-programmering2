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

            player.Update(gameTime);
            // TODO: Add your update logic here

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

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
