namespace YesXNo
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YesTxt = new System.Windows.Forms.Label();
            this.NoTxt = new System.Windows.Forms.Label();
            this.BallAnswerBtn = new System.Windows.Forms.Button();
            this.BallAswrLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Location = new System.Drawing.Point(44, 129);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(87, 30);
            this.AnswerBtn.TabIndex = 1;
            this.AnswerBtn.Text = "Ответ";
            this.AnswerBtn.UseVisualStyleBackColor = true;
            this.AnswerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(78, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Задайте Ваш вопрос";
            // 
            // YesTxt
            // 
            this.YesTxt.AutoSize = true;
            this.YesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesTxt.ForeColor = System.Drawing.Color.Green;
            this.YesTxt.Location = new System.Drawing.Point(142, 181);
            this.YesTxt.Name = "YesTxt";
            this.YesTxt.Size = new System.Drawing.Size(34, 20);
            this.YesTxt.TabIndex = 3;
            this.YesTxt.Text = "ДА";
            this.YesTxt.Visible = false;
            // 
            // NoTxt
            // 
            this.NoTxt.AutoSize = true;
            this.NoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoTxt.ForeColor = System.Drawing.Color.Red;
            this.NoTxt.Location = new System.Drawing.Point(134, 181);
            this.NoTxt.Name = "NoTxt";
            this.NoTxt.Size = new System.Drawing.Size(42, 20);
            this.NoTxt.TabIndex = 4;
            this.NoTxt.Text = "Нет";
            this.NoTxt.Visible = false;
            // 
            // BallAnswerBtn
            // 
            this.BallAnswerBtn.Location = new System.Drawing.Point(190, 130);
            this.BallAnswerBtn.Name = "BallAnswerBtn";
            this.BallAnswerBtn.Size = new System.Drawing.Size(87, 29);
            this.BallAnswerBtn.TabIndex = 5;
            this.BallAnswerBtn.Text = "Ответ шара";
            this.BallAnswerBtn.UseVisualStyleBackColor = true;
            this.BallAnswerBtn.Click += new System.EventHandler(this.BallAnswerBtn_Click);
            // 
            // BallAswrLbl
            // 
            this.BallAswrLbl.AutoSize = true;
            this.BallAswrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BallAswrLbl.Location = new System.Drawing.Point(142, 181);
            this.BallAswrLbl.Name = "BallAswrLbl";
            this.BallAswrLbl.Size = new System.Drawing.Size(19, 20);
            this.BallAswrLbl.TabIndex = 6;
            this.BallAswrLbl.Text = "0";
            this.BallAswrLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 247);
            this.Controls.Add(this.BallAswrLbl);
            this.Controls.Add(this.BallAnswerBtn);
            this.Controls.Add(this.NoTxt);
            this.Controls.Add(this.YesTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnswerBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label YesTxt;
        private System.Windows.Forms.Label NoTxt;
        private System.Windows.Forms.Button BallAnswerBtn;
        private System.Windows.Forms.Label BallAswrLbl;
    }
}

