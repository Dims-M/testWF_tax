namespace WP_testTask
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInfaVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIshowUpdate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAssemblyApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 261);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 261);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Обновить программу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текущая версия программы:";
            // 
            // lbInfaVersion
            // 
            this.lbInfaVersion.AutoSize = true;
            this.lbInfaVersion.Location = new System.Drawing.Point(195, 35);
            this.lbInfaVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInfaVersion.Name = "lbInfaVersion";
            this.lbInfaVersion.Size = new System.Drawing.Size(39, 13);
            this.lbInfaVersion.TabIndex = 3;
            this.lbInfaVersion.Text = "Vesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Состояние:";
            // 
            // lbIshowUpdate
            // 
            this.lbIshowUpdate.AutoSize = true;
            this.lbIshowUpdate.Location = new System.Drawing.Point(195, 87);
            this.lbIshowUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIshowUpdate.Name = "lbIshowUpdate";
            this.lbIshowUpdate.Size = new System.Drawing.Size(138, 13);
            this.lbIshowUpdate.TabIndex = 5;
            this.lbIshowUpdate.Text = "Обновление не требуется";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Текущая версия сборки:";
            // 
            // lbAssemblyApp
            // 
            this.lbAssemblyApp.AutoSize = true;
            this.lbAssemblyApp.Location = new System.Drawing.Point(197, 71);
            this.lbAssemblyApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAssemblyApp.Name = "lbAssemblyApp";
            this.lbAssemblyApp.Size = new System.Drawing.Size(44, 13);
            this.lbAssemblyApp.TabIndex = 7;
            this.lbAssemblyApp.Text = "Сборка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 310);
            this.Controls.Add(this.lbAssemblyApp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbIshowUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInfaVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Tестовая программа такснет";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInfaVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIshowUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAssemblyApp;
    }
}

