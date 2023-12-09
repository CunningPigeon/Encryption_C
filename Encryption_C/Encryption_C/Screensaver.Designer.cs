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
            progressBar1.Location = new Point(4, 245);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(627, 36);
            progressBar1.TabIndex = 0;
            progressBar1.Visible = false;
            // 
            // Screensaver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(634, 286);
            Controls.Add(progressBar1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
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