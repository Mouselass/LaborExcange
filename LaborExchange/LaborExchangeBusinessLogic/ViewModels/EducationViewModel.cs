using System;
using System.ComponentModel;

namespace LaborExchangeBusinessLogic.ViewModels
{
    public class EducationViewModel
    {
        public int Id { get; set; }

        [DisplayName("Тип образования")]
        public string Type { get; set; }
    }
}
