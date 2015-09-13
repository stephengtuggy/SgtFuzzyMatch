/**
 * Copyright (C) 2015 Stephen G. Tuggy (sgt@StephenGTuggy.com).
 * 
 * This file is part of StephenGTuggy.FuzzyMatch.
 *
 * StephenGTuggy.FuzzyMatch is free software: you can redistribute it and/or 
 * modify it under the terms of the GNU Lesser General Public License as 
 * published by the Free Software Foundation, either version 3 of the License, 
 * or (at your option) any later version.
 *
 * StephenGTuggy.FuzzyMatch is distributed in the hope that it will be useful, 
 * but WITHOUT ANY WARRANTY; without even the implied warranty of 
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser 
 * General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License 
 * along with StephenGTuggy.FuzzyMatch.  If not, see 
 * <http://www.gnu.org/licenses/>.
 */

using nullpointer.Metaphone;
using System;

namespace StephenGTuggy.FuzzyMatch
{
    public class WordSimilarityCalcDoubleMetaphone : IStringSimilarityCalc
    {
        private DoubleMetaphoneSimilarityCalc _DoubleMetaphoneSimilarityCalc = new DoubleMetaphoneSimilarityCalc();
        
        public float CalcSimilarity(string p_ValueA, string p_ValueB)
        {
            if (p_ValueA.Equals(p_ValueB, StringComparison.OrdinalIgnoreCase))
            {
                return SimilarityCalc.MAX_POSSIBLE_SIMILARITY;
            }
            
            DoubleMetaphone l_DoubleMetaphoneA = new DoubleMetaphone(p_ValueA);
            DoubleMetaphone l_DoubleMetaphoneB = new DoubleMetaphone(p_ValueB);
            return _DoubleMetaphoneSimilarityCalc.CalcSimilarity(l_DoubleMetaphoneA, l_DoubleMetaphoneB);
        }
    }
}
