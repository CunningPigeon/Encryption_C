namespace Encryption_C
{
    partial class Transposition
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
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            butt_save = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            tabPage3 = new TabPage();
            button5 = new Button();
            But_save = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            button4 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(983, 553);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(975, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Теория";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(butt_save);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(975, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Текстом";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // butt_save
            // 
            butt_save.Location = new Point(838, 38);
            butt_save.Name = "butt_save";
            butt_save.Size = new Size(90, 28);
            butt_save.TabIndex = 20;
            butt_save.Text = "Скачать";
            butt_save.UseVisualStyleBackColor = true;
            butt_save.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(196, 37);
            button3.Name = "button3";
            button3.Size = new Size(134, 29);
            button3.TabIndex = 13;
            button3.Text = "Дешифрование";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(366, 38);
            textBox3.MaxLength = 30;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 27);
            textBox3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 246);
            label2.Name = "label2";
            label2.Size = new Size(291, 20);
            label2.TabIndex = 11;
            label2.Text = "Зашифрованный/дешифрованный текст";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 278);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(888, 100);
            textBox2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 81);
            label1.Name = "label1";
            label1.Size = new Size(290, 20);
            label1.TabIndex = 9;
            label1.Text = "Текст для шифрованния/дешифрования";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 113);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(888, 100);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(40, 36);
            button1.Name = "button1";
            button1.Size = new Size(124, 29);
            button1.TabIndex = 7;
            button1.Text = "Шифрование";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(But_save);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(button4);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(975, 520);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Файлом";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(664, 39);
            button5.Name = "button5";
            button5.Size = new Size(135, 28);
            button5.TabIndex = 20;
            button5.Text = "Загрузить файл";
            button5.UseVisualStyleBackColor = true;
            // 
            // But_save
            // 
            But_save.Location = new Point(838, 39);
            But_save.Name = "But_save";
            But_save.Size = new Size(90, 28);
            But_save.TabIndex = 19;
            But_save.Text = "Скачать";
            But_save.UseVisualStyleBackColor = true;
            But_save.Click += But_save_Click;
            // 
            // button2
            // 
            button2.Location = new Point(196, 38);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 18;
            button2.Text = "Дешифрование";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(366, 39);
            textBox4.MaxLength = 30;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(148, 27);
            textBox4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 82);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 16;
            label3.Text = "Имя файла";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(40, 114);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(888, 100);
            textBox5.TabIndex = 15;
            // 
            // button4
            // 
            button4.Location = new Point(40, 37);
            button4.Name = "button4";
            button4.Size = new Size(124, 29);
            button4.TabIndex = 14;
            button4.Text = "Шифрование";
            button4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Transposition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Transposition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transposition";
            FormClosed += Transposition_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button But_save;
        private Button button2;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private Button button4;
        private Button button5;
        private Button butt_save;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}