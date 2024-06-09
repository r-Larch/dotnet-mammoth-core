using System;
using System.Text.RegularExpressions;


namespace Mammoth.Couscous.java.util.regex {
    internal class Matcher {
        private readonly Regex _regex;
        private readonly string _value;
        private Match _lastMatch;
        private int _regionStart;

        internal Matcher(Regex regex, string value)
        {
            _regex = regex;
            _value = value;
        }

        internal bool LookingAt()
        {
            var match = _regex.Match(_value, _regionStart);
            if (match.Success && match.Index == _regionStart) {
                _lastMatch = match;
                return true;
            }

            return false;
        }

        internal bool Find()
        {
            var match = _regex.Match(_value, _regionStart);
            if (match.Success) {
                _lastMatch = match;
                _regionStart = End();
                return true;
            }

            return false;
        }

        internal string Group()
        {
            return Group(0);
        }

        internal string Group(int groupIndex)
        {
            var group = _lastMatch.Groups[groupIndex];
            return group.Success ? group.Value : null;
        }

        internal int GroupCount()
        {
            return _regex.GetGroupNumbers().Length - 1;
        }

        internal int Start()
        {
            return _lastMatch.Index;
        }

        internal int End()
        {
            return _lastMatch.Index + _lastMatch.Length;
        }

        internal int RegionStart()
        {
            return _regionStart;
        }

        internal void Region(int start, int end)
        {
            if (end == _value.Length) {
                _regionStart = start;
            }
            else {
                throw new NotSupportedException();
            }
        }
    }
}
