namespace RPA99AI.Library
{
    public class Quality
    {
        public Quality(QualityCriteria qualitieCriteria)
        {
            QualitieCriteria = qualitieCriteria;
        }

        public QualityCriteria QualitieCriteria { get; }
        public double Valeur => GetValue(QualitieCriteria);
        public bool NonObserve { get; set; } = true;

        private static double GetValue(QualityCriteria qualitieCriterias)
        {
            return qualitieCriterias switch
            {
                QualityCriteria.Q1MinimalConditionsOnBracingLines => 0.05,
                QualityCriteria.Q2RedundancyInPlan => 0.05,
                QualityCriteria.Q3RegularityInPlan => 0.05,
                QualityCriteria.Q4RegularityInElevation => 0.05,
                QualityCriteria.Q5ControlOfMaterialQuality => 0.05,
                QualityCriteria.Q6ControlOfConstructionQuality => 0.10,
                _ => throw new ArgumentOutOfRangeException(nameof(qualitieCriterias)),
            };
        }
    }
}