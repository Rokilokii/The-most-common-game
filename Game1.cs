using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace   The_most_common_game
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Sprite sprite1;
        private Component sprite2;
        private Texture2D backTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Services.AddService(typeof(SpriteBatch), _spriteBatch);

            sprite1 = new Sprite(Content.Load<Texture2D>("spite"), new Vector2(150, 200));
            sprite2 = new Component(this, Content.Load<Texture2D>("spite1"), new Vector2(250, 200), new Rectangle(2, 2, 48, 84));

            backTexture = Content.Load<Texture2D>("background");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _spriteBatch.Draw(backTexture, new Rectangle(0, 0, 800, 500), Color.White);
            _spriteBatch.Draw(sprite1.SpTexture, sprite1.SpPosition, Color.White);
            _spriteBatch.End();

            sprite2.Draw(gameTime);

            base.Draw(gameTime);
        }
    }
}
