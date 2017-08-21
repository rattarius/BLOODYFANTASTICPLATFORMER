 using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections;

namespace AwesomePlatformer
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
        class Player
        {
            Sprite sprite = new Sprite();
            public Player()
            {
            }
            public void Load(ContentManager content)
            {
                sprite.Load(content, "hero");
            }
            public void Update(float deltaTime)
            {
                sprite.Update(deltaTime);
            }
            public void Draw(SpriteBatch spriteBatch)
            {
                sprite.Draw(spriteBatch);
            }
        }
    }
       