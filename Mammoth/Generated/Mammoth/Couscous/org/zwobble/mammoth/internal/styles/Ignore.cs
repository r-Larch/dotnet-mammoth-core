using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class Ignore : HtmlPath {
        internal static HtmlPath _INSTANCE;

        static Ignore()
        {
            _INSTANCE = new Ignore();
        }

        public Supplier<List<HtmlNode>> wrap(Supplier<List<HtmlNode>> generateNodes)
        {
            return new Ignore__Anonymous_0();
        }
    }
}
