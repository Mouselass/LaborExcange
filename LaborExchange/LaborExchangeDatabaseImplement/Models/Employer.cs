using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LaborExchangeDatabaseImplement.Models
{
    public partial class Employer
    {
        public Employer()
        {
            Deal = new HashSet<Deal>();
            Vacancy = new HashSet<Vacancy>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Activity { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public int Userid { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Deal> Deal { get; set; }
        public virtual ICollection<Vacancy> Vacancy { get; set; }
    }
}
