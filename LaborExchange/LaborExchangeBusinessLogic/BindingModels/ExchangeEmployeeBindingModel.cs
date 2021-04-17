using System;
using System.Collections.Generic;
using System.Text;

namespace LaborExchangeBusinessLogic.BindingModels
{
    public class ExchangeEmployeeBindingModel
    {
        public int? Id { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Middlename { get; set; }

        public long Phone { get; set; }

        public int? Userid { get; set; }
    }
}
