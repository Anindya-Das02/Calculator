using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Creator: Anindya Das
    App Name: C# Calculator
    email: anindyadasofficial@gmail.com
    twitter: @dasanindya98

*/
namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonDigit0_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += "0";
        }

        private void ButtonDigit1_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += "1";
        }

        private void ButtonDigit2_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += "2";
        }

        private void ButtonDigit3_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += "3";
        }

        private void ButtonDigit4_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += "4";
        }

        private void ButtonDigit5_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += "5";
        }

        private void ButtonDigit6_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += "6";
        }

        private void ButtonDigit7_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += "7";
        }

        private void ButtonDigit8_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += "8";
        }

        private void ButtonDigit9_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += "9";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = "";
            OutputResult.Text = "";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(InputTextBox.Text.Length !=0)
            {
                if(InputTextBox.Text.Length < 3)
                {
                    InputTextBox.Text += " + ";
                }
                else
                {
                    string  ts = InputTextBox.Text;
                    ts = ts.Trim();
                    if(LastCharValid(ts[ts.Length - 1]))
                    {
                        InputTextBox.Text += " + ";
                    }
                }
            }
        }

        private void ButtonSubtract_Click(object sender, EventArgs e)
        {
            if(InputTextBox.Text.Length == 0)
            {
                InputTextBox.Text = "0 - ";
            }
            else
            {
                string ts = InputTextBox.Text;
                ts = ts.Trim();
                if (LastCharValid(ts[ts.Length - 1]))
                {
                    InputTextBox.Text = "0 - ";
                }
            }
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text.Length != 0)
            {
                if (InputTextBox.Text.Length < 3)
                {
                    // just add sign
                    InputTextBox.Text += " x ";
                }
                else
                {
                    string ts = InputTextBox.Text;
                    ts = ts.Trim();
                    if (LastCharValid(ts[ts.Length - 1]))
                    {
                        InputTextBox.Text += " x ";
                    }
                }
            }
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text.Length != 0)
            {
                if (InputTextBox.Text.Length < 3)
                {
                    // just add sign
                    InputTextBox.Text += " / ";
                }
                else
                {
                    string ts = InputTextBox.Text.Trim();
                    if (LastCharValid(ts[ts.Length - 1]))
                    {
                        InputTextBox.Text += " / ";
                    }
                }
            }
        }

        private void ButtonOpenBracket_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += " ( ";
        }

        private void ButtonCloseBracket_Click(object sender, EventArgs e)
        {
            InputTextBox.Text += " ) ";
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                InputTextBox.Text = InputTextBox.Text.Remove(InputTextBox.Text.Length - 1, 1);
            }
            catch (Exception)
            {
                InputTextBox.Text = "";
            }
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (IsDotValid(InputTextBox.Text))
            {
                InputTextBox.Text += ".";
            }
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            string queryExpression = InputTextBox.Text;
            InputTextBox.Text = Calculate(queryExpression);
            if(InputTextBox.Text.ToLower() != "math error!")
            {
                OutputResult.Text = queryExpression;
            }
        }

        //=================================================================================================
        //=================================================================================================
        //   My Own Code/functions Below
        //=================================================================================================
        //=================================================================================================

        /*
         *  LastCharValid(char) : return boolean
         *  receives char and checks if the last-character is not any of [+ - / x .]
         *  eg. if expression is "12 +" the last char is '+' so do not let the user enter any new operator [+ - / x .]
         */
        private bool LastCharValid(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                case '/':
                case 'x':
                case '.':
                    return false;
            }
            return true;
        }

        private bool IsDotValid(string s)
        {
            // split the string based on whitespace
            // eg if the expression is "12.03 + 12.33"
            // srr: [12.03, +, 12.33]
            // therefore the current-expression is "12.33"
            string[] srr = s.Trim().Split(' ');
            string current_exp = srr[srr.Length - 1];

            //  if '.' found in current expression | eg 12.33
            //  so do not let new '.' add in InputTextBox
            //  if '.' found -> return false;
            if (Regex.IsMatch(current_exp, @"(\.)+"))
            {
                return false;
            }

            // else if current expression is not '.'
            // then it is a symbol [+ - x / ( )]
            // check if last char. is not [+ - x / ( )]
            // it checks for a match of [+ - x / ( )] in the current-expression
            // if not any of [+ - x / ( )] -> add '.' to current-expression -> return true
            // else do not add '.' to current-expression -> return false
            else if (Regex.IsMatch(current_exp,@"(\+|x|/|\-|\(|\))+"))
            {
                return LastCharValid(Convert.ToChar(current_exp));
            }
            return true;
        }


        /*
        //=================================================
        //      ****   Calculate the result   ****
        //  Calculate(string expression) : returns string
        //  convert expression -> postfix notation -> evaluate postfix expression -> answer -> return answer
        //=================================================
        */
        private string Calculate(string s)
        {
            s = s.Trim();
            string[] arr = s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>();
            string postfix = "";
            
            foreach (string i in arr)
            {
                if (double.TryParse(i, out _)) // check if 'i' is a number
                {
                    postfix += " " + i + " ";
                }
                else if (i == "(")
                {
                    stack.Push(i);
                }
                else if (i == ")")
                {
                    while (stack.Count != 0 && stack.Peek() != "(")
                    {
                        postfix += " " + stack.Pop() + " ";
                    }
                    stack.Pop();
                }
                else
                {
                    while (stack.Count != 0 && Priority(i) <= Priority(stack.Peek()))
                    {
                        postfix += " " + stack.Pop() + " ";
                    }
                    stack.Push(i);
                }
            }
            while (stack.Count != 0)
            {
                postfix += " " + stack.Pop() + " ";
            }
            bool math_error = false;
            Stack<double> ns = new Stack<double>();
            string[] postfix_exp = postfix.Trim().Split(' ');
            foreach (string str in postfix_exp)
            {
                try
                {
                    if (double.TryParse(str, out _))
                    {
                        ns.Push(Convert.ToDouble(str));
                    }
                    else if (str == "+")
                    {
                        double v1 = ns.Pop();
                        double v2 = ns.Pop();
                        ns.Push(v1 + v2);
                    }
                    else if (str == "-")
                    {
                        double v1 = ns.Pop();
                        double v2 = ns.Pop();
                        ns.Push(v2 - v1);
                    }
                    else if (str == "x")
                    {
                        double v1 = ns.Pop();
                        double v2 = ns.Pop();
                        ns.Push(v1 * v2);
                    }
                    else if (str == "/")
                    {
                        double v1 = ns.Pop();
                        double v2 = ns.Pop();
                        if (v1 == 0)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            double r = v2 / v1;
                            ns.Push(r);
                        }
                    }
                }
                catch (Exception _)
                {
                    math_error = true;
                }
            }

            string resultString;
            if (!math_error)
            {
                double result = ns.Pop();
                resultString = Convert.ToString(result);
            }
            else
            {
                resultString = "Math Error!";
            }

            return resultString;
        }

        private int Priority(String c)
        {
            switch (c)
            {
                case "+":
                case "-":
                    return 1;
                case "x":
                case "/":
                    return 2;
            }
            return -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}