using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParser__Anonymous_1 : BiConsumer<StyleMapBuilder, HtmlPath> {
        internal RunMatcher _run;

        internal DocumentMatcherParser__Anonymous_1(RunMatcher run)
        {
            _run = run;
        }

        public void accept(StyleMapBuilder builder, HtmlPath path)
        {
            builder.mapRun(_run, path);
        }
    }
}
