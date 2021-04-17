using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.BusinessLogics;
using LaborExchangeBusinessLogic.ViewModels;
using System;
using System.Windows.Forms;
using Unity;
using Microsoft.EntityFrameworkCore;

namespace LaborExchange
{
    public partial class FormApplicant : Form
    {
        public int Id { set { id = value; } }
        private readonly ApplicantLogic logic;
        private readonly EducationLogic logicE;
        private int? id;

        public FormApplicant(ApplicantLogic logic, EducationLogic logicE)
        {
            InitializeComponent();
            this.logic = logic;
            this.logicE = logicE;
        }

        private void FormApplicant_Load(object sender, EventArgs e)
        {
            try
            {
                var listEducation = logicE.Read(null);

                foreach (var item in listEducation)
                {
                    comboBoxEducation.DisplayMember = "Type";
                    comboBoxEducation.ValueMember = "Id";
                    comboBoxEducation.DataSource = listEducation;
                    comboBoxEducation.SelectedItem = null;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new ApplicantBindingModel { Id = id })?[0];

                    if (view != null)
                    {
                        textBoxName.Text = view.Name;
                        textBoxSurname.Text = view.Surname;
                        textBoxMiddlename.Text = view.Middlename;
                        textBoxWorkExperience.Text = view.Workexperience;
                        textBoxPhone.Text = view.Phone.ToString();
                        comboBoxEducation.SelectedValue = view.Educationid;
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
            if (comboBoxEducation.SelectedValue == null)
            {
                MessageBox.Show("Выберите образование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePickerBirthdayDate.Value == null)
            {
                MessageBox.Show("Заполните дату рождения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxWorkExperience.Text))
            {
                MessageBox.Show("Заполните опыт работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Заполните телефон", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                logic.CreateOrUpdate(new ApplicantBindingModel
                {
                    Id = id,
                    Userid = Program.User.Id,
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Middlename = textBoxMiddlename.Text,
                    Educationid = (int)comboBoxEducation.SelectedValue,
                    Birthdaydate = dateTimePickerBirthdayDate.Value,
                    Workexperience = textBoxWorkExperience.Text,
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
