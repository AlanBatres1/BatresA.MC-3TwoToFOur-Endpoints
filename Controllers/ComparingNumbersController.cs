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
    public class ComparingNumbersController : ControllerBase
    {
        private readonly ComparingNumbersServices _comparingNumbersServices;

        public ComparingNumbersController(ComparingNumbersServices comparingNumbersServices)
        {
            _comparingNumbersServices = comparingNumbersServices;
        }
        [HttpGet]
        [Route("CompareNumbers/{num3}/{num4}")]
        public string CompareNums(int num3, int num4)
        {
            return _comparingNumbersServices.CompareNums(num3, num4);
        }
    }
}