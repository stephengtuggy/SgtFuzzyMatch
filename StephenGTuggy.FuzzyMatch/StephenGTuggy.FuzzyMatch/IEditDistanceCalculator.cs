﻿/**
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

namespace StephenGTuggy.FuzzyMatch
{
    public interface IEditDistanceCalculator
    {
        int CalcEditDistance(string p_ValueA, string p_ValueB);
        int GetMaxPossibleEditDistance(string p_ValueA, string p_ValueB);
    }
}