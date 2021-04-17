using System;
using System.Collections.Generic;
using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.Interfaces;
using LaborExchangeBusinessLogic.ViewModels;

namespace LaborExchangeBusinessLogic.BusinessLogics
{
    public class VacancyLogic
    {
        private readonly IVacancyStorage _vacancyStorage;

        public VacancyLogic(IVacancyStorage vacancyStorage)
        {
            _vacancyStorage = vacancyStorage;
        }

        public List<VacancyViewModel> Read(VacancyBindingModel model)
        {
            if (model == null)
            {
                return _vacancyStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<VacancyViewModel> { _vacancyStorage.GetElement(model) };
            }
            return _vacancyStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(VacancyBindingModel model)
        {
            var element = _vacancyStorage.GetElement(new VacancyBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такая вакансия");
            }
            if (model.Id.HasValue)
            {
                _vacancyStorage.Update(model);
            }
            else
            {
                _vacancyStorage.Insert(model);
            }
        }

        public void Delete(VacancyBindingModel model)
        {
            var element = _vacancyStorage.GetElement(new VacancyBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Вакансия не найдена");
            }
            _vacancyStorage.Delete(model);
        }
    }
}
