namespace Practice3_2
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
            this.start = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.stack1 = new System.Windows.Forms.Label();
            this.stack2 = new System.Windows.Forms.Label();
            this.stack3 = new System.Windows.Forms.Label();
            this.stack4 = new System.Windows.Forms.Label();
            this.stackBox2 = new System.Windows.Forms.TextBox();
            this.stackBox4 = new System.Windows.Forms.TextBox();
            this.stackBox3 = new System.Windows.Forms.TextBox();
            this.stackBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Font = new System.Drawing.Font("新細明體", 14F);
            this.start.Location = new System.Drawing.Point(122, 254);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(116, 39);
            this.start.TabIndex = 0;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(14, 32);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Size = new System.Drawing.Size(308, 42);
            this.message.TabIndex = 1;
            // 
            // stack1
            // 
            this.stack1.AutoSize = true;
            this.stack1.Font = new System.Drawing.Font("新細明體", 12F);
            this.stack1.Location = new System.Drawing.Point(12, 93);
            this.stack1.Name = "stack1";
            this.stack1.Size = new System.Drawing.Size(48, 16);
            this.stack1.TabIndex = 2;
            this.stack1.Text = "堆疊1";
            // 
            // stack2
            // 
            this.stack2.AutoSize = true;
            this.stack2.Font = new System.Drawing.Font("新細明體", 12F);
            this.stack2.Location = new System.Drawing.Point(12, 126);
            this.stack2.Name = "stack2";
            this.stack2.Size = new System.Drawing.Size(48, 16);
            this.stack2.TabIndex = 3;
            this.stack2.Text = "堆疊2";
            // 
            // stack3
            // 
            this.stack3.AutoSize = true;
            this.stack3.Font = new System.Drawing.Font("新細明體", 12F);
            this.stack3.Location = new System.Drawing.Point(12, 164);
            this.stack3.Name = "stack3";
            this.stack3.Size = new System.Drawing.Size(48, 16);
            this.stack3.TabIndex = 4;
            this.stack3.Text = "堆疊3";
            // 
            // stack4
            // 
            this.stack4.AutoSize = true;
            this.stack4.Font = new System.Drawing.Font("新細明體", 12F);
            this.stack4.Location = new System.Drawing.Point(12, 206);
            this.stack4.Name = "stack4";
            this.stack4.Size = new System.Drawing.Size(48, 16);
            this.stack4.TabIndex = 5;
            this.stack4.Text = "堆疊4";
            // 
            // stackBox2
            // 
            this.stackBox2.Location = new System.Drawing.Point(81, 126);
            this.stackBox2.Name = "stackBox2";
            this.stackBox2.Size = new System.Drawing.Size(241, 22);
            this.stackBox2.TabIndex = 6;
            // 
            // stackBox4
            // 
            this.stackBox4.Location = new System.Drawing.Point(81, 206);
            this.stackBox4.Name = "stackBox4";
            this.stackBox4.Size = new System.Drawing.Size(241, 22);
            this.stackBox4.TabIndex = 7;
            // 
            // stackBox3
            // 
            this.stackBox3.Location = new System.Drawing.Point(81, 164);
            this.stackBox3.Name = "stackBox3";
            this.stackBox3.Size = new System.Drawing.Size(241, 22);
            this.stackBox3.TabIndex = 8;
            // 
            // stackBox1
            // 
            this.stackBox1.Location = new System.Drawing.Point(81, 90);
            this.stackBox1.Name = "stackBox1";
            this.stackBox1.Size = new System.Drawing.Size(241, 22);
            this.stackBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 305);
            this.Controls.Add(this.stackBox1);
            this.Controls.Add(this.stackBox3);
            this.Controls.Add(this.stackBox4);
            this.Controls.Add(this.stackBox2);
            this.Controls.Add(this.stack4);
            this.Controls.Add(this.stack3);
            this.Controls.Add(this.stack2);
            this.Controls.Add(this.stack1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label stack1;
        private System.Windows.Forms.Label stack2;
        private System.Windows.Forms.Label stack3;
        private System.Windows.Forms.Label stack4;
        private System.Windows.Forms.TextBox stackBox2;
        private System.Windows.Forms.TextBox stackBox4;
        private System.Windows.Forms.TextBox stackBox3;
        private System.Windows.Forms.TextBox stackBox1;
    }
}

