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
        private bool isTake = true;
        private int selectedStack = 0;
        private Game game;
        private Form1 form1;
        private void setButtonText(string s)
        {
            button1.Text = s;
            button2.Text = s;
            button3.Text = s;
            button4.Text = s;
        }
        private void enabledAll(bool b)
        {
            button1.Enabled = b;
            button2.Enabled = b;
            button3.Enabled = b;
            button4.Enabled = b;
        }
        private void buttonPress(int stackIdx)
        {
            if (isTake)
            {
                setButtonText("放置");
                isTake = !isTake;
                selectedStack = stackIdx;
                textBox5.Text = "你選了堆疊" + (stackIdx + 1);
            }
            else
            {
                setButtonText("選取");
                isTake = !isTake;
                game.move(selectedStack, stackIdx);
                textBox5.Text = "...";
            }
        }
        private void refresh()
        {
            textBox1.Lines = game.output(0);
            textBox2.Lines = game.output(1);
            textBox3.Lines = game.output(2);
            textBox4.Lines = game.output(3);
            if (isTake)
            {
                if (game.cantake(0)) button1.Enabled = true;
                else button1.Enabled = false;
                if (game.cantake(1)) button2.Enabled = true;
                else button2.Enabled = false;
                if (game.cantake(2)) button3.Enabled = true;
                else button3.Enabled = false;
                if (game.cantake(3)) button4.Enabled = true;
                else button4.Enabled = false;
            }
            else
            {
                if (game.canplace(0)) button1.Enabled = true;
                else button1.Enabled = false;
                if (game.canplace(1)) button2.Enabled = true;
                else button2.Enabled = false;
                if (game.canplace(2)) button3.Enabled = true;
                else button3.Enabled = false;
                if (game.canplace(3)) button4.Enabled = true;
                else button4.Enabled = false;
            }
            if (game.win())
            {
                textBox5.Text = "你贏了";
                setButtonText("贏");
                enabledAll(false);
            }
        }
        public void Init()
        {
            game = form1.game;
            setButtonText("選取");
            textBox5.Text = "...";
            enabledAll(true);
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
            buttonPress(0);
            refresh();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            buttonPress(1);
            refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonPress(2);
            refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonPress(3);
            refresh();
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
            form1.init();
        }
    }
}
