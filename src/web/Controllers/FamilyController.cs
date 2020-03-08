using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hatch.Web.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class FamilyController : ControllerBase
    {
        private readonly ILogger<FamilyController> _logger;

        public FamilyController(ILogger<FamilyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Family> GetFamily()
        {
            var test = new Family() 
            {
            };
            var test1 = new Family()
            {
            };

            Family[] retval = new Family[] {test, test1};

            return retval;

            {
            }

        }

        [HttpGet("{id}")]
        public ActionResult<Family> GetFamily(int id)
        {
            return new Family();
        }
    }
}
