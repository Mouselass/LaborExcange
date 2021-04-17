using System;
using System.Collections.Generic;
using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.Interfaces;
using LaborExchangeBusinessLogic.ViewModels;

namespace LaborExchangeBusinessLogic.BusinessLogics
{
    public class ApplicantLogic
    {
        private readonly IApplicantStorage _applicantStorage;

        public ApplicantLogic(IApplicantStorage applicantStorage)
        {
            _applicantStorage = applicantStorage;
        }

        public List<ApplicantViewModel> Read(ApplicantBindingModel model)
        {
            if (model == null)
            {
                return _applicantStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ApplicantViewModel> { _applicantStorage.GetElement(model) };
            }
            return _applicantStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(ApplicantBindingModel model)
        {
            var element = _applicantStorage.GetElement(new ApplicantBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такой соискатель");
            }
            if (model.Id.HasValue)
            {
                _applicantStorage.Update(model);
            }
            else
            {
                _applicantStorage.Insert(model);
            }
        }

        public void Delete(ApplicantBindingModel model)
        {
            var element = _applicantStorage.GetElement(new ApplicantBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Соискатель не найдена");
            }
            _applicantStorage.Delete(model);
        }
    }
}
