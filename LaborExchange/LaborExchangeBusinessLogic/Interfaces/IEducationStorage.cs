using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace LaborExchangeBusinessLogic.Interfaces
{
    public interface IEducationStorage
    {
        List<EducationViewModel> GetFullList();

        List<EducationViewModel> GetFilteredList(EducationBindingModel model);

        EducationViewModel GetElement(EducationBindingModel model);

        void Insert(EducationBindingModel model);

        void Update(EducationBindingModel model);

        void Delete(EducationBindingModel model);
    }
}
