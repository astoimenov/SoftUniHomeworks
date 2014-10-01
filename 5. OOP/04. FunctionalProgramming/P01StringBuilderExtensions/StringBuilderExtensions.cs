namespace P01StringBuilderExtensions
{
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder stringBuilder, int startIndex, int length)
        {
            return stringBuilder.ToString().Substring(startIndex, length);
        }

        public static StringBuilder RemoveText(this StringBuilder stringBuilder, string text)
        {
            string sbToString = stringBuilder.ToString();
            string replaced = Regex.Replace(sbToString, text, string.Empty, RegexOptions.IgnoreCase);
            return stringBuilder.Replace(sbToString, replaced);
        }

        public static StringBuilder AppendAll<T>(this StringBuilder stringBuilder, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                stringBuilder.Append(item.ToString());
            }

            return stringBuilder;
        }
    }
}
