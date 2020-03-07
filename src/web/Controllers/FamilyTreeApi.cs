using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamilyTreeApi : ControllerBase
    {
        [HttpGet]
        public string Test()
        {
            var repo = new Repo();
            var guys = repo.GetIndividual(123);
            return guys;
        }
    }
}
