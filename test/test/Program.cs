using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            //christmas tree
            string x = "*";
            int num1 = 10;
            for(int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num1 - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i + 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            //inverted
            int num2 = 10;
            for(int i = 0; i < num2; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < (2 * (num2 - i) - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            Console.WriteLine();
            int num3 = 10;
            for(int i = 0; i < num3; i++)
            {
                Console.Write(" ");
                for(int j = 0;j < num3 - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            
            
            int num4 = 10;
            for (int i = 0; i < num4; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            int num5 = 10;
            for (int i = 0 ; i < num5; i++)
            {
                for(int j = 0; j < num5 - i - 1 ; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int[] num8 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = int.MinValue, min = int.MaxValue;

            foreach (int num in num8)
            {
                if (num > max) max = num;
                if (num < min)  min = num;
            }
            Console.WriteLine($"Max: {max}");

            Console.WriteLine($"Min: {min}");
        }
    }
}
