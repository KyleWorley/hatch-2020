using System;
using System.Collections.Generic;

namespace Hatch.Web 
{
    public class Individual 
    {
        /// <summary>
        /// Gets/sets the Individual's Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets/sets the sex of the Individual
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// Gets/sets the list of diseases
        /// </summary>
        public List<string> Diseases { get; set; }


        /// <summary>
        /// Get/sets the age of death
        /// </summary>
        public int? DeathAge { get; set; }

    }
}
