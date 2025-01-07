using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatresA.MC_3TwoToFOur_Endpoints.Services
{
    public class GreetingsServices
    {
        public List<string> GreetPersonList = new();
        public List<string> GreetPerson(string name, int time)
        {
            if (time > 12 || time == 0)
            {
                GreetPersonList.Add("Please Enter a Hour 1-12");
            }
            else
            {
                GreetPersonList.Add($"Good Morning {name}! You have woken at around {time}:00");
            }
            return GreetPersonList;
        }
    }
}