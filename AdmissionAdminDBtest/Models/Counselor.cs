using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class Counselor
    {
        public Counselor()
        {
            Talkshows = new HashSet<Talkshow>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }

        public virtual User IdNavigation { get; set; }
        public virtual ICollection<Talkshow> Talkshows { get; set; }
    }
}
