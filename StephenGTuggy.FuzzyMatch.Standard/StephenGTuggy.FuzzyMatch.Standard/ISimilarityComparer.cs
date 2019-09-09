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

namespace StephenGTuggy.FuzzyMatch
{
    public interface ISimilarityComparer<T>
    {
        /// <summary>
        /// Returns a score between 0.0F and 1.0F, representing how similar the two given values are. 1.0F means that the values are an exact match; 0.0F means that the values are completely different.
        /// </summary>
        /// <param name="p_ValueA">The first value to compare</param>
        /// <param name="p_ValueB">The second value to compare with the first</param>
        /// <returns>A float between 0.0F and 1.0F, representing the match percentage between <paramref name="p_ValueA"/> and <paramref name="p_ValueB"/></returns>
        float CalcSimilarity(T p_ValueA, T p_ValueB);
    }
}
