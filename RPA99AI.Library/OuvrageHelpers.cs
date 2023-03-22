using RPA99AI.Library;

internal static class OuvrageHelpers
{
    internal static readonly Dictionary<Wilaya, Zone> WilayaZoneMap = new Dictionary<Wilaya, Zone>
{
                    {Wilaya.ChlefA , Zone.ZoneIII},
                    {Wilaya.ChlefB , Zone.ZoneIIb},
                    {Wilaya.ChlefC , Zone.ZoneIIa},
                    {Wilaya.Laghouat , Zone.ZoneI},
                    {Wilaya.OumElBouaghi , Zone.ZoneI},
                    {Wilaya.Batna , Zone.ZoneI},
                    {Wilaya.Bejaia , Zone.ZoneIIa},
                    {Wilaya.Biskra , Zone.ZoneI},
                    {Wilaya.BlidaA , Zone.ZoneIII},
                    {Wilaya.BlidaB , Zone.ZoneIIb},
                    {Wilaya.Bouira , Zone.ZoneIIa},
                    {Wilaya.Tebessa , Zone.ZoneI},
                    {Wilaya.Tlemcen , Zone.ZoneI},
                    {Wilaya.Tiaret , Zone.ZoneI},
                    {Wilaya.TiziOuzouA , Zone.ZoneIIb},
                    {Wilaya.TiziOuzouB , Zone.ZoneIIa},
                    {Wilaya.Alger , Zone.ZoneIII},
                    {Wilaya.Djelfa , Zone.ZoneI},
                    {Wilaya.Jijel , Zone.ZoneIIa},
                    {Wilaya.Setif , Zone.ZoneIIa},
                    {Wilaya.Saida , Zone.ZoneI},
                    {Wilaya.Skikda , Zone.ZoneIIa},
                    {Wilaya.SidiBelAbbes , Zone.ZoneI},
                    {Wilaya.Annaba , Zone.ZoneIIa},
                    {Wilaya.Guelma , Zone.ZoneIIa},
                    {Wilaya.Constantine , Zone.ZoneIIa},
                    {Wilaya.MedeaA , Zone.ZoneIIb},
                    {Wilaya.MedeaB , Zone.ZoneIIa},
                    {Wilaya.MedeaC , Zone.ZoneI},
                    {Wilaya.MostganemA , Zone.ZoneIII},
                    {Wilaya.MostganemB , Zone.ZoneIIb},
                    {Wilaya.MostganemC , Zone.ZoneIIa},
                    {Wilaya.MsilaA , Zone.ZoneIIa},
                    {Wilaya.MsilaB , Zone.ZoneI},
                    {Wilaya.MascaraA , Zone.ZoneIIa},
                    {Wilaya.MascareB , Zone.ZoneI},
                    {Wilaya.Oran , Zone.ZoneIIa},
                    {Wilaya.ElBayadh , Zone.ZoneI},
                    {Wilaya.BordjBouArreridj , Zone.ZoneIIa},
                    {Wilaya.BoumerdesA , Zone.ZoneIII},
                    {Wilaya.BoumerdesB , Zone.ZoneIIb},
                    {Wilaya.BoumerdesC , Zone.ZoneIIa},
                    {Wilaya.ElTaref , Zone.ZoneIIa},
                    {Wilaya.Tissemsilt , Zone.ZoneIIa},
                    {Wilaya.Khenchela , Zone.ZoneI},
                    {Wilaya.SoukAhras , Zone.ZoneI},
                    {Wilaya.Tipaza , Zone.ZoneIII},
                    {Wilaya.Mila , Zone.ZoneIIa},
                    {Wilaya.AinDeflaA , Zone.ZoneIII},
                    {Wilaya.AinDeflaB , Zone.ZoneIIb},
                    {Wilaya.AinDeflaC , Zone.ZoneIIa},
                    {Wilaya.Naama , Zone.ZoneI},
                    {Wilaya.AinTemouchent , Zone.ZoneIIa},
                    {Wilaya.RelizaneA , Zone.ZoneIII},
                    {Wilaya.RelizaneB , Zone.ZoneIIb},
                    {Wilaya.RelizaneC , Zone.ZoneIIa},
};

