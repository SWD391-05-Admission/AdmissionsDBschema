using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            TalkshowTransactions = new HashSet<TalkshowTransaction>();
        }

        public int Id { get; set; }
        public int? Amount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Desciption { get; set; }
        public int? Wallet { get; set; }

        public virtual Wallet WalletNavigation { get; set; }
        public virtual ICollection<TalkshowTransaction> TalkshowTransactions { get; set; }
    }
}
