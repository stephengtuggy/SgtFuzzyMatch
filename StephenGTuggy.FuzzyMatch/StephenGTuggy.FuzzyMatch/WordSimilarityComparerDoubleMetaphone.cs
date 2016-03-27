﻿/**
 * Copyright (C) 2015-2016 Stephen G. Tuggy
 * 
 * This file is part of SgtFuzzyMatch.
 *
 * SgtFuzzyMatch is free software: you can redistribute it and/or modify it 
 * under the terms of the GNU Lesser General Public License as published by the 
 * Free Software Foundation, either version 3 of the License, or (at your 
 * option) any later version.
 *
 * SgtFuzzyMatch is distributed in the hope that it will be useful, but WITHOUT 
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS 
 * FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public License for more 
 * details.
 *
 * You should have received a copy of the GNU Lesser General Public License 
 * along with SgtFuzzyMatch.  If not, see <http://www.gnu.org/licenses/>.
 */

using nullpointer.Metaphone;
using System;

namespace StephenGTuggy.FuzzyMatch
{
    public class WordSimilarityComparerDoubleMetaphone : IStringSimilarityComparer
    {
        private DoubleMetaphoneSimilarityComparer _DoubleMetaphoneSimilarityComparer = new DoubleMetaphoneSimilarityComparer();
        
        public float CalcSimilarity(string p_ValueA, string p_ValueB)
        {
            if (p_ValueA.Equals(p_ValueB, StringComparison.OrdinalIgnoreCase))
            {
                return Similarity.MAX_POSSIBLE_SIMILARITY;
            }
            
            DoubleMetaphone l_DoubleMetaphoneA = new DoubleMetaphone(p_ValueA);
            DoubleMetaphone l_DoubleMetaphoneB = new DoubleMetaphone(p_ValueB);
            return _DoubleMetaphoneSimilarityComparer.CalcSimilarity(l_DoubleMetaphoneA, l_DoubleMetaphoneB);
        }
    }
}
