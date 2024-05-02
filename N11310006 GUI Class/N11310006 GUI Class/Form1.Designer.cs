namespace N11310006_GUI_Class
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnButton = new System.Windows.Forms.Button();
            this.btnTextBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(33, 135);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(140, 81);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "button1";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTextBox
            // 
            this.btnTextBox.Location = new System.Drawing.Point(207, 135);
            this.btnTextBox.Name = "btnTextBox";
            this.btnTextBox.Size = new System.Drawing.Size(140, 81);
            this.btnTextBox.TabIndex = 1;
            this.btnTextBox.Text = "輸入框";
            this.btnTextBox.UseVisualStyleBackColor = true;
            this.btnTextBox.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "期中考-攝氏轉華氏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 75);
            this.button2.TabIndex = 3;
            this.button2.Text = "trycatch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 75);
            this.button3.TabIndex = 4;
            this.button3.Text = "Timer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTextBox);
            this.Controls.Add(this.btnButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

