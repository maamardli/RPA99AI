using static System.Math;

namespace RPA99AI.Library
{
    public class Spectre
    {
        private readonly Ouvrage _ouvrage;
        public Spectre(Ouvrage ouvrage)
        {
            _ouvrage = ouvrage;
        }

        public int Duration { get; set; } = 5;
        public int Steps { get; set; } = 1000;
        private int N => (Duration * Steps) + 1;

        public List<double> T => Enumerable.Range(0, N).Select(t => 1.0 * t / Steps).ToList();
        public List<double> Sg => T.Select(t => GetSa(t, _ouvrage.A, _ouvrage.T1, _ouvrage.T2, _ouvrage.Q, _ouvrage.R, _ouvrage.Eta)).ToList();

        private static double GetSa(double t, double a, double t1, double t2, double q, double r, double eta)
        {
            return t switch
            {
                double _ when t >= 0.0 && t < t1 => 1.25 * a * (1.0 + (t / t1 * ((2.5 * eta * (q / r)) - 1.0))),
                double _ when t >= t1 && t < t2 => 1.25 * a * 2.5 * eta * (q / r),
                double _ when t >= t2 && t < 3.0 => 1.25 * a * 2.5 * eta * (q / r) * Pow(t2 / t, 2.0 / 3.0),
                double _ when t >= 3.0 => 1.25 * a * 2.5 * eta * (q / r) * Pow(t2 / 3.0, 2.0 / 3.0) * Pow(3.0 / t, 5.0 / 3.0),
                _ => throw new ArgumentOutOfRangeException(nameof(t)),
            };
        }
    }
}