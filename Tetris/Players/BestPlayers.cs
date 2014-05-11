﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    [Serializable]
    public class BestPlayers
    {
        public List<Player> bestPlayers;

        public BestPlayers()
        {
            bestPlayers = new List<Player>();
        }
        public BestPlayers(Player player)
        {

        }
        public void orderList()
        {
            bestPlayers = bestPlayers.OrderByDescending(x => x.Points).ToList();
        }
    }
}
