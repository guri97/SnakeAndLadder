using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class PlayerPosition1
    {
        int[] arr = new int[100];
        int[] snake = { 18, 54, 62, 64, 87, 95, 92, 98 };
        int[] ladder = { 4, 9, 21, 28, 51, 71, 80 };//arr[18]=9
        public void Positon2()
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
            int Position = 0;
            Console.WriteLine("player is at the position Zero");
            for (int i = 0; i < 100; i++)
            {
                if (Position == 0)
                {
                    Dice roll = new Dice();
                    roll.DiceRoll2();


                }

            }

        }
        public class Dice
        {
            public void DiceRoll2()

            {

                Console.WriteLine("enter 1 to roll the dice");
                int Entered_val = Convert.ToInt32(Console.ReadLine());
                if (Entered_val == 1)
                {

                    Random rand = new Random();
                    int Dic = rand.Next(0, 7);
                    Console.WriteLine(Dic);


                }
            }




        }
    }
}
