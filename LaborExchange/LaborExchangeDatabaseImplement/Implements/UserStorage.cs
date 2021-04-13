using System;
using System.Collections.Generic;
using System.Linq;
using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.Interfaces;
using LaborExchangeBusinessLogic.ViewModels;
using LaborExchangeBusinessLogic.Enums;
using LaborExchangeDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace LaborExchangeDatabaseImplement.Implements
{
    public class UserStorage : IUserStorage
    {
        public List<UserViewModel> GetFullList()
        {
            using (var context = new postgresContext())
            {
                return context.Users.Select(rec => new UserViewModel
                {
                    Id = rec.Id,
                    Role = (UserRole)rec.Role,
                    Login = rec.Login,
                    Password = rec.Password
                })
                .ToList();
            }
        }

        public List<UserViewModel> GetFilteredList(UserBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                return context.Users
                .Select(rec => new UserViewModel
                {
                    Id = rec.Id,
                    Role = (UserRole)rec.Role,
                    Login = rec.Login,
                    Password = rec.Password
                })
                .ToList();
            }
        }

        public UserViewModel GetElement(UserBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new postgresContext())
            {
                var user = context.Users
                .FirstOrDefault(rec => rec.Login == model.Login || rec.Id == model.Id);
                return user != null ?
                new UserViewModel
                {
                    Id = user.Id,
                    Role = (UserRole)user.Role,
                    Login = user.Login,
                    Password = user.Password
                } :
                null;
            }
        }

        public void Insert(UserBindingModel model)
        {
            using (var context = new postgresContext())
            {
                context.Users.Add(CreateModel(model, new Users()));
                context.SaveChanges();
            }
        }

        public void Update(UserBindingModel model)
        {
            using (var context = new postgresContext())
            {
                var element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Мебель не найдена");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(UserBindingModel model)
        {
            using (var context = new postgresContext())
            {
                Users element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Users.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Мебель не найдена");
                }
            }
        }

        private Users CreateModel(UserBindingModel model, Users user)
        {
            user.Role = Convert.ToInt32(model.Role);
            user.Login = model.Login;
            user.Password = model.Password;
            return user;
        }
    }
}
