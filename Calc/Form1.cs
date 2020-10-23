using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a, b; //тип переменной с плавающей точкой
        int count; //используется для указания действий для переменных (выше)
        bool znak = true; //znak используется для изменения знака у введенных чисел (+/-)
        // bool может быть как true так и false. 


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0; // Код для отображения введеных символов в textBox1
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }


        //Клавиша "+"
        private void button4_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text); // Присваение переменной "a" то что будет написано в textBox1
            textBox1.Clear(); // Очистка формы textBox1, переменная "a" сохраняется
            count = 1; // Присваение переменной count значение 1
            label1.Text = a.ToString() + "+"; // Запись числа из переменной "a" в label1, добавление знака "+" в конце строки
            znak = true; // Присваение переменной znak значение true
        }

        // Клавиша "-"
        private void button8_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        // Клавиша умножить
        private void button12_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        // Клавиша деление "/"
        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;


        }

        // Клавиша равно "="
        private void button19_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        //Создание функции calculate
            private void calculate()
            {
                    // Оператор управления. Включает в себя несколько case.
                   switch(count)
                    {
                //case метки имеющие значение, в зависимости от значения, выполняется определенная операция
                case 1:
                   b = a + float.Parse(textBox1.Text); // Parse конвертирует набранный текст из текстБокса в тип float
                   textBox1.Text = b.ToString(); // Вывод в текстБокс1 значение переменной "b" в виде строки "ToString"
                   break; // завершает выполнение кода switch при выполнение кода метки case 1. Так как использовать его более не требуется

                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
                    
                     }
            


                 }

        // Кнопка удаления "C"
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        // Кнопка удаления последнего символа "<-"
        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1; // Присваивает переменной "lenght" значение равное колличеству символом в "textBox1" минус 1
            string text = textBox1.Text; // новая переменная "text", в которую заносится текст из "textBox1"
            textBox1.Clear(); // После занесения теста из "textBox1", "textBox1" очищается
            /*
              for (int i = 0; i < lenght; i++) - цыкл. Выполнение цыкла начинается с "0"
              textBox1.Text = textBox1.Text + text[i]; - выполнение цыкла, до тех пор пока
              не выполнится условие i<lenght, с интервалом 1 (прибавление по целому числу)
              вывод значение переменной "text"
             * 
             * 
            */
            for (int i = 0; i < lenght; i++) 
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        //Клавиша znak "+/-"
        private void button3_Click(object sender, EventArgs e)
        {
            if(znak==true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }

            else if (znak==false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }




        // Клавиша дроби "."
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

    }
}
