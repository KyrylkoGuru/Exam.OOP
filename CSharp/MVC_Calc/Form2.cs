using MVC_Calc.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVC_Calc
{
    public partial class Form2 : Form
    {
        private Point originalLabel2Position;
        private Point fixedErrorPosition = new Point(85, 190);
        private Point fixedErrorPosition2 = new Point(178, 190);

        public Form2()
        {
            InitializeComponent();
            originalLabel2Position = label2.Location;
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || !int.TryParse(textBox1.Text, out int age))
                {
                    label2.Visible = true;
                    label2.Location = fixedErrorPosition2;
                    label2.Text = "Дивний у вас вік...Введіть число";
                    return;
                }

                if (age < 0)
                {
                    label2.Visible = true;
                    label2.Location = fixedErrorPosition;
                    label2.Text = "Ми не у ліриці Шевченка. Визначтеся, ви мертві, живі, чи ненароджені?";
                    return;
                }

                if (age > 110)
                {
                    label2.Visible = true;
                    label2.Location = fixedErrorPosition2;
                    label2.Text = "Люди стільки не живуть... Ви ельф?";
                    return;
                }

                label2.Visible = true;
                label2.Location = originalLabel2Position;

                AgeController ageController = new AgeController();
                string category = ageController.CheckAgeCategory(age);

                label2.Text = "Ви: " + category;
            }
            catch (Exception ex)
            {
                label2.Text = "Помилка: " + ex.Message;
            }
        }
    }
}
