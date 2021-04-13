using System;
using System.Windows.Forms;
using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.BusinessLogics;
using LaborExchangeBusinessLogic.Enums;
using Unity;

namespace LaborExchange
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private readonly UserLogic logic;

        public FormRegister(UserLogic logic)
        {
            InitializeComponent();
            comboBoxRole.Items.AddRange(new string[] { "Работник_биржи", "Работодатель", "Соискатель" });
            this.logic = logic;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните Email", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните пароль", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Выберите роль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UserBindingModel model = new UserBindingModel
                {
                    Role = ((UserRole)Enum.Parse(typeof(UserRole), comboBoxRole.SelectedItem.ToString())),
                    Login = textBoxLogin.Text,
                    Password = textBoxPassword.Text
                };
                logic.CreateOrUpdate(model);
                Program.User = logic.Read(model)?[0];
                DialogResult = DialogResult.OK;
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
