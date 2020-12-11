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
    public partial class WindowGame : Form
    {
        public static int points = 0;
        private String answer = "TOOTH";
      


        public WindowGame()
        {
            InitializeComponent();
        }

        private void WindowGame_Load(object sender, EventArgs e)
        {
 
            button1.Text = "Q";
            button2.Text = "T";
            button3.Text = "I";
            button4.Text = "P";
            button5.Text = "B";
            button6.Text = "O";
            button7.Text = "N";
            button8.Text = "T";
            button9.Text = "H";
            button10.Text = "E";
            button11.Text = "R";
            button12.Text = "U";
            label3.Text = "  ";
            label4.Text = "  ";
            label5.Text = "  ";
            label6.Text = "  ";
            label7.Text = "  ";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(timeLabel.Text);

            if (x == 1)
            {
                timer1.Stop();

                timeLabel.Text = "0";

                MessageBox.Show("Times up!\nYour final point/s is " + points);

                progressReset();

                WindowStart windowStart = new WindowStart();
                this.Close();
                windowStart.Show();
            }
            x -= 1;

            timeLabel.Text = x + "";

            if (x <= 10)
            {
                timeLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                timeLabel.ForeColor = System.Drawing.Color.PaleGreen;
            }
        }

        public void setLabelValue(Button c)
        {

            if (label3.Text.Equals("  "))
            {
                label3.Text = c.Text;
            }

            else if (label4.Text.Equals("  "))
            {
                label4.Text = c.Text;
            }

            else if (label5.Text.Equals("  "))
            {
                label5.Text = c.Text;
            }

            else if (label6.Text.Equals("  "))
            {
                label6.Text = c.Text;
            }

            else if (label7.Text.Equals("  "))
            {
                label7.Text = c.Text;
            }
  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            setLabelValue(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setLabelValue(button2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            setLabelValue(button3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            setLabelValue(button4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            setLabelValue(button5);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            setLabelValue(button11);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            setLabelValue(button6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            setLabelValue(button7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            setLabelValue(button8);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            setLabelValue(button10);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            setLabelValue(button12);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            setLabelValue(button9);
        }


        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "  ";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "  ";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "  ";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = "  ";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = "  ";
        }


        public void reset()
        {
            button1.Text = "Q";
            button2.Text = "T";
            button3.Text = "I";
            button4.Text = "P";
            button5.Text = "B";
            button6.Text = "O";
            button7.Text = "N";
            button8.Text = "T";
            button9.Text = "H";
            button10.Text = "E";
            button11.Text = "R";
            button12.Text = "U";
            label3.Text = "  ";
            label4.Text = "  ";
            label5.Text = "  ";
            label6.Text = "  ";
            label7.Text = "  ";

            lblLevel.Text = (1 + points) + "";
            if (points == 1)
            {
                button4.Text = "L";
                button5.Text = "C";
                button6.Text = "S";
                button7.Text = "N";
                button8.Text = "W";
                this.answer = "SLICE";
                this.pictureBox1.Image = global::_4Pics1Word_EFAL.Properties.Resources.Stage2;
            }
            else if (points == 2)
            {
                button1.Text = "I";
                button2.Text = "T";
                button3.Text = "H";
                button4.Text = "P";
                button6.Text = "T";
                button12.Text = "W";
                this.answer = "WHITE";
                this.pictureBox1.Image = global::_4Pics1Word_EFAL.Properties.Resources.Stage3;
            }
            else if (points == 3)
            {
                button6.Text = "S";
                button9.Text = "P";
                button4.Text = "C";
                button1.Text = "A";
                this.answer = "SPACE";
                this.pictureBox1.Image = global::_4Pics1Word_EFAL.Properties.Resources.Stage4;
            }
            else if (points == 4)
            {
                button2.Text = "R";
                button5.Text = "F";
                button7.Text = "M";
                button12.Text = "A";
                this.answer = "MAFIA";
                this.pictureBox1.Image = global::_4Pics1Word_EFAL.Properties.Resources.Stage5;
            }
            else if (points == 5)
            {
                button1.Text = "R";
                button11.Text = "D";
                button6.Text = "M";
                button10.Text = "A";
                this.answer = "ADMIN";
                this.pictureBox1.Image = global::_4Pics1Word_EFAL.Properties.Resources.Stage6;
            }
            else if (points == 6)
            {
                button1.Text = "C";
                button3.Text = "S";
                button6.Text = "A";
                button8.Text = "F";
                this.answer = "SCARF";
                this.pictureBox1.Image = global::_4Pics1Word_EFAL.Properties.Resources.Stage7;
            }
            else if (points == 7)
            {
                button9.Text = "P";
                button2.Text = "T";
                button8.Text = "C";
                button12.Text = "S";
                this.answer = "SPECS";
                this.pictureBox1.Image = global::_4Pics1Word_EFAL.Properties.Resources.Stage8;
            }
            else if (points == 8)
            {
                button10.Text = "P";
                button1.Text = "D";
                button5.Text = "Z";
                button7.Text = "E";
                this.answer = "PRIDE";
                this.pictureBox1.Image = global::_4Pics1Word_EFAL.Properties.Resources.Stage9;
            }
            else if (points == 9)
            {
                button2.Text = "Y";
                button5.Text = "U";
                button7.Text = "M";
                button12.Text = "A";
                this.answer = "TOMMY";
                this.pictureBox1.Image = global::_4Pics1Word_EFAL.Properties.Resources.Stage10;
            }

            else
            {
                progressReset();
                WindowLast windowLast = new WindowLast();
                this.Close();
                windowLast.Show();
            }
            this.timeLabel.Text = "30";
            this.timer1.Start();

        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            String s = label3.Text.ToString().Substring(0, 1) +
                       label4.Text.ToString().Substring(0, 1) +
                       label5.Text.ToString().Substring(0, 1) +
                       label6.Text.ToString().Substring(0, 1) +
                       label7.Text.ToString().Substring(0, 1);
            if (s.Equals(answer))
            {
                points++;
                MessageBox.Show("Congratulations! You now have " + points + " point/s");
                reset();

            }
            else
            {
                MessageBox.Show("Wrong Answer! \nHurry Up!");
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            WindowStart windowStart = new WindowStart();
            this.Close();
            windowStart.Show();
        }

        public void progressReset()
        {
            if(points != 0 && !lblLevel.Text.Equals("1"))
            {
                points = 0;
                lblLevel.Text = "1";
                reset();
            }
        }
    }
}
