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
            chartRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask = new GroupBox();
            groupBoxTask1 = new GroupBox();
            groupBoxVvod = new GroupBox();
            groupBoxStop = new GroupBox();
            textBoxStop = new TextBox();
            groupBoxStart = new GroupBox();
            textBoxStart = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            panelVyvod = new Panel();
            groupBoxVyvod = new GroupBox();
            textBoxVyvod = new TextBox();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)chartRes).BeginInit();
            groupBoxTask.SuspendLayout();
            groupBoxVvod.SuspendLayout();
            groupBoxStop.SuspendLayout();
            groupBoxStart.SuspendLayout();
            panelVyvod.SuspendLayout();
            groupBoxVyvod.SuspendLayout();
            SuspendLayout();
            // 
            // chartRes
            // 
            chartArea1.Name = "ChartArea1";
            chartRes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRes.Legends.Add(legend1);
            chartRes.Location = new Point(487, 120);
            chartRes.Name = "chartRes";
            chartRes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes.Series.Add(series1);
            chartRes.Size = new Size(618, 441);
            chartRes.TabIndex = 0;
            chartRes.Text = "График";
            chartRes.Click += chartRes_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxTask1);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(467, 102);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // groupBoxTask1
            // 
            groupBoxTask1.Location = new Point(7, 30);
            groupBoxTask1.Name = "groupBoxTask1";
            groupBoxTask1.Size = new Size(453, 65);
            groupBoxTask1.TabIndex = 0;
            groupBoxTask1.TabStop = false;
            groupBoxTask1.Text = "Протабулировать функцию (sin(x)/(x+1,2))+cos(x)*7x-2 на заданном диапазоне.";
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(groupBoxStop);
            groupBoxVvod.Controls.Add(groupBoxStart);
            groupBoxVvod.Location = new Point(487, 13);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(328, 101);
            groupBoxVvod.TabIndex = 2;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод данных";
            // 
            // groupBoxStop
            // 
            groupBoxStop.Controls.Add(textBoxStop);
            groupBoxStop.Location = new Point(176, 29);
            groupBoxStop.Name = "groupBoxStop";
            groupBoxStop.Size = new Size(146, 61);
            groupBoxStop.TabIndex = 0;
            groupBoxStop.TabStop = false;
            groupBoxStop.Text = "Конец шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(6, 26);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(132, 27);
            textBoxStop.TabIndex = 0;
            // 
            // groupBoxStart
            // 
            groupBoxStart.Controls.Add(textBoxStart);
            groupBoxStart.Location = new Point(10, 29);
            groupBoxStart.Name = "groupBoxStart";
            groupBoxStart.Size = new Size(146, 61);
            groupBoxStart.TabIndex = 0;
            groupBoxStart.TabStop = false;
            groupBoxStart.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 26);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(132, 27);
            textBoxStart.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(821, 27);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(110, 68);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(1053, 27);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(52, 68);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelVyvod
            // 
            panelVyvod.Controls.Add(groupBoxVyvod);
            panelVyvod.Location = new Point(12, 120);
            panelVyvod.Name = "panelVyvod";
            panelVyvod.Size = new Size(451, 441);
            panelVyvod.TabIndex = 5;
            // 
            // groupBoxVyvod
            // 
            groupBoxVyvod.Controls.Add(textBoxVyvod);
            groupBoxVyvod.Location = new Point(7, 14);
            groupBoxVyvod.Name = "groupBoxVyvod";
            groupBoxVyvod.Size = new Size(427, 413);
            groupBoxVyvod.TabIndex = 0;
            groupBoxVyvod.TabStop = false;
            groupBoxVyvod.Text = "Вывод данных";
            // 
            // textBoxVyvod
            // 
            textBoxVyvod.Location = new Point(15, 38);
            textBoxVyvod.Name = "textBoxVyvod";
            textBoxVyvod.Size = new Size(392, 27);
            textBoxVyvod.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(937, 27);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(110, 68);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormSprint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 575);
            Controls.Add(buttonSave);
            Controls.Add(panelVyvod);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxVvod);
            Controls.Add(groupBoxTask);
            Controls.Add(chartRes);
            MinimumSize = new Size(800, 450);
            Name = "FormSprint";
            Text = "Спринт 6 | Таск 4 | Вариант 1 | Рагозина А.Д    ";
            ((System.ComponentModel.ISupportInitialize)chartRes).EndInit();
            groupBoxTask.ResumeLayout(false);
            groupBoxVvod.ResumeLayout(false);
            groupBoxStop.ResumeLayout(false);
            groupBoxStop.PerformLayout();
            groupBoxStart.ResumeLayout(false);
            groupBoxStart.PerformLayout();
            panelVyvod.ResumeLayout(false);
            groupBoxVyvod.ResumeLayout(false);
            groupBoxVyvod.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxTask1;
        private GroupBox groupBoxVvod;
        private GroupBox groupBoxStop;
        private TextBox textBoxStop;
        private GroupBox groupBoxStart;
        private TextBox textBoxStart;
        private Button buttonDone;
        private Button buttonHelp;
        private Panel panelVyvod;
        private GroupBox groupBoxVyvod;
        private TextBox textBoxVyvod;
        private Button buttonSave;
    }
}
