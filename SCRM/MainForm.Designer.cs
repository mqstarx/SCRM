namespace SCRM
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tasks_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.taskVivewControl1 = new AdvancedControls.TaskVivewControl();
            this.SuspendLayout();
            // 
            // tasks_list
            // 
            this.tasks_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6});
            this.tasks_list.FullRowSelect = true;
            this.tasks_list.GridLines = true;
            this.tasks_list.Location = new System.Drawing.Point(12, 12);
            this.tasks_list.Name = "tasks_list";
            this.tasks_list.Size = new System.Drawing.Size(82, 509);
            this.tasks_list.TabIndex = 0;
            this.tasks_list.UseCompatibleStateImageBehavior = false;
            this.tasks_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Задача";
            this.columnHeader1.Width = 258;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата начала";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Срок завершения";
            this.columnHeader3.Width = 138;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Статус";
            this.columnHeader6.Width = 142;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(930, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(849, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // taskVivewControl1
            // 
            this.taskVivewControl1.AutoScroll = true;
            this.taskVivewControl1.Location = new System.Drawing.Point(188, 88);
            this.taskVivewControl1.Name = "taskVivewControl1";
            this.taskVivewControl1.Size = new System.Drawing.Size(1079, 286);
            this.taskVivewControl1.TabIndex = 3;
            this.taskVivewControl1.TaskItems = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 533);
            this.Controls.Add(this.taskVivewControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tasks_list);
            this.Name = "MainForm";
            this.Text = "Автоматизированный контроль";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView tasks_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private AdvancedControls.TaskVivewControl taskVivewControl1;
    }
}

