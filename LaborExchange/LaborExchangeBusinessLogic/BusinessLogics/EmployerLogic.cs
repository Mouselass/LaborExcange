using System;
using System.Collections.Generic;
using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.Interfaces;
using LaborExchangeBusinessLogic.ViewModels;

namespace LaborExchangeBusinessLogic.BusinessLogics
{
    public class EmployerLogic
    {
        private readonly IEmployerStorage _employerStorage;

        public EmployerLogic(IEmployerStorage employerStorage)
        {
            _employerStorage = employerStorage;
        }

        public List<EmployerViewModel> Read(EmployerBindingModel model)
        {
            if (model == null)
            {
                return _employerStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<EmployerViewModel> { _employerStorage.GetElement(model) };
            }
            return _employerStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(EmployerBindingModel model)
        {
            var element = _employerStorage.GetElement(new EmployerBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такой работодатель");
            }
            if (model.Id.HasValue)
            {
                _employerStorage.Update(model);
            }
            else
            {
                _employerStorage.Insert(model);
            }
        }

        public void Delete(EmployerBindingModel model)
        {
            var element = _employerStorage.GetElement(new EmployerBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Мебель не найдена");
            }
            _employerStorage.Delete(model);
        }
    }
}
