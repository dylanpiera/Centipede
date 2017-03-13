using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class PlayingState : GameObjectList
    {
        Player player;
        Bullet bullet;
        GameObjectList snake;

        public PlayingState()
        {
            player = new Player();
            bullet = new Bullet();
            snake = new GameObjectList();

            for (int i = 0; i < 9; i++)
            {
                this.snake.Add(new SnakeSegment(new Vector2(0+(32 * i),0)));
            }

            player.Position = new Vector2(235, 500);

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(player);
            this.Add(bullet);
            this.Add(snake);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space))
            {
                bullet.Fire(new Vector2((player.GlobalPosition.X + (player.Sprite.Width / 2)), player.Position.Y - 20));
            }
        }
    }
}
