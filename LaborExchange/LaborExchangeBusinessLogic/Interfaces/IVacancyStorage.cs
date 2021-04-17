using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace LaborExchangeBusinessLogic.Interfaces
{
    public interface IVacancyStorage
    {
        List<VacancyViewModel> GetFullList();

        List<VacancyViewModel> GetFilteredList(VacancyBindingModel model);

        VacancyViewModel GetElement(VacancyBindingModel model);

        void Insert(VacancyBindingModel model);

        void Update(VacancyBindingModel model);

        void Delete(VacancyBindingModel model);
    }
}
