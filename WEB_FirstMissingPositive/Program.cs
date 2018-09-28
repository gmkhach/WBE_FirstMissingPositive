/**
 * Given an unsorted integer array, find the first missing positive number.
 * ie: [3, 4, -1, 1] should return 2.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WEB_FirstMissingPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Input an array of integer\n\n>>> ");
                    string[] input = Console.ReadLine().Split(',');
                    int[] intArr = new int[input.Length];
                    for (int i = 0; i < input.Length; i++)
                    {
                        intArr[i] = Convert.ToInt32(input[i]);
                    }
                    Console.WriteLine(FirstMissingPositive(intArr));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static int FirstMissingPositive(int[] arr)
        {
            int missing = 1;
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    if (arr[i] > missing)
                    {
                        return missing;
                    }
                    else
                    {
                        missing = arr[i] + 1;
                    }
                }
            }
            return missing;
        }
    }
}
