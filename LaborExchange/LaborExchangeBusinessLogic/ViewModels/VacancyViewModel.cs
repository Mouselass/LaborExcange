using System.ComponentModel;

namespace LaborExchangeBusinessLogic.ViewModels
{
    public class VacancyViewModel
    {
        public int? Id { get; set; }

        [DisplayName("Работодатель")]
        public string EmployerName { get; set; }

        [DisplayName("Должность")]
        public string Post { get; set; }

        [DisplayName("Образование")]
        public string Education { get; set; }

        [DisplayName("Опыт работы")]
        public string Workexperience { get; set; }

        [DisplayName("Описание")]
        public string Description { get; set; }

        public int? Educationid { get; set; }

        public int? Employerid { get; set; }
    }
}
