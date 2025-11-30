namespace Tyuiu.RagozinaAD.Sprint6.Task1.V26
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
            buttonDone = new Button();
            groupBoxVvod = new GroupBox();
            groupBoxStop = new GroupBox();
            textBoxStop = new TextBox();
            groupBoxStart = new GroupBox();
            textBoxStart = new TextBox();
            groupBoxTask = new GroupBox();
            groupBoxTask1 = new GroupBox();
            groupBoxVyvod = new GroupBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            buttonHelp = new Button();
            groupBoxVvod.SuspendLayout();
            groupBoxStop.SuspendLayout();
            groupBoxStart.SuspendLayout();
            groupBoxTask.SuspendLayout();
            groupBoxVyvod.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(420, 352);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(124, 80);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(groupBoxStop);
            groupBoxVvod.Controls.Add(groupBoxStart);
            groupBoxVvod.Location = new Point(12, 349);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(317, 89);
            groupBoxVvod.TabIndex = 1;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод данных";
            groupBoxVvod.Enter += groupBoxVvod_Enter;
            // 
            // groupBoxStop
            // 
            groupBoxStop.Controls.Add(textBoxStop);
            groupBoxStop.Location = new Point(150, 18);
            groupBoxStop.Name = "groupBoxStop";
            groupBoxStop.Size = new Size(161, 65);
            groupBoxStop.TabIndex = 1;
            groupBoxStop.TabStop = false;
            groupBoxStop.Text = "Конец шага:";
            groupBoxStop.Enter += groupBoxStop_Enter;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(6, 26);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(93, 27);
            textBoxStop.TabIndex = 0;
            textBoxStop.TextChanged += textBoxStop_TextChanged;
            // 
            // groupBoxStart
            // 
            groupBoxStart.Controls.Add(textBoxStart);
            groupBoxStart.Location = new Point(6, 18);
            groupBoxStart.Name = "groupBoxStart";
            groupBoxStart.Size = new Size(138, 65);
            groupBoxStart.TabIndex = 0;
            groupBoxStart.TabStop = false;
            groupBoxStart.Text = "Старт шага:";
            groupBoxStart.Enter += groupBoxStart_Enter;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 26);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(91, 27);
            textBoxStart.TabIndex = 0;
            textBoxStart.TextChanged += textBoxStart_TextChanged;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxTask1);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(532, 320);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            groupBoxTask.Enter += groupBoxTask_Enter;
            // 
            // groupBoxTask1
            // 
            groupBoxTask1.Location = new Point(18, 35);
            groupBoxTask1.Name = "groupBoxTask1";
            groupBoxTask1.Size = new Size(503, 275);
            groupBoxTask1.TabIndex = 0;
            groupBoxTask1.TabStop = false;
            groupBoxTask1.Text = "Протабулировать функцию ((2cos(x)+2)/(2x-1))+cos(x)-5x+3 на заданном диапазоне.";
            groupBoxTask1.Enter += groupBoxTask1_Enter;
            // 
            // groupBoxVyvod
            // 
            groupBoxVyvod.Controls.Add(groupBoxResult);
            groupBoxVyvod.Location = new Point(556, 25);
            groupBoxVyvod.Name = "groupBoxVyvod";
            groupBoxVyvod.Size = new Size(236, 406);
            groupBoxVyvod.TabIndex = 3;
            groupBoxVyvod.TabStop = false;
            groupBoxVyvod.Text = "Вывод данных";
            groupBoxVyvod.Enter += groupBoxVyvod_Enter;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(12, 22);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(215, 372);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            groupBoxResult.Enter += groupBoxResult_Enter;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(11, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(198, 333);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(332, 355);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(82, 75);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormSprint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxVyvod);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxVvod);
            Controls.Add(buttonDone);
            Name = "FormSprint";
            Text = "Спринт 6 | Таск 1 | Вариант 26 | Рагозина А.Д ";
            groupBoxVvod.ResumeLayout(false);
            groupBoxStop.ResumeLayout(false);
            groupBoxStop.PerformLayout();
            groupBoxStart.ResumeLayout(false);
            groupBoxStart.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxVyvod.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private GroupBox groupBoxVvod;
        private GroupBox groupBoxStart;
        private TextBox textBoxStart;
        private GroupBox groupBoxStop;
        private TextBox textBoxStop;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxTask1;
        private GroupBox groupBoxVyvod;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Button buttonHelp;
    }
}
