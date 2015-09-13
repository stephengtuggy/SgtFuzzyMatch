using nullpointer.Metaphone;

namespace StephenGTuggy.FuzzyMatch
{
    public class DoubleMetaphoneSimilarityCalc : ISimilarityCalc<DoubleMetaphone>
    {
        public const float PRIMARY_KEYS_EQUAL = 0.98F;
        public const float PRIMARY_KEY_EQUALS_ALTERNATE = 0.90F;
        public const float ALTERNATE_KEYS_EQUAL = 0.80F;

        public float CalcSimilarity(DoubleMetaphone p_ValueA, DoubleMetaphone p_ValueB)
        {
            if ((p_ValueA.PrimaryKey == p_ValueB.PrimaryKey)
                && (p_ValueA.AlternateKey == p_ValueB.AlternateKey))
            {
                return SimilarityCalc.MAX_POSSIBLE_SIMILARITY;
            }
            else if (p_ValueA.PrimaryKey.Equals(p_ValueB.PrimaryKey))
            {
                return PRIMARY_KEYS_EQUAL;
            }
            else if (!string.IsNullOrEmpty(p_ValueB.AlternateKey)
                && p_ValueA.PrimaryKey.Equals(p_ValueB.AlternateKey))
            {
                return PRIMARY_KEY_EQUALS_ALTERNATE;
            }
            else if (!string.IsNullOrEmpty(p_ValueA.AlternateKey)
                && p_ValueB.PrimaryKey.Equals(p_ValueA.AlternateKey))
            {
                return PRIMARY_KEY_EQUALS_ALTERNATE;
            }
            else if (!string.IsNullOrEmpty(p_ValueA.AlternateKey)
                && !string.IsNullOrEmpty(p_ValueB.AlternateKey)
                && p_ValueA.AlternateKey.Equals(p_ValueA.AlternateKey))
            {
                return ALTERNATE_KEYS_EQUAL;
            }
            else
            {
                return SimilarityCalc.MIN_POSSIBLE_SIMILARITY;
            }
        }
    }
}