    internal static readonly Dictionary<SystemeContreventement, double> RValues = new Dictionary<SystemeContreventement, double>
        {
            { SystemeContreventement.A1A, 5.00 },
            { SystemeContreventement.A1B, 3.50 },
            { SystemeContreventement.A2, 3.50 },
            { SystemeContreventement.A3, 3.50 },
            { SystemeContreventement.A4A, 5.00 },
            { SystemeContreventement.A4B, 4.00 },
            { SystemeContreventement.A5, 2.00 },
            { SystemeContreventement.A6, 2.00 },
            { SystemeContreventement.B7, 6.00 },
            { SystemeContreventement.B8, 4.00 },
            { SystemeContreventement.B9A, 4.00 },
            { SystemeContreventement.B9B, 3.00 },
            { SystemeContreventement.B10A, 5.00 },
            { SystemeContreventement.B10B, 4.00 },
            { SystemeContreventement.B11, 2.00 },
            { SystemeContreventement.C12, 2.50 },
            { SystemeContreventement.D13, 2.00 },
            { SystemeContreventement.D14, 3.00 },
            { SystemeContreventement.D15, 3.50 },
            { SystemeContreventement.D16, 4.00 },
            { SystemeContreventement.D17, 2.00 },
        };
    internal static readonly Dictionary<(Zone, Importance), double> AValues = new()
        {
            {(Zone.ZoneI, Importance.Groupe1A), 0.15},
            {(Zone.ZoneI, Importance.Groupe1B), 0.12},
            {(Zone.ZoneI, Importance.Groupe2), 0.10},
            {(Zone.ZoneI, Importance.Groupe3), 0.07},
            {(Zone.ZoneIIa, Importance.Groupe1A), 0.25},
            {(Zone.ZoneIIa, Importance.Groupe1B), 0.20},
            {(Zone.ZoneIIa, Importance.Groupe2), 0.15},
            {(Zone.ZoneIIa, Importance.Groupe3), 0.10},
            {(Zone.ZoneIIb, Importance.Groupe1A), 0.30},
            {(Zone.ZoneIIb, Importance.Groupe1B), 0.25},
            {(Zone.ZoneIIb, Importance.Groupe2), 0.20},
            {(Zone.ZoneIIb, Importance.Groupe3), 0.14},
            {(Zone.ZoneIII, Importance.Groupe1A), 0.40},
            {(Zone.ZoneIII, Importance.Groupe1B), 0.30},
            {(Zone.ZoneIII, Importance.Groupe2), 0.25},
            {(Zone.ZoneIII, Importance.Groupe3), 0.18}
        };
    internal static readonly Dictionary<TypeOuvrage, double> BetaValues = new Dictionary<TypeOuvrage, double>
        {
            {TypeOuvrage.Cas1BatimentsHabitationBureaux,0.20},
            {TypeOuvrage.Cas2ABatimentsRecevantPublicTemporairementSallesExposition,0.30},
            {TypeOuvrage.Cas2BBatimentsRecevantPublicTemporairementSallesClasses,0.40},
            {TypeOuvrage.Cas3EntrepotsHangars, 0.40 },
            {TypeOuvrage.Cas4ArchivesBibliothequesReservoirs, 1.00 },
            {TypeOuvrage.Cas5AutresLocaux, 0.60 }
        };


    internal static readonly Dictionary<Site, double> T2Values = new Dictionary<Site, double>
        {
            {Site.S1SiteRocheux, 0.30},
            {Site.S2SiteFerme, 0.40},
            {Site.S3SiteMeuble, 0.50},
            {Site.S4SiteTresMeuble, 0.70},
        };

    internal static readonly Dictionary<Site, double> T1Values = new Dictionary<Site, double>
        {
            {Site.S1SiteRocheux, 0.15},
            {Site.S2SiteFerme, 0.15},
            {Site.S3SiteMeuble, 0.15},
            {Site.S4SiteTresMeuble, 0.15},
        };

    internal static readonly Dictionary<Materiau, double> XiValues = new Dictionary<Materiau, double>
        {
            { Materiau.BetonLeger, 6.00 },
            { Materiau.BetonDense, 7.00 },
            { Materiau.AcierLeger, 4.00 },
            { Materiau.AcierDense, 5.00 },
            { Materiau.Voile, 10.00 }
        };
}