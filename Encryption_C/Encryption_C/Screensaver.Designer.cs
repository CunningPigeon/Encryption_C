namespace Encryption_C
{
    partial class Screensaver
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screensaver));
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.WindowText;
            progressBar1.Location = new Point(27, 198);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(549, 27);
            progressBar1.TabIndex = 0;
            progressBar1.Visible = false;
            // 
            // Screensaver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(620, 250);
            Controls.Add(progressBar1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Screensaver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screensaver";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
    }
}