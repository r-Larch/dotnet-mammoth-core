using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class Html__Anonymous_0 : Consumer<HtmlNode> {
        private StringBuilder _builder;

        internal Html__Anonymous_0(StringBuilder builder)
        {
            _builder = builder;
        }

        public void accept(HtmlNode node)
        {
            HtmlWriter.write(node, _builder);
        }
    }
}
