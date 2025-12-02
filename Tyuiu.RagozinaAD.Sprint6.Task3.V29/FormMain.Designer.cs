namespace Tyuiu.RagozinaAD.Sprint6.Task3.V29
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
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxTask = new GroupBox();
            groupBoxTask1 = new GroupBox();
            dataGridViewResult = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBoxVyvod = new GroupBox();
            groupBoxResult = new GroupBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            groupBoxVyvod.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(911, 392);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(49, 46);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(976, 392);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(136, 46);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxTask1);
            groupBoxTask.Location = new Point(15, 15);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(416, 426);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // groupBoxTask1
            // 
            groupBoxTask1.Location = new Point(8, 24);
            groupBoxTask1.Name = "groupBoxTask1";
            groupBoxTask1.Size = new Size(403, 398);
            groupBoxTask1.TabIndex = 0;
            groupBoxTask1.TabStop = false;
            groupBoxTask1.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в пятом столбце.";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewResult.Location = new Point(6, 26);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(378, 284);
            dataGridViewResult.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 75;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 75;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 75;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 75;
            // 
            // groupBoxVyvod
            // 
            groupBoxVyvod.Controls.Add(groupBoxResult);
            groupBoxVyvod.Location = new Point(457, 20);
            groupBoxVyvod.Name = "groupBoxVyvod";
            groupBoxVyvod.Size = new Size(676, 362);
            groupBoxVyvod.TabIndex = 4;
            groupBoxVyvod.TabStop = false;
            groupBoxVyvod.Text = "Вывод данных";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Location = new Point(6, 20);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(664, 336);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // FormSprint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 450);
            Controls.Add(groupBoxVyvod);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Name = "FormSprint";
            Text = "Спринт 6 | Таск 3 | Вариант 29 | Рагозина А.Д     ";
            Load += FormSprint_Load;
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            groupBoxVyvod.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxTask1;
        private DataGridView dataGridViewResult;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBoxVyvod;
        private GroupBox groupBoxResult;
    }
}
