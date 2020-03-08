using data.Models;
using System;
using System.Collections.Generic;

namespace data.Models
{
    public class Individual
    {
        public Individual()
        {
            Relations = new Dictionary<int, Relation>();
        }
        /// <summary>
        /// Gets/sets the Individual's Id
        /// </summary>
        public int Id { get; set; }

        public string Name { get; set; }
        public bool Living { get; set; }

        /// <summary>
        /// Gets/sets the sex of the Individual
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// Gets/sets the list of diseases
        /// </summary>
        public List<Disease> Diseases { get; set; }


        /// <summary>
        /// Get/sets the age of death
        /// </summary>        
        public int? DeathAge { get; set; }

        public Dictionary<int, Relation> Relations { get; set; }

    }
}
