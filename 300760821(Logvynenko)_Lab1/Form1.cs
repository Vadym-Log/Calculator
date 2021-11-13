using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300760821_Logvynenko__Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
        
        double result = 0; char sign = '=';
        Boolean flag_first = true, flag_sign = false;
        int intoperation = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1_my();
        }
        private void button1_my()
        {   try        
            {
                if (flag_sign == true)
                {
                    textBox1.Text = "";
                    flag_sign = false;
                }
                if (textBox1.Text == "" || textBox1.Text.Length != 0 &&
                    (!textBox1.Text[0].Equals('0') ||
                        textBox1.Text[0].Equals('0') && textBox1.Text.Contains(".")))
                    textBox1.Text = textBox1.Text + "1";
                flag_first = false;
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2_my();
        }
        private void button2_my()
        {   try
            {
                if (flag_sign == true)
                {
                    textBox1.Text = "";
                    flag_sign = false;
                }
                if (textBox1.Text == "" || textBox1.Text.Length != 0 &&
                    (!textBox1.Text[0].Equals('0') ||
                        textBox1.Text[0].Equals('0') && textBox1.Text.Contains(".")))
                    textBox1.Text = textBox1.Text + "2";
                flag_first = false;
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3_my();
        }
        private void button3_my()
        {   try
            {
                if (flag_sign == true)
                {
                    textBox1.Text = "";
                    flag_sign = false;
                }
                if (textBox1.Text == "" || textBox1.Text.Length != 0 &&
                    (!textBox1.Text[0].Equals('0') ||
                        textBox1.Text[0].Equals('0') && textBox1.Text.Contains(".")))
                    textBox1.Text = textBox1.Text + "3";
                flag_first = false;
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4_my();
        }
        private void button4_my()
        {   try
            {
                if (flag_sign == true)
                {
                    textBox1.Text = "";
                    flag_sign = false;
                }
                if (textBox1.Text == "" || textBox1.Text.Length != 0 &&
                    (!textBox1.Text[0].Equals('0') ||
                        textBox1.Text[0].Equals('0') && textBox1.Text.Contains(".")))
                    textBox1.Text = textBox1.Text + "4";
                flag_first = false;
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5_my();
        }
        private void button5_my()
        {   try
            {
                if (flag_sign == true)
                {
                    textBox1.Text = "";
                    flag_sign = false;
                }
                if (textBox1.Text == "" || textBox1.Text.Length != 0 &&
                    (!textBox1.Text[0].Equals('0') ||
                        textBox1.Text[0].Equals('0') && textBox1.Text.Contains(".")))
                    textBox1.Text = textBox1.Text + "5";
                flag_first = false;
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6_my();
        }
        private void button6_my()
        {   try
            {
                if (flag_sign == true)
                {
                    textBox1.Text = "";
                    flag_sign = false;
                }
                if (textBox1.Text == "" || textBox1.Text.Length != 0 &&
                    (!textBox1.Text[0].Equals('0') ||
                        textBox1.Text[0].Equals('0') && textBox1.Text.Contains(".")))
                    textBox1.Text = textBox1.Text + "6";
                flag_first = false;
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7_my();
        }
        private void button7_my()
        {   try
            {
                if (flag_sign == true)
                {
                    textBox1.Text = "";
                    flag_sign = false;
                }
                if (textBox1.Text == "" || textBox1.Text.Length != 0 &&
                    (!textBox1.Text[0].Equals('0') ||
                        textBox1.Text[0].Equals('0') && textBox1.Text.Contains(".")))
                    textBox1.Text = textBox1.Text + "7";
                flag_first = false;
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8_my();
        }
        private void button8_my()
        {   try
            {
                if (flag_sign == true)
                {
                    textBox1.Text = "";
                    flag_sign = false;
                }
                if (textBox1.Text == "" || textBox1.Text.Length != 0 &&
                    (!textBox1.Text[0].Equals('0') ||
                        textBox1.Text[0].Equals('0') && textBox1.Text.Contains(".")))
                    textBox1.Text = textBox1.Text + "8";
                flag_first = false;
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9_my();
        }
        private void button9_my()
        {   try
            {
                if (flag_sign == true)
                {
                    textBox1.Text = "";
                    flag_sign = false;
                }
                if (textBox1.Text == "" || textBox1.Text.Length != 0 &&
                    (!textBox1.Text[0].Equals('0') ||
                        textBox1.Text[0].Equals('0') && textBox1.Text.Contains(".")))
                    textBox1.Text = textBox1.Text + "9";
                flag_first = false;
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10_my();
        }
        private void button10_my()
        {   try
            {
                if (flag_sign == true)
                {
                    textBox1.Text = "";
                    flag_sign = false;
                }
                if (textBox1.Text == "" || textBox1.Text.Length != 0 &&
                    (!textBox1.Text[0].Equals('0') && textBox1.Text != "-0" ||
                        textBox1.Text[0].Equals('0') && textBox1.Text.Contains(".")))
                    textBox1.Text = textBox1.Text + "0";
                flag_first = false;
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11_my();
        }
        private void button11_my()
        {   try
            {
                if (textBox1.Text != "" && !textBox1.Text.Contains(".") && textBox1.Text != "-")
                    textBox1.Text = textBox1.Text + ".";
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12_my();
        }
        private void button12_my()
        {   try
            {
                if (!flag_sign && !flag_first)
                {
                    switch (sign)
                    {
                        case '+':
                            result = result + Double.Parse(textBox1.Text);
                            break;
                        case '-':
                            result = result - Double.Parse(textBox1.Text);
                            break;
                        case '*':
                            result = result * Double.Parse(textBox1.Text);
                            break;
                        case '/':
                            result = result / Double.Parse(textBox1.Text);
                            break;
                        default:
                            if (textBox1.Text != "" && textBox1.Text != "-")
                                result = Double.Parse(textBox1.Text);
                            else result = 0;
                            break;
                    }
                    textBox1.Text = (string.Format("{0:N5}", result)).TrimEnd('0');
                    if (textBox1.Text[textBox1.Text.Length - 1].Equals('.'))
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    flag_sign = false;
                    sign = '=';
                }
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13_my();
        }
        private void button13_my()
        {   try
            {
                if (textBox1.Text != "") textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                if (textBox1.Text == "")
                {
                    result = 0;
                    flag_first = true;
                    flag_sign = false;
                    sign = '=';
                }
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14_my();
        }
        private void button14_my()
        {   try
            {
                textBox1.Text = "";
                result = 0;
                flag_first = true;
                flag_sign = false;
                sign = '=';
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15_my();
        }
        private void button15_my()
        {   try
            {
                if (textBox1.Text != "")
                {
                    if (Double.Parse(textBox1.Text) != 0)
                    {
                        result = 1 / Double.Parse(textBox1.Text);
                        textBox1.Text = (string.Format("{0:N5}", result)).TrimEnd('0');
                        if (textBox1.Text[textBox1.Text.Length - 1].Equals('.'))
                            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                        flag_sign = false;
                        sign = '=';
                    }
                }
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16_my();
        }
        private void button16_my()
        {   try
            {
                if (textBox1.Text != "")
                {
                    result = Math.Pow(Double.Parse(textBox1.Text), 2);
                    textBox1.Text = (string.Format("{0:N5}", result)).TrimEnd('0');
                    if (textBox1.Text[textBox1.Text.Length - 1].Equals('.'))
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    flag_sign = false;
                    sign = '=';
                }
            } catch { MessageBox.Show("You entered wrong data..."); }
        }

        private void button17_Click(object sender, EventArgs e)
        {            

            button17_my();
        }
        private void button17_my()
        {
            intoperation = 1;
            result = GetDelegateRef(intoperation).Invoke(result, textBox1.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18_my();
        }
        private void button18_my()
        {
            intoperation = 2;
            result = GetDelegateRef(intoperation).Invoke(result, textBox1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19_my();
        }
        private void button19_my()
        {
            intoperation = 3;
            result = GetDelegateRef(intoperation).Invoke(result, textBox1.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20_my();
        }
        private void button20_my()
        {
            intoperation = 4;
            result = GetDelegateRef(intoperation).Invoke(result, textBox1.Text);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {   
            switch (keyData)
            {
                case Keys.D1:
                    button1_my();
                    break;
                case Keys.D2:
                    button2_my();
                    break;
                case Keys.D3:
                    button3_my();
                    break;
                case Keys.D4:
                    button4_my();
                    break;
                case Keys.D5:
                    button5_my();
                    break;
                case Keys.D6:
                    button6_my();
                    break;
                case Keys.D7:
                    button7_my();
                    break;
                case Keys.D8:
                    button8_my();
                    break;
                case Keys.D9:
                    button9_my();
                    break;
                case Keys.D0:
                    button10_my();
                    break;
                case Keys.Decimal:
                    button11_my();
                    break;
                case Keys.Oemplus:
                    button12_my();
                    break;
                case Keys.Back:
                    button13_my();
                    break;
                case Keys.Escape:
                    button14_my();
                    break;
                case Keys.Add:
                    button17_my();
                    break;
                case Keys.Subtract:
                    button18_my();
                    break;
                case Keys.Multiply:
                    button19_my();
                    break;
                case Keys.Divide:
                    button20_my();
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            return true;
        }
        
        public delegate double CalculatorDelegate(double res, string text);
        CalculatorDelegate delegateObj = null;        
        public CalculatorDelegate GetDelegateRef(int oper)
        {            
            switch (oper)
            {
                case 1:
                    delegateObj = Add;
                    break;
                case 2:
                    delegateObj = Sub;
                    break;
                case 3:
                    delegateObj = Multi;
                    break;
                case 4:
                    delegateObj = Div;
                    break;
                default: break;
            }
            return delegateObj;
        }
        private double Add(double res, string text)
        {
            try
            {
                if (!flag_sign && !flag_first)
                {
                    switch (sign)
                    {
                        case '+':
                            res = res + Double.Parse(text);
                            break;
                        case '-':
                            res = res - Double.Parse(text);
                            break;
                        case '*':
                            res = res * Double.Parse(text);
                            break;
                        case '/':
                            res = res / Double.Parse(text);
                            break;
                        default:
                            if (text != "-")
                                res = Double.Parse(text);
                            break;
                    }
                    textBox1.Text = "+";
                    sign = '+';
                    flag_sign = true;
                    flag_first = false;                    
                }                
            } 
            catch { MessageBox.Show("You entered wrong data..."); }
            return res;
        }
        private double Sub(double res, string text)
        {
            try
            {
                if (!flag_sign && !flag_first)
                {
                    switch (sign)
                    {
                        case '+':
                            res = res + Double.Parse(text);
                            break;
                        case '-':
                            res = res - Double.Parse(text);
                            break;
                        case '*':
                            res = res * Double.Parse(text);
                            break;
                        case '/':
                            res = res / Double.Parse(text);
                            break;
                        default:
                            if (text != "-")
                                res = Double.Parse(text);
                            break;
                    }
                    textBox1.Text = "-";
                    sign = '-';
                    flag_sign = true;
                    flag_first = false;
                }
            }
            catch { MessageBox.Show("You entered wrong data..."); }
            return res;
        }
        private double Multi(double res, string text)
        {
            try
            {
                if (!flag_sign && !flag_first)
                {
                    switch (sign)
                    {
                        case '+':
                            res = res + Double.Parse(text);
                            break;
                        case '-':
                            res = res - Double.Parse(text);
                            break;
                        case '*':
                            res = res * Double.Parse(text);
                            break;
                        case '/':
                            res = res / Double.Parse(text);
                            break;
                        default:
                            if (text != "-")
                                res = Double.Parse(text);
                            break;
                    }
                    textBox1.Text = "*";
                    sign = '*';
                    flag_sign = true;
                    flag_first = false;
                }
            }
            catch { MessageBox.Show("You entered wrong data..."); }
            return res;
        }
        private double Div(double res, string text)
        {
            try
            {
                if (!flag_sign && !flag_first)
                {
                    switch (sign)
                    {
                        case '+':
                            res = res + Double.Parse(text);
                            break;
                        case '-':
                            res = res - Double.Parse(text);
                            break;
                        case '*':
                            res = res * Double.Parse(text);
                            break;
                        case '/':
                            res = res / Double.Parse(text);
                            break;
                        default:
                            if (text != "-")
                                res = Double.Parse(text);
                            break;
                    }
                    textBox1.Text = "/";
                    sign = '/';
                    flag_sign = true;
                    flag_first = false;
                }
            }
            catch { MessageBox.Show("You entered wrong data..."); }
            return res;
        }
    }
}
