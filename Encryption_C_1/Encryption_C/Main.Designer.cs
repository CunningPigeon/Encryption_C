﻿namespace Encryption_C
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            теорияToolStripMenuItem = new ToolStripMenuItem();
            шифрЦезаряToolStripMenuItem = new ToolStripMenuItem();
            транпозиционныйШифрToolStripMenuItem = new ToolStripMenuItem();
            азбукаМорзеToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { теорияToolStripMenuItem, шифрЦезаряToolStripMenuItem, транпозиционныйШифрToolStripMenuItem, азбукаМорзеToolStripMenuItem, toolStripSeparator1, выходToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(65, 24);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // теорияToolStripMenuItem
            // 
            теорияToolStripMenuItem.Name = "теорияToolStripMenuItem";
            теорияToolStripMenuItem.Size = new Size(269, 26);
            теорияToolStripMenuItem.Text = "Теория";
            // 
            // шифрЦезаряToolStripMenuItem
            // 
            шифрЦезаряToolStripMenuItem.Name = "шифрЦезаряToolStripMenuItem";
            шифрЦезаряToolStripMenuItem.Size = new Size(269, 26);
            шифрЦезаряToolStripMenuItem.Text = "Шифр Цезаря";
            шифрЦезаряToolStripMenuItem.Click += button1_Click;
            // 
            // транпозиционныйШифрToolStripMenuItem
            // 
            транпозиционныйШифрToolStripMenuItem.Name = "транпозиционныйШифрToolStripMenuItem";
            транпозиционныйШифрToolStripMenuItem.Size = new Size(269, 26);
            транпозиционныйШифрToolStripMenuItem.Text = "Транпозиционный шифр";
            транпозиционныйШифрToolStripMenuItem.Click += button2_Click;
            // 
            // азбукаМорзеToolStripMenuItem
            // 
            азбукаМорзеToolStripMenuItem.Name = "азбукаМорзеToolStripMenuItem";
            азбукаМорзеToolStripMenuItem.Size = new Size(269, 26);
            азбукаМорзеToolStripMenuItem.Text = "Азбука Морзе";
            азбукаМорзеToolStripMenuItem.Click += button3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(266, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(269, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 522);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(524, 106);
            button1.Name = "button1";
            button1.Size = new Size(150, 150);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(401, 282);
            button2.Name = "button2";
            button2.Size = new Size(150, 150);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(585, 282);
            button3.Name = "button3";
            button3.Size = new Size(150, 150);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(340, 106);
            button4.Name = "button4";
            button4.Size = new Size(150, 150);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(982, 553);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Encryption";
            FormClosed += Main_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ToolStripMenuItem теорияToolStripMenuItem;
        private ToolStripMenuItem шифрЦезаряToolStripMenuItem;
        private ToolStripMenuItem транпозиционныйШифрToolStripMenuItem;
        private ToolStripMenuItem азбукаМорзеToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}