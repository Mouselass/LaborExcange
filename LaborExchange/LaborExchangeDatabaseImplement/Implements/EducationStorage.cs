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
    public class EducationStorage : IEducationStorage
    {
        public List<EducationViewModel> GetFullList()
        {
            using (var context = new postgresContext())
            {
                return context.Education.Select(rec => new EducationViewModel
                {
                    Id = rec.Id,
                    Type = rec.Type
                })
                .ToList();
            }
        }

        public List<EducationViewModel> GetFilteredList(EducationBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                return context.Education.Select(rec => new EducationViewModel
                {
                    Id = rec.Id,
                    Type = rec.Type
                })
                .ToList();
            }
        }

        public EducationViewModel GetElement(EducationBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                var education = context.Education.FirstOrDefault(rec => rec.Type == model.Type || rec.Id == model.Id);
                return education != null ?
                new EducationViewModel
                {
                    Id = education.Id,
                    Type = education.Type
                } :
                null;
            }
        }

        public void Insert(EducationBindingModel model)
        {
            using (var context = new postgresContext())
            {
                context.Education.Add(CreateModel(model, new Education()));
                context.SaveChanges();
            }
        }

        public void Update(EducationBindingModel model)
        {
            using (var context = new postgresContext())
            {
                var element = context.Education.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Образование не найдено");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(EducationBindingModel model)
        {
            using (var context = new postgresContext())
            {
                Education element = context.Education.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Education.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Образование не найдено");
                }
            }
        }

        private Education CreateModel(EducationBindingModel model, Education education)
        {
            education.Type = model.Type;
            return education;
        }
    }
}
