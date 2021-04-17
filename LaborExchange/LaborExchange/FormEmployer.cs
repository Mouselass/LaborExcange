using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.BusinessLogics;
using LaborExchangeBusinessLogic.ViewModels;
using System;
using System.Windows.Forms;
using Unity;
using Microsoft.EntityFrameworkCore;

namespace LaborExchange
{
    public partial class FormEmployer : Form
    {
        public int Id { set { id = value; } }
        private readonly EmployerLogic logic;
        private int? id;

        public FormEmployer(EmployerLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormEmployer_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new EmployerBindingModel { Id = id })?[0];

                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxActivity.Text = view.Activity;
                        textBoxAddress.Text = view.Address;
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
            if (string.IsNullOrEmpty(textBoxActivity.Text))
            {
                MessageBox.Show("Заполните деятельность", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Заполните адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Заполните телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                logic.CreateOrUpdate(new EmployerBindingModel
                {
                    Id = id,
                    Userid = Program.User.Id,
                    Name = textBoxName.Text,
                    Activity = textBoxActivity.Text,
                    Address = textBoxAddress.Text,
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
