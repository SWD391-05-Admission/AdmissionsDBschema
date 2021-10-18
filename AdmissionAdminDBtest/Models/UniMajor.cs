using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class UniMajor
    {
        public int Id { get; set; }
        public int? University { get; set; }
        public int? MajorId { get; set; }

        public virtual Major Major { get; set; }
        public virtual University UniversityNavigation { get; set; }
    }
}
