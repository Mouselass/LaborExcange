using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace LaborExchangeBusinessLogic.Interfaces
{
    public interface IExchangeEmployeeStorage
    {
        List<ExchangeEmployeeViewModel> GetFullList();

        List<ExchangeEmployeeViewModel> GetFilteredList(ExchangeEmployeeBindingModel model);

        ExchangeEmployeeViewModel GetElement(ExchangeEmployeeBindingModel model);

        void Insert(ExchangeEmployeeBindingModel model);

        void Update(ExchangeEmployeeBindingModel model);

        void Delete(ExchangeEmployeeBindingModel model);
    }
}
