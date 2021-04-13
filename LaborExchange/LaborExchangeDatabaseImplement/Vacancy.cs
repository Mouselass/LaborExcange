using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace LaborExchangeDatabaseImplement
{
    public partial class Vacancy
    {
        public int Id { get; set; }
        public string Post { get; set; }
        public string Workexperience { get; set; }
        public string Description { get; set; }
        public int Educationid { get; set; }
        public int Employerid { get; set; }

        public virtual Education Education { get; set; }
        public virtual Employer Employer { get; set; }
    }
}
