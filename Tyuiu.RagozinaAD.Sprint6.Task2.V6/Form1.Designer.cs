namespace Tyuiu.RagozinaAD.Sprint6.Task2.V6
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
            buttonDone = new Button();
            groupBoxVvod = new GroupBox();
            groupBoxStop = new GroupBox();
            textBoxStop = new TextBox();
            groupBoxStart = new GroupBox();
            textBoxStart = new TextBox();
            buttonHelp = new Button();
            groupBoxTask = new GroupBox();
            groupBoxTask1 = new GroupBox();
            groupBoxVyvod = new GroupBox();
            dataGridView1 = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnF = new DataGridViewTextBoxColumn();
            groupBoxVvod.SuspendLayout();
            groupBoxStop.SuspendLayout();
            groupBoxStart.SuspendLayout();
            groupBoxTask.SuspendLayout();
            groupBoxVyvod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(502, 385);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(135, 53);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(groupBoxStop);
            groupBoxVvod.Controls.Add(groupBoxStart);
            groupBoxVvod.Location = new Point(12, 332);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(333, 106);
            groupBoxVvod.TabIndex = 1;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод данных";
            // 
            // groupBoxStop
            // 
            groupBoxStop.Controls.Add(textBoxStop);
            groupBoxStop.Location = new Point(170, 26);
            groupBoxStop.Name = "groupBoxStop";
            groupBoxStop.Size = new Size(141, 64);
            groupBoxStop.TabIndex = 1;
            groupBoxStop.TabStop = false;
            groupBoxStop.Text = "Конец шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(14, 27);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(121, 27);
            textBoxStop.TabIndex = 0;
            // 
            // groupBoxStart
            // 
            groupBoxStart.Controls.Add(textBoxStart);
            groupBoxStart.Location = new Point(6, 26);
            groupBoxStart.Name = "groupBoxStart";
            groupBoxStart.Size = new Size(148, 64);
            groupBoxStart.TabIndex = 0;
            groupBoxStart.TabStop = false;
            groupBoxStart.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(15, 26);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(117, 27);
            textBoxStart.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(415, 385);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(81, 53);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxTask1);
            groupBoxTask.Location = new Point(12, 6);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(625, 320);
            groupBoxTask.TabIndex = 3;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // groupBoxTask1
            // 
            groupBoxTask1.Location = new Point(12, 26);
            groupBoxTask1.Name = "groupBoxTask1";
            groupBoxTask1.Size = new Size(605, 281);
            groupBoxTask1.TabIndex = 0;
            groupBoxTask1.TabStop = false;
            groupBoxTask1.Text = "Протабулировать функцию (cos(x)/(x-0.7))-sin(x)*12x+2 на заданном диапазоне";
            // 
            // groupBoxVyvod
            // 
            groupBoxVyvod.Controls.Add(dataGridView1);
            groupBoxVyvod.Location = new Point(655, 6);
            groupBoxVyvod.Name = "groupBoxVyvod";
            groupBoxVyvod.Size = new Size(508, 432);
            groupBoxVyvod.TabIndex = 4;
            groupBoxVyvod.TabStop = false;
            groupBoxVyvod.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnF });
            dataGridView1.Location = new Point(24, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(167, 385);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.Width = 75;
            // 
            // ColumnF
            // 
            ColumnF.HeaderText = "F(X)";
            ColumnF.MinimumWidth = 6;
            ColumnF.Name = "ColumnF";
            ColumnF.Width = 75;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 450);
            Controls.Add(groupBoxVyvod);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxVvod);
            Controls.Add(buttonDone);
            Name = "Form1";
            Text = "Form1";
            groupBoxVvod.ResumeLayout(false);
            groupBoxStop.ResumeLayout(false);
            groupBoxStop.PerformLayout();
            groupBoxStart.ResumeLayout(false);
            groupBoxStart.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxVyvod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private GroupBox groupBoxVvod;
        private GroupBox groupBoxStop;
        private TextBox textBoxStop;
        private GroupBox groupBoxStart;
        private TextBox textBoxStart;
        private Button buttonHelp;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxTask1;
        private GroupBox groupBoxVyvod;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnF;
    }
}
