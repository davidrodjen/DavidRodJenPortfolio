using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DavidRodJenPortfolio.Models
{
    public class Resume
    {
        /// <summary>
        /// ID of job, for storage information
        /// and pulling of info
        /// </summary>
        [Key]
        public int JobID { get; set; }

        /// <summary>
        /// Company Name & Date of employment, no string limit
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Position Name, no string limit
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Description/Role Details, no string limit
        /// </summary>
        public string Description { get; set; }

    }
}
