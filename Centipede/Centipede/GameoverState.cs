using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class GameoverState : GameObjectList
    {
        private TextGameObject text;

        public GameoverState()
        {
            this.text = new TextGameObject("GameFont");
            this.text.Text = "Game Over!";
            this.text.Position = new Microsoft.Xna.Framework.Vector2((Centipede.Screen.X / 2) - (this.text.Size.X / 2), (Centipede.Screen.Y / 2) - (this.text.Size.Y / 2));

            this.Add(text);
        }
    }
}
