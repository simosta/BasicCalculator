using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double change_sign, first, second, result;
        string operation, first_num, second_num;

        public Form1()
        {
            InitializeComponent();
        }

        // Skaitmenų atvaizdavimas ekrane
        private void num1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
            //labelis, kuris parodo kokie veiksmai dabar atliekami ar koks prieš tai sk buvo įvestas
            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "0";
            }

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",") == false)
            {
                textBox1.Text = textBox1.Text + ",";
            }

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void pos_neg_Click(object sender, EventArgs e)
        {
            change_sign = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(0 - change_sign);

            if (first_num != null)
            {
                operations_label.Text = first_num + " " + operation + " " + textBox1.Text;
            }
            else
            {
                operations_label.Text = textBox1.Text;
            }
        }

        private void suma_Click(object sender, EventArgs e)
        {
            first_num = textBox1.Text;
            first = Convert.ToDouble(first_num);
            operation = "+";
            textBox1.Text = "0";
            operations_label.Text = first_num + " " + operation + " ";
        }



        private void minus_Click(object sender, EventArgs e)
        {
            first_num = textBox1.Text;
            first = Convert.ToDouble(first_num);
            operation = "-";
            textBox1.Text = "0";
            operations_label.Text = first_num + " " + operation + " ";
        }

        private void Clear_entry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            operations_label.Text = "";
            first = 0;
            second = 0;
            first_num = null;
            second_num = null;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            first_num = textBox1.Text;
            first = Convert.ToDouble(first_num);
            operation = "*";
            textBox1.Text = "0";
            operations_label.Text = first_num + " " + operation + " ";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            first_num = textBox1.Text;
            first = Convert.ToDouble(first_num);
            operation = "/";
            textBox1.Text = "0";
            operations_label.Text = first_num + " " + operation + " ";
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            second_num = textBox1.Text;
            second = Convert.ToDouble(second_num);
            operations_label.Text = first_num + " " + operation + " " + second_num + " = ";
            switch (operation)
            {
                case "+":
                    result = first + second;
                    textBox1.Text = Convert.ToString(result);
                    first = result;
                    break;
                case "-":
                    result = first - second;
                    textBox1.Text = Convert.ToString(result);
                    first = result;
                    break;
                case "*":
                    result = first * second;
                    textBox1.Text = Convert.ToString(result);
                    first = result;
                    break;
                case "/":
                    if (second == 0)
                    {
                        textBox1.ForeColor = Color.Red;
                        textBox1.Text = "Can't divide by 0!";
                    }
                    else
                    {
                        result = first / second;
                        textBox1.Text = Convert.ToString(result);
                        first = result;
                    }
                    break;
            }
        }
    }
}
