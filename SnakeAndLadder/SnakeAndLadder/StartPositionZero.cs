using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class StartPositionZero
    {
        int[] arr = new int[100];
        public void Positon()
        {
            //for (int i = 0; i < arr.Length; i++)
            //if(i == 0)
            //{
            //    Console.WriteLine("player is at the position Zero");

            //}
            //else
            //{
            //    Console.WriteLine("player not at position zero");
            //}
            arr[0] = 0;
            Console.WriteLine("player is at the position Zero");

        }

    }
}
