namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_9 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher _breakMatcher;
        internal DocumentMatcherParser__Anonymous_9(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.BreakMatcher breakMatcher) {
            this._breakMatcher = breakMatcher;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            builder.mapBreak(this._breakMatcher, path);
        }
    }
}

