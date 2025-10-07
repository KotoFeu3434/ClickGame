namespace ClickGame
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
            this.labelTime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.buttonClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(25, 20);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 16);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "час: 0";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(173, 83);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(73, 16);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "рахунок: 0";
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Location = new System.Drawing.Point(271, 314);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(132, 16);
            this.labelLast.TabIndex = 2;
            this.labelLast.Text = "останнія рахунок: 0";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(12, 314);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(70, 16);
            this.labelHigh.TabIndex = 3;
            this.labelHigh.Text = "рекорд:  0";
            // 
            // buttonClick
            // 
            this.buttonClick.Location = new System.Drawing.Point(158, 166);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(110, 79);
            this.buttonClick.TabIndex = 4;
            this.buttonClick.Text = "Клікни";
            this.buttonClick.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 356);
            this.Controls.Add(this.buttonClick);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Button buttonClick;
    }
}

