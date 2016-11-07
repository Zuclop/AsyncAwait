namespace WindowsFormsAsyncAwait
{
    partial class FileLoggerForm
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
            this.AddToLogButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddToLogButton
            // 
            this.AddToLogButton.Location = new System.Drawing.Point(12, 85);
            this.AddToLogButton.Name = "AddToLogButton";
            this.AddToLogButton.Size = new System.Drawing.Size(694, 23);
            this.AddToLogButton.TabIndex = 0;
            this.AddToLogButton.Text = "Add to Log";
            this.AddToLogButton.UseVisualStyleBackColor = true;
            this.AddToLogButton.Click += new System.EventHandler(this.AddToLogButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(90, 59);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(616, 20);
            this.FilePathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text File Path";
            // 
            // FileLoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.AddToLogButton);
            this.Name = "FileLoggerForm";
            this.Text = "File Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddToLogButton;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Label label1;
    }
}

