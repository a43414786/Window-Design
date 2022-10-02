using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice3_2
{

    
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Game game;
        
        private int[] getStack(string s)
        {
            int[] stack = new int[5];
            if (s.Equals(""))
            {
                stack[4] = 0;
                return stack;
            }
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    try
                    {
                        stack[counter++] = int.Parse(s[i].ToString());
                        if (counter == 5) return null;
                    }
                    catch
                    {
                        return null;
                    }
                }
                else
                {
                    if (s[i] != ' ')
                    {
                        return null;
                    }
                    if (i == s.Length - 1) return null;
                }
            }
            stack[4] = counter;
            return stack;
        }
        private void init()
        {
            message.Text = "請輸入測資";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            form2.Hide();
            init();
        }

        private void start_Click(object sender, EventArgs e)
        {
            int[] intStack1 = null;
            int[] intStack2 = null;
            int[] intStack3 = null;
            int[] intStack4 = null;

            string stack1 = stackBox1.Text;
            string stack2 = stackBox2.Text;
            string stack3 = stackBox3.Text;
            string stack4 = stackBox4.Text;

            intStack1 = getStack(stack1);
            intStack2 = getStack(stack2);
            intStack3 = getStack(stack3);
            intStack4 = getStack(stack4);

            if (intStack1 == null || intStack2 == null || intStack3 == null || intStack4 == null)
            {
                message.Text = "測資錯誤";
            }
            else
            {
                game = new Game(intStack1, intStack2, intStack3, intStack4);
                form2.Init();
                this.Hide();
                form2.Show();
            }

            
            
        }
    }
}
