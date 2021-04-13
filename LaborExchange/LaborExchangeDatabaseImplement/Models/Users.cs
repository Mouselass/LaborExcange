using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LaborExchangeDatabaseImplement.Models
{
    public partial class Users
    {
        public Users()
        {
            Applicant = new HashSet<Applicant>();
            Employer = new HashSet<Employer>();
            Exchangeemployee = new HashSet<Exchangeemployee>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }

        public virtual ICollection<Applicant> Applicant { get; set; }
        public virtual ICollection<Employer> Employer { get; set; }
        public virtual ICollection<Exchangeemployee> Exchangeemployee { get; set; }
    }
}
