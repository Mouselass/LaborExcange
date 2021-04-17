using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.BusinessLogics;
using LaborExchangeBusinessLogic.ViewModels;
using System;
using System.Windows.Forms;
using Unity;
using Microsoft.EntityFrameworkCore;
namespace LaborExchange
{
    public partial class FormExchangeEmployee : Form
    {
        public int Id { set { id = value; } }
        private readonly ExchangeEmployeeLogic logic;
        private int? id;

        public FormExchangeEmployee(ExchangeEmployeeLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormExchangeEmployee_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new ExchangeEmployeeBindingModel { Id = id })?[0];

                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxSurname.Text = view.Surname;
                        textBoxMiddlename.Text = view.Middlename;
                        textBoxPhone.Text = view.Phone.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxSurname.Text))
            {
                MessageBox.Show("Заполните фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxMiddlename.Text))
            {
                MessageBox.Show("Заполните отчество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Заполните телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                logic.CreateOrUpdate(new ExchangeEmployeeBindingModel
                {
                    Id = id,
                    Userid = Program.User.Id,
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Middlename = textBoxMiddlename.Text,
                    Phone = Convert.ToInt64(textBoxPhone.Text)
                });


                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DbUpdateException exe)
            {
                MessageBox.Show(exe?.InnerException?.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
