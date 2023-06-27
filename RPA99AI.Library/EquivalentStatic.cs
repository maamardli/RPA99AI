using static System.Math;
namespace RPA99AI.Library
{
    /// <summary>
    /// 4.2. Equivalent static method:
    /// the dynamic real loads developed in the construction are replaced by a system of nominal static loads the effects of which are considered equivalent to those of the seismic action
    /// </summary>
    public class EquivalentStatic
    {
        private readonly Building _building;

        public EquivalentStatic(Building building)
        {
            _building = building;
        }

        public MethodToCalculateTEmpiric Empiric { get; set; }

        public FormulatoCalculateTStatic FormulaCalculateTStatic { get; set; }

        public ResistingSystem SystemeContreventementStat { get; set; }

        /// <summary>
        /// Ct: coefficient, function of the lateral force resisting system and of the type of infill
        /// </summary>
        public double Ct => GetCt(SystemeContreventementStat);

        /// <summary>
        /// δ (Delta): horizontal displacement at to the top of the building
        /// </summary>
        public double Delta { get; set; } = 1.0;

        /// <summary>
        /// Determines if the Equivalent Static method is applicable or not according the ALGERIAN EARTHQUAKE RESISTANT REGULATIONS
        /// </summary>
        public bool IsStaticApplicable => GetIsStaticApplicable(_building);

        /// <summary>
        /// Tx: the fundamental period of the structure in the direction X
        /// </summary>
        public double Tx => GetT(_building, _building.Lx);
        /// <summary>
        /// Ty: the fundamental period of the structure in the direction Y
        /// </summary>
        public double Ty => GetT(_building, _building.Ly);

        /// <summary>
        /// Dx: Average dynamic amplification factor in the direction X
        /// </summary>
        public double Dx => GetD(_building.Eta, Tx, _building.T2);
        /// <summary>
        /// Dy: Average dynamic amplification factor in the direction Y
        /// </summary>
        public double Dy => GetD(_building.Eta, Ty, _building.T2);

        /// <summary>
        /// Vx: The total seismic load in the direction X
        /// </summary>
        public double Vx => GetV(_building.A, Dx, _building.Q, _building.W, _building.R);
        /// <summary>
        /// Vy: The total seismic load in the direction Y
        /// </summary>
        public double Vy => GetV(_building.A, Dy, _building.Q, _building.W, _building.R);

        public double Vx08 => Vx * 0.8;
        public double Vy08 => Vy * 0.8;

        #region Static Methodes

        /// <summary>
        /// The empirical formula recommended
        /// </summary>
        /// <param name="hn">height measured in meters</param>
        /// <param name="ct">coefficient, function of the lateral force resisting system</param>
        /// <returns></returns>
        private static double GetEmp1(double hn, double ct) => ct * Pow(hn, 3.0 / 4.0);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hn"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        private static double GetEmp2(double hn, double l) => 0.09 * hn / Sqrt(l);

        /// <summary>
        /// Simplified version of Rayleigh formula
        /// </summary>
        /// <param name="delta"> Horizontal displacement at to the top of the building, measured in meters, due to the vertical dead loads applied horizontally.</param>
        /// <returns></returns>
        private static double GetRayleigh(double delta) => 2 * Sqrt(delta);

