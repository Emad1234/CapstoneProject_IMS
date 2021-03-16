using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CapstoneProject_IMS.Models
{
    public partial class IncidentTeam
    {
        public IncidentTeam()
        {
            Change = new HashSet<Change>();
            Incident = new HashSet<Incident>();
        }

        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamEmail { get; set; }
        public string TeamPhone { get; set; }
        public string TeamHandle { get; set; }
        public string TeamManager { get; set; }
        public string TeamFirstBackup { get; set; }
        public string TeamSecondBackup { get; set; }

        public virtual ICollection<Change> Change { get; set; }
        public virtual ICollection<Incident> Incident { get; set; }
    }
}
