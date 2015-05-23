using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchedNum = int.Parse(Console.ReadLine());
            int midIndex;
            int lowerIndex = 0, HighIndex = nums.Length - 1;


            while (true)
            {
                midIndex = (HighIndex + lowerIndex) / 2;

                if ((lowerIndex == midIndex) && (nums[midIndex + 1] == searchedNum))
                {
                    Console.WriteLine(midIndex + 1);
                    break;
                }

                if (nums[midIndex] == searchedNum)
                {
                    Console.WriteLine(midIndex);
                    break;
                }
                else if (nums[midIndex] < searchedNum)
                {
                    lowerIndex = midIndex;
                }
                else
                {
                    HighIndex = midIndex;
                }

                if (HighIndex == lowerIndex)
                {
                    Console.WriteLine(-1);
                    break;
                }
            }
        }
    }
}
