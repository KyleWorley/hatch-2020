using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data.Models
{
    public class Relation
    {
        public RelationType Type { get; set; }
        public int ReportedBy {get;set;}
    }
}
