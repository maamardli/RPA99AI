using RPA99AI.Library;

internal static class BuildingHelpers
{
    internal static readonly Dictionary<Wilaya, Zone> WilayaZoneMap = new()
    {
        {Wilaya.ChlefA          , Zone.ZoneIII_HighSeismicity       },
        {Wilaya.ChlefB          , Zone.ZoneIIb_ModerateSeismicity   },
        {Wilaya.ChlefC          , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Laghouat        , Zone.ZoneI_LowSeismicity          },
        {Wilaya.OumElBouaghi    , Zone.ZoneI_LowSeismicity          },
        {Wilaya.Batna           , Zone.ZoneI_LowSeismicity          },
        {Wilaya.Bejaia          , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Biskra          , Zone.ZoneI_LowSeismicity          },
        {Wilaya.BlidaA          , Zone.ZoneIII_HighSeismicity       },
        {Wilaya.BlidaB          , Zone.ZoneIIb_ModerateSeismicity   },
        {Wilaya.Bouira          , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Tebessa         , Zone.ZoneI_LowSeismicity          },
        {Wilaya.Tlemcen         , Zone.ZoneI_LowSeismicity          },
        {Wilaya.Tiaret          , Zone.ZoneI_LowSeismicity          },
        {Wilaya.TiziOuzouA      , Zone.ZoneIIb_ModerateSeismicity   },
        {Wilaya.TiziOuzouB      , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Alger           , Zone.ZoneIII_HighSeismicity       },
        {Wilaya.Djelfa          , Zone.ZoneI_LowSeismicity          },
        {Wilaya.Jijel           , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Setif           , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Saida           , Zone.ZoneI_LowSeismicity          },
        {Wilaya.Skikda          , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.SidiBelAbbes    , Zone.ZoneI_LowSeismicity          },
        {Wilaya.Annaba          , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Guelma          , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Constantine     , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.MedeaA          , Zone.ZoneIIb_ModerateSeismicity   },
        {Wilaya.MedeaB          , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.MedeaC          , Zone.ZoneI_LowSeismicity          },
        {Wilaya.MostganemA      , Zone.ZoneIII_HighSeismicity       },
        {Wilaya.MostganemB      , Zone.ZoneIIb_ModerateSeismicity   },
        {Wilaya.MostganemC      , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.MsilaA          , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.MsilaB          , Zone.ZoneI_LowSeismicity          },
        {Wilaya.MascaraA        , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.MascareB        , Zone.ZoneI_LowSeismicity          },
        {Wilaya.Oran            , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.ElBayadh        , Zone.ZoneI_LowSeismicity          },
        {Wilaya.BordjBouArreridj, Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.BoumerdesA      , Zone.ZoneIII_HighSeismicity       },
        {Wilaya.BoumerdesB      , Zone.ZoneIIb_ModerateSeismicity   },
        {Wilaya.BoumerdesC      , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.ElTaref         , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Tissemsilt      , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Khenchela       , Zone.ZoneI_LowSeismicity          },
        {Wilaya.SoukAhras       , Zone.ZoneI_LowSeismicity          },
        {Wilaya.Tipaza          , Zone.ZoneIII_HighSeismicity       },
        {Wilaya.Mila            , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.AinDeflaA       , Zone.ZoneIII_HighSeismicity       },
        {Wilaya.AinDeflaB       , Zone.ZoneIIb_ModerateSeismicity   },
        {Wilaya.AinDeflaC       , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.Naama           , Zone.ZoneI_LowSeismicity          },
        {Wilaya.AinTemouchent   , Zone.ZoneIIa_ModerateSeismicity   },
        {Wilaya.RelizaneA       , Zone.ZoneIII_HighSeismicity       },
        {Wilaya.RelizaneB       , Zone.ZoneIIb_ModerateSeismicity   },
        {Wilaya.RelizaneC       , Zone.ZoneIIa_ModerateSeismicity   },
    };

    internal static readonly Dictionary<StructuralSystems, double> RValues = new()
    {
        {StructuralSystems.A1A, 5.00},
        {StructuralSystems.A1B, 3.50},
        {StructuralSystems.A2, 3.50},
        {StructuralSystems.A3, 3.50},
        {StructuralSystems.A4A, 5.00},
        {StructuralSystems.A4B, 4.00},
        {StructuralSystems.A5, 2.00},
        {StructuralSystems.A6, 2.00},
        {StructuralSystems.B7, 6.00},
        {StructuralSystems.B8, 4.00},
        {StructuralSystems.B9A, 4.00},
        {StructuralSystems.B9B, 3.00},
        {StructuralSystems.B10A, 5.00},
        {StructuralSystems.B10B, 4.00},
        {StructuralSystems.B11, 2.00},
        {StructuralSystems.C12, 2.50},
        {StructuralSystems.D13, 2.00},
        {StructuralSystems.D14, 3.00},
        {StructuralSystems.D15, 3.50},
        {StructuralSystems.D16, 4.00},
        {StructuralSystems.D17, 2.00},
    };
    