        /// <summary>
        ///  Estimation of the fundamental period of the structure
        /// </summary>
        /// <param name="myBuilding"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private static double GetT(Building myBuilding, double l)
        {
            if (myBuilding is null)
            {
                throw new ArgumentNullException(nameof(myBuilding));
            }

            var criteria = (myBuilding.EquivalentStaticMethod.FormulaCalculateTStatic, myBuilding.EquivalentStaticMethod.SystemeContreventementStat, myBuilding.EquivalentStaticMethod.Empiric);
            return criteria switch
            {
                (FormulatoCalculateTStatic.FormulaEmpiric, ResistingSystem.Case1_ConcreteMomentResistingFramesWithoutInFilled, _) => GetEmp1(myBuilding.Hn, myBuilding.EquivalentStaticMethod.Ct),
                (FormulatoCalculateTStatic.FormulaEmpiric, ResistingSystem.Case2_SteelMomentResistingFramesWIthoutInFilled, _) => GetEmp1(myBuilding.Hn, myBuilding.EquivalentStaticMethod.Ct),
                (FormulatoCalculateTStatic.FormulaEmpiric, ResistingSystem.Case3_SteelOrConcreteMomentResistingFramesWithInfilled, MethodToCalculateTEmpiric.Methode1Formule46) => GetEmp1(myBuilding.Hn, myBuilding.EquivalentStaticMethod.Ct),
                (FormulatoCalculateTStatic.FormulaEmpiric, ResistingSystem.Case3_SteelOrConcreteMomentResistingFramesWithInfilled, MethodToCalculateTEmpiric.Methode2Formule47) => GetEmp2(myBuilding.Hn, l),
                (FormulatoCalculateTStatic.FormulaEmpiric, ResistingSystem.Case3_SteelOrConcreteMomentResistingFramesWithInfilled, MethodToCalculateTEmpiric.Methode3MinFormule) => Min(GetEmp1(myBuilding.Hn, myBuilding.EquivalentStaticMethod.Ct), GetEmp2(myBuilding.Hn, l)),
                (FormulatoCalculateTStatic.FormulaEmpiric, ResistingSystem.Case4_PartiallyOrTotallyRCShearWalls, MethodToCalculateTEmpiric.Methode1Formule46) => GetEmp1(myBuilding.Hn, myBuilding.EquivalentStaticMethod.Ct),
                (FormulatoCalculateTStatic.FormulaEmpiric, ResistingSystem.Case4_PartiallyOrTotallyRCShearWalls, MethodToCalculateTEmpiric.Methode2Formule47) => GetEmp2(myBuilding.Hn, l),
                (FormulatoCalculateTStatic.FormulaEmpiric, ResistingSystem.Case4_PartiallyOrTotallyRCShearWalls, MethodToCalculateTEmpiric.Methode3MinFormule) => Min(GetEmp1(myBuilding.Hn, myBuilding.EquivalentStaticMethod.Ct), GetEmp2(myBuilding.Hn, l)),
                (FormulatoCalculateTStatic.FormulaRayleighSimplified, _, _) => GetRayleigh(myBuilding.EquivalentStaticMethod.Delta),
                _ => throw new ArgumentOutOfRangeException(nameof(myBuilding)),
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eta"></param>
        /// <param name="t"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private static double GetD(double eta, double t, double t2) => t switch
        {
            double _ when t >= 0.0 && t < t2 => 2.5 * eta,
            double _ when t >= t2 && t < 3.0 => 2.5 * eta * Pow(t2 / t, 2.0 / 3.0),
            double _ when t >= 3.0 => 2.5 * eta * Pow(t2 / 3.0, 2.0 / 3.0) * Pow(3.0 / t, 5.0 / 3.0),
            _ => throw new ArgumentOutOfRangeException(nameof(t)),
        };

        /// <summary>
        /// The method to get the Total seismic load 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="d"></param>
        /// <param name="q"></param>
        /// <param name="w"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private static double GetV(double a, double d, double q, double w, double r) => a * d * q * w / r;

        /// <summary>
        /// Getting the value of the coefficient CT
        /// </summary>
        /// <param name="systemeContreventementStat"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static double GetCt(ResistingSystem systemeContreventementStat)
        {
            return systemeContreventementStat switch
            {
                ResistingSystem.Case1_ConcreteMomentResistingFramesWithoutInFilled => 0.075,
                ResistingSystem.Case2_SteelMomentResistingFramesWIthoutInFilled => 0.085,
                ResistingSystem.Case3_SteelOrConcreteMomentResistingFramesWithInfilled => 0.050,
                ResistingSystem.Case4_PartiallyOrTotallyRCShearWalls => 0.050,
                _ => throw new NotImplementedException(),
            };
        }

        /// <summary>
        /// A method that tests if the Equivilant static method is applicable on this Building.
        /// </summary>
        /// <param name="myOuvrage"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private static bool GetIsStaticApplicable(Building myOuvrage)
        {
            if (myOuvrage is null)
            {
                throw new ArgumentNullException(nameof(myOuvrage));
            }

            var criteria = (myOuvrage.Zone, myOuvrage.Importance, myOuvrage.Qualites[2].NonObserve, myOuvrage.Qualites[3].NonObserve);
            return criteria switch
            {
                //**************Zone************,***********************Importance**********************,
                (Zone.ZoneI_LowSeismicity       , _                                                     , false , false ) => myOuvrage.Hn <= 65.0,
                (Zone.ZoneIIa_ModerateSeismicity, _                                                     , false , false ) => myOuvrage.Hn <= 65.0,
                (Zone.ZoneIIb_ModerateSeismicity, _                                                     , false , false ) => myOuvrage.Hn <= 30.0,
                (Zone.ZoneIII_HighSeismicity    , _                                                     , false , false ) => myOuvrage.Hn <= 30.0,
                (Zone.ZoneI_LowSeismicity       , _                                                     , _     , _     ) => true,
                (Zone.ZoneIIa_ModerateSeismicity, Importance.Group1A_ConstructionOfVitalImportance      , _     , _     ) => myOuvrage.Hn <= 10.0,
                (Zone.ZoneIIa_ModerateSeismicity, Importance.Group1B_ConstructionOfHighImportance       , _     , _     ) => myOuvrage.Hn <= 17.0,
                (Zone.ZoneIIa_ModerateSeismicity, Importance.Group2_ConstructionsOfModerateImportance   , _     , _     ) => myOuvrage.Hn <= 23.0,
                (Zone.ZoneIIa_ModerateSeismicity, Importance.Group3_ConstructionsOfLowImportance        , _     , _     ) => true,
                (Zone.ZoneIIb_ModerateSeismicity, Importance.Group1A_ConstructionOfVitalImportance      , _     , _     ) => myOuvrage.Hn <= 08.0,
                (Zone.ZoneIIb_ModerateSeismicity, Importance.Group1B_ConstructionOfHighImportance       , _     , _     ) => myOuvrage.Hn <= 10.0,
                (Zone.ZoneIIb_ModerateSeismicity, Importance.Group2_ConstructionsOfModerateImportance   , _     , _     ) => myOuvrage.Hn <= 17.0,
                (Zone.ZoneIIb_ModerateSeismicity, Importance.Group3_ConstructionsOfLowImportance        , _     , _     ) => myOuvrage.Hn <= 17.0,
                (Zone.ZoneIII_HighSeismicity    , Importance.Group1A_ConstructionOfVitalImportance      , _     , _     ) => myOuvrage.Hn <= 08.0,
                (Zone.ZoneIII_HighSeismicity    , Importance.Group1B_ConstructionOfHighImportance       , _     , _     ) => myOuvrage.Hn <= 10.0,
                (Zone.ZoneIII_HighSeismicity    , Importance.Group2_ConstructionsOfModerateImportance   , _     , _     ) => myOuvrage.Hn <= 17.0,
                (Zone.ZoneIII_HighSeismicity    , Importance.Group3_ConstructionsOfLowImportance        , _     , _     ) => myOuvrage.Hn <= 17.0,
                _ => throw new ArgumentOutOfRangeException(nameof(myOuvrage)),
            };
        }
        #endregion Static Methodes
    }
}