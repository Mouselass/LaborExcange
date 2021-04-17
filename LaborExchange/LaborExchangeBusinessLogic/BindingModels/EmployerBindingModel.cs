using System;
using System.Collections.Generic;
using System.Text;

namespace LaborExchangeBusinessLogic.BindingModels
{
    public class EmployerBindingModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Activity { get; set; }

        public string Address { get; set; }

        public long Phone { get; set; }

        public int? Userid { get; set; }
    }
}
