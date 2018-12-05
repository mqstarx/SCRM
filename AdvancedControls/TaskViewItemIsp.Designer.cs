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
            this.components = new System.ComponentModel.Container();
            this.dateTimePickerperenos = new System.Windows.Forms.DateTimePicker();
            this.perenos_btn = new System.Windows.Forms.Button();
            this.isp_comment = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agreement_send_btn = new System.Windows.Forms.Button();
            this.toolTipchat = new System.Windows.Forms.ToolTip(this.components);
            this.messages_txb = new System.Windows.Forms.TextBox();
            this.DatesList = new AdvancedControls.InfoList();
            this.infoListUtv = new AdvancedControls.InfoList();
            this.infoListSogl = new AdvancedControls.InfoList();
            this.staticInfoTask = new AdvancedControls.StaticInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerperenos
            // 
            this.dateTimePickerperenos.Location = new System.Drawing.Point(566, 105);
            this.dateTimePickerperenos.Name = "dateTimePickerperenos";
            this.dateTimePickerperenos.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerperenos.TabIndex = 4;
            // 
            // perenos_btn
            // 
            this.perenos_btn.Location = new System.Drawing.Point(566, 130);
            this.perenos_btn.Name = "perenos_btn";
            this.perenos_btn.Size = new System.Drawing.Size(149, 23);
            this.perenos_btn.TabIndex = 5;
            this.perenos_btn.Text = "Запросить перенос срока";
            this.perenos_btn.UseVisualStyleBackColor = true;
            this.perenos_btn.Click += new System.EventHandler(this.perenos_btn_Click);
            // 
            // isp_comment
            // 
            this.isp_comment.Location = new System.Drawing.Point(6, 89);
            this.isp_comment.Name = "isp_comment";
            this.isp_comment.Size = new System.Drawing.Size(164, 20);
            this.isp_comment.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.messages_txb);
            this.groupBox1.Controls.Add(this.isp_comment);
            this.groupBox1.Location = new System.Drawing.Point(721, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сообщения:";
            // 
            // agreement_send_btn
            // 
            this.agreement_send_btn.Location = new System.Drawing.Point(721, 130);
            this.agreement_send_btn.Name = "agreement_send_btn";
            this.agreement_send_btn.Size = new System.Drawing.Size(176, 23);
            this.agreement_send_btn.TabIndex = 8;
            this.agreement_send_btn.Text = "Отправить на согласование";
            this.agreement_send_btn.UseVisualStyleBackColor = true;
            this.agreement_send_btn.Click += new System.EventHandler(this.agreement_send_btn_Click);
            // 
            // messages_txb
            // 
            this.messages_txb.Location = new System.Drawing.Point(7, 20);
            this.messages_txb.Multiline = true;
            this.messages_txb.Name = "messages_txb";
            this.messages_txb.ReadOnly = true;
            this.messages_txb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messages_txb.Size = new System.Drawing.Size(163, 63);
            this.messages_txb.TabIndex = 7;
            // 
            // DatesList
            // 
            this.DatesList.BackColor = System.Drawing.Color.White;
            this.DatesList.FontSize = 9;
            this.DatesList.HeaderText = "Сроки";
            this.DatesList.Location = new System.Drawing.Point(565, 0);
            this.DatesList.Name = "DatesList";
            this.DatesList.Size = new System.Drawing.Size(150, 96);
            this.DatesList.TabIndex = 2;
            // 
            // infoListUtv
            // 
            this.infoListUtv.FontSize = 9;
            this.infoListUtv.HeaderText = "Утверждающие";
            this.infoListUtv.Location = new System.Drawing.Point(409, 74);
            this.infoListUtv.Name = "infoListUtv";
            this.infoListUtv.Size = new System.Drawing.Size(150, 78);
            this.infoListUtv.TabIndex = 9;
            // 
            // infoListSogl
            // 
            this.infoListSogl.FontSize = 9;
            this.infoListSogl.HeaderText = "Согласующие";
            this.infoListSogl.Location = new System.Drawing.Point(409, 0);
            this.infoListSogl.Name = "infoListSogl";
            this.infoListSogl.Size = new System.Drawing.Size(150, 77);
            this.infoListSogl.TabIndex = 3;
            // 
            // staticInfoTask
            // 
            this.staticInfoTask.Location = new System.Drawing.Point(3, 3);
            this.staticInfoTask.Name = "staticInfoTask";
            this.staticInfoTask.Size = new System.Drawing.Size(400, 151);
            this.staticInfoTask.TabIndex = 0;
            // 
            // TaskViewItemIsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DatesList);
            this.Controls.Add(this.infoListUtv);
            this.Controls.Add(this.agreement_send_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.perenos_btn);
            this.Controls.Add(this.dateTimePickerperenos);
            this.Controls.Add(this.infoListSogl);
            this.Controls.Add(this.staticInfoTask);
            this.Name = "TaskViewItemIsp";
            this.Size = new System.Drawing.Size(900, 155);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private StaticInfo staticInfoTask;
        private InfoList DatesList;
        private InfoList infoListSogl;
        private System.Windows.Forms.Button perenos_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button agreement_send_btn;
        private InfoList infoListUtv;
        public System.Windows.Forms.DateTimePicker dateTimePickerperenos;
        public System.Windows.Forms.TextBox isp_comment;
        private System.Windows.Forms.ToolTip toolTipchat;
        private System.Windows.Forms.TextBox messages_txb;
    }
}
