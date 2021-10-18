using System;
using System.Collections.Generic;

#nullable disable

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
        public int? Counselor { get; set; }
        public int? Major { get; set; }
        public int? University { get; set; }

        public virtual Counselor CounselorNavigation { get; set; }
        public virtual Major MajorNavigation { get; set; }
        public virtual University UniversityNavigation { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<Slot> Slots { get; set; }
        public virtual ICollection<TalkshowTransaction> TalkshowTransactions { get; set; }
    }
}
