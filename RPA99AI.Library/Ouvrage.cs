namespace RPA99AI.Library
{
    public class Ouvrage
    {
        private double _a = 0.40;
        private double _beta = 1.00;
        private double _q = 1.35;
        private double _r = 2.00;
        private double _t1 = 0.15;
        private double _t2 = 0.70;
        private double _xi = 4.00;
        private Zone _zone = Zone.ZoneIII;

        public Spectre Spectre { get; }
        public Statique Statique { get; }

        public Ouvrage()
        {
            Spectre = new Spectre(this);
            Statique = new Statique(this);
            Qualites = new List<Qualitie>()
            {
                new Qualitie(QualitieCriteria.ConditionsMinimalesSurLesFilesDeContreventement),
                new Qualitie(QualitieCriteria.RedondanceEnPlan),
                new Qualitie(QualitieCriteria.RegulariteEnPlan),
                new Qualitie(QualitieCriteria.RegulariteEnElevation),
                new Qualitie(QualitieCriteria.ControleDeLaQualiteDesMateriaux),
                new Qualitie(QualitieCriteria.ControleDeLaQualiteDeLExecution)
            };
        }

        public double Lx { get; set; } = 1.0;
        public double Ly { get; set; } = 1.0;
        public double Hn { get; set; } = 1.0;

        public double Wg { get; set; } = 1.0;
        public double Wq { get; set; } = 1.0;
        public double W => Wg + (Beta * Wq);

        public DeclarationduZone DeclarationduZone { get; set; } = DeclarationduZone.ParZone;
        public Wilaya Wilaya { get; set; } = Wilaya.AinDeflaA;
        public Zone Zone
        {
            get => GetZone(this);
            set => _zone = value;
        }
        public Site Site { get; set; } = Site.S1SiteRocheux;
        public Importance Importance { get; set; } = Importance.Groupe1A;
        public Materiau Materiau { get; set; } = Materiau.AcierDense;
        public SystemeContreventement SysContreventement { get; set; } = SystemeContreventement.A1A;
        public TypeOuvrage TypeOuvrage { get; set; } = TypeOuvrage.Cas1BatimentsHabitationBureaux;
        public List<Qualitie> Qualites { get; }

        public bool IsACustomValue { get; set; }
        public double A
        {
            get => IsACustomValue ? _a : GetA(this);
            set => _a = value;
        }

        public bool IsBetaCustomValue { get; set; }
        public double Beta
        {
            get => IsBetaCustomValue ? _beta : GetBeta(TypeOuvrage);
            set => _beta = value;
        }

        public bool IsQCustomValue { get; set; }
        public double Q
        {
            get => IsQCustomValue ? _q : Qualites.Where(qualite => qualite.NonObserve)
                                                 .Aggregate(1.0, (current, qualite) => current + qualite.Valeur);
            set => _q = value;
        }

        public bool IsRCustomValue { get; set; }
        public double R
        {
            get => IsRCustomValue ? _r : GetR(SysContreventement);
            set => _r = value;
        }

        public bool IsT1T2CustomValue { get; set; }
        public double T1
        {
            get => IsT1T2CustomValue ? _t1 : GetT1(Site);
            set => _t1 = value;
        }

        public double T2
        {
            get => IsT1T2CustomValue ? _t2 : GetT2(Site);
            set => _t2 = value;
        }

        public bool IsXiCustomValue { get; set; }
        public double Xi
        {
            get => IsXiCustomValue ? _xi : GetXi(Materiau);
            set => _xi = value;
        }

        public double Eta => GetEta(Xi);

        #region static Methodes

        private static double GetA(Ouvrage ouvrage)
        {
            var criteria = (ouvrage.Zone, ouvrage.Importance);
            return OuvrageHelpers.AValues.TryGetValue(criteria, out double value) ? value : throw new NotImplementedException();
        }

        private static double GetEta(double xi) => Math.Sqrt(7.0 / (xi + 2.0));

        private static double GetBeta(TypeOuvrage typesOuvrages)
        {
            if (OuvrageHelpers.BetaValues.TryGetValue(typesOuvrages, out var beta))
            {
                return beta;
            }

            throw new NotImplementedException();
        }

        private static double GetR(SystemeContreventement systemeContreventement)
        {
            if (OuvrageHelpers.RValues.TryGetValue(systemeContreventement, out double r))
            {
                return r;
            }
            throw new NotImplementedException();
        }

        private static double GetT2(Site site)
        {
            if (!OuvrageHelpers.T2Values.TryGetValue(site, out double value))
            {
                throw new NotImplementedException();
            }
            return value;
        }

        private static double GetT1(Site site)
        {
            if (OuvrageHelpers.T1Values.TryGetValue(site, out double value))
            {
                return value;
            }

            throw new NotImplementedException();
        }

        private static double GetXi(Materiau materiau)
        {
            if (OuvrageHelpers.XiValues.TryGetValue(materiau, out double value))
            {
                return value;
            }

            throw new NotImplementedException();
        }


        private static Zone GetZone(Ouvrage ouvrage)
        {
            if (ouvrage.DeclarationduZone == DeclarationduZone.ParZone)
            {
                return ouvrage._zone;
            }

            if (ouvrage.DeclarationduZone == DeclarationduZone.ParWilaya && OuvrageHelpers.WilayaZoneMap.TryGetValue(ouvrage.Wilaya, out var zone))
            {
                return zone;
            }

            throw new NotImplementedException();
        }

        #endregion
    }
}