using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AdmissionAdminDBtest.Models
{
    public partial class Student
    {
        public Student()
        {
            Rates = new HashSet<Rate>();
            Slots = new HashSet<Slot>();
            Wallets = new HashSet<Wallet>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Dob { get; set; }
        public string OldSchool { get; set; }
        public string Avatar { get; set; }

        public virtual User IdNavigation { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<Slot> Slots { get; set; }
        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
