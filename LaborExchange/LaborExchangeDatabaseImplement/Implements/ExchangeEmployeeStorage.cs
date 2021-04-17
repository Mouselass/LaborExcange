using System;
using System.Collections.Generic;
using System.Linq;
using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.Interfaces;
using LaborExchangeBusinessLogic.ViewModels;
using LaborExchangeDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace LaborExchangeDatabaseImplement.Implements
{
    public class ExchangeEmployeeStorage : IExchangeEmployeeStorage
    {
        public List<ExchangeEmployeeViewModel> GetFullList()
        {
            using (var context = new postgresContext())
            {
                return context.Exchangeemployee.Select(rec => new ExchangeEmployeeViewModel
                {
                    Id = rec.Id,
                    Userid = rec.Userid,
                    Surname = rec.Surname,
                    Name = rec.Name,
                    Middlename = rec.Middlename,
                    Phone = rec.Phone
                })
                .ToList();
            }
        }

        public List<ExchangeEmployeeViewModel> GetFilteredList(ExchangeEmployeeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                return context.Exchangeemployee.Where(rec => rec.Userid == model.Userid).Select(rec => new ExchangeEmployeeViewModel
                {
                    Id = rec.Id,
                    Userid = rec.Userid,
                    Surname = rec.Surname,
                    Name = rec.Name,
                    Middlename = rec.Middlename,
                    Phone = rec.Phone
                })
                .ToList();
            }
        }

        public ExchangeEmployeeViewModel GetElement(ExchangeEmployeeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                var exchangeEmployee = context.Exchangeemployee.FirstOrDefault(rec => rec.Id == model.Id);
                return exchangeEmployee != null ?
                new ExchangeEmployeeViewModel
                {
                    Id = exchangeEmployee.Id,
                    Userid = exchangeEmployee.Userid,
                    Surname = exchangeEmployee.Surname,
                    Name = exchangeEmployee.Name,
                    Middlename = exchangeEmployee.Middlename,
                    Phone = exchangeEmployee.Phone
                } :
                null;
            }
        }

        public void Insert(ExchangeEmployeeBindingModel model)
        {
            using (var context = new postgresContext())
            {
                context.Exchangeemployee.Add(CreateModel(model, new Exchangeemployee()));
                context.SaveChanges();
            }
        }

        public void Update(ExchangeEmployeeBindingModel model)
        {
            using (var context = new postgresContext())
            {
                var element = context.Exchangeemployee.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Работник биржи не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ExchangeEmployeeBindingModel model)
        {
            using (var context = new postgresContext())
            {
                Exchangeemployee element = context.Exchangeemployee.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Exchangeemployee.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Работник биржи не найден");
                }
            }
        }

        private Exchangeemployee CreateModel(ExchangeEmployeeBindingModel model, Exchangeemployee applicant)
        {
            applicant.Userid = model.Userid.Value;
            applicant.Surname = model.Surname;
            applicant.Name = model.Name;
            applicant.Middlename = model.Middlename;
            applicant.Phone = model.Phone;
            return applicant;
        }
    }
}
