﻿/*
 * Frenzied Game, Copyright (C) 2012 - 2013 Int6 Studios - All Rights Reserved. - http://www.int6.org
 *
 * This file is part of Frenzied Game project. Unauthorized copying of this file, via any medium is strictly prohibited.
 * Frenzied Gam or its components/sources can not be copied and/or distributed without the express permission of Int6 Studios.
 */

using System.Collections.Generic;
using Frenzied.GamePlay.Modes;
using Microsoft.Xna.Framework;

namespace Frenzied.GamePlay.Implementations.PieMode
{
    /// <summary>
    /// Defines shape color.
    /// </summary>
    public class PieColors : ShapeColors
    {
        public const byte Orange = 1;
        public const byte Purple = 2;
        public const byte Green = 3;
        public const byte Blue = 4;
        public const byte Red = 5;
        public const byte Brown = 6;

        public new static IEnumerable<byte> GetEnumerator()
        {
            yield return Orange;
            yield return Purple;
            yield return Green;
            yield return Blue;
            yield return Red;
            yield return Brown;
        }

        public new static byte[] ToArray()
        {
            return new[] { Orange, Purple, Green, Blue, Red, Brown };
        }
    }
}
