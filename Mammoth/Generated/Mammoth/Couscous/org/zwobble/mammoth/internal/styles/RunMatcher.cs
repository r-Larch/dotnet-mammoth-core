using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class RunMatcher : DocumentElementMatcher<Run> {
        internal static RunMatcher _ANY;
        internal Optional<string> _styleId;
        internal Optional<StringMatcher> _styleName;

        static RunMatcher()
        {
            _ANY = new RunMatcher(Optional.empty<string>(), Optional.empty<StringMatcher>());
        }

        internal RunMatcher(Optional<string> styleId, Optional<StringMatcher> styleName)
        {
            _styleId = styleId;
            _styleName = styleName;
        }

        public bool matches(Run run)
        {
            return DocumentElementMatching.matchesStyle(_styleId, _styleName, run.getStyle());
        }

        public static RunMatcher styleId(string styleId)
        {
            return new RunMatcher(Optional.of(styleId), Optional.empty<StringMatcher>());
        }

        public static RunMatcher styleName(string styleName)
        {
            return new RunMatcher(Optional.empty<string>(), Optional.of<StringMatcher>(new EqualToStringMatcher(styleName)));
        }
    }
}
