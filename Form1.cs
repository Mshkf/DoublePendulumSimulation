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
        double g, m1, m2, l1, l2, interval, h;
        int height, width, x0, y0, x1, y1, x2, y2;
        double a1, a2, da1, da2;
        bool isActive = false, isRecording = false;
        Vector u, p;
        List<Vector> ulist;
        int iterationsPerFrame = 20;
        Brush blackBrush = Brushes.Black;
        Brush redBrush = Brushes.Red;
        Brush blueBrush = Brushes.Blue;
        Pen blackPen = new Pen(Color.Black);
        static Bitmap Pole;
        Graphics PoleGraphics;

        private void Stop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

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
            l1 = int.Parse(L1TextBox.Text) / 100d;
            l2 = int.Parse(L2TextBox.Text) / 100d;
            a1 = int.Parse(θ1TextBox.Text) * 2 * Math.PI / 360;
            a2 = int.Parse(θ2TextBox.Text) * 2 * Math.PI / 360;
            g = double.Parse(gTextBox.Text);
            m1 = double.Parse(m1TextBox.Text);
            m2 = double.Parse(m2TextBox.Text);
            da1 = double.Parse(v1TextBox.Text) / l1;
            da2 = double.Parse(v2TextBox.Text) / l1;
            L1Scroll.Value = int.Parse(L1TextBox.Text);
            L2Scroll.Value = int.Parse(L2TextBox.Text);
            θ1Scroll.Value = int.Parse(θ1TextBox.Text);
            θ2Scroll.Value = int.Parse(θ2TextBox.Text);
            u = new Vector(a1, a2, da1, da2);
        }

        private void gTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValid(gTextBox))
                g = double.Parse(gTextBox.Text);
        }

        private void m2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValid(m2TextBox))
                m2 = double.Parse(m2TextBox.Text);
        }

        private void v1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValid(v1TextBox))
                da1 = double.Parse(v1TextBox.Text) / l1;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            isRecording = false;
            Record.Text = "Record";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.Unicode);
                double time = 0d;
                foreach (Vector u in ulist)
                {
                    sw.WriteLine(time.ToString() + "\t" + u[0] + "\t" + u[1]);
                    time += h;
                }
                ulist.Clear();
                sw.Close();
            }
        }

        private void Record_Click(object sender, EventArgs e)
        {
            isRecording = true;
            Record.Text = "Recording...";
            ulist = new List<Vector>();
            if (isActive)
                ulist.Add(u);
        }

        private void v2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValid(v2TextBox))
                da2 = double.Parse(v2TextBox.Text) / l2;
        }

        private bool IsValid(TextBox textBox)
        {
            if (double.TryParse(textBox.Text, out double a))
            {
                textBox.BackColor = Color.White;
                return true;
            }
            textBox.BackColor = Color.Red;
            return false;
        }

        private void m1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValid(m1TextBox))
                m1 = double.Parse(m1TextBox.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void θ1Scroll_Scroll(object sender, EventArgs e)
        {
            θ1TextBox.Text = θ1Scroll.Value.ToString();
        }

        private void θ2Scroll_Scroll(object sender, EventArgs e)
        {
            θ2TextBox.Text = θ2Scroll.Value.ToString();
        }

        private void L2Scroll_Scroll(object sender, EventArgs e)
        {
            L2TextBox.Text = L2Scroll.Value.ToString();
        }

        private void L1Scroll_Scroll(object sender, EventArgs e)
        {
            L1TextBox.Text = L1Scroll.Value.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                for (int i = 0; i < iterationsPerFrame; i++)
                {
                    u = Calc.ERK4(u, p, h);
                    if (isRecording)
                        ulist.Add(u);
                }
                a1 = u[0];
                a2 = u[1];
            }
            x1 = x0 + (int)(l1 * 200 * Math.Sin(a1));
            y1 = y0 + (int)(l1 * 200 * Math.Cos(a1));
            x2 = x1 + (int)(l2 * 200 * Math.Sin(a2));
            y2 = y1 + (int)(l2 * 200 * Math.Cos(a2));
            PoleGraphics.Clear(Color.White);
            PoleGraphics.DrawLine(blackPen, x0, y0, x1, y1);
            PoleGraphics.DrawLine(blackPen, x1, y1, x2, y2);
            PoleGraphics.FillEllipse(blackBrush, x0 - 5, y0 - 5, 10, 10);
            PoleGraphics.FillEllipse(redBrush, x1 - 5, y1 - 5, 10, 10);
            PoleGraphics.FillEllipse(blueBrush, x2 - 5, y2 - 5, 10, 10);
            pictureBox1.Image = Pole;
        }

        private void L1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (SyncTextBox(L1TextBox, L1Scroll))
                l1 = int.Parse(L1TextBox.Text) / 100d;
        }

        private bool SyncTextBox(TextBox textBox, TrackBar scroll)
        {
            if (int.TryParse(textBox.Text, out int a) &&
                            int.Parse(textBox.Text) >= scroll.Minimum
                            && int.Parse(textBox.Text) <= scroll.Maximum)
            {
                textBox.BackColor = Color.White;
                scroll.Value = int.Parse(textBox.Text);
                return true;
            }
            textBox.BackColor = Color.Red;
            return false;
        }

        private void L2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (SyncTextBox(L2TextBox, L2Scroll))
                l2 = int.Parse(L2TextBox.Text) / 100d;
        }

        private void θ1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (SyncTextBox(θ1TextBox, θ1Scroll))
                a1 = int.Parse(θ1TextBox.Text) * 2 * Math.PI / 360;
        }

        private void θ2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (SyncTextBox(θ2TextBox, θ2Scroll))
                a2 = int.Parse(θ2TextBox.Text) * 2 * Math.PI / 360;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            width = pictureBox1.Width;
            height = pictureBox1.Height;
            Pole = new Bitmap(width, height);
            PoleGraphics = Graphics.FromImage(Pole);
            x0 = width / 2;
            y0 = height / 3;
            l1 = int.Parse(L1TextBox.Text) / 100d;
            l2 = int.Parse(L2TextBox.Text) / 100d;
            a1 = int.Parse(θ1TextBox.Text) * 2 * Math.PI / 360;
            a2 = int.Parse(θ2TextBox.Text) * 2 * Math.PI / 360;
            g = double.Parse(gTextBox.Text);
            m1 = double.Parse(m1TextBox.Text);
            m2 = double.Parse(m2TextBox.Text);
            da1 = double.Parse(v1TextBox.Text) / l1;
            da2 = double.Parse(v2TextBox.Text) / l1;
            L1Scroll.Value = int.Parse(L1TextBox.Text);
            L2Scroll.Value = int.Parse(L2TextBox.Text);
            θ1Scroll.Value = int.Parse(θ1TextBox.Text);
            θ2Scroll.Value = int.Parse(θ2TextBox.Text);
            interval = timer.Interval / 1000d;
            h = interval / iterationsPerFrame;

        }

        private void Start_Click(object sender, EventArgs e)
        {
            isActive = true;
            u = new Vector(a1, a2, da1, da2);
            p = new Vector(g, l1, l2, m1, m2);
            if (isRecording)
                ulist.Add(u);
        }
    }
}
