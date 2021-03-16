﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CapstoneProject_IMS.Models
{
    public partial class IncidentAnnotation
    {
        public int AnnotationId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string AnnotationContent { get; set; }
        public bool AnnotationVisible { get; set; }
        public int IncidentId { get; set; }

        public virtual Incident Incident { get; set; }
    }
}