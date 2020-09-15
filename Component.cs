using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace The_most_common_game
{
    public class Component : DrawableGameComponent
    {
        private Texture2D SpTexture;
        private Vector2 SpPosition;
        private Rectangle SpRectangle;


        public Component(Game game, Texture2D newTexture, Vector2 newPosition, Rectangle newRectangle) : base(game)
        {
            SpTexture = newTexture;
            SpPosition = newPosition;
            SpRectangle = newRectangle;
        }

       
        public override void Draw(GameTime gameTime)
        {
            SpriteBatch sprBatch = (SpriteBatch) Game.Services.GetService(typeof(SpriteBatch));

            sprBatch.Begin();
            sprBatch.Draw(SpTexture, SpPosition, SpRectangle, Color.White);
            sprBatch.End();
        }
    }
}
