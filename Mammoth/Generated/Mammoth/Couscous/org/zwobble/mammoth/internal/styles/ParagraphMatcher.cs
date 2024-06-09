namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class ParagraphMatcher : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatcher<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph> {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher _ANY;
        internal Mammoth.Couscous.java.util.Optional<string> _styleId;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> _styleName;
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> _numbering;
        static ParagraphMatcher() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher._ANY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>());
        }
        internal ParagraphMatcher(Mammoth.Couscous.java.util.Optional<string> styleId, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher> styleName, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering) {
            this._styleId = styleId;
            this._styleName = styleName;
            this._numbering = numbering;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher styleId(string styleId) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.of<string>(styleId), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher styleName(string styleName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher.styleName(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.EqualToStringMatcher(styleName));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher styleName(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher styleName) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(styleName), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher orderedList(string level) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel.ordered(level)));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher unorderedList(string level) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher(Mammoth.Couscous.java.util.Optional.empty<string>(), Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StringMatcher>(), Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel.unordered(level)));
        }
        public bool matches(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return this.matchesStyle(paragraph) && this.matchesNumbering(paragraph);
        }
        public bool matchesStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matchesStyle(this._styleId, this._styleName, paragraph.getStyle());
        }
        public bool matchesNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DocumentElementMatching.matches<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(this._numbering, paragraph.getNumbering(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.ParagraphMatcher__Anonymous_0());
        }
    }
}

