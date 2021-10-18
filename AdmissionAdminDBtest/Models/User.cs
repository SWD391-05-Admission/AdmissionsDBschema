using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        public string Description { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual Counselor Counselor { get; set; }
        public virtual Student Student { get; set; }
    }
}
