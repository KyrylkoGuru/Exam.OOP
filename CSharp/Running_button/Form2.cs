using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Running_button
{

    public partial class Form2 : Form
    {
        private Random random = new Random();
        public Form2()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int buttonX = button1.Location.X;
            int buttonY = button1.Location.Y;

            if (Math.Abs(e.X - (buttonX + button1.Width / 2)) < 100 && Math.Abs(e.Y - (buttonY + button1.Height / 2)) < 50)
            {
                int newX = random.Next(0, this.ClientSize.Width - button1.Width);
                int newY = random.Next(0, this.ClientSize.Height - button1.Height);
                button1.Location = new Point(newX, newY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оце впертість...Все ж натиснули");
        }
    }
}
