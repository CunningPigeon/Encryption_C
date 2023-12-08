namespace Encryption_C
{
    partial class Caesar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            tabPage1 = new TabPage();
            button3 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            tabPage2 = new TabPage();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(979, 551);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(971, 518);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Теория";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(971, 518);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Текстом";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(196, 42);
            button3.Name = "button3";
            button3.Size = new Size(134, 29);
            button3.TabIndex = 6;
            button3.Text = "Дешифрование";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(366, 43);
            textBox3.MaxLength = 2;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(59, 27);
            textBox3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 251);
            label2.Name = "label2";
            label2.Size = new Size(291, 20);
            label2.TabIndex = 4;
            label2.Text = "Зашифрованный/дешифрованный текст";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 283);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(888, 100);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 86);
            label1.Name = "label1";
            label1.Size = new Size(290, 20);
            label1.TabIndex = 2;
            label1.Text = "Текст для шифрованния/дешифрования";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 118);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(888, 100);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(40, 41);
            button1.Name = "button1";
            button1.Size = new Size(124, 29);
            button1.TabIndex = 0;
            button1.Text = "Шифрование";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(971, 518);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Файлом";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(771, 42);
            button6.Name = "button6";
            button6.Size = new Size(150, 28);
            button6.TabIndex = 14;
            button6.Text = "Скачать файл";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(593, 42);
            button5.Name = "button5";
            button5.Size = new Size(153, 28);
            button5.TabIndex = 13;
            button5.Text = "Загрузить файл";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(182, 40);
            button4.Name = "button4";
            button4.Size = new Size(136, 30);
            button4.TabIndex = 12;
            button4.Text = "Дешифрование";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(340, 41);
            textBox4.MaxLength = 2;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(59, 27);
            textBox4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 85);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 8;
            label4.Text = "Имя файла";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(33, 117);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(888, 100);
            textBox5.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(34, 40);
            button2.Name = "button2";
            button2.Size = new Size(124, 29);
            button2.TabIndex = 6;
            button2.Text = "Шифрование";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Caesar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Caesar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Шифр Цезаря";
            FormClosed += Caesar_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TabPage tabPage3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private OpenFileDialog openFileDialog1;
        private Button button6;
    }
}