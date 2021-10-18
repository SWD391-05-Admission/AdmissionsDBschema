using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class Rate
    {
        public int Id { get; set; }
        public int? Rate1 { get; set; }
        public int? Talkshow { get; set; }
        public int? Student { get; set; }

        public virtual Student StudentNavigation { get; set; }
        public virtual Talkshow TalkshowNavigation { get; set; }
    }
}
