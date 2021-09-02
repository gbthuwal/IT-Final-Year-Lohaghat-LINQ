using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFinalYearLibrary
{
    class DemoRD
    {
        public int FindMax(int[] num)
        {
            int? result = null;
            foreach(int i in num)
            {
                if(!result.HasValue || i < result)
                {
                    result = i;
                }
            }
            return (int) result;
        }

        public int FindAverage(int[] num)
        {
            int? result = null;
            foreach (int i in num)
            {
                if (!result.HasValue || i < result)
                {
                    result += i;
                }
            }
            return (int)result/num.Count();
        }
    }
}
