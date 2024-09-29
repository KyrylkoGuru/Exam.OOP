using MVC_Calc.Controllers;
using MVC_Calc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Visible = true;
                if (!double.TryParse(textBox1.Text, out double operand1) ||
                    !double.TryParse(textBox2.Text, out double operand2))
                {
                    label3.Text = "Помилка: Будь ласка, введіть коректне значення!";
                    return;
                }

                CalculatorController controller = new CalculatorController();
                Plus addition = new Plus(operand1, operand2);

                double result = controller.PerformOeration(addition);
                label3.Text = "Результат: " + result.ToString();
            }
            catch (Exception ex)
            {
                label3.Text = "Помилка: " + ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Visible = true;
                if (!double.TryParse(textBox1.Text, out double operand1) ||
                    !double.TryParse(textBox2.Text, out double operand2))
                {
                    label3.Text = "Помилка: Будь ласка, введіть коректне значення!";
                    return;
                }

                CalculatorController controller = new CalculatorController();
                Substaction substaction = new Substaction(operand1, operand2);

                double result = controller.PerformOeration(substaction);
                label3.Text = "Результат: " + result.ToString();
            }
            catch (Exception ex)
            {
                label3.Text = "Помилка: " + ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Visible = true;
                if (!double.TryParse(textBox1.Text, out double operand1) ||
                    !double.TryParse(textBox2.Text, out double operand2))
                {
                    label3.Text = "Помилка: Будь ласка, введіть коректне значення!";
                    return;
                }

                CalculatorController controller = new CalculatorController();
                Mulriplication mulriplication = new Mulriplication(operand1, operand2);

                double result = controller.PerformOeration(mulriplication);
                label3.Text = "Результат: " + result.ToString();
            }
            catch (Exception ex)
            {
                label3.Text = "Помилка: " + ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Visible = true;
                if (!double.TryParse(textBox1.Text, out double operand1) ||
                    !double.TryParse(textBox2.Text, out double operand2))
                {
                    label3.Text = "Помилка: Будь ласка, введіть коректне значення!";
                    return;
                }

                CalculatorController controller = new CalculatorController();
                Division division = new Division(operand1, operand2);

                double result = controller.PerformOeration(division);
                label3.Text = "Результат: " + result.ToString();
            }
            catch (Exception ex)
            {
                label3.Text = "Помилка: " + ex.Message;
            }
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
