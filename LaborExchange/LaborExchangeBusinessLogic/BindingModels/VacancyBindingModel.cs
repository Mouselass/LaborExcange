using System;
using System.Collections.Generic;
using System.Text;

namespace LaborExchangeBusinessLogic.BindingModels
{
    public class VacancyBindingModel
    {
        public int? Id { get; set; }

        public string Post { get; set; }

        public string Workexperience { get; set; }

        public string Description { get; set; }

        public int? Educationid { get; set; }

        public int? Employerid { get; set; }
    }
}
