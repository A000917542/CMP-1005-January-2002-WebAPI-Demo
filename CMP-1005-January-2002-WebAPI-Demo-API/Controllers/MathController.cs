using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMP_1005_January_2002_WebAPI_Demo_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet]
        public double Add(int lValue, int rValue)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");
            Response.Headers.Add("Access-Control-Allow-Origin", "https://ca.yahoo.com");
            return lValue + rValue;
        }

        [HttpGet]
        public double Subtract(int lValue, int rValue)
        {
            return lValue - rValue;
        }
    }
}
