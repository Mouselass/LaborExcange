using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace LaborExchangeBusinessLogic.Interfaces
{
    public interface IApplicantStorage
    {
        List<ApplicantViewModel> GetFullList();

        List<ApplicantViewModel> GetFilteredList(ApplicantBindingModel model);

        ApplicantViewModel GetElement(ApplicantBindingModel model);

        void Insert(ApplicantBindingModel model);

        void Update(ApplicantBindingModel model);

        void Delete(ApplicantBindingModel model);
    }
}
