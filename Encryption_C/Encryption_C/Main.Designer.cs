namespace Encryption_C
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.GhostWhite;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1000, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.BackColor = Color.GhostWhite;
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { теорияToolStripMenuItem, шифрЦезаряToolStripMenuItem, транпозиционныйШифрToolStripMenuItem, азбукаМорзеToolStripMenuItem, toolStripSeparator1, выходToolStripMenuItem });
            менюToolStripMenuItem.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            менюToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            менюToolStripMenuItem.Image = (Image)resources.GetObject("менюToolStripMenuItem.Image");
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(78, 24);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // теорияToolStripMenuItem
            // 
            теорияToolStripMenuItem.Image = (Image)resources.GetObject("теорияToolStripMenuItem.Image");
            теорияToolStripMenuItem.Name = "теорияToolStripMenuItem";
            теорияToolStripMenuItem.Size = new Size(270, 26);
            теорияToolStripMenuItem.Text = "Теория";
            // 
            // шифрЦезаряToolStripMenuItem
            // 
            шифрЦезаряToolStripMenuItem.Image = (Image)resources.GetObject("шифрЦезаряToolStripMenuItem.Image");
            шифрЦезаряToolStripMenuItem.Name = "шифрЦезаряToolStripMenuItem";
            шифрЦезаряToolStripMenuItem.Size = new Size(270, 26);
            шифрЦезаряToolStripMenuItem.Text = "Шифр Цезаря";
            шифрЦезаряToolStripMenuItem.Click += button1_Click;
            // 
            // транпозиционныйШифрToolStripMenuItem
            // 
            транпозиционныйШифрToolStripMenuItem.Image = (Image)resources.GetObject("транпозиционныйШифрToolStripMenuItem.Image");
            транпозиционныйШифрToolStripMenuItem.Name = "транпозиционныйШифрToolStripMenuItem";
            транпозиционныйШифрToolStripMenuItem.Size = new Size(270, 26);
            транпозиционныйШифрToolStripMenuItem.Text = "Транпозиционный шифр";
            транпозиционныйШифрToolStripMenuItem.Click += button2_Click;
            // 
            // азбукаМорзеToolStripMenuItem
            // 
            азбукаМорзеToolStripMenuItem.Image = (Image)resources.GetObject("азбукаМорзеToolStripMenuItem.Image");
            азбукаМорзеToolStripMenuItem.Name = "азбукаМорзеToolStripMenuItem";
            азбукаМорзеToolStripMenuItem.Size = new Size(270, 26);
            азбукаМорзеToolStripMenuItem.Text = "Азбука Морзе";
            азбукаМорзеToolStripMenuItem.Click += button3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Image = (Image)resources.GetObject("выходToolStripMenuItem.Image");
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(270, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveBorder;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.MediumOrchid;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkOrchid;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(522, 119);
            button1.Name = "button1";
            button1.Size = new Size(150, 171);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveBorder;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.MediumOrchid;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.DarkOrchid;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(350, 305);
            button2.Name = "button2";
            button2.Size = new Size(150, 171);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveBorder;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.MediumOrchid;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.DarkOrchid;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(522, 305);
            button3.Name = "button3";
            button3.Size = new Size(150, 171);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveBorder;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.MediumOrchid;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.DarkOrchid;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(350, 119);
            button4.Name = "button4";
            button4.Size = new Size(150, 171);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 604);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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