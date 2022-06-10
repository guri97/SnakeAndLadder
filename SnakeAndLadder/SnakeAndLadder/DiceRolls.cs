using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class DiceRolls
    {
        readonly int[] arr = new int[100];
        public void Positon1()
        {
            //for (int i = 0; i < arr.Length; i++)
            //    if (i == 0)
            //    {
            //        Console.WriteLine("player is at the position Zero");

            //    }
            //    else
            //    {
            //        Console.WriteLine("player not at position zero");
            //    }
            arr[0] = 0;
            Console.WriteLine("player is at the position Zero");
        }
        public static void DiceRoll1()
        {
            Console.WriteLine("enter 1 to roll the dice");
            int Entered_val = Convert.ToInt32(Console.ReadLine());
            if (Entered_val == 1)
            {

                Random rand = new();
                int Dice = rand.Next(0, 7);
                Console.WriteLine(Dice);
            }
        }
    }
}
