using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapAnonymous1 : IFunction<StyleMapping<Paragraph>, IHtmlPath> {
        public IHtmlPath Apply(StyleMapping<Paragraph> arg0)
        {
            return arg0.GetHtmlPath();
        }
    }
}
