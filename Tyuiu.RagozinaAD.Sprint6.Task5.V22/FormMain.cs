using Tyuiu.RagozinaAD.Sprint6.Task5.V22.Lib;
namespace Tyuiu.RagozinaAD.Sprint6.Task5.V22
{
    public partial class FormSprint : Form
    {
        public FormSprint()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint6\Sprint6Task5\InPutDataFileTask5V22.txt";
        private void FormSprint_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewRes.ColumnCount = 2;
            dataGridViewRes.Columns[0].Width = 20;
            dataGridViewRes.Columns[1].Width = 50;

            this.chartDiag.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i=0; i<numsMass .Length;i++)
            {
                dataGridViewRes.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка АСОиУб-25-1 Рагозина А.Д ");
        }
    }
}
