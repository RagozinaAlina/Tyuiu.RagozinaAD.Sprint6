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

                textBoxResult.Text = "";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    Startstep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSprint_Load(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка АСОиУб-25-1 Рагозина А.Д ");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\Алина\Desktop\source\repos\Tyuiu.RagozinaAD.Sprint6\DataSprint6\OutPutDataFileTask4V1.txt";
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно\n Открать его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
