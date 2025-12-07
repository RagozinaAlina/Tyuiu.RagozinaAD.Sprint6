using Tyuiu.RagozinaAD.Sprint6.Task6.V4.Lib;
namespace Tyuiu.RagozinaAD.Sprint6.Task6.V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxVvod.Text = groupBoxVvod.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAboutSprint formAbout = new FormAboutSprint();
            formAbout.ShowDialog();
        }
    }
}
