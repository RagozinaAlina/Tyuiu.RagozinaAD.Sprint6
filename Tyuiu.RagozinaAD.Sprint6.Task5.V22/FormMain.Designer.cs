namespace Tyuiu.RagozinaAD.Sprint6.Task5.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonDone = new Button();
            buttonOpen = new Button();
            buttonHelp = new Button();
            groupBoxTask = new GroupBox();
            groupBoxTask1 = new GroupBox();
            groupBoxVyvod = new GroupBox();
            dataGridViewRes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask.SuspendLayout();
            groupBoxVyvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(597, 35);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(106, 66);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(709, 35);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(105, 66);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(820, 35);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(90, 66);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxTask1);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(571, 99);
            groupBoxTask.TabIndex = 3;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // groupBoxTask1
            // 
            groupBoxTask1.Location = new Point(6, 23);
            groupBoxTask1.Name = "groupBoxTask1";
            groupBoxTask1.Size = new Size(549, 70);
            groupBoxTask1.TabIndex = 0;
            groupBoxTask1.TabStop = false;
            groupBoxTask1.Text = "Прочитать данные из файла InPutFileTask5V22.txt. Вывести в dataGridView.Дан список из 20 чисел. Вывести все числа, больше 5.  Построить диаграмму по этим значениям.";
            // 
            // groupBoxVyvod
            // 
            groupBoxVyvod.Controls.Add(dataGridViewRes);
            groupBoxVyvod.Location = new Point(16, 117);
            groupBoxVyvod.Name = "groupBoxVyvod";
            groupBoxVyvod.Size = new Size(253, 354);
            groupBoxVyvod.TabIndex = 4;
            groupBoxVyvod.TabStop = false;
            groupBoxVyvod.Text = "Вывод данных";
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.ColumnHeadersVisible = false;
            dataGridViewRes.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewRes.Location = new Point(13, 29);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.RowHeadersWidth = 51;
            dataGridViewRes.Size = new Size(227, 318);
            dataGridViewRes.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 225;
            // 
            // chartDiag
            // 
            chartArea2.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartDiag.Legends.Add(legend2);
            chartDiag.Location = new Point(281, 126);
            chartDiag.Name = "chartDiag";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartDiag.Series.Add(series2);
            chartDiag.Size = new Size(623, 341);
            chartDiag.TabIndex = 5;
            // 
            // FormSprint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 480);
            Controls.Add(chartDiag);
            Controls.Add(groupBoxVyvod);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOpen);
            Controls.Add(buttonDone);
            Name = "FormSprint";
            Text = "Спринт 6 | Таск 5 | Вариант 22 | Рагозина А.Д      ";
            Load += FormSprint_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxVyvod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonOpen;
        private Button buttonHelp;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxTask1;
        private GroupBox groupBoxVyvod;
        private DataGridView dataGridViewRes;
        private DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
    }
}
