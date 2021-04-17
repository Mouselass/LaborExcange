using System;
using System.ComponentModel;

namespace LaborExchangeBusinessLogic.ViewModels
{
    public class ApplicantViewModel
    {
        public int? Id { get; set; }

        public int? Userid { get; set; }

        public int? Educationid { get; set; }

        [DisplayName("Фамилия")]
        public string Surname { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Отчество")]
        public string Middlename { get; set; }

        [DisplayName("Образование")]
        public string Education { get; set; }

        [DisplayName("Дата рождения")]
        public DateTime Birthdaydate { get; set; }

        [DisplayName("Опыт работы")]
        public string Workexperience { get; set; }

        [DisplayName("Телефон")]
        public long Phone { get; set; }
    }
}
