using Tyuiu.RagozinaAD.Sprint6.Task3.V29.Lib;
namespace Tyuiu.RagozinaAD.Sprint6.Task3.V29
{
    public partial class FormSprint : Form
    {
        public FormSprint()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrx = new int[5, 5]  {  { -2, -13, -15, -9, -17 },
                                           { 13, -20, -15, 27, 18 },
                                           { -12, -1, -20, 13, 0 },
                                           { 15, 32, 18, -12, -18 },
                                           { 16, 5, 3, -5, -8 } };
        private void FormSprint_Load(object sender, EventArgs e)
        {
            int rows = matrx.GetUpperBound(0) + 1;
            int columns = matrx.Length / rows;

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 75;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(matrx[i, j]);
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка АСОиУб-25-1 Рагозина А.Д");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 75;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void dataGridViewRes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
