using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CapstoneProject_IMS.Models
{
    public partial class Change
    {
        public Change()
        {
            ChangeAnnotation = new HashSet<ChangeAnnotation>();
        }

        public int ChangeId { get; set; }
        public string ChangeTitle { get; set; }
        public string ChangeDescription { get; set; }
        public DateTime ChangeStart { get; set; }
        public DateTime? ChangeEnd { get; set; }
        public bool ChangeComplete { get; set; }
        public string ExternalTicket { get; set; }
        public string ExternalTicketUrl { get; set; }
        public int LocationId { get; set; }
        public string LocationUrl { get; set; }
        public int TeamId { get; set; }

        public virtual Location Location { get; set; }
        public virtual IncidentTeam Team { get; set; }
        public virtual ICollection<ChangeAnnotation> ChangeAnnotation { get; set; }
    }
}
