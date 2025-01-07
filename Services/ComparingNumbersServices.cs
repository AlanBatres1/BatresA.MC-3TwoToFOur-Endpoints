using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.MC_3TwoToFOur_Endpoints.Services
{
    public class ComparingNumbersServices
    {
        public string CompareNums(int num3, int num4)
        {
            if (num3 > num4)
            {
                return $"{num3} is greater than {num4}";
            }
            else if (num3 < num4)
            {
                return $"{num3} is less than {num4}";
            }
            else
            {
                return $"{num3} and {num4} are equal";
            }
        }
    }
}