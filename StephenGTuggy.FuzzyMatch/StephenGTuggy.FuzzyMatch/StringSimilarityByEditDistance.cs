using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenGTuggy.FuzzyMatch
{
    public class StringSimilarityByEditDistance : IStringSimilarity
    {
        private readonly IEditDistance _EditDistance;
        public IEditDistance EditDistance
        {
            get
            {
                return _EditDistance;
            }
        }

        public StringSimilarityByEditDistance(IEditDistance p_EditDistance)
        {
            _EditDistance = p_EditDistance;
        }
        
        public float GetSimilarity(string p_ValueA, string p_ValueB)
        {
            return EditDistance.GetEditDistance(p_ValueA, p_ValueB)
                / EditDistance.GetMaxPossibleEditDistance(p_ValueA, p_ValueB);
        }
    }
}
