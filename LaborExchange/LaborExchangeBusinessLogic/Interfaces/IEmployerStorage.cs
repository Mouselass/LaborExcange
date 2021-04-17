using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace LaborExchangeBusinessLogic.Interfaces
{
    public interface IEmployerStorage
    {
        List<EmployerViewModel> GetFullList();

        List<EmployerViewModel> GetFilteredList(EmployerBindingModel model);

        EmployerViewModel GetElement(EmployerBindingModel model);

        void Insert(EmployerBindingModel model);

        void Update(EmployerBindingModel model);

        void Delete(EmployerBindingModel model);
    }
}