    internal static readonly Dictionary<(Zone, Importance), double> AValues = new()
    {
        {(Zone.ZoneI_LowSeismicity       , Importance.Group1A_ConstructionOfVitalImportance   ), 0.15},
        {(Zone.ZoneI_LowSeismicity       , Importance.Group1B_ConstructionOfHighImportance    ), 0.12},
        {(Zone.ZoneI_LowSeismicity       , Importance.Group2_ConstructionsOfModerateImportance), 0.10},
        {(Zone.ZoneI_LowSeismicity       , Importance.Group3_ConstructionsOfLowImportance     ), 0.07},
        {(Zone.ZoneIIa_ModerateSeismicity, Importance.Group1A_ConstructionOfVitalImportance   ), 0.25},
        {(Zone.ZoneIIa_ModerateSeismicity, Importance.Group1B_ConstructionOfHighImportance    ), 0.20},
        {(Zone.ZoneIIa_ModerateSeismicity, Importance.Group2_ConstructionsOfModerateImportance), 0.15},
        {(Zone.ZoneIIa_ModerateSeismicity, Importance.Group3_ConstructionsOfLowImportance     ), 0.10},
        {(Zone.ZoneIIb_ModerateSeismicity, Importance.Group1A_ConstructionOfVitalImportance   ), 0.30},
        {(Zone.ZoneIIb_ModerateSeismicity, Importance.Group1B_ConstructionOfHighImportance    ), 0.25},
        {(Zone.ZoneIIb_ModerateSeismicity, Importance.Group2_ConstructionsOfModerateImportance), 0.20},
        {(Zone.ZoneIIb_ModerateSeismicity, Importance.Group3_ConstructionsOfLowImportance     ), 0.14},
        {(Zone.ZoneIII_HighSeismicity    , Importance.Group1A_ConstructionOfVitalImportance   ), 0.40},
        {(Zone.ZoneIII_HighSeismicity    , Importance.Group1B_ConstructionOfHighImportance    ), 0.30},
        {(Zone.ZoneIII_HighSeismicity    , Importance.Group2_ConstructionsOfModerateImportance), 0.25},
        {(Zone.ZoneIII_HighSeismicity    , Importance.Group3_ConstructionsOfLowImportance     ), 0.18}
    };


    internal static readonly Dictionary<BuildingType, double> BetaValues = new()
    {
            {BuildingType.Case1_ResidentialOfficesBuildings                         , 0.20},
            {BuildingType.Case2A_BuildingReceivingPublicTemporarilyRoomsOfExhibition, 0.30},
            {BuildingType.Case2B_BuildingReceivingPublicTemporarilyClassrooms       , 0.40},
            {BuildingType.Case3_WarehousesHangars                                   , 0.40},
            {BuildingType.Case4_ArchivesLibrariesTanks                              , 1.00},
            {BuildingType.Case5_OtherBuildings                                      , 0.60}
        };


    /// <summary>
    /// T2: characteristic period, associated to the category of the site
    /// </summary>
    internal static readonly Dictionary<Site, double> T2Values = new()
    {
            {Site.S1RockySite, 0.30},
            {Site.S2FirmSite, 0.40},
            {Site.S3SoftSite, 0.50},
            {Site.S4VerySoftSite, 0.70},
        };

    internal static readonly Dictionary<Site, double> T1Values = new()
    {
            {Site.S1RockySite, 0.15},
            {Site.S2FirmSite, 0.15},
            {Site.S3SoftSite, 0.15},
            {Site.S4VerySoftSite, 0.15},
        };

    internal static readonly Dictionary<Material, double> XiValues = new()
    {
            { Material.ConcreteLight, 6.00 },
            { Material.ConcreteHeavy, 7.00 },
            { Material.SteelLight, 4.00 },
            { Material.SteelHeavy, 5.00 },
            { Material.ShearWalls, 10.00 }
        };


    internal static double GetA(Building ouvrage)
    {
        var criteria = (ouvrage.Zone, ouvrage.Importance);
        return AValues.TryGetValue(criteria, out double value) ? value : throw new NotImplementedException();
    }

    /// <summary>
    /// Get Beta (β): based on the Type of the Building
    /// </summary>
    /// <param name="typesOuvrages"> Type of the building</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    internal static double GetBeta(BuildingType typesOuvrages)
    {
        if (BuildingHelpers.BetaValues.TryGetValue(typesOuvrages, out var beta))
        {
            return beta;
        }

        throw new NotImplementedException();
    }

    internal static double GetEta(double xi) => Math.Sqrt(7.0 / (xi + 2.0));

    internal static double GetR(StructuralSystems systemeContreventement)
    {
        return RValues.TryGetValue(systemeContreventement, out double r) ? r : throw new NotImplementedException();
    }

    internal static double GetT1(Site site)
    {
        return T1Values.TryGetValue(site, out double value) ? value : throw new NotImplementedException();
    }

    internal static double GetT2(Site site)
    {
        return T2Values.TryGetValue(site, out double value) ? value : throw new NotImplementedException();
    }

    internal static double GetXi(Material materiau)
    {
        return XiValues.TryGetValue(materiau, out double value) ? value : throw new NotImplementedException();
    }


    internal static Zone GetZone(Building ouvrage)
    {
        return ouvrage.DeclarationduZone switch
        {
            DeclarationOfTheZone.ByZone => ouvrage._zone,
            DeclarationOfTheZone.ByWilaya when WilayaZoneMap.TryGetValue(ouvrage.Wilaya, out var zone) => zone,
            _ => throw new NotImplementedException(),
        };
    }
}