using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class AdmissionForm
    {
        public AdmissionForm()
        {
            UniAdmissions = new HashSet<UniAdmission>();
        }

        public int Id { get; set; }
        public string Method { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UniAdmission> UniAdmissions { get; set; }
    }
}
