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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Encryption_C
{
    public partial class Caesar : Form
    {
        public Caesar()
        {
            InitializeComponent();
            textBox3.Text = "1";

        }

        private void Caesar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }


        public class CaesarCipher
        {
            //символы русской азбуки
            const string alfavit = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            private string CodeEncode(string text, int k)
            {
                //добавляем в алфавит маленькие буквы
                var fullAlfabet = alfavit + alfavit.ToLower();
                var letterQty = fullAlfabet.Length;
                var retVal = "";
                for (int i = 0; i < text.Length; i++)
                {
                    var c = text[i];
                    var index = fullAlfabet.IndexOf(c);
                    if (index < 0)
                    {
                        //если символ не найден, то добавляем его в неизменном виде
                        retVal += c.ToString();
                    }
                    else
                    {
                        var codeIndex = (letterQty + index + k) % letterQty;
                        retVal += fullAlfabet[codeIndex];
                    }
                }

                return retVal;
            }

            //шифрование текста
            public string Encrypt(string plainMessage, int key)
                => CodeEncode(plainMessage, key);

            //дешифрование текста
            public string Decrypt(string encryptedMessage, int key)
                => CodeEncode(encryptedMessage, -key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cipher = new CaesarCipher(); //  = textBox1.Text;
            var message = textBox1.Text; // Текст для шифрования
            var secretKey = Convert.ToInt32(textBox3.Text); // Ключ
            var encryptedText = cipher.Encrypt(message, secretKey);
            textBox2.Text = encryptedText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cipher = new CaesarCipher();
            var secretKey = Convert.ToInt32(textBox3.Text); // Ключ
            var encryptedText = textBox1.Text; // текст для шифрования

            textBox2.Text = cipher.Decrypt(encryptedText, secretKey);
        }

        StreamReader sr;
        /*private void button2_Click(object sender, EventArgs e)
        {
            var cipher = new CaesarCipher();
            // var secretKey = Convert.ToInt32(textBox4.Text); // Ключ
            string filename = openFileDialog1.FileName;
            label3.Text = filename.ToString();
            //sr = new StreamReader(filename);
            var secretKey = Convert.ToInt32(sr.ReadLine()); // Ключ

            string text = "";
            ///////////////////////////////
            ///СТРОКА ПУСТАЯ
            ///Возможно не запускается файл
            ///НУЖНО ПРОЧИТАТЬ ПЕРВУЮ СТРОКУ И ЗАПИСАТЬ ЕЕ В secretKey
            ///////////////////////////////
            if ((label4.Text != "Имя файла") && (label4.Text != ""))
            {

                while (sr != null) // конець файла - значение null
                {
                    // Прочитать следующую строку
                    string s = sr.ReadLine();
                    text += s;
                }

                // 4. Закрыть файл
                sr.Close();

                textBox5.Text = text;
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }

        }*/

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show(OPF.FileName);
                label4.Text = OPF.FileName;
            }

            // получаем выбранный файл
            // string filename = openFileDialog1.FileName;
            // читаем файл в строку
            // string fileText = System.IO.File.ReadAllText(filename);
            // textBox1.Text = fileText;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            // string str = textBox3.Text + "\n" + textBox5.Text;
            System.IO.File.WriteAllText(filename, textBox5.Text);
            MessageBox.Show("Файл сохранен");
        }

        // Файлом
        private void button7_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            string str = textBox3.Text + "\n" + textBox2.Text;

            System.IO.File.WriteAllText(filename, str);
            MessageBox.Show("Файл сохранен");
        }

    }
}