using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CapstoneProject_IMS.Models
{
    public partial class Location
    {
        public Location()
        {
            Change = new HashSet<Change>();
            Incident = new HashSet<Incident>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocationEmail { get; set; }
        public string LocationPhone { get; set; }
        public string LocationUrl { get; set; }
        public string LocationManager { get; set; }
        public string LocationFirstBackup { get; set; }
        public string LocationSecondBackup { get; set; }
        public int UsersCount { get; set; }

        public virtual ICollection<Change> Change { get; set; }
        public virtual ICollection<Incident> Incident { get; set; }
    }
}
