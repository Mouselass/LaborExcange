using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace LaborExchangeBusinessLogic.Interfaces
{
    public interface IDealStorage
    {
        List<DealViewModel> GetFullList();

        List<DealViewModel> GetFilteredList(DealBindingModel model);

        DealViewModel GetElement(DealBindingModel model);

        void Insert(DealBindingModel model);

        void Update(DealBindingModel model);

        void Delete(DealBindingModel model);
    }
}
