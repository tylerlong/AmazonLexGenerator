using System.Linq;

namespace AmazonLexGenerator
{
    public static class Util
    {
        public static string[] Cartesian(this string[] first, string[] second)
        {
            return (from f in first from s in second select $"{f} {s}".Trim()).ToArray();
        }

        public static string[] Variant(this string[] original, string subStr, string newSubStr)
        {
            return original.Concat(original.Select(s => s.Replace(subStr, newSubStr))).ToArray();
        }
    }
}