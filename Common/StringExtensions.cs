using System;

namespace Common
{
    public static class StringExtensions
    {
        public static string[] SplitLines(this string input) => input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
    }
}
