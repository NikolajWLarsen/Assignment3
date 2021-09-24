using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment3
{
    public static class Extensions
    {
        public static bool IsSecure (this Uri uri)
        {
            return uri.Scheme == Uri.UriSchemeHttps;
        }

        public static int WordCount (this string str)
        {
            return Regex.Split(str, @"[^\p{L}]+").Count();
        }
    }
}
