using System;
using System.ComponentModel;

namespace LaborExchangeBusinessLogic.ViewModels
{
    public class DealViewModel
    {
        public int? Id { get; set; }

        public int? Applicantid { get; set; }

        [DisplayName("Соискатель")]
        public string Applicant { get; set; }

        public int? ExchangeEmployeeid { get; set; }

        [DisplayName("Работник биржи")]
        public string ExchangeEmployee { get; set; }

        public int? Vacancyid { get; set; }

        [DisplayName("Вакансия")]
        public string Vacancy { get; set; }

        [DisplayName("Дата сделки")]
        public DateTime Dealdate { get; set; }
    }
}
