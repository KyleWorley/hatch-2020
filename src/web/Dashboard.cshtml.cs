using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.Models;
using Hatch.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hatch_web
{
    public class IndexModel : PageModel
    {
        private Family thisFam;
        private readonly Repo _repo;
        public IndexModel()
        {
            _repo = new Repo();
        }

        public Family OnGet()
        {
            var family = _repo.GetFamily(1);

            return family;
        }
    }
}