using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using data.Models;
using Hatch.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hatch.Web.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class FamilyController : ControllerBase
    {
        private readonly ILogger<FamilyController> _logger;
        private readonly Repo _repo;

        public FamilyController(ILogger<FamilyController> logger)
        {
            _logger = logger;
            _repo = new Repo();
        }

        [HttpGet]
        public IEnumerable<Family> GetFamily()
        {
            var testShit = new Repo();
            testShit.GetFamily(1);
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
        public RedirectToPageResult GetFamily(int individualId)
        {
            var family = _repo.GetFamily(individualId);

            return new RedirectToPageResult("Index.cshtml");
        }


    }
}
