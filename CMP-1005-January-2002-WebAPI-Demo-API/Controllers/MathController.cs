using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
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
        public void GoToPermanent(string url = "https://google.ca/")
        {
            Response.StatusCode = 308;
            Response.Headers.Add("Location", url);
        }

        [HttpGet]
        public void GoToTemporary(string url = "https://bing.ca/")
        {
            Response.StatusCode = 307;
            Response.Headers.Add("Location", url);
        }

        [HttpGet]
        public double? Add(int lValue, int rValue)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            
            if (lValue > 100 || rValue > 100)
            {
                Response.StatusCode = 400;
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Bad Request";
                return null;
            }
            else
            {
                return lValue + rValue;
            }
        }

        [HttpGet]
        public double Subtract(int lValue, int rValue)
        {
            return lValue - rValue;
        }
    }
}
