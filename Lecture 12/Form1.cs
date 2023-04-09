using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_12
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void my_event_handler(object sender, EventArgs e)

        {
            Button button = (Button)sender;
            textBox_Result.Text =  ((Button)sender).Text; // I cast the sender into a Button
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn0.Click += new EventHandler(my_event_handler);
            btn1.Click += new EventHandler(my_event_handler);
            btn2.Click += new EventHandler(my_event_handler);
            btn3.Click += new EventHandler(my_event_handler);
            btn4.Click += new EventHandler(my_event_handler);
            btn5.Click += new EventHandler(my_event_handler);
            btn6.Click += new EventHandler(my_event_handler);
            btn7.Click += new EventHandler(my_event_handler);
            btn8.Click += new EventHandler(my_event_handler);
            btn9.Click += new EventHandler(my_event_handler);
            btnPlus.Click += new EventHandler(my_event_handler);
            btnMinus.Click += new EventHandler(my_event_handler);
            btnMulti.Click += new EventHandler(my_event_handler);
            btnDivision.Click += new EventHandler(my_event_handler);
            btnEqual.Click += new EventHandler(my_event_handler);

        }
        private void button_click(object sender, EventArgs e)
        {

            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;

            }
            else
                textBox_Result.Text = textBox_Result.Text + button.Text;
        }
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }

   

        // You are required to create a simple calculator based on this project
        // The calculator must provide the following operations:
        // Adding +, Subtracting -, Multiplication *, Division /
    }
}
