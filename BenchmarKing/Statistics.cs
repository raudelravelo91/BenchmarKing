using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarKing
{
    public class Statistics
    {
        public List<(int, double)> AveragePerWindow(List<BenchResult> benchs, Func<BenchResult, BenchResult, bool> windowComparer)
        {
            var result = new List<(int, double)>();

            int left, right;
            BenchResult leftBench, rightBench;
            left = right = 0;
            leftBench = rightBench = benchs[0];
            //TODO O(n) average per window...

            return result;
        }
    }
}
