using System;
using System.Collections.Generic;

#nullable disable

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
