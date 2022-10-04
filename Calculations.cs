using static System.Math;

namespace DoublePendulum
{
    internal static class Calculations
    {
        private static Vector F(Vector u, PendulumParameters p)
        {
            Vector f = new Vector(4);
            f[0] = u[2];

            f[1] = u[3];

            f[2] = (-p.G * (2 * p.M1 + p.M2) * Sin(u[0]) - p.M2 * p.G * Sin(u[0] - 2 * u[1])
                - 2 * Sin(u[0] - u[1]) * p.M2 * (u[3] * u[3] * p.L2 + u[2] * u[2]
                * p.L1 * Cos(u[0] - u[1])))
                /
                (p.L1 * (2 * p.M1 + p.M2 - p.M2 * Cos(2 * u[0] - 2 * u[1])));

            f[3] = (2 * Sin(u[0] - u[1]) * (u[2] * u[2] * p.L1 * (p.M1 + p.M2) +
                p.G * (p.M1 + p.M2) * Cos(u[0]) + u[3] * u[3] * p.L2 * p.M2 * Cos(u[0] - u[1])))
                /
                (p.L2 * (2 * p.M1 + p.M2 - p.M2 * Cos(2 * u[0] - 2 * u[1])));
            return f;
        }

        public static void ERK4(PendulumParameters p, double h)
        {
            var u = p.GetAngleVector();

            Vector k1 = F(u, p);
            Vector k2 = F(u + h / 2 * k1, p);
            Vector k3 = F(u + h / 2 * k2, p);
            Vector k4 = F(u + h * k3, p);
            u = u + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);

            p.UpdateFromVector(u);
        }

        public static Vector GetAngleVector(this PendulumParameters p)
        {
            return new Vector(p.A1, p.A2, p.Da1, p.Da2);
        }

        public static void UpdateFromVector(this PendulumParameters p, Vector u)
        {
            p.A1 = u[0];
            p.A2 = u[1];
            p.Da1 = u[2];
            p.Da2 = u[3];
        }
    }
}
