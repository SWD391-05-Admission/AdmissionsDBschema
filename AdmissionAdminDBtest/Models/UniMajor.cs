using System;
using System.Collections.Generic;

#nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class UniMajor
    {
        public int Id { get; set; }
        public int? University { get; set; }
        public int? Major { get; set; }

        public virtual Major MajorNavigation { get; set; }
        public virtual University UniversityNavigation { get; set; }
    }
}
