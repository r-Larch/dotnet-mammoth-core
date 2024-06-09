using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class RunMatcher : IDocumentElementMatcher<Run> {
        public static RunMatcher Any;
        private IOptional<string> _styleId;
        private IOptional<IStringMatcher> _styleName;

        static RunMatcher()
        {
            Any = new RunMatcher(Optional.Empty<string>(), Optional.Empty<IStringMatcher>());
        }

        internal RunMatcher(IOptional<string> styleId, IOptional<IStringMatcher> styleName)
        {
            _styleId = styleId;
            _styleName = styleName;
        }

        public bool Matches(Run run)
        {
            return DocumentElementMatching.MatchesStyle(_styleId, _styleName, run.GetStyle());
        }

        public static RunMatcher StyleId(string styleId)
        {
            return new RunMatcher(Optional.Of(styleId), Optional.Empty<IStringMatcher>());
        }

        public static RunMatcher StyleName(string styleName)
        {
            return new RunMatcher(Optional.Empty<string>(), Optional.Of<IStringMatcher>(new EqualToStringMatcher(styleName)));
        }
    }
}
