using System;
using System.Windows.Forms;
using LaborExchangeBusinessLogic.BusinessLogics;
using LaborExchangeBusinessLogic.Enums;
using Unity;

namespace LaborExchange
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly VacancyLogic logic;

        public FormMain(VacancyLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormVacancy_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = logic.Read(null);

                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[6].Visible = false;
                    dataGridView.Columns[7].Visible = false;
                    dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void соискателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.User != null)
            {
                if (Program.User.Role != (UserRole)2)
                {
                    var form = Container.Resolve<FormApplicants>();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Работодатель не может добавлять соскателей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void работодателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.User != null)
            {
                if (Program.User.Role != (UserRole)3)
                {
                    var form = Container.Resolve<FormEmployers>();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cоскатель не может добавлять работодателей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void работникиБиржиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.User != null)
            {
                if (Program.User.Role == (UserRole)1)
                {
                    var form = Container.Resolve<FormExchangeEmployees>();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Взаимодействовать может только работник биржи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void образованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.User != null)
            {
                if (Program.User.Role == (UserRole)1)
                {
                    var form = Container.Resolve<FormEducations>();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Взаимодействовать с образованием может только работник биржи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void вакансииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.User != null)
            {
                if (Program.User.Role != (UserRole)3)
                {
                    var form = Container.Resolve<FormVacancys>();
                    form.ShowDialog();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Соискатель не может взаимодействовать с вакансиями", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void сделкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.User != null)
            {
                if (Program.User.Role == (UserRole)1)
                {
                    var form = Container.Resolve<FormDeals>();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Заключать сделки может только работник биржи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAuthorize>();
            form.ShowDialog();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRegister>();
            form.ShowDialog();
        }
    }
}
