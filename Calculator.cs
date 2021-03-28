using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void disable()//disable calculator
        {
            richTextBox1.Enabled = false;
            button6.Show();
     
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button26.Enabled = false;
            button14.Enabled = false;
            button19.Enabled = false;
            button24.Enabled = false;
            button28.Enabled = false;
            button27.Enabled = false;
            button25.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
        }
            public void enable()
        {
            richTextBox1.Enabled = true;
           
            button1.Show();
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button26.Enabled = true;
            button14.Enabled = true;
            button19.Enabled = true;
            button24.Enabled = true;
            button28.Enabled = true;
            button27.Enabled = true;
            button25.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
        }
        float ans;
        float num;
      int count;
        public void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(richTextBox1.Text);
                    richTextBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(richTextBox1.Text);
                    richTextBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(richTextBox1.Text);
                    richTextBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(richTextBox1.Text);
                    richTextBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
          
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 7;
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 8;
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 9;
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 4;
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 5;
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 6;
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 1;
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 2;
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 3;
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 0;
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            richTextBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            richTextBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            num = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            richTextBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            num = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            richTextBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ".";
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            label1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int length = richTextBox1.TextLength - 1;
            string text = richTextBox1.Text;
            richTextBox1.Clear();
            for (int x = 0; x < length; x++)
                richTextBox1.Text = richTextBox1.Text + text[x];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
