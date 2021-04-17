using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.BusinessLogics;
using LaborExchangeBusinessLogic.ViewModels;
using System;
using System.Windows.Forms;
using Unity;
using Microsoft.EntityFrameworkCore;

namespace LaborExchange
{
    public partial class FormVacancy : Form
    {
        public int Id { set { id = value; } }
        private readonly VacancyLogic logic;
        private readonly EducationLogic logicEd;
        private readonly EmployerLogic logicEm;
        private int? id;

        public FormVacancy(VacancyLogic logic, EducationLogic logicEd, EmployerLogic logicEm)
        {
            InitializeComponent();
            this.logic = logic;
            this.logicEd = logicEd;
            this.logicEm = logicEm;
        }

        private void FormVacancy_Load(object sender, EventArgs e)
        {
            try
            {
                var listEducation = logicEd.Read(null);

                foreach (var item in listEducation)
                {
                    comboBoxEducation.DisplayMember = "Type";
                    comboBoxEducation.ValueMember = "Id";
                    comboBoxEducation.DataSource = listEducation;
                    comboBoxEducation.SelectedItem = null;
                }

                var listEmployer = logicEm.Read(null);

                foreach (var item in listEmployer)
                {
                    comboBoxEmployer.DisplayMember = "Name";
                    comboBoxEmployer.ValueMember = "Id";
                    comboBoxEmployer.DataSource = listEmployer;
                    comboBoxEmployer.SelectedItem = null;
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
                    var view = logic.Read(new VacancyBindingModel { Id = id })?[0];

                    if (view != null)
                    {
                        textBoxPost.Text = view.Post;
                        textBoxDescription.Text = view.Description;
                        textBoxWorkExperience.Text = view.Workexperience;
                        comboBoxEducation.SelectedValue = view.Educationid;
                        comboBoxEmployer.SelectedValue = view.Employerid;
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
            if (string.IsNullOrEmpty(textBoxPost.Text))
            {
                MessageBox.Show("Заполните имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxDescription.Text))
            {
                MessageBox.Show("Заполните фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxEducation.SelectedValue == null)
            {
                MessageBox.Show("Выберите образование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxEmployer.SelectedValue == null)
            {
                MessageBox.Show("Выберите образование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxWorkExperience.Text))
            {
                MessageBox.Show("Заполните опыт работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                logic.CreateOrUpdate(new VacancyBindingModel
                {
                    Id = id,
                    Post = textBoxPost.Text,
                    Description = textBoxDescription.Text,
                    Employerid = (int)comboBoxEmployer.SelectedValue,
                    Educationid = (int)comboBoxEducation.SelectedValue,
                    Workexperience = textBoxWorkExperience.Text
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
