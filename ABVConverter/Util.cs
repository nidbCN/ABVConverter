﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ABVConverter
{
    public static class Util
    {
        // Private data.
        private const string Table = "fZodR9XQDSUm21yCkr6zBqiveYah8bt4xsWpHnJE7jL5VG3guMTKNPAwcF";
        private const int Xor = 177451812;
        private const long Add = 100618342136696320L;
        private static readonly int[] S = { 11, 10, 3, 8, 4, 6, 2, 9, 5, 7 };
        private static readonly Dictionary<char, int> Tr;

        static Util()
        {
            Tr = new Dictionary<char, int>();
            for (var i = 0; i < 58; ++i)
            {
                Tr.Add(Table[i], i);
            }
        }

        /// <summary>
        /// Convert BvCode to AvCode
        /// </summary>
        /// <param name="bv">Video BvCode</param>
        /// <returns></returns>
        public static string BvToAv(string bv)
        {
            if (bv == null) return null;
            if (!bv.ToUpper().StartsWith("BV")) bv = "BV" + bv;

            long r = 0;
            for (var i = 0; i < 10; ++i)
            {
                r += Tr[bv[S[i]]] * (long)Math.Pow(58, i);
            }

            return "av" + ((r - Add) ^ Xor);
        }

        /// <summary>
        /// Convert AvCode to BvCode
        /// </summary>
        /// <param name="av">Video AvCode</param>
        /// <returns></returns>
        public static string AvToBv(string av)
        {

            if (!int.TryParse(av.ToLower().StartsWith("av") ? av[2..] : av
                , out var x)) return null;

            var x1 = (x ^ Xor) + Add;
            var r = "BV          ".ToCharArray();
            for (var i = 0; i < 10; ++i)
            {
                r[S[i]] = Table[(int)(x1 / (long)Math.Pow(58, i) % 58)];
            }

            return Regex.Replace(new string(r), @"[\[\]\s,]", string.Empty);
        }
    }
}
