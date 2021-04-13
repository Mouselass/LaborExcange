using System.Windows.Forms;
using Unity;

namespace LaborExchange
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void соискателиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (Program.User != null)
            {
                var form = Container.Resolve<FormApplicants>();
                form.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Необходимо авторизоваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void работодателиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = Container.Resolve<FormEmployers>();
            form.ShowDialog();
        }

        private void работникиБиржиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = Container.Resolve<FormExchangeEmployees>();
            form.ShowDialog();
        }

        private void образованиеToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = Container.Resolve<FormEducations>();
            form.ShowDialog();
        }

        private void вакансииToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = Container.Resolve<FormVacancys>();
            form.ShowDialog();
        }

        private void сделкиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = Container.Resolve<FormDeals>();
            form.ShowDialog();
        }

        private void входToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = Container.Resolve<FormAuthorize>();
            form.ShowDialog();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = Container.Resolve<FormRegister>();
            form.ShowDialog();
        }
    }
}
