using static System.Math;

namespace RPA99AI.Library
{
    /// <summary>
    /// MODAL RESPONSE SPECTRUM ANALYSIS METHOD
    /// </summary>
    public class Spectrum
    {
        private readonly Building _building;

        public Spectrum(Building building)
        {
            _building = building;
        }

        public int Duration { get; set; } = 5;
        public int Steps { get; set; } = 1000;
        private int N => (Duration * Steps) + 1;

        public List<double> T => Enumerable.Range(0, N).Select(t => 1.0 * t / Steps).ToList();
        public List<double> Sg => T.Select(t => GetSa(t, _building.A, _building.T1, _building.T2, _building.Q, _building.R, _building.Eta)).ToList();

        /// <summary>
        /// The seismic action is represented by the following Design Response Spectrum
        /// </summary>
        /// <param name="t">period</param>
        /// <param name="a">Zone acceleration coefficient</param>
        /// <param name="t1">characteristic periods associated with the site category 1</param>
        /// <param name="t2">characteristic periods associated with the site category 2</param>
        /// <param name="q">factor of quality</param>
        /// <param name="r">behavior coefficient of the structure</param>
        /// <param name="eta">factor of correction of damping </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
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