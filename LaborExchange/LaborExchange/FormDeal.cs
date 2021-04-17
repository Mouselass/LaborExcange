using LaborExchangeBusinessLogic.BindingModels;
using LaborExchangeBusinessLogic.BusinessLogics;
using System;
using System.Windows.Forms;

namespace LaborExchange
{
    public partial class FormDeal : Form
    {
        public int Id { set { id = value; } }
        private readonly DealLogic logic;
        private readonly ApplicantLogic logicA;
        private readonly ExchangeEmployeeLogic logicE;
        private readonly VacancyLogic logicV;
        private int? id;

        public FormDeal(DealLogic logic, ApplicantLogic logicEd, VacancyLogic logicV, ExchangeEmployeeLogic logicE)
        {
            InitializeComponent();
            this.logic = logic;
            this.logicA = logicEd;
            this.logicV = logicV;
            this.logicE = logicE;
        }

        private void FormDeal_Load(object sender, EventArgs e)
        {
            try
            {
                var listApplicant = logicA.Read(null);

                foreach (var item in listApplicant)
                {
                    comboBoxApplicant.DisplayMember = "Surname";
                    comboBoxApplicant.ValueMember = "Id";
                    comboBoxApplicant.DataSource = listApplicant;
                    comboBoxApplicant.SelectedItem = null;
                }

                var listVacancy = logicV.Read(null);

                foreach (var item in listVacancy)
                {
                    comboBoxVacancy.DisplayMember = "Description";
                    comboBoxVacancy.ValueMember = "Id";
                    comboBoxVacancy.DataSource = listVacancy;
                    comboBoxVacancy.SelectedItem = null;
                }

                var listExchangeEmployee = logicE.Read(null);

                foreach (var item in listExchangeEmployee)
                {
                    comboBoxExchangeEmployee.DisplayMember = "Surname";
                    comboBoxExchangeEmployee.ValueMember = "Id";
                    comboBoxExchangeEmployee.DataSource = listExchangeEmployee;
                    comboBoxExchangeEmployee.SelectedItem = null;
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
                    var view = logic.Read(new DealBindingModel { Id = id })?[0];

                    if (view != null)
                    {
                        comboBoxApplicant.SelectedValue = view.Applicantid;
                        comboBoxVacancy.SelectedValue = view.Vacancyid;
                        comboBoxExchangeEmployee.SelectedValue = view.ExchangeEmployeeid;
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
            if (comboBoxApplicant.SelectedValue == null)
            {
                MessageBox.Show("Выберите соискателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxVacancy.SelectedValue == null)
            {
                MessageBox.Show("Выберите работодателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxExchangeEmployee.SelectedValue == null)
            {
                MessageBox.Show("Выберите работника биржи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                logic.CreateOrUpdate(new DealBindingModel
                {
                    Id = id,
                    Vacancyid = (int)comboBoxVacancy.SelectedValue,
                    ExchangeEmployeeid = (int)comboBoxExchangeEmployee.SelectedValue,
                    Applicantid = (int)comboBoxApplicant.SelectedValue,
                    Dealdate = DateTime.Now
                });


                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
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
