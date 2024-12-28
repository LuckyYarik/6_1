using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba_6_1_1
{
    public partial class array : Form
    {
        public array()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }
        private ArrayHandler arr; // Переименовано с array на arr
        private bool allowValidation = false;

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

        private bool isFirstClick = true;

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            label4.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.ColumnCount = 10;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(new object[10]);
            arr = new ArrayHandler(); // Переименовано с array на arr
            label3.Text = "Выберите что вы хотите с делать с вашим массивом";
            label5.Hide();


            button1.Visible = false;
            button2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = -1;
            if (int.TryParse(textBox2.Text, out len) && len > 0 && len <= 65535)
            {
                button3.Visible = true;
                label4.Visible = true;
                dataGridView1.Visible = true;
                dataGridView1.ColumnCount = len;
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(new object[len]);
                label3.Text = "Выберите что вы хотите с делать с вашим массивом";
                label5.Hide();
                arr = new ArrayHandler(len); // Переименовано с array на arr
                button1.Visible = false;
                button2.Visible = false;
                textBox2.Visible = false;
                label3.Visible = false;
            }
            else
            {
                MessageBox.Show("Введите корректное значение длины", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
            }
        }

        private void UpdateDataGridView()
        {
            allowValidation = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(arr.GetArray().Cast<object>().ToArray()); // Переименовано с array на arr
            dataGridView1.BackColor = Color.White;
            allowValidation = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arr.FillArray(); // Переименовано с array на arr
            dataGridView1.ReadOnly = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            UpdateDataGridView();
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!allowValidation) return;
            string inputValue = e.FormattedValue.ToString();
            if (!int.TryParse(inputValue, out _))
            {
                e.Cancel = true;
                MessageBox.Show("Пожалуйста, введите целое число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (int.TryParse(dataGridView1.Rows[0].Cells[i].Value.ToString(), out int value))
                {
                    arr.GetArray()[i] = value; // Переименовано с array на arr
                }
            }
            UpdateDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value) == arr.fMin()) // Переименовано с

                    if (Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value) == arr.fMin()) // Переименовано с array на arr
                    {
                        dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Red;
                    }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            UpdateDataGridView();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value) == arr.fMax()) // Переименовано с array на arr
                {
                    dataGridView1.Rows[0].Cells[i].Style.BackColor = Color.Green;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cреднее значение в вашем массиве равно {arr.Avg()}", "Cреднее значение", MessageBoxButtons.OK); // Переименовано с array на arr
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arr.TtlSort(), "Ваш массив успешно отсортирован!", MessageBoxButtons.OK); // Переименовано с array на arr
            UpdateDataGridView();
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
    }
}

