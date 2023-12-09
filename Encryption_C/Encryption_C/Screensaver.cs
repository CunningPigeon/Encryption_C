using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Encryption_C
{
    public partial class Screensaver : Form
    {
        public Screensaver()
        {
            InitializeComponent();
            progressBar1.ForeColor = Color.FromArgb(255, 0, 0);
        }

        Main main = new Main();
        private void timer1_Tick(object sender, EventArgs e)
        {


            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                main.Show();
                this.Close();
            }
            else
            {
                progressBar1.Value += 10;
            }
        }


        /*private void Screensaver_Shown(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            for (int i = 25 * 60; i > 0; i--)
            {
                progressBar1.Value = i * 100 / (25 * 60);
                await Task.Delay(1000);
            }
            Close();
        }
        }*/

    }

}
