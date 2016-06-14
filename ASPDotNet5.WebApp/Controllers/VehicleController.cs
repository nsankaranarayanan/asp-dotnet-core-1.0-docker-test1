using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPDotNet5.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class VehicleController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return (new string[] { "Yaris", "Corolla", "Camry", "Avlon", "Sienna" });
        }
    }
}
