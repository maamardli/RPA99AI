using System;
using static System.Math;

namespace RPA99AI.Library
{
    public class Statique
    {
        private readonly Ouvrage _ouvrage;

        public Statique(Ouvrage ouvrage)
        {
            _ouvrage = ouvrage;
        }

        public CalculeTEmpirique Empirique { get; set; }

        public FormuleCalculeTStatique FormuleCalculeTStatique { get; set; }

        public SystemeContreventementStat SystemeContreventementStat { get; set; }

        public double Ct => GetCt(SystemeContreventementStat);

        public double Delta { get; set; } = 1.0;

        public bool IsStatiqueApplicable => GetIsStatiqueApplicable(_ouvrage);

        public double Tx => GetT(_ouvrage, _ouvrage.Lx);
        public double Ty => GetT(_ouvrage, _ouvrage.Ly);

        public double Dx => GetD(_ouvrage.Eta, Tx, _ouvrage.T2);
        public double Dy => GetD(_ouvrage.Eta, Ty, _ouvrage.T2);

        public double Vx => GetV(_ouvrage.A, Dx, _ouvrage.Q, _ouvrage.W, _ouvrage.R);
        public double Vy => GetV(_ouvrage.A, Dy, _ouvrage.Q, _ouvrage.W, _ouvrage.R);

        public double Vx08 => Vx * 0.8;
        public double Vy08 => Vy * 0.8;

        #region Static Methodes

        private static double GetEmp1(double hn, double ct) => ct * Pow(hn, 3.0 / 4.0);
        private static double GetEmp2(double hn, double l) => 0.09 * hn / Sqrt(l);
        private static double GetRay(double segma) => 2 * Sqrt(segma);

        private static double GetT(Ouvrage myOuvrage, double l)
        {
            if (myOuvrage is null)
            {
                throw new ArgumentNullException(nameof(myOuvrage));
            }

            var criteria = (myOuvrage.Statique.FormuleCalculeTStatique, myOuvrage.Statique.SystemeContreventementStat, myOuvrage.Statique.Empirique);
            return criteria switch
            {
                (FormuleCalculeTStatique.FormuleEmpirique, SystemeContreventementStat.Cas1, _) => GetEmp1(myOuvrage.Hn, myOuvrage.Statique.Ct),
                (FormuleCalculeTStatique.FormuleEmpirique, SystemeContreventementStat.Cas2, _) => GetEmp1(myOuvrage.Hn, myOuvrage.Statique.Ct),
                (FormuleCalculeTStatique.FormuleEmpirique, SystemeContreventementStat.Cas3, CalculeTEmpirique.Methode1Formule46) => GetEmp1(myOuvrage.Hn, myOuvrage.Statique.Ct),
                (FormuleCalculeTStatique.FormuleEmpirique, SystemeContreventementStat.Cas3, CalculeTEmpirique.Methode2Formule47) => GetEmp2(myOuvrage.Hn, l),
                (FormuleCalculeTStatique.FormuleEmpirique, SystemeContreventementStat.Cas3, CalculeTEmpirique.Methode3MinFormule) => Min(GetEmp1(myOuvrage.Hn, myOuvrage.Statique.Ct), GetEmp2(myOuvrage.Hn, l)),
                (FormuleCalculeTStatique.FormuleEmpirique, SystemeContreventementStat.Cas4, CalculeTEmpirique.Methode1Formule46) => GetEmp1(myOuvrage.Hn, myOuvrage.Statique.Ct),
                (FormuleCalculeTStatique.FormuleEmpirique, SystemeContreventementStat.Cas4, CalculeTEmpirique.Methode2Formule47) => GetEmp2(myOuvrage.Hn, l),
                (FormuleCalculeTStatique.FormuleEmpirique, SystemeContreventementStat.Cas4, CalculeTEmpirique.Methode3MinFormule) => Min(GetEmp1(myOuvrage.Hn, myOuvrage.Statique.Ct), GetEmp2(myOuvrage.Hn, l)),
                (FormuleCalculeTStatique.FormuleDeRayleighSimplifee, _, _) => GetRay(myOuvrage.Statique.Delta),
                _ => throw new ArgumentOutOfRangeException(nameof(myOuvrage)),
            };
        }

