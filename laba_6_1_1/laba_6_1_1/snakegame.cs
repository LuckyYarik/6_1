using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_6_1_1
{
    public partial class snakegame : Form
    {
        private int rI, rJ;
        private PictureBox fruit;
        private PictureBox[] snake = new PictureBox[400]; // Максимальный размер змейки
        private Label labelScore;
        private int dirX, dirY;
        private int _width = 400; // Ширина игрового поля (20 клеток * 20)
        private int _height = 400; // Высота игрового поля (20 клеток * 20)
        private int _sizeOfSides = 20; // Размер клетки
        private int score = 0;
        private bool isGameOver = false; // Переменная для отслеживания состояния игры
        private System.Windows.Forms.Timer timer;
        private int snakeLength = 1; // Начальная длина змейки


        public snakegame()
        {
            InitializeComponent();
            this.Text = "Snake";
            this.Width = _width + 100;
            this.Height = _height + 50;
            dirX = 1;
            dirY = 0;
            
            labelScore = new Label();
            labelScore.Text = "Счёт: 0";
            labelScore.Location = new Point(420, 10);
            this.Controls.Add(labelScore);
            fruit = new PictureBox();
            fruit.BackColor = Color.Red;
            fruit.Size = new Size(_sizeOfSides, _sizeOfSides);
            _generateMap();
            _generateFruit();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(_update);
            timer.Interval = 300;
            timer.Start();
            this.KeyDown += new KeyEventHandler(OKP);

            // Создаем начальную часть змейки
            snake[0] = new PictureBox();
            snake[0].Location = new Point(200, 200);
            snake[0].Size = new Size(_sizeOfSides - 1, _sizeOfSides - 1);
            snake[0].BackColor = Color.DarkGreen;
            this.Controls.Add(snake[0]);
            snake[0].BringToFront();
        }

        private void _generateMap()
        {
            // Создаем границы
            PictureBox topBorder = new PictureBox();
            topBorder.BackColor = Color.Black;
            topBorder.Location = new Point(0, 0);
            topBorder.Size = new Size(_width, 1);
            this.Controls.Add(topBorder);

            PictureBox bottomBorder = new PictureBox();
            bottomBorder.BackColor = Color.Black;
            bottomBorder.Location = new Point(0, _height - 1);
            bottomBorder.Size = new Size(_width, 1);
            this.Controls.Add(bottomBorder);

            PictureBox leftBorder = new PictureBox();
            leftBorder.BackColor = Color.Black;
            leftBorder.Location = new Point(0, 0);
            leftBorder.Size = new Size(1, _height);
            this.Controls.Add(leftBorder);

            PictureBox rightBorder = new PictureBox();
            rightBorder.BackColor = Color.Black;
            rightBorder.Location = new Point(_width - 1, 0);
            rightBorder.Size = new Size(1, _height);
            this.Controls.Add(rightBorder);

            // Отрисовка фона клеток
            for (int i = 0; i < _width / _sizeOfSides; i++)
            {
                for (int j = 0; j < _height / _sizeOfSides; j++)
                {
                    PictureBox cell = new PictureBox();
                    // Меняем цвет клеток, как в оригинале
                    if ((i + j) % 2 == 0)
                        cell.BackColor = Color.LightGreen;
                    else
                        cell.BackColor = Color.Lime;
                    cell.Location = new Point(i * _sizeOfSides, j * _sizeOfSides);
                    cell.Size = new Size(_sizeOfSides - 1, _sizeOfSides - 1);
                    this.Controls.Add(cell);
                }
            }
        }


        private void _generateFruit()
        {
            Random random = new Random();
            rI = random.Next(0, _width / _sizeOfSides);
            rJ = random.Next(0, _height / _sizeOfSides);
            fruit.Location = new Point(rI * _sizeOfSides, rJ * _sizeOfSides);
            this.Controls.Add(fruit);
            fruit.BringToFront(); // Фрукт поверх всех клеток
        }
        private void _update(object sender, EventArgs e)
        {
            if (isGameOver)
                return;

            int prevX = snake[0].Location.X;
            int prevY = snake[0].Location.Y;
            snake[0].Location = new Point(snake[0].Location.X + dirX * _sizeOfSides, snake[0].Location.Y + dirY * _sizeOfSides);

            if (snake[0].Location.X < 0 || snake[0].Location.X >= _width || snake[0].Location.Y < 0 || snake[0].Location.Y >= _height)
            {
                _gameOver();
                return;
            }

            for (int i = 1; i < snakeLength; i++)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    _gameOver();
                    return;
                }
            }

            if (snakeLength > 1)
            {
                int tempX, tempY;
                for (int i = 1; i < snakeLength; i++)
                {
                    tempX = snake[i].Location.X;
                    tempY = snake[i].Location.Y;

                    snake[i].Location = new Point(prevX, prevY);

                    prevX = tempX;
                    prevY = tempY;
                }
            }

            if (snake[0].Location.X == fruit.Location.X && snake[0].Location.Y == fruit.Location.Y)
            {
                score++;
                labelScore.Text = "Счёт: " + score;
                _generateFruit();

                if (snakeLength < snake.Length)
                {
                    snake[snakeLength] = new PictureBox();
                    snake[snakeLength].Size = new Size(_sizeOfSides - 1, _sizeOfSides - 1);
                    snake[snakeLength].BackColor = Color.DarkGreen;
                    snake[snakeLength].Location = new Point(prevX, prevY);
                    this.Controls.Add(snake[snakeLength]);
                    snake[snakeLength].BringToFront();// Змейка поверх всех клеток
                    snakeLength++;
                }
            }
        }



        private void _gameOver()
        {
            isGameOver = true;
            timer.Stop();
            MessageBox.Show("Игра окончена! \n Твой счёт: " + score, "Ты проиграл!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            Form1 mainMenu = new Form1();
            mainMenu.Show();

            
            this.Close();
        }


        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (dirY != 1)
                    {
                        dirY = -1;
                        dirX = 0;
                    }
                    break;
                case Keys.Down:
                    if (dirY != -1)
                    {
                        dirY = 1;
                        dirX = 0;
                    }
                    break;
                case Keys.Left:
                    if (dirX != 1)
                    {
                        dirX = -1;
                        dirY = 0;
                    }
                    break;
                case Keys.Right:
                    if (dirX != -1)
                    {
                        dirX = 1;
                        dirY = 0;
                    }
                    break;

            }
        }
    }

}

