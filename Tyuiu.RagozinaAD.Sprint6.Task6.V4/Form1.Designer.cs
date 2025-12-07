namespace Tyuiu.RagozinaAD.Sprint6.Task6.V4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            groupBoxTask = new GroupBox();
            groupBoxTask1 = new GroupBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel2 = new Panel();
            groupBoxVvod = new GroupBox();
            textBoxLoadFromFile = new TextBox();
            panel3 = new Panel();
            groupBoxVyvod = new GroupBox();
            textBoxResult = new TextBox();
            panel1.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxVvod.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxVyvod.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxTask);
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 155);
            panel1.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxTask1);
            groupBoxTask.Location = new Point(11, 66);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(777, 86);
            groupBoxTask.TabIndex = 3;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // groupBoxTask1
            // 
            groupBoxTask1.Location = new Point(1, 25);
            groupBoxTask1.Name = "groupBoxTask1";
            groupBoxTask1.Size = new Size(771, 58);
            groupBoxTask1.TabIndex = 0;
            groupBoxTask1.TabStop = false;
            groupBoxTask1.Text = resources.GetString("groupBoxTask1.Text");
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(734, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(54, 48);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(73, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(56, 48);
            buttonDone.TabIndex = 1;
            toolTip1.SetToolTip(buttonDone, "Производит поиск слова в которых встречается n");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(55, 48);
            buttonOpenFile.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxVvod);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 295);
            panel2.TabIndex = 1;
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(textBoxLoadFromFile);
            groupBoxVvod.Location = new Point(9, 11);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(387, 278);
            groupBoxVvod.TabIndex = 0;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод:";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(22, 36);
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.Size = new Size(359, 27);
            textBoxLoadFromFile.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxVyvod);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(411, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 295);
            panel3.TabIndex = 2;
            // 
            // groupBoxVyvod
            // 
            groupBoxVyvod.Controls.Add(textBoxResult);
            groupBoxVyvod.Location = new Point(14, 11);
            groupBoxVyvod.Name = "groupBoxVyvod";
            groupBoxVyvod.Size = new Size(363, 278);
            groupBoxVyvod.TabIndex = 0;
            groupBoxVyvod.TabStop = false;
            groupBoxVyvod.Text = "Вывод:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(21, 36);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(336, 27);
            textBoxResult.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Спринт 6 | Таск 4 | Вариант 1 | Рагозина А.Д ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxVvod.ResumeLayout(false);
            groupBoxVvod.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxVyvod.ResumeLayout(false);
            groupBoxVyvod.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonOpenFile;
        private Button buttonDone;
        private Button buttonHelp;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxTask1;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialogTask;
        private Panel panel2;
        private GroupBox groupBoxVvod;
        private Panel panel3;
        private GroupBox groupBoxVyvod;
        private TextBox textBoxLoadFromFile;
        private TextBox textBoxResult;
    }
}
