namespace StephenGTuggy.FuzzyMatch
{
    public class StringSimilarityCalcByEditDistance : IStringSimilarityCalc
    {
        private readonly IEditDistanceCalc _EditDistanceCalc;
        public IEditDistanceCalc EditDistanceCalc
        {
            get
            {
                return _EditDistanceCalc;
            }
        }

        public StringSimilarityCalcByEditDistance(IEditDistanceCalc p_EditDistanceCalc)
        {
            _EditDistanceCalc = p_EditDistanceCalc;
        }
        
        public float CalcSimilarity(string p_ValueA, string p_ValueB)
        {
            return (float)EditDistanceCalc.CalcEditDistance(p_ValueA, p_ValueB)
                / (float)EditDistanceCalc.GetMaxPossibleEditDistance(p_ValueA, p_ValueB);
        }
    }
}
