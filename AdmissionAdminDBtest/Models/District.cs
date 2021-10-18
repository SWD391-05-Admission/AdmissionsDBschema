using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class District
    {
        public District()
        {
            UniAddresses = new HashSet<UniAddress>();
        }

        public int Id { get; set; }
        public string District1 { get; set; }

        public virtual ICollection<UniAddress> UniAddresses { get; set; }
    }
}
