using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Pics1Word_EFAL
{
    public partial class WindowLast : Form
    {
        public WindowLast()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            WindowGame windowGame = new WindowGame();
            this.Hide();
            windowGame.Show();
        }
    }
}
