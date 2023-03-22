namespace RPA99AI.Library
{
    public class Qualitie
    {
        public Qualitie(QualitieCriteria qualitieCriteria)
        {
            QualitieCriteria = qualitieCriteria;
        }

        public QualitieCriteria QualitieCriteria { get; }
        public double Valeur => GetValeur(QualitieCriteria);
        public bool NonObserve { get; set; } = true;

        private static double GetValeur(QualitieCriteria qualitieCriterias)
        {
            return qualitieCriterias switch
            {
                QualitieCriteria.ConditionsMinimalesSurLesFilesDeContreventement => 0.05,
                QualitieCriteria.RedondanceEnPlan => 0.05,
                QualitieCriteria.RegulariteEnPlan => 0.05,
                QualitieCriteria.RegulariteEnElevation => 0.05,
                QualitieCriteria.ControleDeLaQualiteDesMateriaux => 0.05,
                QualitieCriteria.ControleDeLaQualiteDeLExecution => 0.10,
                _ => throw new ArgumentOutOfRangeException(nameof(qualitieCriterias)),
            };
        }
    }
}