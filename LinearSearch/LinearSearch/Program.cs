using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int searchedNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == searchedNum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(-1);
        }
    }
}
