namespace AdvancedControls
{
    partial class StaticInfo
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text1.BackColor = System.Drawing.SystemColors.Window;
            this.text1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.Location = new System.Drawing.Point(3, 15);
            this.text1.Multiline = true;
            this.text1.Name = "text1";
            this.text1.ReadOnly = true;
            this.text1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text1.Size = new System.Drawing.Size(394, 60);
            this.text1.TabIndex = 2;
            this.text1.Text = "Исполнить п. 6 протокола мероприятия \"Изготовление и выпуск СПС 64 «Экспресс-М» (" +
    "для Узбекистана)\"\r\n";
            // 
            // text2
            // 
            this.text2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text2.BackColor = System.Drawing.SystemColors.Window;
            this.text2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text2.Location = new System.Drawing.Point(3, 81);
            this.text2.Multiline = true;
            this.text2.Name = "text2";
            this.text2.ReadOnly = true;
            this.text2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text2.Size = new System.Drawing.Size(394, 66);
            this.text2.TabIndex = 3;
            this.text2.Text = "Исполнить п. 6 протокола мероприятия \"Изготовление и выпуск СПС 64 «Экспресс-М» (" +
    "для Узбекистана)\"\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.text1);
            this.groupBox1.Controls.Add(this.text2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(400, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // StaticInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "StaticInfo";
            this.Size = new System.Drawing.Size(400, 150);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox text1;
        public System.Windows.Forms.TextBox text2;
    }
}
