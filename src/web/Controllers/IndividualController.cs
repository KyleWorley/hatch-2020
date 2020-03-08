using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hatch.Web.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class IndividualController : ControllerBase
    {
        private readonly ILogger<IndividualController> _logger;

        public IndividualController(ILogger<IndividualController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Individual> GetIndividuals()
        {
            Individual[] retval = new Individual[] { };

            return retval;
        }

        [HttpGet("{id}")]
        public ActionResult<Individual> GetIndividuals(int id)
        {
            return new ActionResult<Individual>(new Individual());
        }
    }
}
