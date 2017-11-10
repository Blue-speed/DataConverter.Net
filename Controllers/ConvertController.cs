using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Net;

namespace DataConverter.Net.Controllers
{
    [Route("Convert")]
    public class ConvertController: Controller
    {
        
        ILogger _logger { get; set; }

        public ConvertController(ILogger<ConvertController> logger)
        {
            _logger = logger;
        }

        [HttpPost("ToBase64")]
        public string ToBase64(string inputData)
        {
            var bytes = Encoding.UTF8.GetBytes(inputData);
            return Convert.ToBase64String(bytes);
        }

        [HttpPost("FromBase64")]
        public string FromBase64(string inputData)
        {
            var bytes = Convert.FromBase64String(inputData);
            return Encoding.UTF8.GetString(bytes);
        }

        [HttpGet("UrlEncode")]
        public string UrlEncode(string input)
        {
            return WebUtility.UrlEncode(input);
        }
    }
}