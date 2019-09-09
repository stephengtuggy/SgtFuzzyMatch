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
    public class StringSimilarityComparerByEditDistance : IStringSimilarityComparer
    {
        public IEditDistanceCalculator EditDistanceCalculator { get; set; }

        public StringSimilarityComparerByEditDistance(IEditDistanceCalculator editDistanceCalc) {
            EditDistanceCalculator = editDistanceCalc;
        }

        public Fraction CalcSimilarity(string valueA, string valueB) {
            if (valueA == valueB) {
                return Similarity.MAX_SIMILARITY_FRACTION;
            } else {
                return new Fraction {
                    Numerator = EditDistanceCalculator.CalcEditDistance(valueA, valueB),
                    Denominator = EditDistanceCalculator.GetMaxPossibleEditDistance(valueA, valueB)
                };
            }
        }
    }
}
