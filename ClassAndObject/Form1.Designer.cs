namespace ClassAndObject
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
            this.mainText = new System.Windows.Forms.RichTextBox();
            this.CreateObject = new System.Windows.Forms.Button();
            this.ShowCountObject = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.Dicrease = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.Location = new System.Drawing.Point(12, 12);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(156, 238);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "";
            // 
            // CreateObject
            // 
            this.CreateObject.Location = new System.Drawing.Point(174, 12);
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(98, 27);
            this.CreateObject.TabIndex = 1;
            this.CreateObject.Text = "Создать";
            this.CreateObject.UseVisualStyleBackColor = true;
            this.CreateObject.Click += new System.EventHandler(this.CreateObject_Click);
            // 
            // ShowCountObject
            // 
            this.ShowCountObject.Location = new System.Drawing.Point(174, 214);
            this.ShowCountObject.Name = "ShowCountObject";
            this.ShowCountObject.Size = new System.Drawing.Size(98, 36);
            this.ShowCountObject.TabIndex = 2;
            this.ShowCountObject.Text = "Количество элементов";
            this.ShowCountObject.UseVisualStyleBackColor = true;
            // 
            // Increase
            // 
            this.Increase.Location = new System.Drawing.Point(174, 45);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(98, 27);
            this.Increase.TabIndex = 3;
            this.Increase.Text = "++Минуты";
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.Click += new System.EventHandler(this.Increase_Click);
            // 
            // Dicrease
            // 
            this.Dicrease.Location = new System.Drawing.Point(175, 79);
            this.Dicrease.Name = "Dicrease";
            this.Dicrease.Size = new System.Drawing.Size(97, 27);
            this.Dicrease.TabIndex = 4;
            this.Dicrease.Text = "--Минуты";
            this.Dicrease.UseVisualStyleBackColor = true;
            this.Dicrease.Click += new System.EventHandler(this.Dicrease_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Dicrease);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.ShowCountObject);
            this.Controls.Add(this.CreateObject);
            this.Controls.Add(this.mainText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainText;
        private System.Windows.Forms.Button CreateObject;
        private System.Windows.Forms.Button ShowCountObject;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Button Dicrease;
    }
}

