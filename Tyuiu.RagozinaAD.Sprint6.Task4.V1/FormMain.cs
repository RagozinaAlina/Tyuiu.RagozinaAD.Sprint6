using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.RagozinaAD.Sprint6.Task4.V1.Lib;
namespace Tyuiu.RagozinaAD.Sprint6.Task4.V1
{
    public partial class FormSprint : Form
    {
        public FormSprint()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void FormSprint_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);



                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxVyvod.Text = "";
                chartFunction.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {

                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    this.textBoxVyvod.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint6\Tyuiu.RagozinaAD.Sprint6.Task4.V1\bin\Debug\net8.0-windows\OutPutDataFileTask4V1.txt";
                File.WriteAllText(path, textBoxVyvod.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно\n Открыть его в блокноте? ", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка АСОиУб-25-1 Рагозина А.Д ");
        }
    }
}
