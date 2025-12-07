namespace Tyuiu.RagozinaAD.Sprint6.Task4.V1
{
    partial class FormSprint
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonHelp = new Button();
            groupBoxTask = new GroupBox();
            groupBoxTask1 = new GroupBox();
            groupBoxVvod = new GroupBox();
            groupBoxStart = new GroupBox();
            textBoxStart = new TextBox();
            groupBoxStop = new GroupBox();
            textBoxStop = new TextBox();
            groupBoxVyvod = new GroupBox();
            textBoxVyvod = new TextBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask.SuspendLayout();
            groupBoxVvod.SuspendLayout();
            groupBoxStart.SuspendLayout();
            groupBoxStop.SuspendLayout();
            groupBoxVyvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(809, 35);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 63);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(923, 35);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(109, 63);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(1038, 35);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(83, 63);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxTask1);
            groupBoxTask.Location = new Point(16, 16);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(349, 103);
            groupBoxTask.TabIndex = 3;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // groupBoxTask1
            // 
            groupBoxTask1.Location = new Point(6, 26);
            groupBoxTask1.Name = "groupBoxTask1";
            groupBoxTask1.Size = new Size(337, 69);
            groupBoxTask1.TabIndex = 0;
            groupBoxTask1.TabStop = false;
            groupBoxTask1.Text = "Протабулировать функцию (sin(x)/(x+1,2))+cos(x)*7x-2 на заданном диапазоне.";
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(groupBoxStop);
            groupBoxVvod.Controls.Add(groupBoxStart);
            groupBoxVvod.Location = new Point(371, 16);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(432, 103);
            groupBoxVvod.TabIndex = 4;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод данных";
            // 
            // groupBoxStart
            // 
            groupBoxStart.Controls.Add(textBoxStart);
            groupBoxStart.Location = new Point(6, 26);
            groupBoxStart.Name = "groupBoxStart";
            groupBoxStart.Size = new Size(188, 69);
            groupBoxStart.TabIndex = 0;
            groupBoxStart.TabStop = false;
            groupBoxStart.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(10, 29);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(169, 27);
            textBoxStart.TabIndex = 0;
            // 
            // groupBoxStop
            // 
            groupBoxStop.Controls.Add(textBoxStop);
            groupBoxStop.Location = new Point(211, 26);
            groupBoxStop.Name = "groupBoxStop";
            groupBoxStop.Size = new Size(196, 69);
            groupBoxStop.TabIndex = 1;
            groupBoxStop.TabStop = false;
            groupBoxStop.Text = "Конец шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(6, 29);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(161, 27);
            textBoxStop.TabIndex = 0;
            // 
            // groupBoxVyvod
            // 
            groupBoxVyvod.Controls.Add(textBoxVyvod);
            groupBoxVyvod.Location = new Point(19, 129);
            groupBoxVyvod.Name = "groupBoxVyvod";
            groupBoxVyvod.Size = new Size(346, 358);
            groupBoxVyvod.TabIndex = 5;
            groupBoxVyvod.TabStop = false;
            groupBoxVyvod.Text = "Вывод данных";
            // 
            // textBoxVyvod
            // 
            textBoxVyvod.Location = new Point(6, 36);
            textBoxVyvod.Name = "textBoxVyvod";
            textBoxVyvod.Size = new Size(329, 27);
            textBoxVyvod.TabIndex = 0;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(377, 141);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(733, 346);
            chartFunction.TabIndex = 6;
            chartFunction.Text = "chart1";
            // 
            // FormSprint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 499);
            Controls.Add(chartFunction);
            Controls.Add(groupBoxVyvod);
            Controls.Add(groupBoxVvod);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonHelp);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Name = "FormSprint";
            Text = "Спринт 6 | Таск 4 | Вариант 1 | Рагозина А.Д ";
            Load += FormSprint_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxVvod.ResumeLayout(false);
            groupBoxStart.ResumeLayout(false);
            groupBoxStart.PerformLayout();
            groupBoxStop.ResumeLayout(false);
            groupBoxStop.PerformLayout();
            groupBoxVyvod.ResumeLayout(false);
            groupBoxVyvod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonSave;
        private Button buttonHelp;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxTask1;
        private GroupBox groupBoxVvod;
        private GroupBox groupBoxStart;
        private GroupBox groupBoxStop;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private GroupBox groupBoxVyvod;
        private TextBox textBoxVyvod;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
