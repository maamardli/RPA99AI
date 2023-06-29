using static BuildingHelpers;

namespace RPA99AI.Library
{
    public class Building
    {
        private double _a = 0.40;
        private double _beta = 1.00;
        private double _q = 1.35;
        private double _r = 2.00;
        private double _t1 = 0.15;
        private double _t2 = 0.70;
        private double _xi = 4.00;
        internal Zone _zone = Zone.ZoneIII_HighSeismicity;

        public Spectrum Spectre { get; }
        public EquivalentStatic EquivalentStaticMethod { get; }

        public Building()
        {
            Spectre = new Spectrum(this);
            EquivalentStaticMethod = new EquivalentStatic(this);
            Qualites = new List<Quality>()
            {
                new Quality(QualityCriteria.Q1MinimalConditionsOnBracingLines),
                new Quality(QualityCriteria.Q2RedundancyInPlan),
                new Quality(QualityCriteria.Q3RegularityInPlan),
                new Quality(QualityCriteria.Q4RegularityInElevation),
                new Quality(QualityCriteria.Q5ControlOfMaterialQuality),
                new Quality(QualityCriteria.Q6ControlOfConstructionQuality)
            };
        }

        /// <summary>
        /// Lx: is the dimension of the building measured at its basis in the direction X
        /// </summary>
        public double Lx { get; set; } = 1.0;

        /// <summary>
        /// Ly: is the dimension of the building measured at its basis in the direction y
        /// </summary>
        public double Ly { get; set; } = 1.0;

        /// <summary>
        /// Hn: The height of the building
        /// </summary>
        public double Hn { get; set; } = 1.0;

        /// <summary>
        /// Wg: weight due to the dead loads and loads of the eventual fixed equipment attached to the structure
        /// </summary>
        public double Wg { get; set; } = 1.0;

        /// <summary>
        /// Wq: live loads
        /// </summary>
        public double Wq { get; set; } = 1.0;

        /// <summary>
        /// W: Total weight of the structure
        /// </summary>
        public double W => Wg + (Beta * Wq);

        public DeclarationOfTheZone DeclarationduZone { get; set; } = DeclarationOfTheZone.ByZone;
        public Wilaya Wilaya { get; set; } = Wilaya.AinDeflaA;

        public Zone Zone
        {
            get => GetZone(this);
            set => _zone = value;
        }

        public Site Site { get; set; } = Site.S1RockySite;
        public Importance Importance { get; set; } = Importance.Group1A_ConstructionOfVitalImportance;
        public Material Materiau { get; set; } = Material.SteelHeavy;
        public StructuralSystems SysContreventement { get; set; } = StructuralSystems.A1A;
        public BuildingType TypeOuvrage { get; set; } = BuildingType.Case1_ResidentialOfficesBuildings;
        public List<Quality> Qualites { get; }

        public bool IsACustomValue { get; set; }

        /// <summary>
        /// A: zone acceleration coefficient
        /// </summary>
        public double A
        {
            get => IsACustomValue ? _a : GetA(this);
            set => _a = value;
        }

        public bool IsBetaCustomValue { get; set; }

        /// <summary>
        /// Beta (β): weighting coefficient, depending on the nature and the duration of the live load
        /// </summary>
        public double Beta
        {
            get => IsBetaCustomValue ? _beta : GetBeta(TypeOuvrage);
            set => _beta = value;
        }

        public bool IsQCustomValue { get; set; }

        /// <summary>
        /// Q: Quality factor
        /// </summary>
        public double Q
        {
            get => IsQCustomValue ? _q : Qualites.Where(qualite => qualite.NonObserve)
                                                 .Aggregate(1.0, (current, qualite) => current + qualite.Valeur);
            set => _q = value;
        }

        public bool IsRCustomValue { get; set; }

        /// <summary>
        /// R: global behavior coefficient of the structure
        /// </summary>
        public double R
        {
            get => IsRCustomValue ? _r : GetR(SysContreventement);
            set => _r = value;
        }

        public bool IsT1T2CustomValue { get; set; }

        /// <summary>
        /// T1: Characteristic periods associated with the site category
        /// </summary>
        public double T1
        {
            get => IsT1T2CustomValue ? _t1 : GetT1(Site);
            set => _t1 = value;
        }

        /// <summary>
        /// T2: Characteristic periods associated with the site category
        /// </summary>
        public double T2
        {
            get => IsT1T2CustomValue ? _t2 : GetT2(Site);
            set => _t2 = value;
        }

        public bool IsXiCustomValue { get; set; }

        /// <summary>
        /// ξ: Percentage of critical damping
        /// </summary>
        public double Xi
        {
            get => IsXiCustomValue ? _xi : GetXi(Materiau);
            set => _xi = value;
        }

        /// <summary>
        /// η: Factor of correction of damping (when the damping is different of 5%)
        /// </summary>
        public double Eta => GetEta(Xi);
    }
}