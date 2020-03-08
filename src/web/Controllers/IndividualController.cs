using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using hatch_web.Models;
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
            var test = new Individual() 
            {
                Id = new Guid(),
                Sex = new string("M"),
                Diseases = new List<Disease>(),
                DeathAge = 10
            };
            var test1 = new Individual()
            {
                Id = new Guid(),
                Sex = new string("F"),
                Diseases = new List<Disease>(),
                DeathAge = 51
            };

            Individual[] retval = new Individual[] {test, test1};

            return retval;
        }

        [HttpGet("{id}")]
        public ActionResult<Individual> GetIndividuals(int id)
        {
            var test = new Individual()
            {
                Id = new Guid(),
                Sex = new string("M"),
                Diseases = new List<Disease>(),
                DeathAge = 10
            };

            return test;
        }
    }
}
