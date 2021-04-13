using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LaborExchangeDatabaseImplement.Models
{
    public partial class Education
    {
        public Education()
        {
            Applicant = new HashSet<Applicant>();
            Vacancy = new HashSet<Vacancy>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Applicant> Applicant { get; set; }
        public virtual ICollection<Vacancy> Vacancy { get; set; }
    }
}
