using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapAnonymous3 : IFunction<StyleMapping<Run>, IHtmlPath> {
        public IHtmlPath Apply(StyleMapping<Run> arg0)
        {
            return arg0.GetHtmlPath();
        }
    }
}
