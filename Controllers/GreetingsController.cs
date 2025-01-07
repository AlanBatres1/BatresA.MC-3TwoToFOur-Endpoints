using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatresA.MC_3TwoToFOur_Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace BatresA.MC_3TwoToFOur_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingsController : ControllerBase
    {
        private readonly GreetingsServices _greetingsServices;

        public GreetingsController(GreetingsServices greetingsServices)
        {
            _greetingsServices = greetingsServices;
        }
        [HttpGet]
        [Route("Greetings/{name}/{time}")]
        public List<string> GreetPersonList(string name, int time)
        {
            return _greetingsServices.GreetPerson(name, time);
        }
    }
}