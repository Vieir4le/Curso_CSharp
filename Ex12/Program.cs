﻿namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final;
            Console.WriteLine("**************************");
            Console.WriteLine("Digite o final do intervalo:");
            Console.WriteLine("**************************");
            final = Convert.ToInt32(Console.ReadLine());

            for (int i =1; i<= final; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0}, ", i);
            }
        }
    }
}
