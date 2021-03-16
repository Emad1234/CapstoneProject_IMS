using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CapstoneProject_IMS.Models
{
    public partial class Incident
    {
        public Incident()
        {
            IncidentAnnotation = new HashSet<IncidentAnnotation>();
        }

        public int IncidentId { get; set; }
        public string IncidentTitle { get; set; }
        public string IncidentDescription { get; set; }
        public DateTime IncidentStart { get; set; }
        public DateTime? IncidentEnd { get; set; }
        public bool IncidentResolved { get; set; }
        public string ExternalTicket { get; set; }
        public string ExternalTicketUrl { get; set; }
        public int SeverityId { get; set; }
        public int LocationId { get; set; }
        public string LocationUrl { get; set; }
        public int ManagerId { get; set; }
        public int TeamId { get; set; }

        public virtual Location Location { get; set; }
        public virtual IncidentManager Manager { get; set; }
        public virtual IncidentSeverity Severity { get; set; }
        public virtual IncidentTeam Team { get; set; }
        public virtual ICollection<IncidentAnnotation> IncidentAnnotation { get; set; }
    }
}
