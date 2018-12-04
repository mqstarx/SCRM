namespace InfoList
{
    partial class InfoList
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
            this.infoGroupbox = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.infoGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoGroupbox
            // 
            this.infoGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoGroupbox.Controls.Add(this.panel);
            this.infoGroupbox.Location = new System.Drawing.Point(3, 3);
            this.infoGroupbox.Name = "infoGroupbox";
            this.infoGroupbox.Size = new System.Drawing.Size(144, 94);
            this.infoGroupbox.TabIndex = 0;
            this.infoGroupbox.TabStop = false;
            this.infoGroupbox.Text = "Информаця";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(7, 20);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(131, 68);
            this.panel.TabIndex = 0;
            // 
            // InfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoGroupbox);
            this.Name = "InfoList";
            this.Size = new System.Drawing.Size(150, 100);
            this.infoGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infoGroupbox;
        private System.Windows.Forms.Panel panel;
    }
}
