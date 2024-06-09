using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParserAnonymous1 : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        private RunMatcher _run;

        internal DocumentMatcherParserAnonymous1(RunMatcher run)
        {
            _run = run;
        }

        public void Accept(StyleMapBuilder builder, IHtmlPath path)
        {
            builder.MapRun(_run, path);
        }
    }
}
