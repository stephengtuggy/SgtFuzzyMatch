﻿/**
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
    public static class Similarity
    {
        public const double MIN_SIMILARITY_DOUBLE = 0.0;
        public const double MAX_SIMILARITY_DOUBLE = 1.0;
        public static readonly Fraction MIN_SIMILARITY_FRACTION = new Fraction { Numerator = 0, Denominator = 1 };
        public static readonly Fraction MAX_SIMILARITY_FRACTION = new Fraction { Numerator = 1, Denominator = 1 };
    }
}
