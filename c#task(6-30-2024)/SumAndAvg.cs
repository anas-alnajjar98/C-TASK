using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_task_6_30_2024_
{
    internal class SumAndAvg
    {
        public (double, double) avgandsum(double[] arr)
        {
            double sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            double avg = sum / arr.Length;
            return (sum, avg);
        }
    }
}
