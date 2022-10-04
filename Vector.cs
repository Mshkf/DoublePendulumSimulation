using System;

namespace DoublePendulum
{
    internal class Vector
    {
        int length;
        double[] array;
        public Vector(int l)
        {
            length = l;
            array = new double[length];
            for (int i = 0; i < l; i++)
            {
                array[i] = 0;
            }
        }
        public Vector(params double[] a)
        {
            length = a.Length;
            array = new double[length];
            for (int i = 0; i < a.Length; i++)
            {
                array[i] = a[i];
            }
        }
        public double this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public static Vector operator +(Vector a, Vector b)
        {
            if (a.length != b.length) throw new ArgumentException();
            Vector c = new Vector(a.length);
            for (int i = 0; i < c.length; i++)
            {
                c[i] = a[i] + b[i];
            }
            return c;
        }

        public static Vector operator *(double h, Vector a)
        {
            Vector b = new Vector(a.length);
            for (int i = 0; i < b.length; i++)
            {
                b[i] = a[i] * h;
            }
            return b;
        }

        public static Vector operator *(Vector a, double h) => h * a;

        public override string ToString()
        {
            string result = "";
            foreach (double a in array)
                result += a.ToString("F2") + " ";
            return result;
        }
    }
}
