using System;
using System.Collections.Generic;

#nullable disable

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
