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
    public class Add2NumsController : ControllerBase
    {
        private readonly Add2NumsServices _add2NumsServices;

        public Add2NumsController(Add2NumsServices add2NumsServices)
        {
            _add2NumsServices = add2NumsServices;
        }
        [HttpGet]
        [Route("AddNumbers/{num1}/{num2}")]
        public string Add2Nums(int num1, int num2)
        {
            return _add2NumsServices.Add2Nums(num1, num2);
        }
    }
}