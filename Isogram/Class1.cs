using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Isogram
{
    public class Isogram
    {

        static HashSet<char> set = new HashSet<char>();

        public static bool IsIsogram(string s)
        {
            char[] arr = s.ToCharArray();

            foreach (char item in arr)
            {
                if (set.Contains(item) && Regex.IsMatch(item.ToString(), @"^[a-zA-Z]+$")) return false;
                set.Add(item);
            }
            return true;
        }

    }
}
