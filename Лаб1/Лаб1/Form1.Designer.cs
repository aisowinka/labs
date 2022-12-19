namespace Лаб1
{
    partial class mainForm
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
            this.startBtn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.richTB = new System.Windows.Forms.RichTextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(67, 488);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(195, 46);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Начать";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(498, 488);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(195, 46);
            this.checkBtn.TabIndex = 0;
            this.checkBtn.Text = "Проверить";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // richTB
            // 
            this.richTB.BackColor = System.Drawing.Color.White;
            this.richTB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTB.Location = new System.Drawing.Point(12, 12);
            this.richTB.Name = "richTB";
            this.richTB.ReadOnly = true;
            this.richTB.Size = new System.Drawing.Size(250, 276);
            this.richTB.TabIndex = 1;
            this.richTB.Text = "";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(285, 501);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(65, 21);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Время:";
            // 
            // tbTime
            // 
            this.tbTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTime.Location = new System.Drawing.Point(356, 501);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(28, 24);
            this.tbTime.TabIndex = 3;
            this.tbTime.Text = "15";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 21;
            this.listBox.Location = new System.Drawing.Point(467, 9);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox.Size = new System.Drawing.Size(233, 277);
            this.listBox.TabIndex = 6;
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCheck.Location = new System.Drawing.Point(426, 303);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(0, 21);
            this.labelCheck.TabIndex = 5;
            this.labelCheck.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.richTB);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.startBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "mainForm";
            this.Text = "Лабораторная работа № 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.RichTextBox richTB;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelCheck;
    }
}

