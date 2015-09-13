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

namespace StephenGTuggy.FuzzyMatch
{
    public class DoubleMetaphoneSimilarityComparer : ISimilarityComparer<DoubleMetaphone>
    {
        public const float PRIMARY_KEYS_EQUAL = 0.98F;
        public const float PRIMARY_KEY_EQUALS_ALTERNATE = 0.90F;
        public const float ALTERNATE_KEYS_EQUAL = 0.80F;

        public float CalcSimilarity(DoubleMetaphone p_ValueA, DoubleMetaphone p_ValueB)
        {
            if ((p_ValueA.PrimaryKey == p_ValueB.PrimaryKey)
                && (p_ValueA.AlternateKey == p_ValueB.AlternateKey))
            {
                return Similarity.MAX_POSSIBLE_SIMILARITY;
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
                return Similarity.MIN_POSSIBLE_SIMILARITY;
            }
        }
    }
}
