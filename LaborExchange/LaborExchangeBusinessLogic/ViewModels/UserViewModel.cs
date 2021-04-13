using System.ComponentModel;
using LaborExchangeBusinessLogic.Enums;

namespace LaborExchangeBusinessLogic.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [DisplayName("Роль пользователя")]
        public UserRole Role { get; set; }

        [DisplayName("Логин пользователя")]
        public string Login { get; set; }

        [DisplayName("Пароль пользователя")]
        public string Password { get; set; }
    }
}
