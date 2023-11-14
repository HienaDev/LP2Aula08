using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendString
{
    public static class StringExtensions
    {

        private static readonly Random rng;

        static StringExtensions()
        {
            rng = new Random();
        }

        public static string ToRandomCase(this string str)
        {

            StringBuilder sb = new StringBuilder("", str.Length);

            foreach (char c in str)
            {
                char cAux = rng.NextSingle() >= 0.5 ? 
                Char.ToUpper(c) : Char.ToLower(c);

                sb.Append(cAux);
            }

            return sb.ToString();
        }

    }
}