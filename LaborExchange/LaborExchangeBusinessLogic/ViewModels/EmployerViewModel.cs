using System;
using System.ComponentModel;

namespace LaborExchangeBusinessLogic.ViewModels
{
    public class EmployerViewModel
    {
        public int? Id { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Деятельность")]
        public string Activity { get; set; }

        [DisplayName("Адрес")]
        public string Address { get; set; }

        [DisplayName("Телефон")]
        public long Phone { get; set; }

        public int? Userid { get; set; }
    }
}
