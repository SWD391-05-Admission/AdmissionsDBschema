using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class TalkshowTransaction
    {
        public int Id { get; set; }
        public int? Talkshow { get; set; }
        public int? Transaction { get; set; }

        public virtual Talkshow TalkshowNavigation { get; set; }
        public virtual Transaction TransactionNavigation { get; set; }
    }
}
