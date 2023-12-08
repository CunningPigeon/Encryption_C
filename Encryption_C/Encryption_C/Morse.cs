using Microsoft.VisualBasic.Devices;
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
    public partial class Morse : Form
    {
        public Morse()
        {
            InitializeComponent();
        }

        // словарь Морзе-Буква
        public static Dictionary<string, string> MorseToAbc = new Dictionary<string, string>() {
            { ".-", "A"}, { "-...", "B"},{ "-.-.", "C"},{ "-..", "D"},
            { ".", "E"}, { "..-.", "F"}, { "--.", "G"}, { "....", "H"},
            { "..", "I"}, { ".---", "J"}, { "-.-", "K"}, { ".-..", "L"},
            { "--", "M"}, { "-.", "N"}, { "---", "O"}, { ".--.", "P"},
            { "--.-", "Q"}, { ".-.", "R"}, { "...", "S"}, { "-", "T"},
            { "..-", "U"}, { "...-", "V"}, { ".--", "W"}, { "-..-", "X"},
            { "-.--", "Y"},{ "--..", "Z"}, { "", " "},
        };

        // словарь Буква-Морзе
        public static Dictionary<string, string> AbsToMorse = MorseToAbc.ToDictionary(k => k.Value, v => v.Key);

        // перевод текста в Морзе
        static string ToMorse(string input)
        {
            input = input.ToUpper();

            string[] encoded = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                encoded[i] = AbsToMorse[input[i].ToString()] + " ";
            }

            return string.Concat(encoded);
        }

        // перевод из Морзе в текст
        static List<string> FromMorse(string input)
        {
            string[] words = input.Replace("  ", "2").Split('2');
            List<string[]> morseInput = new List<string[]>();
            foreach (var word in words)
            {
                morseInput.Add(word.Split());
            }


            List<string> morseDecoded = new List<string>();
            foreach (var word in morseInput)
            {
                string[] decoded = new string[word.Length];

                for (int i = 0; i < word.Length; i++)
                {
                    decoded[i] = MorseToAbc[word[i]];
                }
                morseDecoded.Add(string.Concat(decoded));
            }

            return morseDecoded;
        }

        // Шифрование Азбука Морзе
        private void button1_Click(object sender, EventArgs e)
        {
            string morse = ToMorse(textBox1.Text);
            textBox2.Text = morse;
        }

        private void Morse_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string morse = textBox1.Text;
            // перевели из Морзе в слово
            foreach (var word in FromMorse(morse))
            {
                textBox2.Text = word;
            }
        }
    }
}
