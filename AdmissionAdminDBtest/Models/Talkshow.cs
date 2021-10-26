using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class Talkshow
    {
        public Talkshow()
        {
            Rates = new HashSet<Rate>();
            Slots = new HashSet<Slot>();
            TalkshowTransactions = new HashSet<TalkshowTransaction>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string ImagePanel { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsCancel { get; set; }
        public int? Price { get; set; }
        public int? CounselorId { get; set; }
        public int? MajorId { get; set; }
        public int? UniversityId { get; set; }

        public virtual Counselor Counselor { get; set; }
        public virtual Major Major { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<Slot> Slots { get; set; }
        public virtual ICollection<TalkshowTransaction> TalkshowTransactions { get; set; }
    }
}
