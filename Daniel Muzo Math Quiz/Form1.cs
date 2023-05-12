using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daniel_Muzo_Math_Quiz
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();
        private int _timeLeft = 30;
        public Form1()
        {
            InitializeComponent();
            // Display the current date
            labelDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            StartQuiz();
        }



        private void GenerateRandomNumbers()
        {
            plusLeftLabel.Text = _random.Next(51).ToString();
            plusRightLabel.Text = _random.Next(51).ToString();
            minusLeftLabel.Text = _random.Next(1, 101).ToString();
            minusRightLabel.Text = _random.Next(1, 101).ToString();
            timesLeftLabel.Text = _random.Next(2, 11).ToString();
            timesRightLabel.Text = _random.Next(2, 11).ToString();
            dividedLeftLabel.Text = _random.Next(2, 11).ToString();
            dividedRightLabel.Text = _random.Next(2, 11).ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_timeLeft > 0)
            {
                _timeLeft--;
                timeLabel.Text = _timeLeft + " seconds";
            }
            else
            {
                timer.Stop();
                timeLabel.Text = "Time's up!";
                timeLabel.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("You didn't finish in time.", "Sorry!");
            }
        }



 



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }
    }
}