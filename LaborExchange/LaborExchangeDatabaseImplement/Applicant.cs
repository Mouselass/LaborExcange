using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LaborExchangeDatabaseImplement
{
    public partial class Applicant
    {
        public Applicant()
        {
            Deal = new HashSet<Deal>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public DateTime Birthdaydate { get; set; }
        public string Workexperience { get; set; }
        public long Phone { get; set; }
        public int Educationid { get; set; }
        public int Userid { get; set; }

        public virtual Education Education { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Deal> Deal { get; set; }
    }
}
