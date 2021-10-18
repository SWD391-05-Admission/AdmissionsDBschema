using System;
using System.Collections.Generic;

#nullable disable

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
