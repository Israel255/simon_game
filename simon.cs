using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace simon_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to simon!");
            //random numbers on array
            try
            {
                Random num = new Random();
                int sum = 0;
                int sum_player = 0;
                int[] numbers = new int[10];
                int[] player_guess = new int[10];
                int jump = -1;
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = num.Next(1, 5);
                    while (jump < i)
                    {
                        Console.WriteLine(numbers[jump + 1]);
                        sum += numbers[jump + 1];
                        jump++;
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    jump = -1;
                    while (jump < i)
                    {
                        player_guess[jump + 1] = Convert.ToInt32(Console.ReadLine());
                        sum_player += player_guess[jump + 1];
                        jump++;
                    }
                    Console.Clear();
                    if (sum_player != sum)
                    {
                        Console.WriteLine("you lost");
                        break;
                    }
                    jump = -1;
                }
                if (sum == sum_player)
                {
                    Console.WriteLine("winner!!!");
                }
            }
            catch
            {
                Console.WriteLine("number please!!!");
            }
        }
    }
}
