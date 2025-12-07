namespace Tyuiu.RagozinaAD.Sprint6.Task6.V4
{
    partial class FormAboutSprint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            groupBoxGroup = new GroupBox();
            groupBoxC = new GroupBox();
            groupBoxTyuiu = new GroupBox();
            buttonOk = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxGroup.SuspendLayout();
            groupBoxC.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxGroup);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(374, 149);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Разработчик: Рагозина А.Д.";
            // 
            // groupBoxGroup
            // 
            groupBoxGroup.Controls.Add(groupBoxC);
            groupBoxGroup.Location = new Point(0, 26);
            groupBoxGroup.Name = "groupBoxGroup";
            groupBoxGroup.Size = new Size(374, 122);
            groupBoxGroup.TabIndex = 0;
            groupBoxGroup.TabStop = false;
            groupBoxGroup.Text = "Группа: АСОиУб-25-1";
            // 
            // groupBoxC
            // 
            groupBoxC.Controls.Add(groupBoxTyuiu);
            groupBoxC.Location = new Point(0, 26);
            groupBoxC.Name = "groupBoxC";
            groupBoxC.Size = new Size(374, 97);
            groupBoxC.TabIndex = 0;
            groupBoxC.TabStop = false;
            groupBoxC.Text = "Программа разработана в рамках изучения языка C# ";
            // 
            // groupBoxTyuiu
            // 
            groupBoxTyuiu.Location = new Point(0, 45);
            groupBoxTyuiu.Name = "groupBoxTyuiu";
            groupBoxTyuiu.Size = new Size(374, 51);
            groupBoxTyuiu.TabIndex = 0;
            groupBoxTyuiu.TabStop = false;
            groupBoxTyuiu.Text = "Тюменский индустриальный университет. Высшая школа цифровых технологий.";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(251, 173);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(122, 34);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAboutSprint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 219);
            Controls.Add(buttonOk);
            Controls.Add(groupBoxTask);
            Name = "FormAboutSprint";
            Text = "О программе";
            Load += FormAboutSprint_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxGroup.ResumeLayout(false);
            groupBoxC.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxGroup;
        private GroupBox groupBoxC;
        private GroupBox groupBoxTyuiu;
        private Button buttonOk;
    }
}