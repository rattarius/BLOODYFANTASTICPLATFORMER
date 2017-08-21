using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
// if you called your project something different, make sure you change
// the namespace
namespace AwesomePlatformer
{
    class Sprite
    {
        public Vector2 position = Vector2.Zero;
        public Vector2 offset = Vector2.Zero;
        Texture2D texture;
        public Sprite()
        {
        }
        public void Load(ContentManager content, string asset)
        {
            texture = content.Load<Texture2D>(asset);
        }
        public void Update(float deltaTime)
        {
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position + offset, Color.White);
        }
    }
}