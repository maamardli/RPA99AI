namespace RPA99AI.Library
{
    public enum CalculeTEmpirique
    {
        Methode1Formule46,
        Methode2Formule47,
        Methode3MinFormule
    }

    public enum DeclarationduZone
    {
        ParZone,
        ParWilaya
    }

    public enum FormuleCalculeTStatique
    {
        FormuleEmpirique,
        FormuleDeRayleighSimplifee
    }

    public enum Importance
    {
        Groupe1A,
        Groupe1B,
        Groupe2,
        Groupe3
    }

    public enum Materiau
    {
        BetonLeger,
        BetonDense,
        AcierLeger,
        AcierDense,
        Voile
    }

    public enum QualitieCriteria
    {
        ConditionsMinimalesSurLesFilesDeContreventement,
        RedondanceEnPlan,
        RegulariteEnPlan,
        RegulariteEnElevation,
        ControleDeLaQualiteDesMateriaux,
        ControleDeLaQualiteDeLExecution
    }

    public enum Site
    {
        S1SiteRocheux,
        S2SiteFerme,
        S3SiteMeuble,
        S4SiteTresMeuble
    }

    public enum SystemeContreventement
    {
        A1A,
        A1B,
        A2,
        A3,
        A4A,
        A4B,
        A5,
        A6,
        B7,
        B8,
        B9A,
        B9B,
        B10A,
        B10B,
        B11,
        C12,
        D13,
        D14,
        D15,
        D16,
        D17
    }

    public enum SystemeContreventementStat
    {
        Cas1,
        Cas2,
        Cas3,
        Cas4
    }

    public enum TypeOuvrage
    {
        Cas1BatimentsHabitationBureaux,
        Cas2ABatimentsRecevantPublicTemporairementSallesExposition,
        Cas2BBatimentsRecevantPublicTemporairementSallesClasses,
        Cas3EntrepotsHangars,
        Cas4ArchivesBibliothequesReservoirs,
        Cas5AutresLocaux
    }

    public enum Wilaya
    {
        ChlefA,
        ChlefB,
        ChlefC,
        Laghouat,
        OumElBouaghi,
        Batna,
        Bejaia,
        Biskra,
        BlidaA,
        BlidaB,
        Bouira,
        Tebessa,
        Tlemcen,
        Tiaret,
        TiziOuzouA,
        TiziOuzouB,
        Alger,
        Djelfa,
        Jijel,
        Setif,
        Saida,
        Skikda,
        SidiBelAbbes,
        Annaba,
        Guelma,
        Constantine,
        MedeaA,
        MedeaB,
        MedeaC,
        MostganemA,
        MostganemB,
        MostganemC,
        MsilaA,
        MsilaB,
        MascaraA,
        MascareB,
        Oran,
        ElBayadh,
        BordjBouArreridj,
        BoumerdesA,
        BoumerdesB,
        BoumerdesC,
        ElTaref,
        Tissemsilt,
        Khenchela,
        SoukAhras,
        Tipaza,
        Mila,
        AinDeflaA,
        AinDeflaB,
        AinDeflaC,
        Naama,
        AinTemouchent,
        RelizaneA,
        RelizaneB,
        RelizaneC
    }

    public enum Zone
    {
        ZoneI,
        ZoneIIa,
        ZoneIIb,
        ZoneIII
    }
}