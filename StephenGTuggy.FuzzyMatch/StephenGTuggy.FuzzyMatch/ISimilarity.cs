using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenGTuggy.FuzzyMatch
{
    public interface ISimilarity<T>
    {
        /// <summary>
        /// Returns a score between 0.0F and 1.0F, representing how similar the two given values are. 1.0F means that the values are an exact match; 0.0F means that the values are completely different.
        /// </summary>
        /// <param name="p_ValueA">The first value to compare</param>
        /// <param name="p_ValueB">The second value to compare with the first</param>
        /// <returns>A float between 0.0F and 1.0F, representing the match percentage between <paramref name="p_ValueA"/> and <paramref name="p_ValueB"/></returns>
        float GetSimilarity(T p_ValueA, T p_ValueB);
    }
}
