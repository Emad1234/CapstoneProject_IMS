using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CapstoneProject_IMS.Models
{
    public partial class IncidentSeverity
    {
        public IncidentSeverity()
        {
            Incident = new HashSet<Incident>();
        }

        public int SeverityId { get; set; }
        public string SeverityName { get; set; }
        public string SeverityDescription { get; set; }

        public virtual ICollection<Incident> Incident { get; set; }
    }
}
