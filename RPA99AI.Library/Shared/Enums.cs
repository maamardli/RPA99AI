namespace RPA99AI.Library;

public enum MethodToCalculateTEmpiric
{
    Methode1Formule46,
    Methode2Formule47,
    Methode3MinFormule
}

public enum DeclarationOfTheZone
{
    ByZone,
    ByWilaya
}

public enum FormulatoCalculateTStatic
{
    FormulaEmpiric,
    FormulaRayleighSimplified
}

/// <summary>
/// 3.2. Classification of the constructions according to their importance
/// </summary>
public enum Importance
{
    /// <summary>
    /// Group 1A Construction of vital importance:
    /// Vital constructions should stay operational after major earthquake for the needs of the
    /// survival of the region, the public safety and the national defense
    /// </summary>
    Group1A_ConstructionOfVitalImportance,

    /// <summary>
    /// Groupe 1B Construction of high importance:
    /// Constructions housing frequently large groups of persons
    /// </summary>
    Group1B_ConstructionOfHighImportance,

    /// <summary>
    /// Groupe 2 Current constructions or those of moderate importance:
    /// Constructions non classified in the other groups 1A, 1B or 3
    /// </summary>
    Group2_ConstructionsOfModerateImportance,

    /// <summary>
    /// Groupe 3 Constructions of low importance:
    /// - industrial or agricultural buildings sheltering low value goods
    /// - buildings with limited risk for people
    /// - temporary constructions
    /// </summary>
    Group3_ConstructionsOfLowImportance
}

public enum Material
{
    /// <summary>
    /// Frames: Reinforced concrete
    /// Infill: Light
    /// </summary>
    ConcreteLight,

    /// <summary>
    /// Frames: Reinforced concrete
    /// Infill: Heavy
    /// </summary>
    ConcreteHeavy,

    /// <summary>
    /// Frames: Steel
    /// Infill: Light
    /// </summary>
    SteelLight,

    /// <summary>
    /// Frames: Steel
    /// Infill: Heavy
    /// </summary>
    SteelHeavy,

    /// <summary>
    /// Shear walls or walls in reinforced concrete/masonry
    /// </summary>
    ShearWalls
}

public enum QualityCriteria
{
    Q1MinimalConditionsOnBracingLines,
    Q2RedundancyInPlan,
    Q3RegularityInPlan,
    Q4RegularityInElevation,
    Q5ControlOfMaterialQuality,
    Q6ControlOfConstructionQuality
}

/// <summary>
/// 3.3.1 Categories and classification criteria:
/// The sites are classified into four(04) categories according to the mechanical properties of the constituting soils.
/// </summary>
public enum Site
{
    /// <summary>
    /// Category S1 (rocky site):
    /// Rock or other geological formation characterized by an average shear wave velocity Vs ≥ 800 m/s
    /// </summary>
    S1RockySite,

    /// <summary>
    /// Category S2 (firm site):
    /// Very dense gravel or sand and/or over consolidated clay deposits with a thickness of 10 to 20 meters and Vs ≥ 400 m/s from a depth of 10 meters.
    /// </summary>
    S2FirmSite,

    /// <summary>
    /// Category S3 (soft site): Thick deposits of moderately dense gravel and sand or moderately stiff clay with Vs ≥200 m/s from a depth of 10 meters.
    /// </summary>
    S3SoftSite,

    /// <summary>
    /// Category S4 (very soft site):
    /// Loose sands deposits with or without soft clay with Vs < 200 m/s within the 20 first meters.
    /// Soft to moderately stiff clay with Vs < 200 m/s within the 20 first meters.
    /// </summary>
    S4VerySoftSite
}

/// <summary>
/// 3.4. CLASSIFICATION OF THE LATERAL LOAD RESISTING STRUCTURAL SYSTEMS
/// The aim of the classification of the structural systems gives rise in these rules and design
/// methods to the assignment for each category of this classification of a numerical value of the
/// behavior coefficient R.
/// A: Reinforced concrete structures
/// B: Steel
/// C: Masonry
/// D: Other systems
/// </summary>
public enum StructuralSystems
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

public enum ResistingSystem
{
    Case1_ConcreteMomentResistingFramesWithoutInFilled,
    Case2_SteelMomentResistingFramesWIthoutInFilled,
    Case3_SteelOrConcreteMomentResistingFramesWithInfilled,
    Case4_PartiallyOrTotallyRCShearWalls
}

/// <summary>
/// Building type
/// </summary>
public enum BuildingType
{
    Case1_ResidentialOfficesBuildings,
    Case2A_BuildingReceivingPublicTemporarilyRoomsOfExhibition,
    Case2B_BuildingReceivingPublicTemporarilyClassrooms,
    Case3_WarehousesHangars,
    Case4_ArchivesLibrariesTanks,
    Case5_OtherBuildings
}

/// <summary>
/// Algerian Wilayas (Provinces)
/// </summary>
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

/// <summary>
/// 3.1. Classification of the seismic zones
/// The national territory is subdivided into five (05) zones of increasing sismicity,
/// defined on the seismic zoning map and the attached table which details this repartition at the wilaya and commune levels
/// </summary>
public enum Zone
{
    ZoneI_LowSeismicity,
    ZoneIIa_ModerateSeismicity,
    ZoneIIb_ModerateSeismicity,
    ZoneIII_HighSeismicity
}