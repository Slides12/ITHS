﻿using System.Runtime.CompilerServices;

namespace L037__Library
{
    public static class StringExtensions
    {
        public static int WordCount(this string s)
        {
            return s.Split(' ').Length;
        }

        public static string Encapsulate(this string s, string enclosure)
        {
            return enclosure + s + enclosure;
        }
        public static string Encapsulate(this string s, string prefix, string suffix)
        {
            return prefix + s + suffix;
        }


        public static string Title(this string s)
        {
            return s.Substring(0,1).ToUpper() + s.Substring(1).ToLower();
        }
    }
}
