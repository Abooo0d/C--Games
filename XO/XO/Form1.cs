using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int x = 0, o = 0, m = 0, n = 0, w = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Trim() != "")
            {
            }
            else if (button1.Text.Trim() == "")
            {
                if (w % 2 == 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button1.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button1.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                else if (w % 2 != 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button1.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button1.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                a++;
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    button1.BackColor = Color.MediumSlateBlue;
                    button2.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.BackColor = Color.MediumSlateBlue;
                    button2.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    button1.BackColor = Color.MediumSlateBlue;
                    button4.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.BackColor = Color.MediumSlateBlue;
                    button4.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    button1.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text.Trim() != "" && button2.Text.Trim() != "" && button3.Text.Trim() != "" && button4.Text.Trim() != "" && button5.Text.Trim() != "" && button6.Text.Trim() != "" && button7.Text.Trim() != "" && button8.Text.Trim() != "" && button9.Text.Trim() != "")
                {
                    MessageBox.Show("Drwe", "Drow");
                    w++;
                    label3.Text = w.ToString();
                }
                else
                {
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Trim() != "")
            {
            }
            else if (button2.Text.Trim() == "")
            {
                if (w % 2 == 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button2.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button2.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                else if (w % 2 != 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button2.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button2.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                a++;
                if (button2.Text == "X" && button1.Text == "X" && button3.Text == "X")
                {
                    button2.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button2.Text == "O" && button1.Text == "O" && button3.Text == "O")
                {
                    button2.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    button2.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button8.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button2.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button8.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text.Trim() != "" && button2.Text.Trim() != "" && button3.Text.Trim() != "" && button4.Text.Trim() != "" && button5.Text.Trim() != "" && button6.Text.Trim() != "" && button7.Text.Trim() != "" && button8.Text.Trim() != "" && button9.Text.Trim() != "")
                {
                    MessageBox.Show("Drwe", "Drow");
                    w++;
                    label3.Text = w.ToString();
                }
                else
                {
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text.Trim() != "")
            {
            }
            if (button3.Text.Trim() == "")
            {
                if (w % 2 == 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button3.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button3.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                else if (w % 2 != 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button3.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button3.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                a++;
                if (button3.Text == "X" && button2.Text == "X" && button1.Text == "X")
                {
                    button3.BackColor = Color.MediumSlateBlue;
                    button2.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button3.Text == "O" && button2.Text == "O" && button1.Text == "O")
                {
                    button3.BackColor = Color.MediumSlateBlue;
                    button2.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    button3.BackColor = Color.MediumSlateBlue;
                    button6.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button3.BackColor = Color.MediumSlateBlue;
                    button6.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    button3.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button3.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text.Trim() != "" && button2.Text.Trim() != "" && button3.Text.Trim() != "" && button4.Text.Trim() != "" && button5.Text.Trim() != "" && button6.Text.Trim() != "" && button7.Text.Trim() != "" && button8.Text.Trim() != "" && button9.Text.Trim() != "")
                {
                    MessageBox.Show("Drwe", "Drow");
                    w++;
                    label3.Text = w.ToString();
                }
                else
                {
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text.Trim() != "")
            {
            }
            else if (button4.Text.Trim() == "")
            {
                if (w % 2 == 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button4.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button4.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                else if (w % 2 != 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button4.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button4.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                a++;
                if (button4.Text == "X" && button1.Text == "X" && button7.Text == "X")
                {
                    button4.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button4.Text == "O" && button1.Text == "O" && button7.Text == "O")
                {
                    button4.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    button4.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button6.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button4.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text.Trim() != "" && button2.Text.Trim() != "" && button3.Text.Trim() != "" && button4.Text.Trim() != "" && button5.Text.Trim() != "" && button6.Text.Trim() != "" && button7.Text.Trim() != "" && button8.Text.Trim() != "" && button9.Text.Trim() != "")
                {
                    MessageBox.Show("Drwe", "Drow");
                    w++;
                    label3.Text = w.ToString();
                }
                else
                {
                }
            }
        }
        private void button5_Click(object sender, EventArgs e4)
        {
            if (button5.Text.Trim() != "")
            {
            }
            else if (button5.Text.Trim() == "")
            {
                if (w % 2 == 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button5.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button5.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                else if (w % 2 != 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button5.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button5.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                a++;
                if (button5.Text == "X" && button6.Text == "X" && button4.Text == "X")
                {
                    button5.BackColor = Color.MediumSlateBlue;
                    button6.BackColor = Color.MediumSlateBlue;
                    button4.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button5.Text == "O" && button6.Text == "O" && button4.Text == "O")
                {
                    button5.BackColor = Color.MediumSlateBlue;
                    button6.BackColor = Color.MediumSlateBlue;
                    button4.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button5.Text == "X" && button8.Text == "X" && button2.Text == "X")
                {
                    button5.BackColor = Color.MediumSlateBlue;
                    button8.BackColor = Color.MediumSlateBlue;
                    button2.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button5.Text == "O" && button8.Text == "O" && button2.Text == "O")
                {
                    button5.BackColor = Color.MediumSlateBlue;
                    button8.BackColor = Color.MediumSlateBlue;
                    button2.BackColor = Color.MediumSlateBlue;
                    n++;
                    w++;
                    label3.Text = w.ToString();
                    label2.Text = n.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button5.Text == "X" && button9.Text == "X" && button1.Text == "X")
                {
                    button5.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "O")
                {
                    button5.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button5.Text == "X" && button7.Text == "X" && button3.Text == "X")
                {
                    button5.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button5.Text == "O" && button7.Text == "O" && button3.Text == "O")
                {
                    button5.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text.Trim() != "" && button2.Text.Trim() != "" && button3.Text.Trim() != "" && button4.Text.Trim() != "" && button5.Text.Trim() != "" && button6.Text.Trim() != "" && button7.Text.Trim() != "" && button8.Text.Trim() != "" && button9.Text.Trim() != "")
                {
                    MessageBox.Show("Drwe", "Drow");
                    w++;
                    label3.Text = w.ToString();
                }
                else
                {
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text.Trim() != "")
            {
            }
            else if (button6.Text.Trim() == "")
            {
                if (w % 2 == 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button6.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button6.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                else if (w % 2 != 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button6.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button6.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                a++;
                if (button6.Text == "X" && button9.Text == "X" && button3.Text == "X")
                {
                    button6.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "O")
                {
                    button6.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button6.Text == "X" && button5.Text == "X" && button4.Text == "X")
                {
                    button6.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button4.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button6.Text == "O" && button5.Text == "O" && button4.Text == "O")
                {
                    button6.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button4.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text.Trim() != "" && button2.Text.Trim() != "" && button3.Text.Trim() != "" && button4.Text.Trim() != "" && button5.Text.Trim() != "" && button6.Text.Trim() != "" && button7.Text.Trim() != "" && button8.Text.Trim() != "" && button9.Text.Trim() != "")
                {
                    MessageBox.Show("Drwe", "Drow");
                    w++;
                    label3.Text = w.ToString();
                }
                else
                {
                }
            }
        }        
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text.Trim() != "")
            {
            }
            else if (button7.Text.Trim()=="")
            {
                if (w % 2 == 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button7.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button7.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                else if (w % 2 != 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button7.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button7.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                a++;
                if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    button7.BackColor = Color.MediumSlateBlue;
                    button8.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button7.BackColor = Color.MediumSlateBlue;
                    button8.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button7.Text == "X" && button4.Text == "X" && button1.Text == "X")
                {
                    button7.BackColor = Color.MediumSlateBlue;
                    button4.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button7.Text == "O" && button4.Text == "O" && button1.Text == "O")
                {
                    button7.BackColor = Color.MediumSlateBlue;
                    button4.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                }
                else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    button7.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    button7.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text.Trim() != "" && button2.Text.Trim() != "" && button3.Text.Trim() != "" && button4.Text.Trim() != "" && button5.Text.Trim() != "" && button6.Text.Trim() != "" && button7.Text.Trim() != "" && button8.Text.Trim() != "" && button9.Text.Trim() != "")
                {
                    MessageBox.Show("Drwe", "Drow");
                    w++;
                    label3.Text = w.ToString();
                }
                else
                {
                }
            }
        }        
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text.Trim() != "")
            {
            }
            else if (button8.Text.Trim() == "")
            {
                if (w % 2 == 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button8.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button8.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                else if (w % 2 != 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button8.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button8.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                a++;
                if (button8.Text == "X" && button9.Text == "X" && button7.Text == "X")
                {
                    button8.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "O")
                {
                    button8.BackColor = Color.MediumSlateBlue;
                    button9.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button8.Text == "X" && button5.Text == "X" && button2.Text == "X")
                {
                    button8.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button2.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button8.Text == "O" && button5.Text == "O" && button2.Text == "O")
                {
                    button8.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button2.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text.Trim() != "" && button2.Text.Trim() != "" && button3.Text.Trim() != "" && button4.Text.Trim() != "" && button5.Text.Trim() != "" && button6.Text.Trim() != "" && button7.Text.Trim() != "" && button8.Text.Trim() != "" && button9.Text.Trim() != "")
                {
                    MessageBox.Show("Drwe", "Drow");
                    w++;
                    label3.Text = w.ToString();
                }
                else
                {
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text.Trim() != "")
            {
            }
            else if (button9.Text.Trim() == "")
            {
                if (w % 2 == 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button9.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button9.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                else if (w % 2 != 0)
                {
                    if (a <= 9)
                    {
                        if (a % 2 == 0)
                        {
                            button9.Text = "O";
                            o++;
                            textBox1.BackColor = Color.MediumSlateBlue;
                            textBox2.BackColor = Color.White;
                        }
                        else if (a % 2 != 0)
                        {
                            button9.Text = "X";
                            x++;
                            textBox2.BackColor = Color.MediumSlateBlue;
                            textBox1.BackColor = Color.White;
                        }
                    }
                    else { }
                }
                a++;
                if (button9.Text == "X" && button8.Text == "X" && button7.Text == "X")
                {
                    button9.BackColor = Color.MediumSlateBlue;
                    button8.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button9.Text == "O" && button8.Text == "O" && button7.Text == "O")
                {
                    button9.BackColor = Color.MediumSlateBlue;
                    button8.BackColor = Color.MediumSlateBlue;
                    button7.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button9.Text == "X" && button6.Text == "X" && button3.Text == "X")
                {
                    button9.BackColor = Color.MediumSlateBlue;
                    button6.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button9.Text == "O" && button6.Text == "O" && button3.Text == "O")
                {
                    button9.BackColor = Color.MediumSlateBlue;
                    button6.BackColor = Color.MediumSlateBlue;
                    button3.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button9.Text == "X" && button5.Text == "X" && button1.Text == "X")
                {
                    button9.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    m++;
                    label1.Text = m.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox1.BackColor = Color.MediumSlateBlue;
                    textBox2.BackColor = Color.White;
                    MessageBox.Show(textBox1.Text + " Winner", "Winner");

                }
                else if (button9.Text == "O" && button5.Text == "O" && button1.Text == "O")
                {
                    button9.BackColor = Color.MediumSlateBlue;
                    button5.BackColor = Color.MediumSlateBlue;
                    button1.BackColor = Color.MediumSlateBlue;
                    n++;
                    label2.Text = n.ToString();
                    w++;
                    label3.Text = w.ToString();
                    textBox2.BackColor = Color.MediumSlateBlue;
                    textBox1.BackColor = Color.White;
                    MessageBox.Show(textBox2.Text + " Winner", "Winner");

                }
                else if (button1.Text.Trim() != "" && button2.Text.Trim() != "" && button3.Text.Trim() != "" && button4.Text.Trim() != "" && button5.Text.Trim() != "" && button6.Text.Trim() != "" && button7.Text.Trim() != "" && button8.Text.Trim() != "" && button9.Text.Trim() != "")
                {
                    MessageBox.Show("Drwe", "Drow");
                    w++;
                    label3.Text = w.ToString();
                }
                else
                {
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
            }
            else if (checkBox2.Checked == true)
            {
                button1.BackColor = Color.Firebrick;
                button2.BackColor = Color.Firebrick;
                button3.BackColor = Color.Firebrick;
                button4.BackColor = Color.Firebrick;
                button5.BackColor = Color.Firebrick;
                button6.BackColor = Color.Firebrick;
                button7.BackColor = Color.Firebrick;
                button8.BackColor = Color.Firebrick;
                button9.BackColor = Color.Firebrick;
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
            }
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            a = 0;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                this.BackColor = Color.Firebrick;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                button1.BackColor = Color.Firebrick;
                button2.BackColor = Color.Firebrick;
                button3.BackColor = Color.Firebrick;
                button4.BackColor = Color.Firebrick;
                button5.BackColor = Color.Firebrick;
                button6.BackColor = Color.Firebrick;
                button7.BackColor = Color.Firebrick;
                button8.BackColor = Color.Firebrick;
                button9.BackColor = Color.Firebrick;
                button10.BackColor = Color.Firebrick;
                this.BackColor = Color.Gray;
            }
        }
    }
}
    


