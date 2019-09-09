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


using nullpointer.Metaphone;


namespace StephenGTuggy.FuzzyMatch
{
    public class DoubleMetaphoneSimilarityComparer : ISimilarityComparer<DoubleMetaphone>
    {
        public static readonly Fraction PRIMARY_KEYS_EQUAL = new Fraction { Numerator = 98, Denominator = 100 };
        public static readonly Fraction PRIMARY_KEY_EQUALS_ALTERNATE = new Fraction { Numerator = 90, Denominator = 100 };
        public static readonly Fraction ALTERNATE_KEYS_EQUAL = new Fraction { Numerator = 80, Denominator = 100 };

        public Fraction CalcSimilarity(DoubleMetaphone valueA, DoubleMetaphone valueB) {
            if ((valueA.PrimaryKey == valueB.PrimaryKey)
                && (valueA.AlternateKey == valueB.AlternateKey)) {
                return Similarity.MAX_SIMILARITY_FRACTION;
            } else if (valueA.PrimaryKey.Equals(valueB.PrimaryKey)) {
                return PRIMARY_KEYS_EQUAL;
            } else if (!string.IsNullOrEmpty(valueB.AlternateKey)
                  && valueA.PrimaryKey.Equals(valueB.AlternateKey)) {
                return PRIMARY_KEY_EQUALS_ALTERNATE;
            } else if (!string.IsNullOrEmpty(valueA.AlternateKey)
                  && valueB.PrimaryKey.Equals(valueA.AlternateKey)) {
                return PRIMARY_KEY_EQUALS_ALTERNATE;
            } else if (!string.IsNullOrEmpty(valueA.AlternateKey)
                  && !string.IsNullOrEmpty(valueB.AlternateKey)
                  && valueA.AlternateKey.Equals(valueA.AlternateKey)) {
                return ALTERNATE_KEYS_EQUAL;
            } else {
                return Similarity.MIN_SIMILARITY_FRACTION;
            }
        }
    }
}
