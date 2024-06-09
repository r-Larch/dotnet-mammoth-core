namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_1 : Mammoth.Couscous.java.util.function.BiConsumer<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher _run;
        internal DocumentMatcherParser__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.RunMatcher run) {
            this._run = run;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMapBuilder builder, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath path) {
            builder.mapRun(this._run, path);
        }
    }
}

