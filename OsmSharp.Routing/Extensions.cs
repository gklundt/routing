﻿// OsmSharp - OpenStreetMap (OSM) SDK
// Copyright (C) 2015 Abelshausen Ben
// 
// This file is part of OsmSharp.
// 
// OsmSharp is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// OsmSharp is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with OsmSharp. If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;

namespace OsmSharp.Routing
{
    /// <summary>
    /// Contains general extensions.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Gets the value associated with the specified key or returns the default.
        /// </summary>
        public static TValue TryGetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
        {
            TValue value;
            if(dictionary.TryGetValue(key, out value))
            {
                return value;
            }
            return default(TValue);
        }

        /// <summary>
        /// Gets the next power of two.
        /// </summary>
        public static int NextPowerOfTwo(int i)
        {
            if(i == 0)
            {
                return 0;
            }
            else if(i == 1)
            {
                return 1;
            }
            else if(i == 2)
            {
                return 2;
            }
            else if (!((i & (i - 1)) == 0))
            {
                i |= i >> 1;
                i |= i >> 2;
                i |= i >> 4;
                i |= i >> 8;
                i |= i >> 16;
                i++;
            }
            return i;
        }
    }
}