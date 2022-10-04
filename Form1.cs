using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DoublePendulum
{
    public partial class Form1 : Form
    {
        PendulumImage pImage;
        PendulumParameters p;
        Recording recording;
        double timeStep;
        bool isActive = false;
        int iterationsPerFrame = 20;

        private void Stop_Click(object sender, EventArgs e) =>
            isActive = false;

        private void Reset_Click(object sender, EventArgs e)
        {
            isActive = false;
            L1TextBox.Text = 50.ToString();
            L2TextBox.Text = 50.ToString();
            θ1TextBox.Text = 0.ToString();
            θ2TextBox.Text = 0.ToString();
            gTextBox.Text = 9.81.ToString();
            m1TextBox.Text = 1.ToString();
            m2TextBox.Text = 1.ToString();
            v1TextBox.Text = 0.ToString();
            v2TextBox.Text = 0.ToString();
            p = new PendulumParameters();
            L1Scroll.Value = int.Parse(L1TextBox.Text);
            L2Scroll.Value = int.Parse(L2TextBox.Text);
            θ1Scroll.Value = int.Parse(θ1TextBox.Text);
            θ2Scroll.Value = int.Parse(θ2TextBox.Text);
        }

        private void gTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TrySet(gTextBox))
                p.G = double.Parse(gTextBox.Text);
        }

        private void m2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TrySet(m2TextBox))
                p.M2 = double.Parse(m2TextBox.Text);
        }

        private void v1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TrySet(v1TextBox))
                p.v1 = double.Parse(v1TextBox.Text);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            recording.Save();
            Record.Text = "Record";
        }

        private void Record_Click(object sender, EventArgs e)
        {
            Record.Text = "Recording...";
            recording.TurnOn();
        }

        private void v2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TrySet(v2TextBox))
                p.v2 = double.Parse(v2TextBox.Text);
        }

        private bool TrySet(TextBox textBox)
        {
            if (double.TryParse(textBox.Text, out double value))
            {
                textBox.BackColor = Color.White;
                return true;
            }
            textBox.BackColor = Color.Red;
            return false;
        }

        private void m1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TrySet(m1TextBox))
                p.M1 = double.Parse(m1TextBox.Text);
        }

        public Form1() =>
            InitializeComponent();

        private void CloseButton_Click(object sender, EventArgs e) =>
            Close();

        private void θ1Scroll_Scroll(object sender, EventArgs e) =>
            θ1TextBox.Text = θ1Scroll.Value.ToString();

        private void θ2Scroll_Scroll(object sender, EventArgs e) =>
            θ2TextBox.Text = θ2Scroll.Value.ToString();

        private void L2Scroll_Scroll(object sender, EventArgs e) =>
            L2TextBox.Text = L2Scroll.Value.ToString();

        private void L1Scroll_Scroll(object sender, EventArgs e) =>
            L1TextBox.Text = L1Scroll.Value.ToString();

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                for (int i = 0; i < iterationsPerFrame; i++)
                {
                    Calculations.ERK4(p, timeStep);
                    if (recording.IsOn)
                        recording.Add(p.A1, p.A2);
                }
            }
            pictureBox1.Image = pImage.GetImage(p);
        }

        private void L1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TrySyncTextBox(L1TextBox, L1Scroll))
                p.L1InCm = int.Parse(L1TextBox.Text);
        }

        private bool TrySyncTextBox(TextBox textBox, TrackBar scroll)
        {
            if (int.TryParse(textBox.Text, out int value) &&
                            int.Parse(textBox.Text) >= scroll.Minimum
                            && int.Parse(textBox.Text) <= scroll.Maximum)
            {
                textBox.BackColor = Color.White;
                scroll.Value = value;
                return true;
            }
            textBox.BackColor = Color.Red;
            return false;
        }

        private void L2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TrySyncTextBox(L2TextBox, L2Scroll))
                p.L2InCm = int.Parse(L2TextBox.Text);
        }

        private void θ1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TrySyncTextBox(θ1TextBox, θ1Scroll))
                p.A1InDegrees = int.Parse(θ1TextBox.Text);
        }

        private void θ2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TrySyncTextBox(θ2TextBox, θ2Scroll))
                p.A2InDegrees = int.Parse(θ2TextBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pImage = new PendulumImage(pictureBox1.Width, pictureBox1.Height);
            p = new PendulumParameters();
            L1Scroll.Value = int.Parse(L1TextBox.Text);
            L2Scroll.Value = int.Parse(L2TextBox.Text);
            θ1Scroll.Value = int.Parse(θ1TextBox.Text);
            θ2Scroll.Value = int.Parse(θ2TextBox.Text);
            double interval = timer.Interval / 1000d;
            timeStep = interval / iterationsPerFrame;
            recording = new Recording(timeStep);
        }

        private void Start_Click(object sender, EventArgs e) =>
            isActive = true;
    }
}
