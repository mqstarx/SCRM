namespace SCRMOperator
{
    partial class MainOperatorForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.users_tab = new System.Windows.Forms.TabPage();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OtchetTab = new System.Windows.Forms.TabPage();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usersView1 = new AdvancedControls.UsersView();
            this.depView1 = new AdvancedControls.DepView();
            this.tabControl1.SuspendLayout();
            this.users_tab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTasks);
            this.tabControl1.Controls.Add(this.users_tab);
            this.tabControl1.Controls.Add(this.OtchetTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTasks
            // 
            this.tabTasks.Location = new System.Drawing.Point(4, 22);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Size = new System.Drawing.Size(1288, 380);
            this.tabTasks.TabIndex = 0;
            this.tabTasks.Text = "Задачи";
            this.tabTasks.UseVisualStyleBackColor = true;
            // 
            // users_tab
            // 
            this.users_tab.Controls.Add(this.groupBox2);
            this.users_tab.Controls.Add(this.refresh_btn);
            this.users_tab.Controls.Add(this.groupBox1);
            this.users_tab.Location = new System.Drawing.Point(4, 22);
            this.users_tab.Name = "users_tab";
            this.users_tab.Size = new System.Drawing.Size(1256, 437);
            this.users_tab.TabIndex = 1;
            this.users_tab.Text = "Пользователи";
            this.users_tab.UseVisualStyleBackColor = true;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(6, 404);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 2;
            this.refresh_btn.Text = "Обновить";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.depView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отделы";
            // 
            // OtchetTab
            // 
            this.OtchetTab.Location = new System.Drawing.Point(4, 22);
            this.OtchetTab.Name = "OtchetTab";
            this.OtchetTab.Size = new System.Drawing.Size(1187, 397);
            this.OtchetTab.TabIndex = 2;
            this.OtchetTab.Text = "Отчеты";
            this.OtchetTab.UseVisualStyleBackColor = true;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataSource = typeof(CoreLib.UserInfo);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.usersView1);
            this.groupBox2.Location = new System.Drawing.Point(360, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 395);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // usersView1
            // 
            this.usersView1.DepList = null;
            this.usersView1.Location = new System.Drawing.Point(0, 19);
            this.usersView1.MinimumSize = new System.Drawing.Size(895, 0);
            this.usersView1.Name = "usersView1";
            this.usersView1.Size = new System.Drawing.Size(895, 371);
            this.usersView1.TabIndex = 0;
            this.usersView1.UsersList = null;
            // 
            // depView1
            // 
            this.depView1.DepList = null;
            this.depView1.Location = new System.Drawing.Point(6, 19);
            this.depView1.Name = "depView1";
            this.depView1.Size = new System.Drawing.Size(325, 311);
            this.depView1.TabIndex = 0;
            // 
            // MainOperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 462);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1280, 500);
            this.Name = "MainOperatorForm";
            this.Text = "Панель оператора";
            this.tabControl1.ResumeLayout(false);
            this.users_tab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.TabPage users_tab;
        private System.Windows.Forms.TabPage OtchetTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private AdvancedControls.UsersView usersView1;
        private AdvancedControls.DepView depView1;
    }
}

