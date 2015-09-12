namespace StephenGTuggy.FuzzyMatch
{
    public interface IEditDistanceCalc
    {
        int CalcEditDistance(string p_ValueA, string p_ValueB);
        int GetMaxPossibleEditDistance(string p_ValueA, string p_ValueB);
    }
}
