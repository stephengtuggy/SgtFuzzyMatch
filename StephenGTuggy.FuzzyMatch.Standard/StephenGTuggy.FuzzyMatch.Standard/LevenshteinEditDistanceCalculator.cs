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


/**
 * The MIT License (MIT)
 * 
 * Portions adapted from 
 * https://nullwords.wordpress.com/2013/03/13/the-bk-tree-a-data-structure-for-spell-checking/
 * 
 * Copyright (c) 2013
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
 * to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
 * and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */


using System;

namespace StephenGTuggy.FuzzyMatch.Standard
{
    class LevenshteinEditDistanceCalculator : IEditDistanceCalculator
    {
        public long CalcEditDistance(string valueA, string valueB)
        {
            if (valueA.Length == 0)
            {
                return valueB.Length;
            }
            if (valueB.Length == 0)
            {
                return valueA.Length;
            }

            var lenA = valueA.Length;
            var lenB = valueB.Length;

            var d = new int[lenA + 1, lenB + 1];

            for (var i = 0; i <= lenA; ++i)
            {
                d[i, 0] = i;
            }

            for (var i = 0; i <= lenB; ++i)
            {
                d[0, i] = i;
            }

            for (var i = 1; i <= lenA; ++i)
            {
                for (var j = 1; j <= lenB; ++j)
                {
                    var match = (valueA[i - 1].Equals(valueB[j - 1])) ? 0 : 1;
                    d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + match);
                }
            }

            return d[lenA, lenB];
        }

        public long GetMaxPossibleEditDistance(string valueA, string valueB)
        {
            return valueA.Length + valueB.Length;
        }
    }
}
