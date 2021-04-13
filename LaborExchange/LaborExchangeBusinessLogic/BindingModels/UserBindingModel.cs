using System.Collections.Generic;
using LaborExchangeBusinessLogic.Enums;

namespace LaborExchangeBusinessLogic.BindingModels
{
    public class UserBindingModel
    {
        public int? Id { get; set; }

        public UserRole Role { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
