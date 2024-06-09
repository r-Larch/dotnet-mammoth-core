using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_9 : Supplier<HtmlPath> {
        internal Break _breakElement;

        internal DocumentToHtml__Anonymous_9(Break breakElement)
        {
            _breakElement = breakElement;
        }

        public HtmlPath get()
        {
            if ((_breakElement).getType() == Break__Type._LINE) {
                return HtmlPath_static.element("br");
            }

            return HtmlPath_static._EMPTY;
        }
    }
}
