using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CapstoneProject_IMS.Models
{
    public partial class IncidentManager
    {
        public IncidentManager()
        {
            Incident = new HashSet<Incident>();
        }

        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string ManagerEmail { get; set; }
        public string ManagerPhone { get; set; }
        public string ManagerHandle { get; set; }

        public virtual ICollection<Incident> Incident { get; set; }
    }
}
