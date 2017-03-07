using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Player : SpriteGameObject
    {
        public Player(string assetname = "spr_player", int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (((this.Position.Y >= (Centipede.Screen.Y - this.Sprite.Height)) || (this.Position.Y <= 0) || (this.Position.X <= 0) || (this.Position.X >= (Centipede.Screen.X - this.Sprite.Width))))
            {
                if ((this.Position.Y >= (Centipede.Screen.Y - this.Sprite.Height)))
                {
                    this.Position = new Vector2(this.Position.X, (Centipede.Screen.Y - this.Sprite.Height) - 1);
                }
                if ((this.Position.X >= (Centipede.Screen.X - this.Sprite.Width)))
                {
                    this.Position = new Vector2((Centipede.Screen.X - this.Sprite.Width)-1, this.Position.Y);
                }
                if (this.Position.Y <= 0)
                {
                    this.Position = new Vector2(this.Position.X, 1);
                }
                if (this.Position.X <= 0)
                {
                    this.Position = new Vector2(1, this.Position.Y);
                }
                this.Velocity = Vector2.Zero;
            }
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if(inputHelper.IsKeyDown(Keys.Left) && !(this.Position.X <= 0))
            {
                this.Velocity = new Vector2(-200,0);
            }
            if (inputHelper.IsKeyDown(Keys.Right) && !(this.Position.X >= (Centipede.Screen.X - this.Sprite.Width)))
            {
                this.Velocity = new Vector2(200, 0);
            }
            if (inputHelper.IsKeyDown(Keys.Up) && !(this.Position.Y <= 0))
            {
                this.Velocity = new Vector2(0, -200);
            }
            if (inputHelper.IsKeyDown(Keys.Down) && !(this.Position.Y >= (Centipede.Screen.Y - this.Sprite.Height)))
            {
                this.Velocity = new Vector2(0, 200);
            }
            if (!inputHelper.IsKeyDown(Keys.Left) && !inputHelper.IsKeyDown(Keys.Right) && !inputHelper.IsKeyDown(Keys.Up) && !inputHelper.IsKeyDown(Keys.Down))
            {
                this.Velocity = Vector2.Zero;
            }
        }
    }
}
