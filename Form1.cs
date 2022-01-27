using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace laba01
{
    public partial class Form1 : Form
    {
        public int counter = 1;
        public int width = 20;
        public int height = 350;
        public Form1()
        {
            InitializeComponent();
        }


        private void delB_Click(object sender, EventArgs e)
        {
            delBox.Text = "";
            progressBar1.Value = 30;
        }

        private void OKnameB_Click(object sender, EventArgs e)
        {
            string greeting = "Hello, " + textBox1.Text;
            greetBox.Text = greeting;
            delBox.Text = greeting;
            progressBar1.Value = 20;
        }

        private void greetBox_MouseHover(object sender, EventArgs e)
        {
            greetBox.ForeColor = Color.Green;
        }

        private void greetBox_MouseLeave(object sender, EventArgs e)
        {
            greetBox.ForeColor = Color.Black;
        }

        private void LanguageCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string new_t = LanguageCBox.Text + " is chosen";
            LanguageL.Text = new_t;
            progressBar1.Value = 40;
        }

        private void WorkCompleteChBox_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations!");
            progressBar1.Value = 60;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.CheckAlign == ContentAlignment.MiddleLeft)
            {
                radioButton1.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                radioButton1.CheckAlign = ContentAlignment.MiddleLeft;
            }
            progressBar1.Value = 50;
        }

        private void UniversLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(UniversLBox.Text == "USATU")
            {
                testL.Text = "Hello, bro!";
            } else
            {
                testL.Text = "Test is failed :(";
            }
            progressBar1.Value = 70;
        }

        private void colorP_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] abc = new int[3];
            for(int i = 0; i < 3; ++i)
                abc[i] = rnd.Next(0, 254);
            colorP.BackColor = Color.FromArgb(abc[0], abc[1], abc[2]);
            progressBar1.Value = 80;
        }

        private void colorP_MouseHover(object sender, EventArgs e)
        {
            colorP.Size = new Size(70,70);
        }

        private void colorP_MouseLeave(object sender, EventArgs e)
        {
            colorP.Size = new Size(90,90);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
        }

        private void newfbut_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Size = new Size(30, 15);
            button.Name = "but" + counter;
            button.Location = MousePosition;
            this.Controls.Add(button);
        }


        private void newbbut_Click(object sender, EventArgs e)
        {

            Button button = new Button();
            button.Size = new Size(50, 25);
            button.Name = "but" + counter;
            button.Text = button.Name;
            button.Location = new Point(width, height);
            button.Click += new System.EventHandler(this.remove_Click);
            width += 60;
            if (width > 315)
            {
                width = 20;
                height += 35;
            }
            this.Controls.Add(button);
            counter++;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(sender as Button);
        }

        private void birthMaskTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            birthMaskTB.ForeColor = Color.Red;
        }

        private void birthMaskTB_Validated(object sender, EventArgs e)
        {
            birthMaskTB.ForeColor = Color.Green;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            /*DateTime examDate = new DateTime(2022, 1, 19);
            if (e.Equals(examDate)) label2.Text = "exam date";*/
            label2.Text = "Date Selected: Start = " + e.Start.ToShortDateString() +
                " : End = " + e.End.ToShortDateString();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            timerLabel.Text = i.ToString();
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageCBox.SelectedIndex = tabControl1.SelectedIndex;
        }
    }
}
