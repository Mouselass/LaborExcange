using System;
using System.Collections.Generic;
using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.Interfaces;
using LaborExchangeBusinessLogic.ViewModels;

namespace LaborExchangeBusinessLogic.BusinessLogics
{
    public class EducationLogic
    {
        private readonly IEducationStorage _educationStorage;

        public EducationLogic(IEducationStorage educationStorage)
        {
            _educationStorage = educationStorage;
        }

        public List<EducationViewModel> Read(EducationBindingModel model)
        {
            if (model == null)
            {
                return _educationStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<EducationViewModel> { _educationStorage.GetElement(model) };
            }
            return _educationStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(EducationBindingModel model)
        {
            var element = _educationStorage.GetElement(new EducationBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такое образование");
            }
            if (model.Id.HasValue)
            {
                _educationStorage.Update(model);
            }
            else
            {
                _educationStorage.Insert(model);
            }
        }

        public void Delete(EducationBindingModel model)
        {
            var element = _educationStorage.GetElement(new EducationBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Образование не найдено");
            }
            _educationStorage.Delete(model);
        }
    }
}
