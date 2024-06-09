using System.Text.RegularExpressions;


namespace Mammoth.Couscous.java.util.regex {
    internal class Pattern {
        public string Value { get; }
        private readonly Regex _regex;

        internal Pattern(string pattern, Regex regex)
        {
            Value = pattern;
            _regex = regex;
        }

        internal static Pattern Compile(string pattern)
        {
            return new Pattern(pattern, new Regex(pattern));
        }

        internal Matcher Matcher(string value)
        {
            return new Matcher(_regex, value);
        }
    }
}
