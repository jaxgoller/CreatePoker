using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePoker
{
    class Winner
    {
        Hand Player0 = new Hand();
        Hand Player1 = new Hand();
        River river = new River();
        Winner[] P0 = new Winner[7];
        Winner[] P1 = new Winner[7];
        //Add river to both player's hands
        public Winner()
        {
            for (int i = 0; i < 7; i++)
            {

            }
        }
    }
}
