using System;
using System.Collections.Generic;

#nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class UniAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int? District { get; set; }
        public int? University { get; set; }

        public virtual District DistrictNavigation { get; set; }
        public virtual University UniversityNavigation { get; set; }
    }
}
