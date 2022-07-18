using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderDice
{
    internal class Dice2
    {
        public static void Ldice2()
        {
            int position = 0;
            Console.WriteLine("The starting position is : " +position);
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("The Dice roll is :" +dice);
        }
    }
}
