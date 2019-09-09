/**
 * Copyright (C) 2015-2019 Stephen G. Tuggy
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

using System.Linq;

namespace StephenGTuggy.FuzzyMatch
{
    public class EncryptedBytesSimilarityComparer : ISimilarityComparer<byte[]>
    {
        public float CalcSimilarity(byte[] p_ValueA, byte[] p_ValueB)
        {
            if ((p_ValueA == null) && (p_ValueB == null))
            {
                return Similarity.MAX_POSSIBLE_SIMILARITY;
            }
            else if (Enumerable.SequenceEqual(p_ValueA, p_ValueB))
            {
                return Similarity.MAX_POSSIBLE_SIMILARITY;
            }
            else
            {
                return Similarity.MIN_POSSIBLE_SIMILARITY;
            }
        }
    }
}
