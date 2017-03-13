using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Bullet : SpriteGameObject
    {
        public Bullet(string assetname = "spr_bullet", int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Reset();
        }

        public override void Reset()
        {
            base.Reset();
            //this.Visible = false;
            this.Velocity = Vector2.Zero;
            this.Position = new Vector2(-100, 0);
        }

        public void Fire(Vector2 startPos)
        {
            this.Position = startPos;
            this.Velocity = new Vector2(0, -200);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            PlayingState PS = GameWorld as PlayingState;

            foreach (Mushroom item in PS.Mushroom.Objects)
            {
                if (this.CollidesWith(item))
                {
                    this.Reset();
                    PS.Mushroom.Remove(item);
                    break;
                }
            }

            foreach (SnakeSegment item in PS.Snake.Objects)
            {
                if (this.CollidesWith(item))
                {
                    PS.Score.ScoreValue += 10;
                    this.Reset();
                    PS.Mushroom.Add(new Mushroom(item.Position));
                    PS.Snake.Remove(item);
                    break;
                }
            }
        }
    }
}
