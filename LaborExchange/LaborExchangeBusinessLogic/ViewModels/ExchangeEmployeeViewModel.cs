using System;
using System.ComponentModel;

namespace LaborExchangeBusinessLogic.ViewModels
{
    public class ExchangeEmployeeViewModel
    {
        public int? Id { get; set; }

        public int? Userid { get; set; }

        [DisplayName("Фамилия")]
        public string Surname { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Отчество")]
        public string Middlename { get; set; }

        [DisplayName("Телефон")]
        public long Phone { get; set; }
    }
}
