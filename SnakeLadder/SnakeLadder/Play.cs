using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class Play
    {
        int position1 = 0, count = 0;
        int Player1;

        public void rollDice()
        {
            Random random = new Random();

            while (position1 != 100)
            {
                Player1 = random.Next(0, 7);
                int check1 = random.Next(0, 3);
                count++;

                switch (check1)
                {
                    case 0:
                        break;
                    case 1:
                        position1 += Player1;
                        break;
                    case 2:
                        position1 -= Player1;
                        break;
                }
                if (position1 < 0)
                    position1 = 0;
                if (position1 > 100)
                    position1 -= Player1;
                Console.WriteLine("Dice roll: " + count + " Position of Player 1: " + position1);
            }
        }
    }
}
