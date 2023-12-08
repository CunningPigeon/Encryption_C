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

                for (int i = 0; i < input.Length; i += key.Length)
                {
                    char[] transposition = new char[key.Length];

                    for (int j = 0; j < key.Length; j++)
                        transposition[key[j] - 1] = input[i + j]; // Сделать исключение 

                    for (int j = 0; j < key.Length; j++)
                        result += transposition[j];
                }

                return result;
            }

            public string Decrypt(string input)
            {
                string result = "";

                for (int i = 0; i < input.Length; i += key.Length)
                {
                    char[] transposition = new char[key.Length];

                    for (int j = 0; j < key.Length; j++)
                        transposition[j] = input[i + key[j] - 1];

                    for (int j = 0; j < key.Length; j++)
                        result += transposition[j];
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


    }
}
