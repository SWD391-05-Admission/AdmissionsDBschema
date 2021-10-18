using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class UniImage
    {
        public int Id { get; set; }
        public string Src { get; set; }
        public string Alt { get; set; }
        public bool? IsLogo { get; set; }
        public bool? IsBanner { get; set; }
        public int? University { get; set; }

        public virtual University UniversityNavigation { get; set; }
    }
}
