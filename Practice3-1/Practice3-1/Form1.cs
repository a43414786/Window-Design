using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice3_1
{
    
    public partial class Form1 : Form
    {
        private List<Account> accountList = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string str = searchBox.Text,text = "";
            string[] strs = new string[accountList.Count * 4];
            int counter = 0;
            if (str.Equals(""))
            {
                foreach(Account account in accountList)
                {
                    strs[counter++] = "連結:" + account.link;
                    strs[counter++] = "使用者:" + account.user;
                    strs[counter++] = "密碼:" + account.pass;
                    strs[counter++] = "===============================";

                }
                textBox1.Lines = strs;
            }
            else
            {
                foreach (Account account in accountList)
                {
                    if(account.link.IndexOf(str) != -1)
                    {
                        strs[counter++] = "連結:" + account.link;
                        strs[counter++] = "使用者:" + account.user;
                        strs[counter++] = "密碼:" + account.pass;
                        strs[counter++] = "===============================";

                    }
                }
                textBox1.Lines = strs;
            }
        }

        private void riskyAccount_Click(object sender, EventArgs e)
        {
            string[] strs = new string[accountList.Count * 4];
            int counter = 0;
            for (int i = 0; i < accountList.Count; i++)
            {
                for (int j = 0; j < accountList.Count; j++)
                {
                    if(i != j)
                    {
                        if (accountList[i].pass.Equals(accountList[j].pass))
                        {
                            strs[counter++] = "連結:" + accountList[i].link;
                            strs[counter++] = "使用者:" + accountList[i].user;
                            strs[counter++] = "密碼:" + accountList[i].pass;
                            strs[counter++] = "===============================";
                            break;
                        }
                    }
                }
            }
            textBox1.Lines = strs;
        }

        private void addOrDel_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            searchBox.Visible = false;
            search.Enabled = false;
            riskyAccount.Enabled = false;

            back.Visible = true;
            textBox2.Visible = true;
            link.Visible = true;
            user.Visible = true;
            pass.Visible = true;
            linkBox.Visible = true;
            userBox.Visible = true;
            passBox.Visible = true;
            add.Visible = true;
            delete.Visible = true;
            status.Visible = true;
            status.ReadOnly = true;
            textBox2.ReadOnly = true;

            riskyAccount.Text = "風險密碼";
            searchBox.Text = "";
            textBox1.Text = "";

        }
        private void back_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            searchBox.Visible = true;
            search.Enabled = true;
            riskyAccount.Enabled = true;

            back.Visible = false;
            textBox2.Visible = false;
            textBox2.ReadOnly = false;
            link.Visible = false;
            user.Visible = false;
            pass.Visible = false;
            linkBox.Visible = false;
            userBox.Visible = false;
            passBox.Visible = false;
            add.Visible = false;
            delete.Visible = false;
            status.Visible = false;
            status.Text = "我是狀態列";
            linkBox.Text = "";
            userBox.Text = "";
            passBox.Text = "";
            riskyAccount.Text = "風險帳號";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            back.Visible = false;
            link.Visible = false;
            user.Visible = false;
            pass.Visible = false;
            linkBox.Visible = false;
            userBox.Visible = false;
            passBox.Visible = false;
            add.Visible = false;
            delete.Visible = false;
            status.Visible = false;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string _link, _user, _pass;
            _link = linkBox.Text;
            _user = userBox.Text;
            _pass = passBox.Text;
            if(_link.Equals("") || _user.Equals("") || _pass.Equals(""))
            {
                return;
            }
            foreach(Account account in accountList)
            {
                if(account.link.Equals(_link) && account.user.Equals(_user))
                {
                    status.Text = "帳號已存在";
                    return;
                }
            }
            accountList.Add(new Account(_link, _user, _pass));
            status.Text = "新增完成";
            linkBox.Text = "";
            userBox.Text = "";
            passBox.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string _link, _user, _pass;
            _link = linkBox.Text;
            _user = userBox.Text;
            _pass = passBox.Text;
            if (_link.Equals("") || _user.Equals("") || _pass.Equals(""))
            {
                return;
            }
            foreach (Account account in accountList)
            {
                if (account.link.Equals(_link) && account.user.Equals(_user) && account.pass.Equals(_pass))
                {
                    accountList.Remove(account);
                    status.Text = "刪除完成";
                    linkBox.Text = "";
                    userBox.Text = "";
                    passBox.Text = "";
                    return;
                }
            }
            status.Text = "帳號不存在或密碼錯誤";
            
        }
    }
    class Account
    {
        public string link, user, pass;
        public Account(string _link, string _user, string _pass)
        {
            link = _link;
            user = _user;
            pass = _pass;
        }
    }
}
