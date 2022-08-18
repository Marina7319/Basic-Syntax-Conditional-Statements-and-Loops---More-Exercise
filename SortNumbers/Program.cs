using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                sum += nums;

                if (nums > maxNum)
                {
                    maxNum = nums;
                }

               if(nums < minNum)
                {
                    minNum = nums;
                }
                
            }
            int num = sum - minNum - maxNum;
                Console.WriteLine(maxNum);
                Console.WriteLine(num);
                Console.WriteLine(minNum);
        }
    }
}
