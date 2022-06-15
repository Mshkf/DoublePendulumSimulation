using static System.Math;

namespace DoublePendulum
{
    internal static class Calc
    {
        private static Vector F(Vector u, Vector p)
        {
            double g = p[0];
            double l1 = p[1];
            double l2 = p[2];
            double m1 = p[3];
            double m2 = p[4];
            Vector f = new Vector(4);
            f[0] = u[2];
            f[1] = u[3];
            f[2] = (
                -g * (2 * m1 + m2) * Sin(u[0]) - m2 * g * Sin(u[0] - 2 * u[1])
                - 2 * Sin(u[0] - u[1]) * m2 * (u[3] * u[3] * l2 + u[2] * u[2]
                * l1 * Cos(u[0] - u[1]))
                )
                /
                (
                l1 * (2 * m1 + m2 - m2 * Cos(2 * u[0] - 2 * u[1]))
                );
            f[3] = (
                2 * Sin(u[0] - u[1]) * (u[2] * u[2] * l1 * (m1 + m2) +
                g * (m1 + m2) * Cos(u[0]) + u[3] * u[3] * l2 * m2 * Cos(u[0] - u[1]))
                )
                /
                (
                l2 * (2 * m1 + m2 - m2 * Cos(2 * u[0] - 2 * u[1]))
                );
            return f;
        }
        public static Vector ERK4(Vector u, Vector p, double h)
        {
            Vector k1 = F(u, p);
            Vector k2 = F(u + h / 2 * k1, p);
            Vector k3 = F(u + h / 2 * k2, p);
            Vector k4 = F(u + h * k3, p);
            u = u + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
            return u;
        }
    }
}
