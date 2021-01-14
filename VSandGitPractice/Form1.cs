using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSandGitPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnPush_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100000; i++)
            {
                await Task.Delay(1000);
                lblCounter.Text = Convert.ToString(i);
            }
        }
        // Yes I know that this button can be pressed more than once, but all this async stuff was beyond the scope of this part of the training, I just wanted a timer....
    }
}
