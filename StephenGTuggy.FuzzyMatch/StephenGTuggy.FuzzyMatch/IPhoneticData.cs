using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenGTuggy.FuzzyMatch
{
    public interface IPhoneticData
    {
        IList<string> GetPhoneticData(string p_Value);
    }
}
