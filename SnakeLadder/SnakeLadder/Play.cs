using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class Play
    {
        int position1 = 0;
        int Player1;

        public void rollDice()
        {
            Random random = new Random();
            Player1 = random.Next(0, 7);
        }
}
