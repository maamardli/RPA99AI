namespace RPA99AI.Library
{
    public class Quality
    {
        public Quality(QualityCriteria qualitieCriteria)
        {
            QualitieCriteria = qualitieCriteria;
        }

        public QualityCriteria QualitieCriteria { get; }
        public double Valeur => BuildingHelpers.GetQualityValue(QualitieCriteria);
        public bool NonObserve { get; set; } = true;
    }
}