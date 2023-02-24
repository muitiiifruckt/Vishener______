using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Первая_пара_тимп
{
    public partial class Form1 : Form
    {
        string s = ""; // строка для основной работы 

        string ss = "";// строка для обработки от лишних символов 

        string S = ""; // строка для вывода

        /// <summary>
        /// 
        /// </summary>
        string key; // принимаемый ключ шифровки 

        string al = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; // русский алфавит 

        public Form1()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////

        /// Шифровка

        ///////////////////////////////////////////////////

        public bool string_in(char a, string s) // функция, которая проверяет наличие того или иного элемента в алфавите 
        {
            for (int i = 0; i < s.Length; i++)
                if (a == s[i])
                    return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ss = richTextBox1.Text.ToLower(); // получаем текст из окошка в нижнем колонтитуле 

                key = richTextBox3.Text.ToLower(); // получаем ключ из окошка 

                int size_key = key.Length; // получаем длину ключа 

                int[] key_shift = new int[size_key]; // массив для индексов ключа

                for (int i = 0; i < ss.Length; i++) // избавляемся от лишних символов, пробелов ( получается сплошной текст)
                {
                    if (string_in(ss[i], al))
                        s += ss[i];
                }

                ///
                /////


                for (int i = 0, j = 0; i < size_key; i++) // сдвиг по ключу 
                {
                    j = 0;
                    for (; j < al.Length; j++)
                        if (al[j] == key[i])
                            break;
                    key_shift[i] = j;

                }

                /////
                ///

                ///
                /////
                for (int i = 0, j = 0; i < s.Length; i++) // главный цикл, который проводит шифрование
                {
                    if (string_in(s[i], al))
                    {
                        j = 0;
                        for (; j < al.Length; j++) // сдвиг по исходному элементу 
                            if (al[j] == s[i])
                                break;
                        S += al[(j + key_shift[i % size_key]) % 33];
                    }
                    else
                        S += s[i];
                }

                richTextBox2.Text = S;// вывод зашифрованного текста 

                S = ""; //  очитска памяти для далнейшей с ними работы 

                ss = ""; // очитска памяти для далнейшей с ними работы 

                s = ""; // очитска памяти для далнейшей с ними работы 

            }
            catch
            { MessageBox.Show("Неправильный ввод ключа или текста"); }
            /////
            ///
        }

        ///////////////////////////////////////////////////

        /// Дешифровка 

        ///////////////////////////////////////////////////

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ss = richTextBox6.Text.ToLower(); // получаем текст из окошка

                string string_for_size_of_key = ""; // строка для вычисления длины ключа 

                int size_key = 0; // длина ключа 

                int[] N = new int[33]; // массив для частотного анализа 

                double hit_index = 0; // индекс самой частой буквы

                int n = 0; // количество символов в тексте 


                for (int i = 0; i < ss.Length; i++) // // избавляемся от лишних символов, пробелов ( получается сплошной текст)
                {
                    if (string_in(ss[i], al))
                        s += ss[i];
                }



                for (int p = 2; p < 20; p++) // цикл, который вычисляет длину ключа (предпологается что ключ-слово не длиннее 19 символов)
                {
                    n = 0;
                    hit_index = 0;
                    string_for_size_of_key = ""; // промежуточная строка для работы с группами символов 
                    for (int t = 0; t < s.Length; t = t + p) // отбираем символы с некотором шагом р
                    {
                        if (string_in(s[t], al))
                            string_for_size_of_key += s[t];
                    }

                    ///
                    ////////
                    ///


                    for (int i = 0; i < al.Length; i++) // цикл для подсчета  частоты букв
                    {
                        N[i] = 0;
                        for (int j = 0; j < string_for_size_of_key.Length; j++)
                            if (al[i] == string_for_size_of_key[j])
                                N[i]++;
                    }

                    ///
                    ////////
                    ///


                    for (int i = 0; i < al.Length; i++) // цикл  для подсчета  количества символов
                        n += N[i];


                    ///
                    ////////
                    ///


                    for (int i = 0; i < al.Length; i++) // цикл для подсчета индекса совпадений 
                        hit_index += (double)(N[i] * (N[i] - 1)) / (n * (n - 1));


                    ///
                    ////////
                    ///

                    if (hit_index > 0.054) // если индекс совпадений больше критического числа => мы нашли длину ключа 
                    {
                        size_key = p;
                        break;
                    }
                }


                ///
                ////////
                ///


                int[] index_of_key = new int[size_key]; // массив индексов ключа для дешифровки 

                string decrypted_message = ""; // строка для вывода расшифрованного сообщения 

                for (int y = 0; y < size_key; y++) // 
                {
                    int shift = 0; // индекс определенной буквы ключа 

                    int quantity_top_symbol = 0; // количество самой частой буквы

                    int index_top_symbol = 0; //индекс самой частой буквы

                    string string_for_analyze = ""; // строка для применения дешифровки цезаря для группы символов 

                    ///
                    ////////
                    ///

                    for (int t = y; t < s.Length; t = t + size_key) // отбираем символы с некотором шагом size_key
                    {
                        string_for_analyze += s[t];
                    }

                    ///
                    ////////
                    ///

                    for (int i = 0; i < al.Length; i++) // цикл для подсчета   частоты букв
                    {
                        N[i] = 0;
                        for (int j = 0; j < string_for_analyze.Length; j++)
                            if (al[i] == string_for_analyze[j])
                                N[i]++;
                    }

                    ///
                    ////////
                    ///

                    for (int i = 0; i < al.Length; i++) // цикл для подсчета  самой частой буквы
                    {
                        quantity_top_symbol = Math.Max(quantity_top_symbol, N[i]);
                    }

                    ///
                    ////////
                    ///

                    for (int i = 0; i < al.Length; i++) // цикл для подсчета  самой частой буквы
                    {
                        if (N[i] == quantity_top_symbol)
                        {
                            index_top_symbol = i;
                            break;
                        }
                    }

                    ///
                    ////////
                    ///

                    shift = ((index_top_symbol - 15) + 33) % 33; // находим сдвиг для данной группы символов 

                    index_of_key[y] = shift; // задаем значения для массива индексов ключа 
                }

                ////////
                ///

                for (int i = 0, j = 0; i < s.Length; i++) // дешифрование 
                {
                    j = 0;

                    for (; j < al.Length; j++) // получаем индекс буквы алфавита
                        if (al[j] == s[i])
                            break;

                    decrypted_message += al[((j - index_of_key[i % index_of_key.Length]) + 33) % 33];

                }

                richTextBox4.Text = decrypted_message; // вывод дешифрованного сообщения
                string hak_key = "";
                for (int i = 0; i < index_of_key.Length; i++)
                {
                    hak_key += al[index_of_key[i]];
                }
                richTextBox5.Text = hak_key;
            }
            catch
            { MessageBox.Show("Неправильный ввод  текста"); }
        }
    }
}
