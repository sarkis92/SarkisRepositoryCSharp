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
            long[] nums;

            nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();


            long searchedNum = int.Parse(Console.ReadLine());
            long midIndex;
            long lowerIndex = 0, HighIndex = nums.Length - 1;
            if (nums.Length == 1 && nums[0] == searchedNum)
            {
                Console.WriteLine(0);
                return;
            }
            else if (nums.Length == 1 && nums[0] != searchedNum)
            {
                Console.WriteLine(-1);
                return;
            }

            while (true)
            {
                midIndex = (HighIndex + lowerIndex) / 2;



                if (nums[midIndex] == searchedNum)
                {
                    long counter = midIndex;
                    while (true)
                    {
                        counter--;
                        if (nums[counter] == nums[midIndex])
                        {
                            midIndex = counter;
                        }
                        else break;
                    }
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

                if ((HighIndex == lowerIndex + 1))
                {
                    Console.WriteLine(searchedNum == HighIndex ? HighIndex : -1);
                }
            }





        }
    }
}
