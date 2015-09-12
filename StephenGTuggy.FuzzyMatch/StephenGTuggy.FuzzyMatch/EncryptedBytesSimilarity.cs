using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenGTuggy.FuzzyMatch
{
    public class EncryptedBytesSimilarity : ISimilarity<byte[]>
    {
        public float GetSimilarity(byte[] p_ValueA, byte[] p_ValueB)
        {
            if (Enumerable.SequenceEqual(p_ValueA, p_ValueB))
            {
                return Similarity.MaxSimilarity;
            }
            else
            {
                return Similarity.MinSimilarity;
            }
        }
    }
}
