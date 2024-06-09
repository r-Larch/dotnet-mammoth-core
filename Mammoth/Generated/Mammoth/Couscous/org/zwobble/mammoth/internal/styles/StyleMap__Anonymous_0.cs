using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapAnonymous0(Paragraph paragraph) : IPredicate<StyleMapping<Paragraph>> {
        public bool Test(StyleMapping<Paragraph> styleMapping)
        {
            return styleMapping.Matches(paragraph);
        }
    }

    internal class StyleMapAnonymous1 : IFunction<StyleMapping<Paragraph>, IHtmlPath> {
        public IHtmlPath Apply(StyleMapping<Paragraph> arg0)
        {
            return arg0.GetHtmlPath();
        }
    }

    internal class StyleMapAnonymous2(Run run) : IPredicate<StyleMapping<Run>> {
        public bool Test(StyleMapping<Run> styleMapping)
        {
            return styleMapping.Matches(run);
        }
    }

    internal class StyleMapAnonymous3 : IFunction<StyleMapping<Run>, IHtmlPath> {
        public IHtmlPath Apply(StyleMapping<Run> arg0)
        {
            return arg0.GetHtmlPath();
        }
    }

    internal class StyleMapAnonymous4(Table table) : IPredicate<StyleMapping<Table>> {
        public bool Test(StyleMapping<Table> styleMapping)
        {
            return styleMapping.Matches(table);
        }
    }

    internal class StyleMapAnonymous5 : IFunction<StyleMapping<Table>, IHtmlPath> {
        public IHtmlPath Apply(StyleMapping<Table> arg0)
        {
            return arg0.GetHtmlPath();
        }
    }

    internal class StyleMapAnonymous6(Break breakElement) : IPredicate<StyleMapping<Break>> {
        public bool Test(StyleMapping<Break> styleMapping)
        {
            return styleMapping.Matches(breakElement);
        }
    }

    internal class StyleMapAnonymous7 : IFunction<StyleMapping<Break>, IHtmlPath> {
        public IHtmlPath Apply(StyleMapping<Break> arg0)
        {
            return arg0.GetHtmlPath();
        }
    }
}
