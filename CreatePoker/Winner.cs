using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePoker
{
    class Winner
    {
        public Winner()
        { 
        }

        public int WinningPlayer(Hand Player0, Hand Player1)
        {
            int ScoreP0 = Player0.Score();
            Console.WriteLine(ScoreP0);
            int ScoreP1 = Player1.Score();
            Console.WriteLine(ScoreP1);
            if (ScoreP0 > ScoreP1)
            {
                return Player0.player;
            }
            return Player1.player;
        }
    }
}
