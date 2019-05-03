using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace krestikinoliki
{
    public partial class Form1 : Form
    {
        int win;
        int hod = 0;
        int[,] mas = new int[3, 3];
        int draw = 0;
        int xwin = 0;
        int owin = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(Color.Black, 4.0f), 100, 100, 100, 700);
            g.DrawLine(new Pen(Color.Black, 4.0f), 100, 100, 700, 100);
            g.DrawLine(new Pen(Color.Black, 4.0f), 700, 100, 700, 700);
            g.DrawLine(new Pen(Color.Black, 4.0f), 100, 700, 700, 700);
            g.DrawLine(new Pen(Color.Black, 4.0f), 100, 300, 700, 300);
            g.DrawLine(new Pen(Color.Black, 4.0f), 100, 500, 700, 500);
            g.DrawLine(new Pen(Color.Black, 4.0f), 300, 100, 300, 700);
            g.DrawLine(new Pen(Color.Black, 4.0f), 500, 100, 500, 700);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {


            {
                Graphics g = this.CreateGraphics();

                
                if (hod % 2 == 0)
                {
                    if ((e.X > 100) && (e.X < 300) && (e.Y > 100) && (e.Y < 300) && (mas[0, 0] == 0))
                    {
                        g.DrawLine(new Pen(Color.Black, 4.0f), 105, 105, 295, 295);
                        g.DrawLine(new Pen(Color.Black, 4.0f), 105, 295, 295, 105);
                        hod++;
                        mas[0, 0] = 1;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Первая строка, первый столбец: КРЕСТИК" + "\r\n");

                    }
                    if ((e.X > 300) && (e.X < 500) && (e.Y > 100) && (e.Y < 300) && (mas[0, 1] == 0))
                    {
                        g.DrawLine(new Pen(Color.Black, 4.0f), 305, 105, 495, 295);
                        g.DrawLine(new Pen(Color.Black, 4.0f), 305, 295, 495, 105);
                        hod++;
                        mas[0, 1] = 1;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Первая строка, второй столбец: КРЕСТИК" + "\r\n");
                    }

                    if ((e.X > 500) && (e.X < 700) && (e.Y > 100) && (e.Y < 300) && (mas[0, 2] == 0))
                    {
                        g.DrawLine(new Pen(Color.Black, 4.0f), 505, 105, 695, 295);
                        g.DrawLine(new Pen(Color.Black, 4.0f), 505, 295, 695, 105);
                        hod++;
                        mas[0, 2] = 1;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Первая строка, третий столбец: КРЕСТИК" + "\r\n");
                    }
                    if ((e.X > 100) && (e.X < 300) && (e.Y > 300) && (e.Y < 500) && (mas[1, 0] == 0))
                    {
                        g.DrawLine(new Pen(Color.Black, 4.0f), 105, 305, 295, 495);
                        g.DrawLine(new Pen(Color.Black, 4.0f), 105, 495, 295, 305);
                        hod++;
                        mas[1, 0] = 1;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Вторая строка, первый столбец: КРЕСТИК" + "\r\n");
                    }
                    if ((e.X > 300) && (e.X < 500) && (e.Y > 300) && (e.Y < 500) && (mas[1, 1] == 0))
                    {
                        g.DrawLine(new Pen(Color.Black, 4.0f), 305, 305, 495, 495);
                        g.DrawLine(new Pen(Color.Black, 4.0f), 495, 305, 305, 495);
                        hod++;
                        mas[1, 1] = 1;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Вторая строка, второй столбец: КРЕСТИК" + "\r\n");
                    }

                    if ((e.X > 500) && (e.X < 700) && (e.Y > 300) && (e.Y < 500) && (mas[1, 2] == 0))
                    {
                        g.DrawLine(new Pen(Color.Black, 4.0f), 505, 305, 695, 495);
                        g.DrawLine(new Pen(Color.Black, 4.0f), 505, 495, 695, 305);
                        hod++;
                        mas[1, 2] = 1;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Вторая строка, третий столбец: КРЕСТИК" + "\r\n");
                    }
                    if ((e.X > 100) && (e.X < 300) && (e.Y > 500) && (e.Y < 700) && (mas[2, 0] == 0))
                    {
                        g.DrawLine(new Pen(Color.Black, 4.0f), 105, 505, 295, 695);
                        g.DrawLine(new Pen(Color.Black, 4.0f), 105, 695, 295, 505);
                        hod++;
                        mas[2, 0] = 1;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Третья строка, первый столбец: КРЕСТИК" + "\r\n");
                    }
                    if ((e.X > 300) && (e.X < 500) && (e.Y > 500) && (e.Y < 700) && (mas[2, 1] == 0))
                    {
                        g.DrawLine(new Pen(Color.Black, 4.0f), 305, 505, 495, 695);
                        g.DrawLine(new Pen(Color.Black, 4.0f), 305, 695, 495, 505);
                        hod++;
                        mas[2, 1] = 1;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Третья строка, второй столбец: КРЕСТИК" + "\r\n");
                    }
                    if ((e.X > 500) && (e.X < 700) && (e.Y > 500) && (e.Y < 700) && (mas[2, 2] == 0))
                    {
                        g.DrawLine(new Pen(Color.Black, 4.0f), 505, 505, 695, 695);
                        g.DrawLine(new Pen(Color.Black, 4.0f), 505, 695, 695, 505);
                        hod++;
                        mas[2, 2] = 1;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Третья строка, третий столбец: КРЕСТИК" + "\r\n");
                    }

                }
                else

                {

                    if ((e.X > 100) && (e.X < 300) && (e.Y > 100) && (e.Y < 300) && (mas[0, 0] == 0))
                    {
                        g.DrawEllipse(new Pen(Color.Black, 4.0f), 105, 105, 190, 190);
                        hod++;
                        mas[0, 0] = 2;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Первая строка, первый столбец: НОЛИК" + "\r\n");

                    }
                    if ((e.X > 300) && (e.X < 500) && (e.Y > 100) && (e.Y < 300) && (mas[0, 1] == 0))
                    {
                        g.DrawEllipse(new Pen(Color.Black, 4.0f), 305, 105, 190, 190);
                        hod++;
                        mas[0, 1] = 2;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Первая строка, второй столбец: НОЛИК" + "\r\n");
                    }
                    if ((e.X > 500) && (e.X < 700) && (e.Y > 100) && (e.Y < 300) && (mas[0, 2] == 0))
                    {
                        g.DrawEllipse(new Pen(Color.Black, 4.0f), 505, 105, 190, 190);
                        hod++;
                        mas[0, 2] = 2;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Первая строка, третий столбец: НОЛИК" + "\r\n");
                    }
                    if ((e.X > 100) && (e.X < 300) && (e.Y > 300) && (e.Y < 500) && (mas[1, 0] == 0))
                    {
                        g.DrawEllipse(new Pen(Color.Black, 4.0f), 105, 305, 190, 190);
                        hod++;
                        mas[1, 0] = 2;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Вторая строка, первый столбец: НОЛИК" + "\r\n");
                    }
                    if ((e.X > 300) && (e.X < 500) && (e.Y > 300) && (e.Y < 500) && (mas[1, 1] == 0))
                    {
                        g.DrawEllipse(new Pen(Color.Black, 4.0f), 305, 305, 190, 190);
                        hod++;
                        mas[1, 1] = 2;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Вторая строка, второй столбец: НОЛИК" + "\r\n");
                    }
                    if ((e.X > 500) && (e.X < 700) && (e.Y > 300) && (e.Y < 500) && (mas[1, 2] == 0))
                    {
                        g.DrawEllipse(new Pen(Color.Black, 4.0f), 505, 305, 190, 190);
                        hod++;
                        mas[1, 2] = 2;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Вторая строка, третий столбец: НОЛИК" + "\r\n");
                    }
                    if ((e.X > 100) && (e.X < 300) && (e.Y > 500) && (e.Y < 700) && (mas[2, 0] == 0))
                    {
                        g.DrawEllipse(new Pen(Color.Black, 4.0f), 105, 505, 190, 190);
                        hod++;
                        mas[2, 0] = 2;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Третья строка, первый столбец: НОЛИК" + "\r\n");
                    }
                    if ((e.X > 300) && (e.X < 500) && (e.Y > 500) && (e.Y < 700) && (mas[2, 1] == 0))
                    {
                        g.DrawEllipse(new Pen(Color.Black, 4.0f), 305, 505, 190, 190);
                        hod++;
                        mas[2, 1] = 2;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Третья строка, второй столбец: НОЛИК" + "\r\n");
                    }
                    if ((e.X > 500) && (e.X < 700) && (e.Y > 500) && (e.Y < 700) && (mas[2, 2] == 0))
                    {
                        g.DrawEllipse(new Pen(Color.Black, 4.0f), 505, 505, 190, 190);
                        hod++;
                        mas[2, 2] = 2;
                        System.IO.File.AppendAllText(@"C:\test\test.txt", "Третья строка, третий столбец: НОЛИК" + "\r\n");

                    }

                }


                if ((mas[0, 0] == 1 && mas[0, 1] == 1 && mas[0, 2] == 1))
                {
                    win = 1;
                    g.DrawLine(new Pen(Color.Red, 6.0f), 105, 200, 695, 200);
                    xwin += 1;
                    MessageBox.Show("X выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили КРЕСТИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                    
                }


                if ((mas[1, 0] == 1 && mas[1, 1] == 1 && mas[1, 2] == 1))
                {
                    win = 1;
                    g.DrawLine(new Pen(Color.Red, 6.0f), 105, 400, 695, 400);
                    xwin += 1;
                    MessageBox.Show("X выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили КРЕСТИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }
                if ((mas[2, 0] == 1 && mas[2, 1] == 1 && mas[2, 2] == 1))
                {
                    win = 1;
                    g.DrawLine(new Pen(Color.Red, 6.0f), 105, 600, 695, 600);
                    xwin += 1;
                    MessageBox.Show("X выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили КРЕСТИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }
                if ((mas[0, 0] == 1 && mas[1, 0] == 1 && mas[2, 0] == 1))
                {
                    win = 1;
                    g.DrawLine(new Pen(Color.Red, 6.0f), 200, 105, 200, 695);
                    xwin += 1;
                    MessageBox.Show("X выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили КРЕСТИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }

                if ((mas[0, 1] == 1 && mas[1, 1] == 1 && mas[2, 1] == 1))
                {
                    win = 1;
                    g.DrawLine(new Pen(Color.Red, 6.0f), 400, 105, 400, 695);
                    xwin += 1;
                    MessageBox.Show("X выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили КРЕСТИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }
                if ((mas[0, 2] == 1 && mas[1, 2] == 1 && mas[2, 2] == 1))
                {
                    win = 1;
                    g.DrawLine(new Pen(Color.Red, 6.0f), 600, 105, 600, 695);
                    xwin += 1;
                    MessageBox.Show("X выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили КРЕСТИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }

                if ((mas[0, 0] == 1 && mas[1, 1] == 1 && mas[2, 2] == 1))
                {
                    win = 1;
                    g.DrawLine(new Pen(Color.Red, 6.0f), 105, 105, 695, 695);
                    xwin += 1;
                    MessageBox.Show("X выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили КРЕСТИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }
                if ((mas[0, 2] == 1 && mas[1, 1] == 1 && mas[2, 0] == 1))
                {
                    g.DrawLine(new Pen(Color.Red, 6.0f), 695, 105, 105, 695);
                    xwin += 1;
                    MessageBox.Show("X выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили КРЕСТИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }


                if ((mas[0, 0] == 2 && mas[0, 1] == 2 && mas[0, 2] == 2))
                {
                    win = 2;
                    g.DrawLine(new Pen(Color.Blue, 6.0f), 105, 200, 695, 200);
                    owin += 1;
                    MessageBox.Show("O выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили НОЛИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }


                if ((mas[1, 0] == 2 && mas[1, 1] == 2 && mas[1, 2] == 2))
                {
                    win = 2;
                    g.DrawLine(new Pen(Color.Blue, 6.0f), 105, 400, 695, 400);
                    owin += 1;
                    MessageBox.Show("O выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили НОЛИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }
                if ((mas[2, 0] == 2 && mas[2, 1] == 2 && mas[2, 2] == 2))
                {
                    win = 2;
                    g.DrawLine(new Pen(Color.Blue, 6.0f), 105, 600, 695, 600);
                    owin += 1;
                    MessageBox.Show("O выиграли");
                     System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили НОЛИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }
                if ((mas[0, 0] == 2 && mas[1, 0] == 2 && mas[2, 0] == 2))
                {
                    win = 2;
                    g.DrawLine(new Pen(Color.Blue, 6.0f), 200, 105, 200, 695);
                    owin += 1;
                    MessageBox.Show("O выиграли");
                     System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили НОЛИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }
                if ((mas[0, 1] == 2 && mas[1, 1] == 2 && mas[2, 1] == 2))
                {
                    win = 2;
                    g.DrawLine(new Pen(Color.Blue, 6.0f), 400, 105, 400, 695);
                    owin += 1;
                    MessageBox.Show("O выиграли");
                     System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили НОЛИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }
                if ((mas[0, 2] == 2 && mas[1, 2] == 2 && mas[2, 2] == 2))
                {
                    win = 2;
                    g.DrawLine(new Pen(Color.Blue, 6.0f), 600, 105, 600, 695);
                    owin += 1;
                    MessageBox.Show("O выиграли");
                     System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили НОЛИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }
                if ((mas[0, 0] == 2 && mas[1, 1] == 2 && mas[2, 2] == 2))
                {
                    win = 2;
                    g.DrawLine(new Pen(Color.Blue, 6.0f), 105, 105, 695, 695);
                    owin += 1;
                    MessageBox.Show("O выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили НОЛИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }
                if ((mas[0, 2] == 2 && mas[1, 1] == 2 && mas[2, 0] == 2))
                {
                    win = 2;
                    g.DrawLine(new Pen(Color.Blue, 6.0f), 695, 105, 105, 695);
                    owin += 1;
                    MessageBox.Show("O выиграли");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "Победили НОЛИКИ" + "\r\n");
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();
                }



                if ((hod >= 9) && (win != 0))
                {
                    MessageBox.Show("Ничья");
                    System.IO.File.AppendAllText(@"C:\test\test.txt", "НИЧЬЯ!" + "\r\n");
                    draw += 1;
                    Array.Clear(mas, 0, mas.Length);
                    hod = 0;
                    Refresh();

                }

                label1.Text = "Побед у Х : " + xwin;
                label2.Text = "Побед у О : " + owin;
                label3.Text = "Ничьих : " + draw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Clear(mas, 0, mas.Length);
            Refresh();
            Invalidate();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.IO.File.Delete(@"C:\test\test.txt");

        }
    }
    
    }

