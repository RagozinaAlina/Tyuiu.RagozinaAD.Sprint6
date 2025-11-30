using Tyuiu.RagozinaAD.Sprint6.Task0.V4.Lib;
namespace Tyuiu.RagozinaAD.Sprint6.Task0.V4
{
    public partial class FormSprint : Form
    {
        public FormSprint()
        {
            InitializeComponent();
        }

        private void FormSprint_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX.Text)));
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBoxFormula_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxForm_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxResult_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxEnter_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxVvod_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxX_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