        private static double GetD(double eta, double t, double t2) => t switch
        {
            double _ when t >= 0.0 && t < t2  => 2.5 * eta,
            double _ when t >= t2  && t < 3.0 => 2.5 * eta * Pow(t2 / t, 2.0 / 3.0),
            double _ when t >= 3.0            => 2.5 * eta * Pow(t2 / 3.0, 2.0 / 3.0) * Pow(3.0 / t, 5.0 / 3.0),
            _ => throw new ArgumentOutOfRangeException(nameof(t)),
        };

        private static double GetV(double a, double d, double q, double w, double r) => a * d * q * w / r;

        private static double GetCt(SystemeContreventementStat systemeContreventementStat)
        {
            return systemeContreventementStat switch
            {
                SystemeContreventementStat.Cas1 => 0.075,
                SystemeContreventementStat.Cas2 => 0.085,
                SystemeContreventementStat.Cas3 => 0.050,
                SystemeContreventementStat.Cas4 => 0.050,
                _ => throw new NotImplementedException(),
            };
        }

        private static bool GetIsStatiqueApplicable(Ouvrage myOuvrage)
        {
            if (myOuvrage is null)
            {
                throw new ArgumentNullException(nameof(myOuvrage));
            }

            var criteria = (myOuvrage.Zone, myOuvrage.Importance, myOuvrage.Qualites[2].NonObserve, myOuvrage.Qualites[3].NonObserve);
            return criteria switch
            {
                (Zone.ZoneI  , _                  , false, false) => myOuvrage.Hn <= 65.0,
                (Zone.ZoneIIa, _                  , false, false) => myOuvrage.Hn <= 65.0,
                (Zone.ZoneIIb, _                  , false, false) => myOuvrage.Hn <= 30.0,
                (Zone.ZoneIII, _                  , false, false) => myOuvrage.Hn <= 30.0,
                (Zone.ZoneI  , _                  , _    , _    ) => true,
                (Zone.ZoneIIa, Importance.Groupe1A, _    , _    ) => myOuvrage.Hn <= 10.0,
                (Zone.ZoneIIa, Importance.Groupe1B, _    , _    ) => myOuvrage.Hn <= 17.0,
                (Zone.ZoneIIa, Importance.Groupe2 , _    , _    ) => myOuvrage.Hn <= 23.0,
                (Zone.ZoneIIa, Importance.Groupe3 , _    , _    ) => true,
                (Zone.ZoneIIb, Importance.Groupe1A, _    , _    ) => myOuvrage.Hn <= 08.0,
                (Zone.ZoneIIb, Importance.Groupe1B, _    , _    ) => myOuvrage.Hn <= 10.0,
                (Zone.ZoneIIb, Importance.Groupe2 , _    , _    ) => myOuvrage.Hn <= 17.0,
                (Zone.ZoneIIb, Importance.Groupe3 , _    , _    ) => myOuvrage.Hn <= 17.0,
                (Zone.ZoneIII, Importance.Groupe1A, _    , _    ) => myOuvrage.Hn <= 08.0,
                (Zone.ZoneIII, Importance.Groupe1B, _    , _    ) => myOuvrage.Hn <= 10.0,
                (Zone.ZoneIII, Importance.Groupe2 , _    , _    ) => myOuvrage.Hn <= 17.0,
                (Zone.ZoneIII, Importance.Groupe3 , _    , _    ) => myOuvrage.Hn <= 17.0,
                _ => throw new ArgumentOutOfRangeException(nameof(myOuvrage)),
            };
        }
        #endregion Static Methodes
    }
}