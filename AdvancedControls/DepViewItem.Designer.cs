namespace AdvancedControls
{
    partial class DepViewItem
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
            this.dep_name_txb = new System.Windows.Forms.TextBox();
            this.del_dep_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dep_name_txb
            // 
            this.dep_name_txb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dep_name_txb.Location = new System.Drawing.Point(0, -1);
            this.dep_name_txb.Multiline = true;
            this.dep_name_txb.Name = "dep_name_txb";
            this.dep_name_txb.ReadOnly = true;
            this.dep_name_txb.Size = new System.Drawing.Size(233, 35);
            this.dep_name_txb.TabIndex = 0;
            this.dep_name_txb.TextChanged += new System.EventHandler(this.dep_name_txb_TextChanged);
            this.dep_name_txb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dep_name_txb_MouseDoubleClick);
            // 
            // del_dep_btn
            // 
            this.del_dep_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.del_dep_btn.BackgroundImage = global::AdvancedControls.Properties.Resources.del;
            this.del_dep_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.del_dep_btn.Location = new System.Drawing.Point(275, -1);
            this.del_dep_btn.Name = "del_dep_btn";
            this.del_dep_btn.Size = new System.Drawing.Size(40, 37);
            this.del_dep_btn.TabIndex = 2;
            this.del_dep_btn.UseVisualStyleBackColor = true;
            this.del_dep_btn.Click += new System.EventHandler(this.del_dep_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.BackgroundImage = global::AdvancedControls.Properties.Resources.edit;
            this.edit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_btn.Location = new System.Drawing.Point(233, -1);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(40, 37);
            this.edit_btn.TabIndex = 1;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // DepViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.del_dep_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.dep_name_txb);
            this.MaximumSize = new System.Drawing.Size(1024, 36);
            this.MinimumSize = new System.Drawing.Size(0, 36);
            this.Name = "DepViewItem";
            this.Size = new System.Drawing.Size(315, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dep_name_txb;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button del_dep_btn;
    }
}
