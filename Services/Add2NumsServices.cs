using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.MC_3TwoToFOur_Endpoints.Services
{
    public class Add2NumsServices
    {
        public string Add2Nums(int num1, int num2)
        {
            int sum = num1 + num2;
            return $"{num1} + {num2} is equal to {sum}";
        }
    }
}