using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {/*Scrieti o functie care va calcula suma cifrelor unui numar*/

            Console.WriteLine("Scrieti un numar:");
            int num = int.Parse(Console.ReadLine());
            int sum = GetSum(num);
            Console.WriteLine("Suma numerelor este: " + sum);
        }
        static int GetSum (int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum = sum + num % 10; 
                num = num / 10;
            }
            return sum;
        }


    }
}
