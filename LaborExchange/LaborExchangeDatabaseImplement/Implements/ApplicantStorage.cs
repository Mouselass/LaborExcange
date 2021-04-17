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
    public class ApplicantStorage : IApplicantStorage
    {
        public List<ApplicantViewModel> GetFullList()
        {
            using (var context = new postgresContext())
            {
                return context.Applicant.Include(rec => rec.Education).Select(rec => new ApplicantViewModel
                {
                    Id = rec.Id,
                    Userid = rec.Userid,
                    Educationid = rec.Educationid,
                    Surname = rec.Surname,
                    Name = rec.Name,
                    Middlename = rec.Middlename,
                    Education = rec.Education.Type,
                    Birthdaydate = rec.Birthdaydate,
                    Workexperience = rec.Workexperience,
                    Phone = rec.Phone
                })
                .ToList();
            }
        }

        public List<ApplicantViewModel> GetFilteredList(ApplicantBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                return context.Applicant.Include(rec => rec.Education).Where(rec => rec.Userid == model.Userid).Select(rec => new ApplicantViewModel
                {
                    Id = rec.Id,
                    Userid = rec.Userid,
                    Educationid = rec.Educationid,
                    Surname = rec.Surname,
                    Name = rec.Name,
                    Middlename = rec.Middlename,
                    Education = rec.Education.Type,
                    Birthdaydate = rec.Birthdaydate,
                    Workexperience = rec.Workexperience,
                    Phone = rec.Phone
                })
                .ToList();
            }
        }

        public ApplicantViewModel GetElement(ApplicantBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                var applicant = context.Applicant.Include(rec => rec.Education).FirstOrDefault(rec => rec.Id == model.Id);
                return applicant != null ?
                new ApplicantViewModel
                {
                    Id = applicant.Id,
                    Userid = applicant.Userid,
                    Educationid = applicant.Educationid,
                    Surname = applicant.Surname,
                    Name = applicant.Name,
                    Middlename = applicant.Middlename,
                    Education = applicant.Education.Type,
                    Birthdaydate = applicant.Birthdaydate,
                    Workexperience = applicant.Workexperience,
                    Phone = applicant.Phone
                } :
                null;
            }
        }

        public void Insert(ApplicantBindingModel model)
        {
            using (var context = new postgresContext())
            {
                context.Applicant.Add(CreateModel(model, new Applicant()));
                context.SaveChanges();
            }
        }

        public void Update(ApplicantBindingModel model)
        {
            using (var context = new postgresContext())
            {
                var element = context.Applicant.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Соискатель не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ApplicantBindingModel model)
        {
            using (var context = new postgresContext())
            {
                Applicant element = context.Applicant.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Applicant.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Соискатель не найден");
                }
            }
        }

        private Applicant CreateModel(ApplicantBindingModel model, Applicant applicant)
        {
            applicant.Userid = model.Userid.Value;
            applicant.Educationid = model.Educationid.Value;
            applicant.Surname = model.Surname;
            applicant.Name = model.Name;
            applicant.Middlename = model.Middlename;
            applicant.Birthdaydate = model.Birthdaydate;
            applicant.Workexperience = model.Workexperience;
            applicant.Phone = model.Phone;
            return applicant;
        }
    }
}
