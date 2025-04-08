using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 10;

            for(int i = 0; i < num1; i++)
            {
                for(int j = 0; j < num1 - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * (num1 - i) - 1; k++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
            int[] numbers = { 12, 5, 23, 7, 18 }; // Our array
            int max = int.MinValue;
            int min = int.MaxValue; // Initialize max and min
            int sum = 0; // Initialize sum
            foreach (int num in numbers)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Maximum number: " + max);
            Console.WriteLine("Minimum number: " + min);
            Console.WriteLine("sum is: " + sum);

            string input = "racecar";
            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine($"Reversed: {reversed}");

            if(reversed == input)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }

            int[] nums = { 4, 2, 3, 1 , 5 };
            int reversedNum = 0;
            
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(nums[i]); 
            }
            Array.Sort(nums);
            Console.Write(string.Join(",", nums));
        }
    }
    
}
