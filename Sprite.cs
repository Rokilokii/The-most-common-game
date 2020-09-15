using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace The_most_common_game
{
    public class Sprite
    {
        public Texture2D SpTexture { get; }
        public Vector2 SpPosition { get; }

        
        public Sprite(Texture2D newSpTexture, Vector2 newSpPosition)
        {
            SpTexture = newSpTexture;
            SpPosition = newSpPosition;
        }
    }
}
