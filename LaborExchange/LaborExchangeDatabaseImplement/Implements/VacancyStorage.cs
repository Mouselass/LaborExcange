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
    public class VacancyStorage : IVacancyStorage
    {
        public List<VacancyViewModel> GetFullList()
        {
            using (var context = new postgresContext())
            {
                return context.Vacancy.Include(rec => rec.Employer).Include(rec => rec.Education).Select(rec => new VacancyViewModel
                {
                    Id = rec.Id,
                    Employerid = rec.Employerid,
                    EmployerName = rec.Employer.Name,
                    Educationid = rec.Educationid,
                    Education = rec.Education.Type,
                    Description = rec.Description,
                    Post = rec.Post,
                    Workexperience = rec.Workexperience
                })
                .ToList();
            }
        }

        public List<VacancyViewModel> GetFilteredList(VacancyBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                return context.Vacancy.Include(rec => rec.Education).Include(rec => rec.Employer)
                    .Where(rec => rec.Employerid == model.Employerid).Select(rec => new VacancyViewModel
                    {
                        Id = rec.Id,
                        Employerid = rec.Employerid,
                        EmployerName = rec.Employer.Name,
                        Educationid = rec.Educationid,
                        Education = rec.Education.Type,
                        Description = rec.Description,
                        Post = rec.Post,
                        Workexperience = rec.Workexperience
                    })
                .ToList();
            }
        }

        public VacancyViewModel GetElement(VacancyBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                var vacancy = context.Vacancy.Include(rec => rec.Employer).Include(rec => rec.Education).FirstOrDefault(rec => rec.Id == model.Id);
                return vacancy != null ?
                new VacancyViewModel
                {
                    Id = vacancy.Id,
                    Employerid = vacancy.Employerid,
                    EmployerName = vacancy.Employer.Name,
                    Educationid = vacancy.Educationid,
                    Education = vacancy.Education.Type,
                    Description = vacancy.Description,
                    Post = vacancy.Post,
                    Workexperience = vacancy.Workexperience
                } :
                null;
            }
        }

        public void Insert(VacancyBindingModel model)
        {
            using (var context = new postgresContext())
            {
                context.Vacancy.Add(CreateModel(model, new Vacancy()));
                context.SaveChanges();
            }
        }

        public void Update(VacancyBindingModel model)
        {
            using (var context = new postgresContext())
            {
                var element = context.Vacancy.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Вакансия не найдена");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(VacancyBindingModel model)
        {
            using (var context = new postgresContext())
            {
                Vacancy element = context.Vacancy.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Vacancy.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Вакансия не найдена");
                }
            }
        }

        private Vacancy CreateModel(VacancyBindingModel model, Vacancy vacancy)
        {
            vacancy.Employerid = model.Employerid.Value;
            vacancy.Educationid = model.Educationid.Value;
            vacancy.Description = model.Description;
            vacancy.Post = model.Post;
            vacancy.Workexperience = model.Workexperience;
            return vacancy;
        }
    }
}
