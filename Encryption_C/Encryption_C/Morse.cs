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
        /*
         * /*
         * { ".-", "А"}, { "-...", "Б"},{ ".--", "В"},{ "--.", "Г"},
            { ".", "Е"}, { "-..", "Д"}, { "...-", "Ж"}, { "--..", "З"},
            { "..", "И"}, { ".---", "Й"}, { "-.-", "К"}, { ".-..", "Л"},
            { "--", "М"}, { "-.", "Н"}, { "---", "О"}, { ".-.", "Р"},
            { "..-.", "Ф"}, { ".--.", "П"}, { "...", "С"}, { "-", "Т"},
            { "..-", "У"}, { "....", "Х"}, { ".--.-.", "Ъ"}, { "-.-.", "Ц"},
            { "----", "Ш"}, { "--.-", "Щ"},{ "---.", "Ч"}, { "-.--", "Ы"},
            { "-..-", "Ь"}, { "...-...", "Э"}, { "..--", "Ю"}, { ".-.-", "Я"},
            { "", " "}, { ",", ","},
         *  а, б, в, г, д, е, ё, ж, з, и, й, к, л, м, н, о, п, р, с, т, у, ф, х, ц, ч, ш, щ, ъ, ы, ь, э, ю, я
         */

        // словарь Морзе-Буква
        public static Dictionary<string, string> MorseToAbc = new Dictionary<string, string>() {
            { ".-", "А"}, { "-...", "Б"},{ ".--", "В"},{ "--.", "Г"},
            { ".", "Е"}, { "-..", "Д"}, { "...-", "Ж"}, { "--..", "З"},
            { "..", "И"}, { ".---", "Й"}, { "-.-", "К"}, { ".-..", "Л"},
            { "--", "М"}, { "-.", "Н"}, { "---", "О"}, { ".-.", "Р"},
            { "..-.", "Ф"}, { ".--.", "П"}, { "...", "С"}, { "-", "Т"},
            { "..-", "У"}, { "....", "Х"}, { ".--.-.", "Ъ"}, { "-.-.", "Ц"},
            { "----", "Ш"}, { "--.-", "Щ"},{ "---.", "Ч"}, { "-.--", "Ы"},
            { "-..-", "Ь"}, { "...-...", "Э"}, { "..--", "Ю"}, { ".-.-", "Я"},
            { "", " "}, { ",", ","}, { ".", "."},
        };

        // словарь Буква-Морзе
        public static Dictionary<string, string> AbsToMorse = MorseToAbc.ToDictionary(k => k.Value, v => v.Key);

        // перевод текста в Морзе
        static string ToMorse(string input)
        {
            input = input.ToUpper();

            string[] encoded = new string[input.Length];
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    encoded[i] = AbsToMorse[input[i].ToString()] + " ";
                }
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                MessageBox.Show("Поменяйте язык ввода");
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox5.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox2.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
