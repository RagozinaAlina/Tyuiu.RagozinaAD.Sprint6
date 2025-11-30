namespace Tyuiu.RagozinaAD.Sprint6.Task0.V4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSprint));
            buttonDone = new Button();
            pictureBoxFormula = new PictureBox();
            groupBoxTask = new GroupBox();
            groupBoxForm = new GroupBox();
            groupBoxResult = new GroupBox();
            groupBoxEnter = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxVvod = new GroupBox();
            groupBoxX = new GroupBox();
            textBoxX = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            groupBoxEnter.SuspendLayout();
            groupBoxVvod.SuspendLayout();
            groupBoxX.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(562, 370);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(226, 68);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(447, 25);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(341, 79);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            pictureBoxFormula.Click += pictureBoxFormula_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(groupBoxForm);
            groupBoxTask.Location = new Point(19, 20);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(412, 191);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            groupBoxTask.Enter += groupBoxTask_Enter;
            // 
            // groupBoxForm
            // 
            groupBoxForm.Location = new Point(14, 31);
            groupBoxForm.Name = "groupBoxForm";
            groupBoxForm.Size = new Size(392, 154);
            groupBoxForm.TabIndex = 0;
            groupBoxForm.TabStop = false;
            groupBoxForm.Text = "Вычислить выражение по формуле";
            groupBoxForm.Enter += groupBoxForm_Enter;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(6, 26);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(323, 68);
            groupBoxResult.TabIndex = 3;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            groupBoxResult.Enter += groupBoxResult_Enter;
            // 
            // groupBoxEnter
            // 
            groupBoxEnter.Controls.Add(groupBoxResult);
            groupBoxEnter.Location = new Point(445, 248);
            groupBoxEnter.Name = "groupBoxEnter";
            groupBoxEnter.Size = new Size(350, 117);
            groupBoxEnter.TabIndex = 4;
            groupBoxEnter.TabStop = false;
            groupBoxEnter.Text = "Вывод данных";
            groupBoxEnter.Enter += groupBoxEnter_Enter;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 26);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(154, 27);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(groupBoxX);
            groupBoxVvod.Location = new Point(23, 248);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(400, 188);
            groupBoxVvod.TabIndex = 5;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод данных";
            groupBoxVvod.Enter += groupBoxVvod_Enter;
            // 
            // groupBoxX
            // 
            groupBoxX.Controls.Add(textBoxX);
            groupBoxX.Location = new Point(15, 34);
            groupBoxX.Name = "groupBoxX";
            groupBoxX.Size = new Size(374, 67);
            groupBoxX.TabIndex = 0;
            groupBoxX.TabStop = false;
            groupBoxX.Text = "Переменная X";
            groupBoxX.Enter += groupBoxX_Enter;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(6, 26);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(134, 27);
            textBoxX.TabIndex = 0;
            textBoxX.TextChanged += textBoxX_TextChanged;
            // 
            // FormSprint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxVvod);
            Controls.Add(groupBoxEnter);
            Controls.Add(groupBoxTask);
            Controls.Add(pictureBoxFormula);
            Controls.Add(buttonDone);
            Name = "FormSprint";
            Text = "Спринт 6 | Таск 0 | Вариант 4 | Рагозина А.Д ";
            Load += FormSprint_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxTask.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxEnter.ResumeLayout(false);
            groupBoxVvod.ResumeLayout(false);
            groupBoxX.ResumeLayout(false);
            groupBoxX.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxForm;
        private GroupBox groupBoxResult;
        private GroupBox groupBoxEnter;
        private TextBox textBoxResult;
        private GroupBox groupBoxVvod;
        private GroupBox groupBoxX;
        private TextBox textBoxX;
    }
}
