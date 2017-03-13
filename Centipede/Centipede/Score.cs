using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede
{
    class Score : TextGameObject
    {
        private int score;

        public Score(string assetname = "GameFont", int layer = 0, string id = "") : base(assetname, layer, id)
        {
            this.Text = "Score: 0";
        }

        public int ScoreValue
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
                this.Text = "Score: " + value;
            }
        }
    }
}
