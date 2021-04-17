using System;
using System.Collections.Generic;
using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.Interfaces;
using LaborExchangeBusinessLogic.ViewModels;

namespace LaborExchangeBusinessLogic.BusinessLogics
{
    public class ExchangeEmployeeLogic
    {
        private readonly IExchangeEmployeeStorage _exchangeEmployeeStorage;

        public ExchangeEmployeeLogic(IExchangeEmployeeStorage exchangeEmployeeStorage)
        {
            _exchangeEmployeeStorage = exchangeEmployeeStorage;
        }

        public List<ExchangeEmployeeViewModel> Read(ExchangeEmployeeBindingModel model)
        {
            if (model == null)
            {
                return _exchangeEmployeeStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ExchangeEmployeeViewModel> { _exchangeEmployeeStorage.GetElement(model) };
            }
            return _exchangeEmployeeStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(ExchangeEmployeeBindingModel model)
        {
            var element = _exchangeEmployeeStorage.GetElement(new ExchangeEmployeeBindingModel
            {
                Id = model.Id
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такой работник биржи");
            }
            if (model.Id.HasValue)
            {
                _exchangeEmployeeStorage.Update(model);
            }
            else
            {
                _exchangeEmployeeStorage.Insert(model);
            }
        }

        public void Delete(ExchangeEmployeeBindingModel model)
        {
            var element = _exchangeEmployeeStorage.GetElement(new ExchangeEmployeeBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Работник биржи не найден");
            }
            _exchangeEmployeeStorage.Delete(model);
        }
    }
}
