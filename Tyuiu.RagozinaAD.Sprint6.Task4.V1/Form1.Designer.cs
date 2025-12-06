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
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxTask = new GroupBox();
            groupBoxTask1 = new GroupBox();
            groupBoxVvod = new GroupBox();
            groupBoxStop = new GroupBox();
            textBoxStop = new TextBox();
            groupBoxStart = new GroupBox();
            textBoxStart = new TextBox();
            groupBoxVyvod = new GroupBox();
            textBoxResult = new TextBox();
            buttonSave = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxVvod.SuspendLayout();
            groupBoxStop.SuspendLayout();
            groupBoxStart.SuspendLayout();
            groupBoxVyvod.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(724, 306);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(158, 63);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(613, 375);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(105, 63);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxTask1);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(352, 192);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // groupBoxTask1
            // 
            groupBoxTask1.Location = new Point(6, 26);
            groupBoxTask1.Name = "groupBoxTask1";
            groupBoxTask1.Size = new Size(331, 152);
            groupBoxTask1.TabIndex = 0;
            groupBoxTask1.TabStop = false;
            groupBoxTask1.Text = "Протабулировать функцию (sin(x)/(x+1,2))+cos(x)*7x-2 на заданном диапазоне.";
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(groupBoxStop);
            groupBoxVvod.Controls.Add(groupBoxStart);
            groupBoxVvod.Location = new Point(12, 225);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(352, 213);
            groupBoxVvod.TabIndex = 3;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод данных";
            // 
            // groupBoxStop
            // 
            groupBoxStop.Controls.Add(textBoxStop);
            groupBoxStop.Location = new Point(14, 122);
            groupBoxStop.Name = "groupBoxStop";
            groupBoxStop.Size = new Size(131, 59);
            groupBoxStop.TabIndex = 1;
            groupBoxStop.TabStop = false;
            groupBoxStop.Text = "Конец шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(10, 26);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(110, 27);
            textBoxStop.TabIndex = 0;
            // 
            // groupBoxStart
            // 
            groupBoxStart.Controls.Add(textBoxStart);
            groupBoxStart.Location = new Point(14, 38);
            groupBoxStart.Name = "groupBoxStart";
            groupBoxStart.Size = new Size(131, 67);
            groupBoxStart.TabIndex = 0;
            groupBoxStart.TabStop = false;
            groupBoxStart.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 26);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(114, 27);
            textBoxStart.TabIndex = 0;
            // 
            // groupBoxVyvod
            // 
            groupBoxVyvod.Controls.Add(textBoxResult);
            groupBoxVyvod.Location = new Point(380, 5);
            groupBoxVyvod.Name = "groupBoxVyvod";
            groupBoxVyvod.Size = new Size(227, 433);
            groupBoxVyvod.TabIndex = 4;
            groupBoxVyvod.TabStop = false;
            groupBoxVyvod.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(18, 28);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(173, 27);
            textBoxResult.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(724, 376);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(158, 62);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormSprint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 443);
            Controls.Add(buttonSave);
            Controls.Add(groupBoxVyvod);
            Controls.Add(groupBoxVvod);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            MinimumSize = new Size(800, 450);
            Name = "FormSprint";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 4 | Вариант 1 | Рагозина А.Д  ";
            Load += FormSprint_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxVvod.ResumeLayout(false);
            groupBoxStop.ResumeLayout(false);
            groupBoxStop.PerformLayout();
            groupBoxStart.ResumeLayout(false);
            groupBoxStart.PerformLayout();
            groupBoxVyvod.ResumeLayout(false);
            groupBoxVyvod.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonHelp;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxVvod;
        private GroupBox groupBoxStop;
        private TextBox textBoxStop;
        private GroupBox groupBoxStart;
        private TextBox textBoxStart;
        private GroupBox groupBoxVyvod;
        private GroupBox groupBoxTask1;
        private TextBox textBoxResult;
        private Button buttonSave;
    }
}
