﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class BonusBomb : GameObject
    {
        public BonusBomb(Game game) : base(game)
        {
            picture = game.pictureManager.bonusBomb;
            visible = false;
            pickable = true;
        }
        public override void Step()
        {
            foreach (Player player in game.players)//zjistim, ktery z hracu sebral bonus
            {
                if (Collision(player))
                {
                    player.amountOfBombs++;
                }
            }
        }
    }
}
