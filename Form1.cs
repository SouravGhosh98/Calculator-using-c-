using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class Form1 : Form
    {
        double EnterFirstValue , EnterSecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNums(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (textresult.Text=="0")
                textresult.Text=" ";
            { if(num.Text == ".")
                {
                    if(!textresult.Text.Contains("."))
                    {
                        textresult.Text= textresult.Text + num.Text;
                    }
                }
            else
                {
                    textresult.Text = textresult.Text + num.Text;
                }

            }

        }

        private void NumberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            EnterFirstValue = double.Parse(textresult.Text);
            op= num.Text;
            textresult.Text = "";
        }

        private void btneqal_click(object sender, EventArgs e)
        {
            EnterSecondValue = Convert.ToDouble(textresult.Text);
            switch (op)
            {
                case "+":
                    textresult.Text = (EnterFirstValue + EnterSecondValue).ToString();
                    break;
                case "-":
                    textresult.Text = (EnterFirstValue - EnterSecondValue).ToString();
                    break;
                case "*":
                    textresult.Text = (EnterFirstValue * EnterSecondValue).ToString();
                    break;
                case "/":
                    textresult.Text = (EnterFirstValue / EnterSecondValue).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textresult.Text = "0";
            string f, s;
            f=Convert.ToString(EnterFirstValue);
            s= Convert.ToString(EnterSecondValue);
            f = "";
            s = "";
        }

        private void btnpm_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(textresult.Text);
            textresult.Text = Convert.ToString(-1* q);

        }

        private void btnbs_Click(object sender, EventArgs e)
        {
            if(textresult.Text.Length > 0)
            {
                textresult.Text = textresult.Text.Remove(textresult.Text.Length - 1 , 1);
            }
        }

        private void btnclearentry_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textresult.Text);

            if (number > 0)
            {
                double sqrtResult = Math.Sqrt(number);
                textresult.Text = sqrtResult.ToString();
            }
            else
            {
                textresult.Text = "0";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 440;
            textresult.Width = 400;
        }
    }
}
