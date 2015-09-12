using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenGTuggy.FuzzyMatch
{
    public interface IEditDistance
    {
        int GetEditDistance(string p_ValueA, string p_ValueB);
        int GetMaxPossibleEditDistance(string p_ValueA, string p_ValueB);
    }
}
