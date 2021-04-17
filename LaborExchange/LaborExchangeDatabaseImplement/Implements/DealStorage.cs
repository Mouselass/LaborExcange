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
    public class DealStorage : IDealStorage
    {
        public List<DealViewModel> GetFullList()
        {
            using (var context = new postgresContext())
            {
                return context.Deal.Include(rec => rec.Applicant).Include(rec => rec.Exchangeemployee).Include(rec => rec.Vacancy).Select(rec => new DealViewModel
                {
                    Id = rec.Id,
                    Applicantid = rec.Applicantid,
                    Applicant = $"{rec.Applicant.Name} {rec.Applicant.Surname} {rec.Applicant.Middlename}",
                    ExchangeEmployeeid = rec.Exchangeemployeeid,
                    ExchangeEmployee = $"{rec.Exchangeemployee.Name} {rec.Exchangeemployee.Surname} {rec.Exchangeemployee.Middlename}",
                    Vacancyid = rec.Vacancyid,
                    Vacancy = rec.Vacancy.Description,
                    Dealdate = rec.Date
                })
                .ToList();
            }
        }

        public List<DealViewModel> GetFilteredList(DealBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                return context.Deal.Include(rec => rec.Applicant).Include(rec => rec.Exchangeemployee).Include(rec => rec.Vacancy)
                    .Where(rec => rec.Exchangeemployeeid == model.ExchangeEmployeeid).Select(rec => new DealViewModel
                    {
                        Id = rec.Id,
                        Applicantid = rec.Applicantid,
                        Applicant = $"{rec.Applicant.Name} {rec.Applicant.Surname} {rec.Applicant.Middlename}",
                        ExchangeEmployeeid = rec.Exchangeemployeeid,
                        ExchangeEmployee = $"{rec.Exchangeemployee.Name} {rec.Exchangeemployee.Surname} {rec.Exchangeemployee.Middlename}",
                        Vacancyid = rec.Vacancyid,
                        Vacancy = rec.Vacancy.Description,
                        Dealdate = rec.Date
                    })
                .ToList();
            }
        }

        public DealViewModel GetElement(DealBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                var deal = context.Deal.Include(rec => rec.Applicant).Include(rec => rec.Exchangeemployee).Include(rec => rec.Vacancy).FirstOrDefault(rec => rec.Id == model.Id);
                return deal != null ?
                new DealViewModel
                {
                    Id = deal.Id,
                    Applicantid = deal.Applicantid,
                    Applicant = $"{deal.Applicant.Name} {deal.Applicant.Surname} {deal.Applicant.Middlename}",
                    ExchangeEmployeeid = deal.Exchangeemployeeid,
                    ExchangeEmployee = $"{deal.Exchangeemployee.Name} {deal.Exchangeemployee.Surname} {deal.Exchangeemployee.Middlename}",
                    Vacancyid = deal.Vacancyid,
                    Vacancy = deal.Vacancy.Description,
                    Dealdate = deal.Date
                } :
                null;
            }
        }

        public void Insert(DealBindingModel model)
        {
            using (var context = new postgresContext())
            {
                context.Deal.Add(CreateModel(model, new Deal()));
                context.SaveChanges();
            }
        }

        public void Update(DealBindingModel model)
        {
            using (var context = new postgresContext())
            {
                var element = context.Deal.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Соискатель не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(DealBindingModel model)
        {
            using (var context = new postgresContext())
            {
                Deal element = context.Deal.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Deal.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Соискатель не найден");
                }
            }
        }

        private Deal CreateModel(DealBindingModel model, Deal deal)
        {
            deal.Applicantid = model.Applicantid.Value;
            deal.Exchangeemployeeid = model.ExchangeEmployeeid.Value;
            deal.Vacancyid = model.Vacancyid.Value;
            deal.Date = model.Dealdate;
            return deal;
        }
    }
}
