using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_task_6_30_2024_
{
    internal class years
    {
        public int[] graterYear(int[] y) {
            
            int [] years = new int[y.Length];
            for (int i = 0; i<y.Length; i++) {
                if (y[i] >= 1950) { 
                years[i] = y[i];
                }
            }
            return years;
        }
    }
}
