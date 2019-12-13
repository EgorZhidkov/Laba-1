using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Array
    {
        public static List<MinimumandMaximum> DivideSubArrays(int beginIndex, int endIndex, int subArraysCount)
        {
            List<MinimumandMaximum> result = new List<MinimumandMaximum>();

            if ((endIndex - beginIndex) <= subArraysCount)
            {
                result.Add(new MinimumandMaximum(0, (endIndex - beginIndex)));
            }
            else
            {
                int delta = (endIndex - beginIndex) / subArraysCount;
                int currentBegin = beginIndex;

                while ((endIndex - currentBegin) >= 2 * delta)
                {
                    result.Add(new MinimumandMaximum(currentBegin, currentBegin + delta));
                    currentBegin += delta;
                }
                result.Add(new MinimumandMaximum(currentBegin, endIndex));
            }
            return result;
        }
    }
}
