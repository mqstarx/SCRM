namespace AdvancedControls
{
    partial class UsersViewItem
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
            this.usr_name_txb = new System.Windows.Forms.TextBox();
            this.del_dep_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.post_name_txb = new System.Windows.Forms.TextBox();
            this.dep_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usr_name_txb
            // 
            this.usr_name_txb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_name_txb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usr_name_txb.Location = new System.Drawing.Point(0, 0);
            this.usr_name_txb.MinimumSize = new System.Drawing.Size(250, 4);
            this.usr_name_txb.Name = "usr_name_txb";
            this.usr_name_txb.ReadOnly = true;
            this.usr_name_txb.Size = new System.Drawing.Size(250, 35);
            this.usr_name_txb.TabIndex = 3;
            this.usr_name_txb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.usr_name_txb_MouseDoubleClick);
            // 
            // del_dep_btn
            // 
            this.del_dep_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.del_dep_btn.BackgroundImage = global::AdvancedControls.Properties.Resources.del;
            this.del_dep_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del_dep_btn.Location = new System.Drawing.Point(832, 0);
            this.del_dep_btn.Name = "del_dep_btn";
            this.del_dep_btn.Size = new System.Drawing.Size(40, 37);
            this.del_dep_btn.TabIndex = 5;
            this.del_dep_btn.UseVisualStyleBackColor = true;
            this.del_dep_btn.Click += new System.EventHandler(this.del_dep_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.BackgroundImage = global::AdvancedControls.Properties.Resources.edit;
            this.edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_btn.Enabled = false;
            this.edit_btn.Location = new System.Drawing.Point(786, 0);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(40, 37);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // post_name_txb
            // 
            this.post_name_txb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.post_name_txb.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.post_name_txb.Location = new System.Drawing.Point(252, 0);
            this.post_name_txb.MinimumSize = new System.Drawing.Size(250, 4);
            this.post_name_txb.Name = "post_name_txb";
            this.post_name_txb.ReadOnly = true;
            this.post_name_txb.Size = new System.Drawing.Size(348, 35);
            this.post_name_txb.TabIndex = 6;
            this.post_name_txb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.post_name_txb_MouseDoubleClick);
            // 
            // dep_cmb
            // 
            this.dep_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dep_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dep_cmb.Enabled = false;
            this.dep_cmb.FormattingEnabled = true;
            this.dep_cmb.Location = new System.Drawing.Point(604, 9);
            this.dep_cmb.Name = "dep_cmb";
            this.dep_cmb.Size = new System.Drawing.Size(174, 21);
            this.dep_cmb.TabIndex = 7;
            this.dep_cmb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dep_cmb_MouseDoubleClick);
            // 
            // UsersViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dep_cmb);
            this.Controls.Add(this.post_name_txb);
            this.Controls.Add(this.del_dep_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.usr_name_txb);
            this.MinimumSize = new System.Drawing.Size(875, 0);
            this.Name = "UsersViewItem";
            this.Size = new System.Drawing.Size(875, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del_dep_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox usr_name_txb;
        private System.Windows.Forms.TextBox post_name_txb;
        private System.Windows.Forms.ComboBox dep_cmb;
    }
}
