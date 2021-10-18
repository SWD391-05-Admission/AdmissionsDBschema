using System;
using System.Collections.Generic;

#nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class UniAdmission
    {
        public int Id { get; set; }
        public int University { get; set; }
        public int Admission { get; set; }

        public virtual AdmissionForm AdmissionNavigation { get; set; }
        public virtual University UniversityNavigation { get; set; }
    }
}
