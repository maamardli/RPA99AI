using System;
using System.Collections.Generic;
using System.Linq;

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
            return criteria switch
            {
                (Zone.ZoneI, Importance.Groupe1A) => 0.15,
                (Zone.ZoneI, Importance.Groupe1B) => 0.12,
                (Zone.ZoneI, Importance.Groupe2) => 0.10,
                (Zone.ZoneI, Importance.Groupe3) => 0.07,
                (Zone.ZoneIIa, Importance.Groupe1A) => 0.25,
                (Zone.ZoneIIa, Importance.Groupe1B) => 0.20,
                (Zone.ZoneIIa, Importance.Groupe2) => 0.15,
                (Zone.ZoneIIa, Importance.Groupe3) => 0.10,
                (Zone.ZoneIIb, Importance.Groupe1A) => 0.30,
                (Zone.ZoneIIb, Importance.Groupe1B) => 0.25,
                (Zone.ZoneIIb, Importance.Groupe2) => 0.20,
                (Zone.ZoneIIb, Importance.Groupe3) => 0.14,
                (Zone.ZoneIII, Importance.Groupe1A) => 0.40,
                (Zone.ZoneIII, Importance.Groupe1B) => 0.30,
                (Zone.ZoneIII, Importance.Groupe2) => 0.25,
                (Zone.ZoneIII, Importance.Groupe3) => 0.18,
                _ => throw new NotImplementedException(),
            };
        }

        private static double GetEta(double xi) => Math.Sqrt(7.0 / (xi + 2.0));

        private static double GetBeta(TypeOuvrage typesOuvrages)
        {
            return typesOuvrages switch
            {
                TypeOuvrage.Cas1BatimentsHabitationBureaux => 0.20,
                TypeOuvrage.Cas2ABatimentsRecevantPublicTemporairementSallesExposition => 0.30,
                TypeOuvrage.Cas2BBatimentsRecevantPublicTemporairementSallesClasses => 0.40,
                TypeOuvrage.Cas3EntrepotsHangars => 0.40,
                TypeOuvrage.Cas4ArchivesBibliothequesReservoirs => 1.00,
                TypeOuvrage.Cas5AutresLocaux => 0.60,
                _ => throw new NotImplementedException(),
            };
        }

        private static double GetR(SystemeContreventement systemeContreventement)
        {
            return systemeContreventement switch
            {
                SystemeContreventement.A1A => 5.00,
                SystemeContreventement.A1B => 3.50,
                SystemeContreventement.A2 => 3.50,
                SystemeContreventement.A3 => 3.50,
                SystemeContreventement.A4A => 5.00,
                SystemeContreventement.A4B => 4.00,
                SystemeContreventement.A5 => 2.00,
                SystemeContreventement.A6 => 2.00,
                SystemeContreventement.B7 => 6.00,
                SystemeContreventement.B8 => 4.00,
                SystemeContreventement.B9A => 4.00,
                SystemeContreventement.B9B => 3.00,
                SystemeContreventement.B10A => 5.00,
                SystemeContreventement.B10B => 4.00,
                SystemeContreventement.B11 => 2.00,
                SystemeContreventement.C12 => 2.50,
                SystemeContreventement.D13 => 2.00,
                SystemeContreventement.D14 => 3.00,
                SystemeContreventement.D15 => 3.50,
                SystemeContreventement.D16 => 4.00,
                SystemeContreventement.D17 => 2.00,
                _ => throw new NotImplementedException(),
            };
        }

        private static double GetT2(Site site)
        {
            return site switch
            {
                Site.S1SiteRocheux => 0.30,
                Site.S2SiteFerme => 0.40,
                Site.S3SiteMeuble => 0.50,
                Site.S4SiteTresMeuble => 0.70,
                _ => throw new NotImplementedException(),
            };
        }

        private static double GetT1(Site site)
        {
            return site switch
            {
                Site.S1SiteRocheux => 0.15,
                Site.S2SiteFerme => 0.15,
                Site.S3SiteMeuble => 0.15,
                Site.S4SiteTresMeuble => 0.15,
                _ => throw new NotImplementedException(),
            };
        }

        private static double GetXi(Materiau materiau)
        {
            return materiau switch
            {
                Materiau.BetonLeger => 06.00,
                Materiau.BetonDense => 07.00,
                Materiau.AcierLeger => 04.00,
                Materiau.AcierDense => 05.00,
                Materiau.Voile => 10.00,
                _ => throw new NotImplementedException(),
            };
        }

        private static Zone GetZone(Ouvrage ouvrage)
        {
            return ouvrage.DeclarationduZone switch
            {
                DeclarationduZone.ParZone => ouvrage._zone,
                DeclarationduZone.ParWilaya => ouvrage.Wilaya switch
                {
                    Wilaya.ChlefA => Zone.ZoneIII,
                    Wilaya.ChlefB => Zone.ZoneIIb,
                    Wilaya.ChlefC => Zone.ZoneIIa,
                    Wilaya.Laghouat => Zone.ZoneI,
                    Wilaya.OumElBouaghi => Zone.ZoneI,
                    Wilaya.Batna => Zone.ZoneI,
                    Wilaya.Bejaia => Zone.ZoneIIa,
                    Wilaya.Biskra => Zone.ZoneI,
                    Wilaya.BlidaA => Zone.ZoneIII,
                    Wilaya.BlidaB => Zone.ZoneIIb,
                    Wilaya.Bouira => Zone.ZoneIIa,
                    Wilaya.Tebessa => Zone.ZoneI,
                    Wilaya.Tlemcen => Zone.ZoneI,
                    Wilaya.Tiaret => Zone.ZoneI,
                    Wilaya.TiziOuzouA => Zone.ZoneIIb,
                    Wilaya.TiziOuzouB => Zone.ZoneIIa,
                    Wilaya.Alger => Zone.ZoneIII,
                    Wilaya.Djelfa => Zone.ZoneI,
                    Wilaya.Jijel => Zone.ZoneIIa,
                    Wilaya.Setif => Zone.ZoneIIa,
                    Wilaya.Saida => Zone.ZoneI,
                    Wilaya.Skikda => Zone.ZoneIIa,
                    Wilaya.SidiBelAbbes => Zone.ZoneI,
                    Wilaya.Annaba => Zone.ZoneIIa,
                    Wilaya.Guelma => Zone.ZoneIIa,
                    Wilaya.Constantine => Zone.ZoneIIa,
                    Wilaya.MedeaA => Zone.ZoneIIb,
                    Wilaya.MedeaB => Zone.ZoneIIa,
                    Wilaya.MedeaC => Zone.ZoneI,
                    Wilaya.MostganemA => Zone.ZoneIII,
                    Wilaya.MostganemB => Zone.ZoneIIb,
                    Wilaya.MostganemC => Zone.ZoneIIa,
                    Wilaya.MsilaA => Zone.ZoneIIa,
                    Wilaya.MsilaB => Zone.ZoneI,
                    Wilaya.MascaraA => Zone.ZoneIIa,
                    Wilaya.MascareB => Zone.ZoneI,
                    Wilaya.Oran => Zone.ZoneIIa,
                    Wilaya.ElBayadh => Zone.ZoneI,
                    Wilaya.BordjBouArreridj => Zone.ZoneIIa,
                    Wilaya.BoumerdesA => Zone.ZoneIII,
                    Wilaya.BoumerdesB => Zone.ZoneIIb,
                    Wilaya.BoumerdesC => Zone.ZoneIIa,
                    Wilaya.ElTaref => Zone.ZoneIIa,
                    Wilaya.Tissemsilt => Zone.ZoneIIa,
                    Wilaya.Khenchela => Zone.ZoneI,
                    Wilaya.SoukAhras => Zone.ZoneI,
                    Wilaya.Tipaza => Zone.ZoneIII,
                    Wilaya.Mila => Zone.ZoneIIa,
                    Wilaya.AinDeflaA => Zone.ZoneIII,
                    Wilaya.AinDeflaB => Zone.ZoneIIb,
                    Wilaya.AinDeflaC => Zone.ZoneIIa,
                    Wilaya.Naama => Zone.ZoneI,
                    Wilaya.AinTemouchent => Zone.ZoneIIa,
                    Wilaya.RelizaneA => Zone.ZoneIII,
                    Wilaya.RelizaneB => Zone.ZoneIIb,
                    Wilaya.RelizaneC => Zone.ZoneIIa,
                    _ => throw new NotImplementedException(),
                },
                _ => throw new NotImplementedException(),
            };
        }

        #endregion
    }
}