namespace AdvancedControls
{
    partial class TaskViewItemIsp
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.infoList2 = new AdvancedControls.InfoList();
            this.infoList3 = new AdvancedControls.InfoList();
            this.infoList1 = new AdvancedControls.InfoList();
            this.staticInfo1 = new AdvancedControls.StaticInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(566, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Запросить перенос срока";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 92);
            this.textBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(721, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Комментарий";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(721, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отправить на согласование";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // infoList2
            // 
            this.infoList2.BackColor = System.Drawing.Color.White;
            this.infoList2.FontSize = 19;
            this.infoList2.HeaderText = "Сроки";
            this.infoList2.Location = new System.Drawing.Point(565, 0);
            this.infoList2.Name = "infoList2";
            this.infoList2.Size = new System.Drawing.Size(150, 96);
            this.infoList2.TabIndex = 2;
            // 
            // infoList3
            // 
            this.infoList3.FontSize = 19;
            this.infoList3.HeaderText = "Утверждающие";
            this.infoList3.Location = new System.Drawing.Point(409, 83);
            this.infoList3.Name = "infoList3";
            this.infoList3.Size = new System.Drawing.Size(150, 69);
            this.infoList3.TabIndex = 9;
            // 
            // infoList1
            // 
            this.infoList1.FontSize = 19;
            this.infoList1.HeaderText = "Согласующие";
            this.infoList1.Location = new System.Drawing.Point(409, 0);
            this.infoList1.Name = "infoList1";
            this.infoList1.Size = new System.Drawing.Size(150, 77);
            this.infoList1.TabIndex = 3;
            // 
            // staticInfo1
            // 
            this.staticInfo1.Location = new System.Drawing.Point(3, 3);
            this.staticInfo1.Name = "staticInfo1";
            this.staticInfo1.Size = new System.Drawing.Size(400, 151);
            this.staticInfo1.TabIndex = 0;
            // 
            // TaskViewItemIsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.infoList2);
            this.Controls.Add(this.infoList3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.infoList1);
            this.Controls.Add(this.staticInfo1);
            this.Name = "TaskViewItemIsp";
            this.Size = new System.Drawing.Size(900, 155);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private StaticInfo staticInfo1;
        private InfoList infoList2;
        private InfoList infoList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private InfoList infoList3;
    }
}
