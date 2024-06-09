using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class DocumentMatcherParserAnonymous0(ParagraphMatcher paragraph) : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        public void Accept(StyleMapBuilder builder, IHtmlPath path)
        {
            builder.MapParagraph(paragraph, path);
        }
    }

    internal class DocumentMatcherParserAnonymous1(RunMatcher run) : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        public void Accept(StyleMapBuilder builder, IHtmlPath path)
        {
            builder.MapRun(run, path);
        }
    }

    internal class DocumentMatcherParserAnonymous2(TableMatcher table) : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        public void Accept(StyleMapBuilder builder, IHtmlPath path)
        {
            builder.MapTable(table, path);
        }
    }

    internal class DocumentMatcherParserAnonymous3 : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        public void Accept(StyleMapBuilder arg0, IHtmlPath arg1)
        {
            arg0.Bold(arg1);
        }
    }

    internal class DocumentMatcherParserAnonymous4 : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        public void Accept(StyleMapBuilder arg0, IHtmlPath arg1)
        {
            arg0.Italic(arg1);
        }
    }

    internal class DocumentMatcherParserAnonymous5 : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        public void Accept(StyleMapBuilder arg0, IHtmlPath arg1)
        {
            arg0.Underline(arg1);
        }
    }

    internal class DocumentMatcherParserAnonymous6 : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        public void Accept(StyleMapBuilder arg0, IHtmlPath arg1)
        {
            arg0.Strikethrough(arg1);
        }
    }

    internal class DocumentMatcherParserAnonymous7 : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        public void Accept(StyleMapBuilder arg0, IHtmlPath arg1)
        {
            arg0.SmallCaps(arg1);
        }
    }

    internal class DocumentMatcherParserAnonymous8 : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        public void Accept(StyleMapBuilder arg0, IHtmlPath arg1)
        {
            arg0.CommentReference(arg1);
        }
    }

    internal class DocumentMatcherParserAnonymous9(BreakMatcher breakMatcher) : IBiConsumer<StyleMapBuilder, IHtmlPath> {
        public void Accept(StyleMapBuilder builder, IHtmlPath path)
        {
            builder.MapBreak(breakMatcher, path);
        }
    }
}
