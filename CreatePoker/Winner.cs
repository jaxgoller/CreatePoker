using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePoker
{
    class Winner
    {
        Pocket Player0 = new Pocket();
        Pocket Player1 = new Pocket();
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
