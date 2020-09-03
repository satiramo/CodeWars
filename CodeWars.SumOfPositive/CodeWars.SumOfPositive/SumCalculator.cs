using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.SumOfPositive
{
    class SumCalculator
    {
        public static int PositiveSum(int[] arr)
        {
            int sum = arr.Where(x => x > 0).Select(x => x).ToArray().Sum();
            return sum>0 ? sum:0;
        }
    }
}
