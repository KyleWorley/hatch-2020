using System;
using System.Collections.Generic;

namespace data.Models    
{
    public class Family 
    {
        public Family()
        {
            Individuals = new Dictionary<int, Individual>();
        }
        /// <summary>
        /// Gets/sets the Individual's Id
        /// </summary>
        /// Dont think this needs to be a Class but just incase
        public Dictionary<int, Individual> Individuals { get; set; }
    }
}
