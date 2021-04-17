using LaborExchangeBusinessLogic.BusinessLogics;
using LaborExchangeBusinessLogic.Interfaces;
using LaborExchangeBusinessLogic.ViewModels;
using LaborExchangeDatabaseImplement.Implements;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace LaborExchange
{
    static class Program
    {
        public static UserViewModel User { get; set; }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IEducationStorage, EducationStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IUserStorage, UserStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IApplicantStorage, ApplicantStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IEmployerStorage, EmployerStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IExchangeEmployeeStorage, ExchangeEmployeeStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IVacancyStorage, VacancyStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IDealStorage, DealStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<EducationLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<UserLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ApplicantLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<EmployerLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ExchangeEmployeeLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<VacancyLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<DealLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
