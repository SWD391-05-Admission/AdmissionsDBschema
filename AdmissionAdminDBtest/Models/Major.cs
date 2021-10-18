using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class Major
    {
        public Major()
        {
            Talkshows = new HashSet<Talkshow>();
            UniMajors = new HashSet<UniMajor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Talkshow> Talkshows { get; set; }
        public virtual ICollection<UniMajor> UniMajors { get; set; }
    }
}
