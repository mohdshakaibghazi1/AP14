using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConaAppLinsearch
{
    internal class Program
    {
        public static int LinearSearch(int[] arr, int sItem)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == sItem)
                {
                    return i;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("enter search item");
            int sItem = int.Parse(Console.ReadLine());
            int result = LinearSearch(arr, sItem);
            if (result != -1)
            {
                Console.WriteLine($"{sItem}Found at Index {result}");
            }
            else
            {
                Console.WriteLine($"{sItem} not found");
            }
        }
    }
}
