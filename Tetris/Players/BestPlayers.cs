using System;
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

        public Player getBestPlayer() {
            if (bestPlayers.Count>0)
            {
                int max = bestPlayers.Max(x => x.Points);
                return bestPlayers.Where(x => x.Points == max).First();
            }
            Player temp = new Player();
            temp.Points = 0;
            return temp;
        }
    }
}
