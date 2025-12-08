namespace Tyuiu.RagozinaAD.Sprint6.Task7.V2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpenFile = new Button();
            panel1 = new Panel();
            groupBoxTask = new GroupBox();
            groupBoxTask1 = new GroupBox();
            buttonSaveFile = new Button();
            buttonHelp = new Button();
            buttonDone = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panel2 = new Panel();
            groupBoxVvod = new GroupBox();
            dataGridViewInMatrix = new DataGridView();
            panel3 = new Panel();
            groupBoxVyvod = new GroupBox();
            dataGridViewOutMatrix = new DataGridView();
            panel1.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxVvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).BeginInit();
            panel3.SuspendLayout();
            groupBoxVyvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(66, 59);
            buttonOpenFile.TabIndex = 0;
            toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxTask);
            panel1.Controls.Add(buttonSaveFile);
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 196);
            panel1.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxTask1);
            groupBoxTask.Location = new Point(12, 77);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(779, 121);
            groupBoxTask.TabIndex = 4;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // groupBoxTask1
            // 
            groupBoxTask1.Location = new Point(0, 27);
            groupBoxTask1.Name = "groupBoxTask1";
            groupBoxTask1.Size = new Size(781, 91);
            groupBoxTask1.TabIndex = 0;
            groupBoxTask1.TabStop = false;
            groupBoxTask1.Text = resources.GetString("groupBoxTask1.Text");
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(152, 12);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(62, 59);
            buttonSaveFile.TabIndex = 3;
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(723, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(65, 59);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            toolTip.SetToolTip(buttonHelp, "Справка \r\nСведение о программисте");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(84, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(62, 59);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Выполнить обработку файла");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxVvod);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 276);
            panel2.TabIndex = 2;
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(dataGridViewInMatrix);
            groupBoxVvod.Location = new Point(12, 8);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(371, 263);
            groupBoxVvod.TabIndex = 0;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод";
            // 
            // dataGridViewInMatrix
            // 
            dataGridViewInMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix.ColumnHeadersVisible = false;
            dataGridViewInMatrix.Location = new Point(8, 24);
            dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            dataGridViewInMatrix.RowHeadersVisible = false;
            dataGridViewInMatrix.RowHeadersWidth = 51;
            dataGridViewInMatrix.Size = new Size(357, 232);
            dataGridViewInMatrix.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxVyvod);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(390, 196);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 276);
            panel3.TabIndex = 3;
            // 
            // groupBoxVyvod
            // 
            groupBoxVyvod.Controls.Add(dataGridViewOutMatrix);
            groupBoxVyvod.Location = new Point(5, 9);
            groupBoxVyvod.Name = "groupBoxVyvod";
            groupBoxVyvod.Size = new Size(395, 262);
            groupBoxVyvod.TabIndex = 0;
            groupBoxVyvod.TabStop = false;
            groupBoxVyvod.Text = "Вывод";
            // 
            // dataGridViewOutMatrix
            // 
            dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix.ColumnHeadersVisible = false;
            dataGridViewOutMatrix.Location = new Point(6, 23);
            dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            dataGridViewOutMatrix.RowHeadersVisible = false;
            dataGridViewOutMatrix.RowHeadersWidth = 51;
            dataGridViewOutMatrix.Size = new Size(383, 229);
            dataGridViewOutMatrix.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 2 | Рагозина А.Д  ";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxVvod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix).EndInit();
            panel3.ResumeLayout(false);
            groupBoxVyvod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile;
        private Panel panel1;
        private Button buttonDone;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private Button buttonSaveFile;
        private Button buttonHelp;
        private SaveFileDialog saveFileDialogMatrix;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxTask1;
        private Panel panel2;
        private GroupBox groupBoxVvod;
        private DataGridView dataGridViewInMatrix;
        private Panel panel3;
        private GroupBox groupBoxVyvod;
        private DataGridView dataGridViewOutMatrix;
    }
}
