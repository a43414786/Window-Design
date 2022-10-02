namespace Practice3_1
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
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.riskyAccount = new System.Windows.Forms.Button();
            this.addOrDel = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(713, 50);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 0;
            this.search.Text = "搜索";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "密碼管理員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "搜索列";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "搜索結果";
            // 
            // riskyAccount
            // 
            this.riskyAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.riskyAccount.Location = new System.Drawing.Point(38, 87);
            this.riskyAccount.Name = "riskyAccount";
            this.riskyAccount.Size = new System.Drawing.Size(750, 23);
            this.riskyAccount.TabIndex = 5;
            this.riskyAccount.Text = "風險帳號";
            this.riskyAccount.UseVisualStyleBackColor = false;
            this.riskyAccount.Click += new System.EventHandler(this.riskyAccount_Click);
            // 
            // addOrDel
            // 
            this.addOrDel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addOrDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOrDel.Location = new System.Drawing.Point(634, 130);
            this.addOrDel.Name = "addOrDel";
            this.addOrDel.Size = new System.Drawing.Size(154, 23);
            this.addOrDel.TabIndex = 6;
            this.addOrDel.Text = "新增或刪除";
            this.addOrDel.UseVisualStyleBackColor = false;
            this.addOrDel.Click += new System.EventHandler(this.addOrDel_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(83, 50);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(624, 22);
            this.searchBox.TabIndex = 7;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 173);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(750, 273);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(669, 22);
            this.textBox2.TabIndex = 9;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Location = new System.Drawing.Point(634, 130);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(154, 23);
            this.back.TabIndex = 10;
            this.back.Text = "回主畫面";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(199, 210);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(445, 22);
            this.status.TabIndex = 11;
            this.status.Text = "我是狀態列";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(197, 254);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(29, 12);
            this.link.TabIndex = 12;
            this.link.Text = "連結";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(197, 293);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(41, 12);
            this.user.TabIndex = 13;
            this.user.Text = "使用者";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(197, 332);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(29, 12);
            this.pass.TabIndex = 14;
            this.pass.Text = "密碼";
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(256, 251);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(388, 22);
            this.linkBox.TabIndex = 15;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(256, 290);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(388, 22);
            this.userBox.TabIndex = 16;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(256, 329);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(388, 22);
            this.passBox.TabIndex = 17;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(458, 394);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 23);
            this.add.TabIndex = 18;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(554, 394);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 23);
            this.delete.TabIndex = 19;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.link);
            this.Controls.Add(this.status);
            this.Controls.Add(this.back);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.addOrDel);
            this.Controls.Add(this.riskyAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button riskyAccount;
        private System.Windows.Forms.Button addOrDel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
    }
}

