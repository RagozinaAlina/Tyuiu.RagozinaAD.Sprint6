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
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int Startstep = Convert.ToInt32(textBoxStart.Text);
                int StopStep = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(Startstep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(Startstep, StopStep);



                this.chartRes.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartRes.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxVyvod.Text = "";
                chartRes.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {

                    this.chartRes.Series[0].Points.AddXY(Startstep, valueArray[i]);
                    this.textBoxVyvod.AppendText(valueArray[i] + Environment.NewLine);
                    Startstep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка АСОиУб-25-1 Рагозина А.Д ");
        }

        private void chartRes_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint6\Tyuiu.RagozinaAD.Sprint6.Task4.V1\bin\Debug\net8.0-windows\OutPutDataFileTask4V1.txt";
                File.WriteAllText(path, textBoxVyvod.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно\n ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

                if (dialogResult == DialogResult.OK)
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
    }
}
