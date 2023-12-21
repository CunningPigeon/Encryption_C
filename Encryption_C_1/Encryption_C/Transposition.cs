using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_C
{
    public partial class Transposition : Form
    {
        Transpos t;
        public Transposition()
        {
            InitializeComponent();
            t = new Transpos();
        }

        class Transpos
        {
            private int[] key = null;

            public void SetKey(int[] _key)
            {
                key = new int[_key.Length];

                for (int i = 0; i < _key.Length; i++)
                    key[i] = _key[i];
            }

            public void SetKey(string[] _key)
            {
                key = new int[_key.Length];

                for (int i = 0; i < _key.Length; i++)
                    key[i] = Convert.ToInt32(_key[i]);
            }

            public void SetKey(string _key)
            {
                SetKey(_key.Split(' '));
            }

            public string Encrypt(string input)
            {
                for (int i = 0; i < input.Length % key.Length; i++)
                    input += input[i];

                string result = "";
                try
                {
                    for (int i = 0; i < input.Length; i += key.Length)
                    {
                        char[] transposition = new char[key.Length];

                        for (int j = 0; j < key.Length; j++)
                            transposition[key[j] - 1] = input[i + j];

                        for (int j = 0; j < key.Length; j++)
                            result += transposition[j];
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    MessageBox.Show("Введите правильно ключ");
                }
                return result;
            }

            public string Decrypt(string input)
            {
                string result = "";
                try
                {


                    for (int i = 0; i < input.Length; i += key.Length)
                    {
                        char[] transposition = new char[key.Length];

                        for (int j = 0; j < key.Length; j++)
                            transposition[j] = input[i + key[j] - 1];

                        for (int j = 0; j < key.Length; j++)
                            result += transposition[j];
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    MessageBox.Show("Введите правильно ключ");
                }
                return result;
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            t.SetKey(textBox3.Text);
            textBox2.Text = t.Encrypt(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t.SetKey(textBox3.Text);
            textBox2.Text = t.Decrypt(textBox1.Text);
        }

        private void Transposition_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
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

        // Файлом
        private void But_save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            
            System.IO.File.WriteAllText(filename, textBox4.Text);
            System.IO.File.WriteAllText(filename, "\n");
            System.IO.File.WriteAllText(filename, textBox5.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
