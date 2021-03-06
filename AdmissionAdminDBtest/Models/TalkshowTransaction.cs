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
        public int? TalkshowId { get; set; }
        public int? TransactionId { get; set; }

        public virtual Talkshow Talkshow { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
