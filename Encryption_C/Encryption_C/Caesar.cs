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

namespace Encryption_C
{
    public partial class Caesar : Form
    {
        public Caesar()
        {
            InitializeComponent();
            textBox4.Text = "1";
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

        private void button2_Click(object sender, EventArgs e)
        {
            var cipher = new CaesarCipher(); //  = textBox1.Text;      
            var secretKey = Convert.ToInt32(textBox4.Text); // Ключ


            string text = "";
            ///////////////////////////////
            ///СТРОКА ПУСТАЯ
            ///Возможно не запускается файл
            ///////////////////////////////
            if ((label4.Text != "Имя файла") && (label4.Text != ""))
            {
                using (StreamReader fs = new StreamReader("d:\\GitHub\\Encryption_C\\Encryption_C\\Encryption_C\\Properties\\file_test\\Дешифрованный текст(шифром Цезаря).txt"))
                {
                    while (true)
                    {
                        // Читаем строку из файла во временную переменную.
                        string temp = fs.ReadLine();

                        // var message = temp; // Текст для шифрования
                        var encryptedText = cipher.Encrypt(temp, secretKey);

                        // Пишем считанную строку в итоговую переменную.
                        text += encryptedText;

                        // Если достигнут конец файла, прерываем считывание.
                        if (temp == null) break; 
                    }
                }

                // Выводим на экран.
                textBox5.Text = text;
            }
            else
            {
                MessageBox.Show("Файл не выбран");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show(OPF.FileName);
                label4.Text = OPF.FileName;
            }
        }
    }
}
