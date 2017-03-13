using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Mushroom : SpriteGameObject
    {
        public Mushroom(string assetname = "spr_mushroom", int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Position = new Vector2(Centipede.Random.Next(0, 470), Centipede.Random.Next(25, 450));
        }
        public Mushroom(Vector2 startPos, string assetname = "spr_mushroom", int layer = 0, string id = "", int sheetIndex = 0) : base(assetname, layer, id, sheetIndex)
        {
            this.Position = startPos;
        }


    }
}
