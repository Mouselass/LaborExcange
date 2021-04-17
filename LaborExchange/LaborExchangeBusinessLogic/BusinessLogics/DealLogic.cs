using System;
using System.Collections.Generic;
using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.Interfaces;
using LaborExchangeBusinessLogic.ViewModels;

namespace LaborExchangeBusinessLogic.BusinessLogics
{
    public class DealLogic
    {
        private readonly IDealStorage _dealStorage;

        public DealLogic(IDealStorage dealStorage)
        {
            _dealStorage = dealStorage;
        }

        public List<DealViewModel> Read(DealBindingModel model)
        {
            if (model == null)
            {
                return _dealStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<DealViewModel> { _dealStorage.GetElement(model) };
            }
            return _dealStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(DealBindingModel model)
        {
            var element = _dealStorage.GetElement(new DealBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такая сделка");
            }
            if (model.Id.HasValue)
            {
                _dealStorage.Update(model);
            }
            else
            {
                _dealStorage.Insert(model);
            }
        }

        public void Delete(DealBindingModel model)
        {
            var element = _dealStorage.GetElement(new DealBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Сделка не найдена");
            }
            _dealStorage.Delete(model);
        }
    }
}
