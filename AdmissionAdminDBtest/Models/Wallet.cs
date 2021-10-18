using System;
using System.Collections.Generic;

#nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class Wallet
    {
        public Wallet()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Student { get; set; }

        public virtual Student StudentNavigation { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
