using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cezar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int move = 0;
            string[] array = new string[] { "а", "б", "в",
 "г", "д", "е", "ё", "ж",
"з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с",
"т", "у", "ф", "х",
 "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            try
            {
                move = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Установите шаг шифрования!");
                return;
            }

            string[] array2;
            array2 = array.Skip(move).Concat(array.Take(move)).ToArray();

            foreach (string element in array2)
            {

            }

            string text = textBox2.Text;
            foreach (char bykva in text)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (bykva.ToString().ToLower() == array[i])
                    {
                        textBox3.Text += array2[i];
                        break;
                    }
                    else
                    {
                        if (bykva.ToString() == " " || bykva.ToString() == "." ||
                        bykva.ToString() == "," || bykva.ToString() == ":" ||
                        bykva.ToString() == ";" || bykva.ToString() == "?" ||
                        bykva.ToString() == "!")
                        {
                            textBox3.Text += " ";
                            break;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            int move = 0;
            string[] array = new string[] { "а", "б", "в",
 "г", "д", "е", "ё", "ж",
"з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с",
"т", "у", "ф", "х",
 "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            try
            {
                move = Convert.ToInt32(textBox5.Text);
                move = 33 - move;
            }
            catch
            {
                MessageBox.Show("Установите шаг шифрования!");
                return;
            }

            string[] array2;
            array2 = array.Skip(move).Concat(array.Take(move)).ToArray();

            foreach (string element in array2)
            {

            }

            string text = textBox4.Text;
            foreach (char bykva in text)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (bykva.ToString().ToLower() == array[i])
                    {
                        textBox6.Text += array2[i];
                        break;
                    }
                    else
                    {
                        if (bykva.ToString() == " " || bykva.ToString() == "." ||
                        bykva.ToString() == "," || bykva.ToString() == ":" ||
                        bykva.ToString() == ";" || bykva.ToString() == "?" ||
                        bykva.ToString() == "!")
                        {
                            textBox6.Text += " ";
                            break;
                        }
                    }
                }
            }
        }


    }
}