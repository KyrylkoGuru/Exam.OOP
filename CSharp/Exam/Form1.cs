using System;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private DateWithDayOfWeek date;

        public Form1()
        {
            InitializeComponent();
            lblResult.Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Обробка змін у першому текстовому полі
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Обробка змін у другому текстовому полі
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            // Обробка змін у третьому текстовому полі
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Код, який виконується при завантаженні форми
        }

        private void BtnSetDate_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(txtYear.Text);
                int month = int.Parse(txtMonth.Text);
                int day = int.Parse(txtDay.Text);

                date = new DateWithDayOfWeek(year, month, day);
                lblResult.Text = $"Встановлено дату: {date}";
                lblResult.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося встановити дату: {ex.Message}");
            }
        }

        private void BtnAddDays_Click(object sender, EventArgs e)
        {
            if (date != null)
            {
                try
                {
                    int daysToAdd = int.Parse(txtDay.Text);
                    date.AddDays(daysToAdd);
                    lblResult.Text = $"Дата після додавання днів: {date}";
                    lblResult.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося додати дні: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, спершу встановіть дату.");
            }
        }

        private void BtnAddMonths_Click(object sender, EventArgs e)
        {
            if (date != null)
            {
                try
                {
                    int monthsToAdd = int.Parse(txtMonth.Text);
                    date.AddMonths(monthsToAdd);
                    lblResult.Text = $"Дата після додавання місяців: {date}";
                    lblResult.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося додати місяці: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, спершу встановіть дату.");
            }
        }

        private void BtnAddYears_Click(object sender, EventArgs e)
        {
            if (date != null)
            {
                try
                {
                    int yearsToAdd = int.Parse(txtYear.Text);
                    date.AddYears(yearsToAdd);
                    lblResult.Text = $"Дата після додавання років: {date}";
                    lblResult.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося додати роки: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, спершу встановіть дату.");
            }
        }

        private void BtnGetDayOfWeek_Click(object sender, EventArgs e)
        {
            if (date != null)
            {
                DayOfWeek dayOfWeek = date.GetDayOfWeek();
                lblResult.Text = $"День тижня: {dayOfWeek}";
                lblResult.Visible = true;
            }
            else
            {
                MessageBox.Show("Будь ласка, спершу встановіть дату.");
            }
        }
    }
}
