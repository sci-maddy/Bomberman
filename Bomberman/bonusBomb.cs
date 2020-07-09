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
            if (Collision(game.player1))
            {
                game.player1.amountOfBombs++;
            }
            else if (Collision(game.player2))
            {
                game.player2.amountOfBombs++;
            }
        }
    }
}
