using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuarterFinder
{
    public partial class Form1 : Form
    {
        // Список для зберігання всіх точок
        private List<CustomPoint> points = new List<CustomPoint>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX.Text);
                double y = double.Parse(textBoxY.Text);

                CustomPoint newPoint = new CustomPoint(x, y);

                string quarter = GetQuarter(newPoint);

                if (quarter == "на осі")
                {
                    labelResult.Text = "Точка знаходиться на осі координат";
                }
                else
                {
                    labelResult.Text = $"Точка знаходиться у {quarter} чверті";
                }

                points.Add(newPoint);

                DrawAllPoints();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: Некоректне введення");
            }
        }

        private string GetQuarter(CustomPoint point)
        {
            if (point.X > 0 && point.Y > 0)
                return "I";
            else if (point.X < 0 && point.Y > 0)
                return "II";
            else if (point.X < 0 && point.Y < 0)
                return "III";
            else if (point.X > 0 && point.Y < 0)
                return "IV";
            else
                return "на осі";
        }

        private void DrawAllPoints()
        {
            Graphics graph = pictureBoxGraph.CreateGraphics();
            graph.Clear(Color.White);

            // Малюємо осі координат
            Pen axisPen = new Pen(Color.Gray, 2);
            graph.DrawLine(axisPen, 0, pictureBoxGraph.Height / 2, pictureBoxGraph.Width, pictureBoxGraph.Height / 2);
            graph.DrawLine(axisPen, pictureBoxGraph.Width / 2, 0, pictureBoxGraph.Width / 2, pictureBoxGraph.Height);

            // Малюємо всі точки: старі - чорні, нова - кольорова відповідно до чверті
            for (int i = 0; i < points.Count; i++)
            {
                CustomPoint point = points[i];

                // Остання точка має свій колір відповідно до чверті, інші - чорні
                Brush brush = (i == points.Count - 1) ? GetBrushForQuarter(point) : Brushes.Black;

                // Масштабуємо точку для відображення на графіку
                float graphX = (float)(point.X * 10 + pictureBoxGraph.Width / 2);
                float graphY = (float)(-point.Y * 10 + pictureBoxGraph.Height / 2);

                // Малюємо точку
                graph.FillEllipse(brush, graphX - 5, graphY - 5, 10, 10);
            }
        }

        private Brush GetBrushForQuarter(CustomPoint point)
        {
            string quarter = GetQuarter(point);

            // Встановлюємо колір для точки залежно від чверті
            if (quarter == "I")
                return Brushes.Red;
            else if (quarter == "II")
                return Brushes.Green;
            else if (quarter == "III")
                return Brushes.Blue;
            else if (quarter == "IV")
                return Brushes.Yellow;
            else
                return Brushes.Black; // Якщо точка на осі
        }
    }

    public class CustomPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public CustomPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
