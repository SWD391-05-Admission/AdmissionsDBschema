using System;
using System.Collections.Generic;

#nullable disable

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
