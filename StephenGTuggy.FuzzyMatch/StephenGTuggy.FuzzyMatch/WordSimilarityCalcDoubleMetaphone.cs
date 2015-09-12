using nullpointer.Metaphone;
using System;

namespace StephenGTuggy.FuzzyMatch
{
    public class WordSimilarityCalcDoubleMetaphone : IStringSimilarityCalc
    {
        public const float PRIMARY_KEYS_EQUAL = 0.98F;
        public const float PRIMARY_KEY_EQUALS_ALTERNATE = 0.90F;
        public const float ALTERNATE_KEYS_EQUAL = 0.80F;
        
        public float CalcSimilarity(string p_ValueA, string p_ValueB)
        {
            if (p_ValueA.Equals(p_ValueB, StringComparison.OrdinalIgnoreCase))
            {
                return SimilarityCalc.MAX_POSSIBLE_SIMILARITY;
            }
            
            DoubleMetaphone l_DoubleMetaphoneA = new DoubleMetaphone(p_ValueA);
            DoubleMetaphone l_DoubleMetaphoneB = new DoubleMetaphone(p_ValueB);
            
            if (l_DoubleMetaphoneA.PrimaryKey.Equals(l_DoubleMetaphoneB.PrimaryKey))
            {
                return PRIMARY_KEYS_EQUAL;
            }
            else if (!string.IsNullOrEmpty(l_DoubleMetaphoneB.AlternateKey)
                && l_DoubleMetaphoneA.PrimaryKey.Equals(l_DoubleMetaphoneB.AlternateKey))
            {
                return PRIMARY_KEY_EQUALS_ALTERNATE;
            }
            else if (!string.IsNullOrEmpty(l_DoubleMetaphoneA.AlternateKey)
                && l_DoubleMetaphoneB.PrimaryKey.Equals(l_DoubleMetaphoneA.AlternateKey))
            {
                return PRIMARY_KEY_EQUALS_ALTERNATE;
            }
            else if (!string.IsNullOrEmpty(l_DoubleMetaphoneA.AlternateKey)
                && !string.IsNullOrEmpty(l_DoubleMetaphoneB.AlternateKey)
                && l_DoubleMetaphoneA.AlternateKey.Equals(l_DoubleMetaphoneA.AlternateKey))
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
