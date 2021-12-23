using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Random rand = new Random();
                int[] arr = new int[17];
                for (int i = 0; i < 17; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int Sum = 0;
                for (int i = 0; i < 17; i++)
                {
                    Sum += arr[i];
                }
                Console.WriteLine("Сумма=" + Sum);
            }
        }
    }
}
