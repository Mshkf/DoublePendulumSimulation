using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoublePendulum
{
    internal class Recording
    {
        bool isRecording;
        List<Tuple<double, double>> anglesList;
        double timeStep;
        public Recording(double timeStep)
        {
            isRecording = true;
            this.timeStep = timeStep;
            anglesList = new List<Tuple<double, double>>();
        }

        public void TurnOn() =>
            isRecording = true;

        public bool IsOn =>
            isRecording;

        public void Add(double a1, double a2) =>
            anglesList.Add(Tuple.Create(a1, a2));

        public void Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.Unicode);
                double time = 0d;
                foreach (var angles in anglesList)
                {
                    sw.WriteLine(time.ToString() + "\t" + angles.Item1 + "\t" + angles.Item2);
                    time += timeStep;
                }
                anglesList.Clear();
                sw.Close();
            }

            Reset();
        }

        private void Reset()
        {
            isRecording = false;
            anglesList.Clear();
        }
    }
}
