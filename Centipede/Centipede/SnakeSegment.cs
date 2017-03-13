using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class SnakeSegment : SpriteGameObject
    {
        public SnakeSegment(Vector2 startPos, string assetname = "spr_snakebody", int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Position = startPos;
            this.Velocity = new Vector2(200,0);
        }

        public void Bounce()
        {
            this.Velocity *= -1;
            this.Position = new Vector2(this.Position.X, this.Position.Y + 32);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (this.Position.X >= (Centipede.Screen.X - Sprite.Width) || this.position.X < 0)
            {
                this.Bounce();
            }
        }
    }
}
