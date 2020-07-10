﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class BonusSpeed : GameObject
    {
        public BonusSpeed(Game game) : base(game)
        {
            this.game = game;
            picture = game.pictureManager.bonusSpeed;
            pickable = true;
            visible = false;
        }
        public override void Step()
        {
            foreach (Player player in game.players)//zjistim, ktery z hracu sebral bonus
            {
                if (Collision(player))
                {
                    player.timeSpeededUp = 1000;
                }
            }
        }
    }
}
