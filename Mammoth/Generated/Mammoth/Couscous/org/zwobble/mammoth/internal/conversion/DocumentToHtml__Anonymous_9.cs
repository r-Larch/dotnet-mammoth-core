using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous9 : ISupplier<IHtmlPath> {
        private Break _breakElement;

        internal DocumentToHtmlAnonymous9(Break breakElement)
        {
            _breakElement = breakElement;
        }

        public IHtmlPath Get()
        {
            if ((_breakElement).Type == BreakType.Line) {
                return HtmlPathStatic.Element("br");
            }

            return HtmlPathStatic.Empty;
        }
    }
}
