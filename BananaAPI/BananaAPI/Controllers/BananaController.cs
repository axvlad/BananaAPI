using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BananaAPI.Controllers
{
    [Route("api/[controller]")]
    public class BananaController : Controller
    {
        public Banana PrintInfo()
        {
            Banana yellow = new Banana();
            return yellow;
        }

        [HttpGet]
        public Banana Get()
        {
            return PrintInfo();
        }
    }
}
