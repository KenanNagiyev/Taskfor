using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int say = 0;

            for (int i = n; i < m; i++)
            {
                if (i % 7 == 0)
                {
                    say++;
                }

            }
            Console.WriteLine("say = " + say);
            Console.ReadLine();
        }
    }
    }

