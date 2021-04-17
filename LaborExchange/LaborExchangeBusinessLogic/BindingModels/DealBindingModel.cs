using System;
using System.Collections.Generic;
using System.Text;

namespace LaborExchangeBusinessLogic.BindingModels
{
    public class DealBindingModel
    {
        public int? Id { get; set; }

        public DateTime Dealdate { get; set; }

        public int? Applicantid { get; set; }

        public int? ExchangeEmployeeid { get; set; }

        public int? Vacancyid { get; set; }
    }
}
