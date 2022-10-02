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
    
    public partial class Form2 : Form
    {
        private Form1 form1;
        private string[] stack2StrArr(List<int> stack)
        {
            int length = 21,counter = 0;
            int num = length - stack.Count;
            string[] strArr = new string[length];
            for(int i = 0; i < num; i++)
            {
                strArr[i] = "";
            }
            for(int i = length - 1; i >= num; i--)
            {
                strArr[i] = stack[counter++].ToString();
            }
            return strArr;
        }
        private void refresh()
        {
            textBox1.Lines = stack2StrArr(form1.game.getStacks()[0]);
            textBox2.Lines = stack2StrArr(form1.game.getStacks()[1]);
            textBox3.Lines = stack2StrArr(form1.game.getStacks()[2]);
            textBox4.Lines = stack2StrArr(form1.game.getStacks()[3]);
        }
        public void Init()
        {
            refresh();
        }
        public Form2(Form1 _form1)
        {
            form1 = _form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }
    }
}
