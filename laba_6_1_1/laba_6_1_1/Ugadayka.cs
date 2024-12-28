using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace laba_6_1_1
{
    public partial class Ugadayka : Form
    {
        public Ugadayka()
        {
            InitializeComponent();
        }
        private Ugaday ww;

        private void label2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Orange;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Maroon;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            double a, b;

            if (double.TryParse(textBox2.Text, out a) &&
            double.TryParse(textBox1.Text, out b) && (radioButton3.Checked || radioButton5.Checked || radioButton7.Checked))
            {

                if (b <= 0)
                {
                    MessageBox.Show("Ошибка ввода! Число b должно быть больше 0!");
                }
                else if (a > 0 && b > 0)
                {
                    label2.Text = $"Угадайте значение f, если a={a}, b={b}";
                    label3.Location = new Point(150, 194);
                    label4.Hide();
                    textBox1.Hide();
                    button5.Visible = false;
                    button2.Visible = true;
                    radioButton3.Hide();
                    radioButton5.Hide();
                    radioButton7.Hide();
                    label6.Hide();

                    label3.Text = "Введите ответ:";
                    textBox2.Text = "";


                    if (radioButton3.Checked)
                    {
                        ww = new Ugaday(3, a, b);
                    }
                    else if (radioButton5.Checked)
                    {
                        ww = new Ugaday(5, a, b);
                    }
                    else if (radioButton7.Checked)
                    {
                        ww = new Ugaday(7, a, b);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поля правильно!");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double curAnswer;
            if (double.TryParse(textBox2.Text, out curAnswer))
            {
                MessageBox.Show(ww.Ugadaika(curAnswer));
                if (ww.CheckEnd(curAnswer))
                {
                    Form1 mm = new Form1();
                    mm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное значение для поля ответа.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox2.Text = "";
        }
    }
}