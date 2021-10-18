using System;
using System.Collections.Generic;

#nullable disable

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
