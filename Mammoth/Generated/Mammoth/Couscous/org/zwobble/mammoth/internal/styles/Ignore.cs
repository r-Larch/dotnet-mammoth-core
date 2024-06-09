using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class Ignore : IHtmlPath {
        public static IHtmlPath Instance;

        static Ignore()
        {
            Instance = new Ignore();
        }

        public ISupplier<IList<IHtmlNode>> Wrap(ISupplier<IList<IHtmlNode>> generateNodes)
        {
            return new IgnoreAnonymous0();
        }
    }
}
