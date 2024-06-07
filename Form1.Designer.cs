namespace BalanceWorkForms
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
            buttonStartStop = new Button();
            labelTimer = new Label();
            textBoxTaskName = new TextBox();
            buttonDeleteTask = new Button();
            buttonSaveTasks = new Button();
            labelAuthor = new Label();
            listBoxTasks = new ListBox();
            SuspendLayout();
            // 
            // buttonStartStop
            // 
            buttonStartStop.Location = new Point(12, 68);
            buttonStartStop.Name = "buttonStartStop";
            buttonStartStop.Size = new Size(776, 23);
            buttonStartStop.TabIndex = 0;
            buttonStartStop.Text = "Старт";
            buttonStartStop.UseVisualStyleBackColor = true;
            buttonStartStop.Click += button1_Click;
            // 
            // labelTimer
            // 
            labelTimer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTimer.Location = new Point(372, 40);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(80, 25);
            labelTimer.TabIndex = 1;
            labelTimer.Text = "00:00:00";
            labelTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(12, 14);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new Size(776, 23);
            textBoxTaskName.TabIndex = 2;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Location = new Point(93, 242);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(75, 23);
            buttonDeleteTask.TabIndex = 4;
            buttonDeleteTask.Text = "Удалить";
            buttonDeleteTask.UseVisualStyleBackColor = true;
            buttonDeleteTask.Click += buttonDeleteTask_Click;
            // 
            // buttonSaveTasks
            // 
            buttonSaveTasks.Location = new Point(12, 242);
            buttonSaveTasks.Name = "buttonSaveTasks";
            buttonSaveTasks.Size = new Size(75, 23);
            buttonSaveTasks.TabIndex = 5;
            buttonSaveTasks.Text = "Сохранить";
            buttonSaveTasks.UseVisualStyleBackColor = true;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelAuthor.Location = new Point(12, 426);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(170, 15);
            labelAuthor.TabIndex = 6;
            labelAuthor.Text = "https://github.com/Pank0REKT";
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(12, 97);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(776, 139);
            listBoxTasks.TabIndex = 7;
            listBoxTasks.SelectedIndexChanged += listBoxTasks_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxTasks);
            Controls.Add(labelAuthor);
            Controls.Add(buttonSaveTasks);
            Controls.Add(buttonDeleteTask);
            Controls.Add(textBoxTaskName);
            Controls.Add(labelTimer);
            Controls.Add(buttonStartStop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = Properties.Resources.capybara;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Рабочий таймер 1.0";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStartStop;
        private Label labelTimer;
        private TextBox textBoxTaskName;
        private Button buttonDeleteTask;
        private Button buttonSaveTasks;
        private Label labelAuthor;
        private ListBox listBoxTasks;
    }
}
