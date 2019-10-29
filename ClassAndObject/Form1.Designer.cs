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
            this.CreateObject = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.Dicrease = new System.Windows.Forms.Button();
            this.timeArrayList = new System.Windows.Forms.ListBox();
            this.showClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateObject
            // 
            this.CreateObject.Location = new System.Drawing.Point(170, 12);
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(98, 27);
            this.CreateObject.TabIndex = 1;
            this.CreateObject.Text = "Добавить";
            this.CreateObject.UseVisualStyleBackColor = true;
            this.CreateObject.Click += new System.EventHandler(this.CreateObject_Click);
            // 
            // Increase
            // 
            this.Increase.Location = new System.Drawing.Point(170, 105);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(98, 27);
            this.Increase.TabIndex = 3;
            this.Increase.Text = "++Минуты";
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.Click += new System.EventHandler(this.Increase_Click);
            // 
            // Dicrease
            // 
            this.Dicrease.Location = new System.Drawing.Point(170, 138);
            this.Dicrease.Name = "Dicrease";
            this.Dicrease.Size = new System.Drawing.Size(97, 27);
            this.Dicrease.TabIndex = 4;
            this.Dicrease.Text = "--Минуты";
            this.Dicrease.UseVisualStyleBackColor = true;
            this.Dicrease.Click += new System.EventHandler(this.Dicrease_Click);
            // 
            // timeArrayList
            // 
            this.timeArrayList.FormattingEnabled = true;
            this.timeArrayList.Location = new System.Drawing.Point(12, 12);
            this.timeArrayList.Name = "timeArrayList";
            this.timeArrayList.Size = new System.Drawing.Size(141, 264);
            this.timeArrayList.TabIndex = 5;
            // 
            // showClick
            // 
            this.showClick.Location = new System.Drawing.Point(170, 45);
            this.showClick.Name = "showClick";
            this.showClick.Size = new System.Drawing.Size(97, 29);
            this.showClick.TabIndex = 6;
            this.showClick.Text = "Показать";
            this.showClick.UseVisualStyleBackColor = true;
            this.showClick.Click += new System.EventHandler(this.showClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 286);
            this.Controls.Add(this.showClick);
            this.Controls.Add(this.timeArrayList);
            this.Controls.Add(this.Dicrease);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.CreateObject);
            this.Name = "Form1";
            this.Text = "Time";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateObject;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Button Dicrease;
        private System.Windows.Forms.ListBox timeArrayList;
        private System.Windows.Forms.Button showClick;
    }
}

