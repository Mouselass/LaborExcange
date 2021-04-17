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
    public class EmployerStorage : IEmployerStorage
    {
        public List<EmployerViewModel> GetFullList()
        {
            using (var context = new postgresContext())
            {
                return context.Employer.Select(rec => new EmployerViewModel
                {
                    Id = rec.Id,
                    Userid = rec.Userid,
                    Name = rec.Name,
                    Activity = rec.Activity,
                    Address = rec.Address,
                    Phone = rec.Phone
                })
                .ToList();
            }
        }

        public List<EmployerViewModel> GetFilteredList(EmployerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                return context.Employer.Where(rec => rec.Userid == model.Userid).Select(rec => new EmployerViewModel
                {
                    Id = rec.Id,
                    Userid = rec.Userid,
                    Name = rec.Name,
                    Activity = rec.Activity,
                    Address = rec.Address,
                    Phone = rec.Phone
                })
                .ToList();
            }
        }

        public EmployerViewModel GetElement(EmployerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                var employer = context.Employer.FirstOrDefault(rec => rec.Id == model.Id);
                return employer != null ?
                new EmployerViewModel
                {
                    Id = employer.Id,
                    Userid = employer.Userid,
                    Name = employer.Name,
                    Activity = employer.Activity,
                    Address = employer.Address,
                    Phone = employer.Phone
                } :
                null;
            }
        }

        public void Insert(EmployerBindingModel model)
        {
            using (var context = new postgresContext())
            {
                context.Employer.Add(CreateModel(model, new Employer()));
                context.SaveChanges();
            }
        }

        public void Update(EmployerBindingModel model)
        {
            using (var context = new postgresContext())
            {
                var element = context.Employer.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Работодатель не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(EmployerBindingModel model)
        {
            using (var context = new postgresContext())
            {
                Employer element = context.Employer.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Employer.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Работодатель не найден");
                }
            }
        }

        private Employer CreateModel(EmployerBindingModel model, Employer employer)
        {
            employer.Userid = model.Userid.Value;
            employer.Name = model.Name;
            employer.Activity = model.Activity;
            employer.Address = model.Address;
            employer.Phone = model.Phone;
            return employer;
        }
    }
}
