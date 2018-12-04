namespace AdvancedControls
{
    partial class TaskVivewControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskViewItemIsp1 = new AdvancedControls.TaskViewItemIsp();
            this.taskViewItemIsp2 = new AdvancedControls.TaskViewItemIsp();
            this.taskViewItemIsp3 = new AdvancedControls.TaskViewItemIsp();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataSource = typeof(CoreLib.UserInfo);
            // 
            // taskViewItemIsp1
            // 
            this.taskViewItemIsp1.BackColor = System.Drawing.Color.White;
            this.taskViewItemIsp1.Location = new System.Drawing.Point(3, 3);
            this.taskViewItemIsp1.Name = "taskViewItemIsp1";
            this.taskViewItemIsp1.Size = new System.Drawing.Size(900, 155);
            this.taskViewItemIsp1.TabIndex = 0;
            // 
            // taskViewItemIsp2
            // 
            this.taskViewItemIsp2.BackColor = System.Drawing.Color.White;
            this.taskViewItemIsp2.Location = new System.Drawing.Point(3, 164);
            this.taskViewItemIsp2.Name = "taskViewItemIsp2";
            this.taskViewItemIsp2.Size = new System.Drawing.Size(900, 155);
            this.taskViewItemIsp2.TabIndex = 1;
            // 
            // taskViewItemIsp3
            // 
            this.taskViewItemIsp3.BackColor = System.Drawing.Color.White;
            this.taskViewItemIsp3.Location = new System.Drawing.Point(3, 325);
            this.taskViewItemIsp3.Name = "taskViewItemIsp3";
            this.taskViewItemIsp3.Size = new System.Drawing.Size(900, 155);
            this.taskViewItemIsp3.TabIndex = 2;
            // 
            // TaskVivewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.taskViewItemIsp3);
            this.Controls.Add(this.taskViewItemIsp2);
            this.Controls.Add(this.taskViewItemIsp1);
            this.Name = "TaskVivewControl";
            this.Size = new System.Drawing.Size(907, 284);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private TaskViewItemIsp taskViewItemIsp1;
        private TaskViewItemIsp taskViewItemIsp2;
        private TaskViewItemIsp taskViewItemIsp3;
    }
}
