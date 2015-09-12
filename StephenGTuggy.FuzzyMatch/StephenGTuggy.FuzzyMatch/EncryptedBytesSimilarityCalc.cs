using System.Linq;

namespace StephenGTuggy.FuzzyMatch
{
    public class EncryptedBytesSimilarityCalc : ISimilarityCalc<byte[]>
    {
        public float CalcSimilarity(byte[] p_ValueA, byte[] p_ValueB)
        {
            if (Enumerable.SequenceEqual(p_ValueA, p_ValueB))
            {
                return SimilarityCalc.MAX_POSSIBLE_SIMILARITY;
            }
            else
            {
                return SimilarityCalc.MIN_POSSIBLE_SIMILARITY;
            }
        }
    }
}
