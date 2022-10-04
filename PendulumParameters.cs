using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoublePendulum
{
    internal class PendulumParameters
    {
        public double M1, M2, G;
        public double L1;
        public double L1InCm
        {
            set { L1 = value/100; }
        }

        public double L2;
        public double L2InCm
        {
            set { L2 = value/100; }
        }

        public double A1;
        public double A1InDegrees
        {
            set { A1 = value * Math.PI / 180; }
        }

        public double A2;
        public double A2InDegrees
        {
            set { A2 = value * Math.PI / 180; }
        }

        public double Da1;
        public double v1
        {
            set { Da1 = value / L1; }
            //w=v/r
        }

        public double Da2;
        public double v2
        {
            set { Da2 = value / L2; }
            //w=v/r
        }

        public PendulumParameters()
        {
            M1 = 1;
            M2 = 1;
            L1InCm = 50;
            L2InCm = 50;
            G = 9.81;
            A1 = 0;
            A2 = 0;
            v1 = 0;
            v2 = 0;
        }
    }
}
